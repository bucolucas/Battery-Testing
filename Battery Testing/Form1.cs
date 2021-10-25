namespace Battery_Testing
{
    public partial class Form1 : Form
    {
        private Charger _charger;
        private ICommandChain _commandChain;

        public Form1()
        {
            InitializeComponent();

            _commandChain = new ArduinoCommandChain();
            //_commandChain = new TestCommandChain();

            ConnectToCOMPort();

            _charger = new Charger(_commandChain, 1);
            var bmsDisplays = Controls.OfType<BMSDisplay>().OrderBy(x => x.TabIndex).ToArray();
            for (int i = 0; i < _charger.BMSs.Count; i++)
            {
                var bms = _charger.BMSs[i];
                bmsDisplays[i].Initialize(bms);
            }
        }

        private async void btnCharge_Click(object sender, EventArgs e)
        {
            await _charger.BeginCharging();
        }

        private void cbUpdateBMSTimerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            tmrUpdateBMSValues.Enabled = cbUpdateBMSTimerEnabled.Checked;
            btnRefresh.Enabled = !cbUpdateBMSTimerEnabled.Checked;
        }

        private async Task RefreshBMSValues()
        {
            try
            {
                await _charger.Update();
            }
            catch (Exception)
            {
            }
            
        }

        private async void tmrUpdateBMSValues_Tick(object sender, EventArgs e)
        {
            await RefreshBMSValues();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await RefreshBMSValues();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToCOMPort();
        }

        private void ConnectToCOMPort()
        {
            var comPortConnectForm = new ConnectToCOMPort();
            comPortConnectForm.ShowDialog();

            if (!string.IsNullOrEmpty(comPortConnectForm.SelectedPort))
            {
                _commandChain.Connect(comPortConnectForm.SelectedPort);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _commandChain.Close();
        }
    }
}