namespace WeatherStation
{
    partial class formLiveValue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBoxSerialport = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tBoxPressure = new System.Windows.Forms.TextBox();
            this.tBoxTemp = new System.Windows.Forms.TextBox();
            this.tBoxHum = new System.Windows.Forms.TextBox();
            this.tBoxIll = new System.Windows.Forms.TextBox();
            this.lblWaardeTemp = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.lblIlluminance = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.btnexit = new System.Windows.Forms.Button();
            this.graphTemp = new WeatherStation.GraphUserControl();
            this.graphPressure = new WeatherStation.GraphUserControl();
            this.graphIllumine = new WeatherStation.GraphUserControl();
            this.graphHumidity = new WeatherStation.GraphUserControl();
            this.SuspendLayout();
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(18, 32);
            this.tBoxData.Multiline = true;
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.ReadOnly = true;
            this.tBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxData.Size = new System.Drawing.Size(219, 478);
            this.tBoxData.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 618);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBoxSerialport
            // 
            this.comboBoxSerialport.FormattingEnabled = true;
            this.comboBoxSerialport.Location = new System.Drawing.Point(85, 545);
            this.comboBoxSerialport.Name = "comboBoxSerialport";
            this.comboBoxSerialport.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerialport.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(145, 618);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 48);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(18, 548);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(61, 13);
            this.lblCom.TabIndex = 4;
            this.lblCom.Text = "Select Com";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(15, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(105, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data weather station";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 516);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(220, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh serial port ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(407, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(26, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "time";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick_1);
            // 
            // tBoxPressure
            // 
            this.tBoxPressure.Location = new System.Drawing.Point(759, 360);
            this.tBoxPressure.Multiline = true;
            this.tBoxPressure.Name = "tBoxPressure";
            this.tBoxPressure.ReadOnly = true;
            this.tBoxPressure.Size = new System.Drawing.Size(100, 150);
            this.tBoxPressure.TabIndex = 13;
            // 
            // tBoxTemp
            // 
            this.tBoxTemp.Location = new System.Drawing.Point(759, 533);
            this.tBoxTemp.Multiline = true;
            this.tBoxTemp.Name = "tBoxTemp";
            this.tBoxTemp.ReadOnly = true;
            this.tBoxTemp.Size = new System.Drawing.Size(100, 150);
            this.tBoxTemp.TabIndex = 14;
            // 
            // tBoxHum
            // 
            this.tBoxHum.Location = new System.Drawing.Point(759, 16);
            this.tBoxHum.Multiline = true;
            this.tBoxHum.Name = "tBoxHum";
            this.tBoxHum.ReadOnly = true;
            this.tBoxHum.Size = new System.Drawing.Size(100, 150);
            this.tBoxHum.TabIndex = 15;
            // 
            // tBoxIll
            // 
            this.tBoxIll.Location = new System.Drawing.Point(759, 191);
            this.tBoxIll.Multiline = true;
            this.tBoxIll.Name = "tBoxIll";
            this.tBoxIll.ReadOnly = true;
            this.tBoxIll.Size = new System.Drawing.Size(100, 150);
            this.tBoxIll.TabIndex = 16;
            // 
            // lblWaardeTemp
            // 
            this.lblWaardeTemp.AutoSize = true;
            this.lblWaardeTemp.Location = new System.Drawing.Point(756, 517);
            this.lblWaardeTemp.Name = "lblWaardeTemp";
            this.lblWaardeTemp.Size = new System.Drawing.Size(36, 13);
            this.lblWaardeTemp.TabIndex = 17;
            this.lblWaardeTemp.Text = "temp: ";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(756, 344);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(51, 13);
            this.lblPressure.TabIndex = 18;
            this.lblPressure.Text = "Pressure:";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Location = new System.Drawing.Point(756, 0);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(50, 13);
            this.lblHum.TabIndex = 19;
            this.lblHum.Text = "Humidity:";
            // 
            // lblIlluminance
            // 
            this.lblIlluminance.AutoSize = true;
            this.lblIlluminance.Location = new System.Drawing.Point(756, 175);
            this.lblIlluminance.Name = "lblIlluminance";
            this.lblIlluminance.Size = new System.Drawing.Size(63, 13);
            this.lblIlluminance.TabIndex = 20;
            this.lblIlluminance.Text = "Illuminance:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(891, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 23);
            this.Save.TabIndex = 21;
            this.Save.Text = "Save in new file";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(891, 41);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(111, 50);
            this.btnAppend.TabIndex = 22;
            this.btnAppend.Text = "append data to existence file ";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // timerSave
            // 
            this.timerSave.Interval = 1000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(873, 660);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // graphTemp
            // 
            this.graphTemp.Location = new System.Drawing.Point(258, 533);
            this.graphTemp.Name = "graphTemp";
            this.graphTemp.Size = new System.Drawing.Size(480, 150);
            this.graphTemp.TabIndex = 12;
            // 
            // graphPressure
            // 
            this.graphPressure.Location = new System.Drawing.Point(258, 360);
            this.graphPressure.Name = "graphPressure";
            this.graphPressure.Size = new System.Drawing.Size(480, 150);
            this.graphPressure.TabIndex = 11;
            // 
            // graphIllumine
            // 
            this.graphIllumine.Location = new System.Drawing.Point(258, 188);
            this.graphIllumine.Name = "graphIllumine";
            this.graphIllumine.Size = new System.Drawing.Size(480, 150);
            this.graphIllumine.TabIndex = 10;
            // 
            // graphHumidity
            // 
            this.graphHumidity.Location = new System.Drawing.Point(258, 13);
            this.graphHumidity.Name = "graphHumidity";
            this.graphHumidity.Size = new System.Drawing.Size(480, 150);
            this.graphHumidity.TabIndex = 9;
            // 
            // formLiveValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 590);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lblIlluminance);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblWaardeTemp);
            this.Controls.Add(this.tBoxIll);
            this.Controls.Add(this.tBoxHum);
            this.Controls.Add(this.tBoxTemp);
            this.Controls.Add(this.tBoxPressure);
            this.Controls.Add(this.graphTemp);
            this.Controls.Add(this.graphPressure);
            this.Controls.Add(this.graphIllumine);
            this.Controls.Add(this.graphHumidity);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.comboBoxSerialport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tBoxData);
            this.Name = "formLiveValue";
            this.Text = "Weather station live value";
            this.Load += new System.EventHandler(this.formLiveValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxData;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBoxSerialport;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private GraphUserControl graphHumidity;
        private GraphUserControl graphIllumine;
        private GraphUserControl graphPressure;
        private GraphUserControl graphTemp;
        private System.Windows.Forms.TextBox tBoxPressure;
        private System.Windows.Forms.TextBox tBoxTemp;
        private System.Windows.Forms.TextBox tBoxHum;
        private System.Windows.Forms.TextBox tBoxIll;
        private System.Windows.Forms.Label lblWaardeTemp;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.Label lblIlluminance;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Button btnexit;
    }
}

