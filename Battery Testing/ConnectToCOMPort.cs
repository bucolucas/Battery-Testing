using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battery_Testing
{
    public partial class ConnectToCOMPort : Form
    {
        public string SelectedPort { get; private set; } = "";

        public ConnectToCOMPort()
        {
            InitializeComponent();
            DisplayCOMPorts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCOMPorts();
        }

        private void DisplayCOMPorts()
        {
            var ports = SerialPort.GetPortNames();
            lbCOMPorts.Items.Clear();
            SelectedPort = "";
            foreach (var port in ports)
            {
                lbCOMPorts.Items.Add(port);
            }
        }

        private void lbCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCOMPorts.SelectedIndex != -1)
            {
                SelectedPort = lbCOMPorts.SelectedItems[0].ToString() ?? "";
            }
            else
            {
                SelectedPort = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
