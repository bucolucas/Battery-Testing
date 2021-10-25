using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battery_Testing
{
    public partial class BMSDisplay : UserControl
    {
        private const string VOLTS_FORMAT_STRING = "{0} Volts";
        private const string MILLI_AMPS_FORMAT_STRING = "{0} mA";
        private const string MILLI_AMP_HOURS_FORMAT_STRING = "{0} mAh";
        private const string BMS_TITLE_FORMAT_STRING = "BMS {0}";
        public BMSDisplay()
        {
            this.Hide();
            InitializeComponent();
        }

        public void Initialize(BMS bms)
        {
            lblBMSTitle.Text = string.Format(BMS_TITLE_FORMAT_STRING, bms.BMSNumber);
            bms.BMSUpdated += OnBMSUpdated;
            this.Visible = true;
        }

        private void OnBMSUpdated(object? sender, EventArgs e)
        {
            if (sender is BMS bms)
            {
                SetBMSValues(bms);
            }
        }

        private void SetBMSValues(BMS bms)
        {
            lblMilliAmpHours.Text = string.Format(MILLI_AMP_HOURS_FORMAT_STRING, bms.MilliAmpHours);
            lblVolts.Text = string.Format(VOLTS_FORMAT_STRING, bms.Volts);
            lblMilliAmps.Text = string.Format(MILLI_AMPS_FORMAT_STRING, bms.MilliAmps);
            if (bms.IsCharging)
            {
                lblChargeStatus.Text = "Charging";
                lblChargeStatus.BackColor = Color.LightGoldenrodYellow;
            }
            else if (bms.IsDischarging)
            {
                lblChargeStatus.Text = "Discharging";
                lblChargeStatus.BackColor = Color.LightCoral;
            }
            else if (bms.IsDischargingFinished)
            {
                lblChargeStatus.Text = "Finished";
                lblChargeStatus.BackColor = Color.LightSeaGreen;
            }
            else
            {
                lblChargeStatus.Text = "Waiting";
            }
        }
    }
}
