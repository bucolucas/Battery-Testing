namespace Battery_Testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCharge = new System.Windows.Forms.Button();
            this.tmrUpdateBMSValues = new System.Windows.Forms.Timer(this.components);
            this.cbUpdateBMSTimerEnabled = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bmsDisplay1 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay2 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay3 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay4 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay5 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay6 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay7 = new Battery_Testing.BMSDisplay();
            this.bmsDisplay8 = new Battery_Testing.BMSDisplay();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(526, 270);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(94, 29);
            this.btnCharge.TabIndex = 0;
            this.btnCharge.Text = "Charge";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // tmrUpdateBMSValues
            // 
            this.tmrUpdateBMSValues.Interval = 10000;
            this.tmrUpdateBMSValues.Tick += new System.EventHandler(this.tmrUpdateBMSValues_Tick);
            // 
            // cbUpdateBMSTimerEnabled
            // 
            this.cbUpdateBMSTimerEnabled.AutoSize = true;
            this.cbUpdateBMSTimerEnabled.Location = new System.Drawing.Point(267, 273);
            this.cbUpdateBMSTimerEnabled.Name = "cbUpdateBMSTimerEnabled";
            this.cbUpdateBMSTimerEnabled.Size = new System.Drawing.Size(153, 24);
            this.cbUpdateBMSTimerEnabled.TabIndex = 1;
            this.cbUpdateBMSTimerEnabled.Text = "Automatic Refresh";
            this.cbUpdateBMSTimerEnabled.UseVisualStyleBackColor = true;
            this.cbUpdateBMSTimerEnabled.CheckedChanged += new System.EventHandler(this.cbUpdateBMSTimerEnabled_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(426, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bmsDisplay1
            // 
            this.bmsDisplay1.Location = new System.Drawing.Point(12, 12);
            this.bmsDisplay1.Name = "bmsDisplay1";
            this.bmsDisplay1.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay1.TabIndex = 3;
            this.bmsDisplay1.Visible = false;
            // 
            // bmsDisplay2
            // 
            this.bmsDisplay2.Location = new System.Drawing.Point(173, 12);
            this.bmsDisplay2.Name = "bmsDisplay2";
            this.bmsDisplay2.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay2.TabIndex = 4;
            this.bmsDisplay2.Visible = false;
            // 
            // bmsDisplay3
            // 
            this.bmsDisplay3.Location = new System.Drawing.Point(334, 12);
            this.bmsDisplay3.Name = "bmsDisplay3";
            this.bmsDisplay3.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay3.TabIndex = 5;
            this.bmsDisplay3.Visible = false;
            // 
            // bmsDisplay4
            // 
            this.bmsDisplay4.Location = new System.Drawing.Point(495, 12);
            this.bmsDisplay4.Name = "bmsDisplay4";
            this.bmsDisplay4.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay4.TabIndex = 6;
            this.bmsDisplay4.Visible = false;
            // 
            // bmsDisplay5
            // 
            this.bmsDisplay5.Location = new System.Drawing.Point(12, 141);
            this.bmsDisplay5.Name = "bmsDisplay5";
            this.bmsDisplay5.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay5.TabIndex = 7;
            this.bmsDisplay5.Visible = false;
            // 
            // bmsDisplay6
            // 
            this.bmsDisplay6.Location = new System.Drawing.Point(173, 141);
            this.bmsDisplay6.Name = "bmsDisplay6";
            this.bmsDisplay6.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay6.TabIndex = 8;
            this.bmsDisplay6.Visible = false;
            // 
            // bmsDisplay7
            // 
            this.bmsDisplay7.Location = new System.Drawing.Point(334, 141);
            this.bmsDisplay7.Name = "bmsDisplay7";
            this.bmsDisplay7.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay7.TabIndex = 9;
            this.bmsDisplay7.Visible = false;
            // 
            // bmsDisplay8
            // 
            this.bmsDisplay8.Location = new System.Drawing.Point(495, 141);
            this.bmsDisplay8.Name = "bmsDisplay8";
            this.bmsDisplay8.Size = new System.Drawing.Size(155, 123);
            this.bmsDisplay8.TabIndex = 10;
            this.bmsDisplay8.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 270);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 311);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.bmsDisplay8);
            this.Controls.Add(this.bmsDisplay7);
            this.Controls.Add(this.bmsDisplay6);
            this.Controls.Add(this.bmsDisplay5);
            this.Controls.Add(this.bmsDisplay4);
            this.Controls.Add(this.bmsDisplay3);
            this.Controls.Add(this.bmsDisplay2);
            this.Controls.Add(this.bmsDisplay1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbUpdateBMSTimerEnabled);
            this.Controls.Add(this.btnCharge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCharge;
        private System.Windows.Forms.Timer tmrUpdateBMSValues;
        private CheckBox cbUpdateBMSTimerEnabled;
        private Button btnRefresh;
        private BMSDisplay bmsDisplay1;
        private BMSDisplay bmsDisplay2;
        private BMSDisplay bmsDisplay3;
        private BMSDisplay bmsDisplay4;
        private BMSDisplay bmsDisplay5;
        private BMSDisplay bmsDisplay6;
        private BMSDisplay bmsDisplay7;
        private BMSDisplay bmsDisplay8;
        private Button btnConnect;
    }
}