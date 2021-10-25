using System.IO.Ports;
using System.Collections.Concurrent;

namespace Battery_Testing
{
    internal class ArduinoCommandChain : ICommandChain
    {
        static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);

        private SerialPort _serialPort = new SerialPort();

        private ConcurrentDictionary<string, string> _receivedMessages = new ConcurrentDictionary<string, string>();

        public void Connect(string selectedPort)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                _serialPort.Dispose();
            }

            _serialPort = new SerialPort(selectedPort)
            {
                BaudRate = 9600,
                ReadTimeout = 8000
            };

            _serialPort.Open();
            _serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;
            if (sp.IsOpen)
            {
                var incomingData = sp.ReadLine();
                System.Threading.Thread.Sleep(30); // wait for all data to be written
                while (sp.BytesToRead > 0)
                {
                    incomingData += sp.ReadLine();
                    System.Threading.Thread.Sleep(30); // wait for all data to be written
                }
                foreach (var dataLine in incomingData.Split(Environment.NewLine))
                {
                    var inData = dataLine.Split('?', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                    if (inData.Length == 1)
                    {
                        _receivedMessages.TryAdd(inData[0], "");
                    }
                    if (inData.Length == 2)
                    {
                        _receivedMessages.TryAdd(inData[0], inData[1]);
                    }
                    // Discard messages that aren't the expected length
                }
            }
        }

        private async Task<string> SendCommand(string command)
        {
            try
            {
                _semaphoreSlim.Wait();
                _serialPort.WriteLine(command);
                return await Task.Run(() =>
                {
                    var response = "";

                    while (!_receivedMessages.Remove(command, out response))
                    {
                        Thread.Sleep(10);
                    }

                    return response ?? "";
                });
            }
            finally
            {
                _semaphoreSlim.Release();
            }
        }

        public async Task Execute(string command)
        {
            await SendCommand(command);
        }

        public async Task Execute(string command, Action resultHandler)
        {
            await SendCommand(command);
            resultHandler();
        }

        public async Task Execute(string command, Action<string> resultHandler)
        {
            var result = await SendCommand(command);
            resultHandler(result);
        }

        public void Close()
        {
            _serialPort?.Dispose();
        }
    }
}