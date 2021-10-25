using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_Testing
{
    public class BMS
    {
        private readonly ICommandChain chain;
        public int BMSNumber { get; }
        public DischargeRelay DischargeRelay { get; }

        public decimal Volts { get; private set; }
        public decimal MilliAmpHours { get; private set; }
        public decimal MilliAmps { get; private set; }
        public bool IsCharging => MilliAmps > 0;
        public bool IsDischarging => MilliAmps < 0;
        public bool IsDischargingFinished { get; private set; }

        public BMS(int bmsNumber, ICommandChain chain)
        {
            this.BMSNumber = bmsNumber;
            this.chain = chain;
            DischargeRelay = new DischargeRelay(bmsNumber, chain);
        }

        public async Task Update()
        {
            await chain.Execute(string.Join(' ', CommandConstants.GET_BMS_STATUS_COMMAND, BMSNumber), ParseArduinoResult);
        }

        internal void ParseArduinoResult(string bmsStatusFromArduino)
        {
            var values = bmsStatusFromArduino.Split(',');
            Volts = decimal.Parse(values[0]) / 1000;
            MilliAmps = decimal.Parse(values[1]);
            MilliAmpHours = decimal.Parse(values[2]);
            //IsChargingFinished = bool.Parse(values[3]);
            IsDischargingFinished = bool.Parse(values[4]);
            BMSUpdated?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? BMSUpdated;
    }
}
