namespace Battery_Testing
{
    partial class BMSDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBMSTitle = new System.Windows.Forms.Label();
            this.lblVolts = new System.Windows.Forms.Label();
            this.lblMilliAmpHours = new System.Windows.Forms.Label();
            this.lblMilliAmps = new System.Windows.Forms.Label();
            this.lblChargeStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBMSTitle
            // 
            this.lblBMSTitle.AutoSize = true;
            this.lblBMSTitle.Location = new System.Drawing.Point(3, 0);
            this.lblBMSTitle.Name = "lblBMSTitle";
            this.lblBMSTitle.Size = new System.Drawing.Size(61, 20);
            this.lblBMSTitle.TabIndex = 0;
            this.lblBMSTitle.Text = "BMS {0}";
            // 
            // lblVolts
            // 
            this.lblVolts.AutoSize = true;
            this.lblVolts.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVolts.Location = new System.Drawing.Point(3, 60);
            this.lblVolts.Name = "lblVolts";
            this.lblVolts.Size = new System.Drawing.Size(96, 19);
            this.lblVolts.TabIndex = 2;
            this.lblVolts.Text = "0.000 Volts";
            // 
            // lblMilliAmpHours
            // 
            this.lblMilliAmpHours.AutoSize = true;
            this.lblMilliAmpHours.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMilliAmpHours.Location = new System.Drawing.Point(3, 20);
            this.lblMilliAmpHours.Name = "lblMilliAmpHours";
            this.lblMilliAmpHours.Size = new System.Drawing.Size(88, 19);
            this.lblMilliAmpHours.TabIndex = 3;
            this.lblMilliAmpHours.Text = "0020 mAh";
            // 
            // lblMilliAmps
            // 
            this.lblMilliAmps.AutoSize = true;
            this.lblMilliAmps.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMilliAmps.Location = new System.Drawing.Point(3, 40);
            this.lblMilliAmps.Name = "lblMilliAmps";
            this.lblMilliAmps.Size = new System.Drawing.Size(121, 19);
            this.lblMilliAmps.TabIndex = 4;
            this.lblMilliAmps.Text = "0010 MilliAmps";
            // 
            // lblChargeStatus
            // 
            this.lblChargeStatus.AutoSize = true;
            this.lblChargeStatus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblChargeStatus.Location = new System.Drawing.Point(65, 0);
            this.lblChargeStatus.Name = "lblChargeStatus";
            this.lblChargeStatus.Size = new System.Drawing.Size(75, 20);
            this.lblChargeStatus.TabIndex = 5;
            this.lblChargeStatus.Text = "Discharge";
            // 
            // BMSDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChargeStatus);
            this.Controls.Add(this.lblMilliAmps);
            this.Controls.Add(this.lblMilliAmpHours);
            this.Controls.Add(this.lblVolts);
            this.Controls.Add(this.lblBMSTitle);
            this.Name = "BMSDisplay";
            this.Size = new System.Drawing.Size(143, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBMSTitle;
        private Label lblVolts;
        private Label lblMilliAmpHours;
        private Label lblMilliAmps;
        private Label lblChargeStatus;
    }
}
