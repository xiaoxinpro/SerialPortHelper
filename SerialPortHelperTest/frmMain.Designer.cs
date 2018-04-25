namespace SerialPortHelperTest
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbConfigCom = new System.Windows.Forms.GroupBox();
            this.btnSetConfigComData = new System.Windows.Forms.Button();
            this.btnGetConfigComData = new System.Windows.Forms.Button();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDetectCom = new System.Windows.Forms.GroupBox();
            this.chkAutoReflash = new System.Windows.Forms.CheckBox();
            this.btnReflashList = new System.Windows.Forms.Button();
            this.listSerialPort = new System.Windows.Forms.ListBox();
            this.gbSerialPortSwitch = new System.Windows.Forms.GroupBox();
            this.btnSerialPortSwitch = new System.Windows.Forms.Button();
            this.gbSerialReceived = new System.Windows.Forms.GroupBox();
            this.txtDataReceived = new System.Windows.Forms.TextBox();
            this.gbSerialWrite = new System.Windows.Forms.GroupBox();
            this.btnSerialWrite = new System.Windows.Forms.Button();
            this.txtSerialWrite = new System.Windows.Forms.TextBox();
            this.txtSerialWriteInterval = new System.Windows.Forms.TextBox();
            this.chkSerialWriteLoop = new System.Windows.Forms.CheckBox();
            this.labMs = new System.Windows.Forms.Label();
            this.rioHex = new System.Windows.Forms.RadioButton();
            this.rioString = new System.Windows.Forms.RadioButton();
            this.timSerialWrite = new System.Windows.Forms.Timer(this.components);
            this.gbConfigCom.SuspendLayout();
            this.gbDetectCom.SuspendLayout();
            this.gbSerialPortSwitch.SuspendLayout();
            this.gbSerialReceived.SuspendLayout();
            this.gbSerialWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfigCom
            // 
            this.gbConfigCom.Controls.Add(this.btnSetConfigComData);
            this.gbConfigCom.Controls.Add(this.btnGetConfigComData);
            this.gbConfigCom.Controls.Add(this.cbParity);
            this.gbConfigCom.Controls.Add(this.cbStop);
            this.gbConfigCom.Controls.Add(this.cbBaudRate);
            this.gbConfigCom.Controls.Add(this.cbDataBits);
            this.gbConfigCom.Controls.Add(this.cbSerial);
            this.gbConfigCom.Controls.Add(this.label5);
            this.gbConfigCom.Controls.Add(this.label4);
            this.gbConfigCom.Controls.Add(this.label3);
            this.gbConfigCom.Controls.Add(this.label2);
            this.gbConfigCom.Controls.Add(this.label6);
            this.gbConfigCom.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbConfigCom.Location = new System.Drawing.Point(126, 9);
            this.gbConfigCom.Margin = new System.Windows.Forms.Padding(2);
            this.gbConfigCom.Name = "gbConfigCom";
            this.gbConfigCom.Padding = new System.Windows.Forms.Padding(2);
            this.gbConfigCom.Size = new System.Drawing.Size(148, 320);
            this.gbConfigCom.TabIndex = 4;
            this.gbConfigCom.TabStop = false;
            this.gbConfigCom.Text = "串口配置";
            // 
            // btnSetConfigComData
            // 
            this.btnSetConfigComData.Location = new System.Drawing.Point(8, 272);
            this.btnSetConfigComData.Name = "btnSetConfigComData";
            this.btnSetConfigComData.Size = new System.Drawing.Size(131, 38);
            this.btnSetConfigComData.TabIndex = 11;
            this.btnSetConfigComData.Text = "设置串口配置";
            this.btnSetConfigComData.UseVisualStyleBackColor = true;
            this.btnSetConfigComData.Click += new System.EventHandler(this.btnSetConfigComData_Click);
            // 
            // btnGetConfigComData
            // 
            this.btnGetConfigComData.Location = new System.Drawing.Point(8, 219);
            this.btnGetConfigComData.Name = "btnGetConfigComData";
            this.btnGetConfigComData.Size = new System.Drawing.Size(131, 38);
            this.btnGetConfigComData.TabIndex = 10;
            this.btnGetConfigComData.Text = "获取串口配置";
            this.btnGetConfigComData.UseVisualStyleBackColor = true;
            this.btnGetConfigComData.Click += new System.EventHandler(this.btnGetConfigComData_Click);
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(77, 174);
            this.cbParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(62, 25);
            this.cbParity.TabIndex = 9;
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(77, 138);
            this.cbStop.Margin = new System.Windows.Forms.Padding(2);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(62, 25);
            this.cbStop.TabIndex = 8;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(77, 66);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(62, 25);
            this.cbBaudRate.TabIndex = 7;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(77, 102);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(62, 25);
            this.cbDataBits.TabIndex = 6;
            // 
            // cbSerial
            // 
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(77, 30);
            this.cbSerial.Margin = new System.Windows.Forms.Padding(2);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(62, 25);
            this.cbSerial.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "检验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "端口号：";
            // 
            // gbDetectCom
            // 
            this.gbDetectCom.Controls.Add(this.chkAutoReflash);
            this.gbDetectCom.Controls.Add(this.btnReflashList);
            this.gbDetectCom.Controls.Add(this.listSerialPort);
            this.gbDetectCom.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbDetectCom.Location = new System.Drawing.Point(12, 9);
            this.gbDetectCom.Name = "gbDetectCom";
            this.gbDetectCom.Size = new System.Drawing.Size(109, 429);
            this.gbDetectCom.TabIndex = 5;
            this.gbDetectCom.TabStop = false;
            this.gbDetectCom.Text = "串口检测";
            // 
            // chkAutoReflash
            // 
            this.chkAutoReflash.AutoSize = true;
            this.chkAutoReflash.Checked = true;
            this.chkAutoReflash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoReflash.Location = new System.Drawing.Point(6, 26);
            this.chkAutoReflash.Name = "chkAutoReflash";
            this.chkAutoReflash.Size = new System.Drawing.Size(88, 24);
            this.chkAutoReflash.TabIndex = 7;
            this.chkAutoReflash.Text = "自动刷新";
            this.chkAutoReflash.UseVisualStyleBackColor = true;
            // 
            // btnReflashList
            // 
            this.btnReflashList.Location = new System.Drawing.Point(6, 386);
            this.btnReflashList.Name = "btnReflashList";
            this.btnReflashList.Size = new System.Drawing.Size(97, 35);
            this.btnReflashList.TabIndex = 6;
            this.btnReflashList.Text = "手动刷新";
            this.btnReflashList.UseVisualStyleBackColor = true;
            // 
            // listSerialPort
            // 
            this.listSerialPort.FormattingEnabled = true;
            this.listSerialPort.ItemHeight = 20;
            this.listSerialPort.Location = new System.Drawing.Point(6, 56);
            this.listSerialPort.Name = "listSerialPort";
            this.listSerialPort.Size = new System.Drawing.Size(97, 324);
            this.listSerialPort.TabIndex = 4;
            // 
            // gbSerialPortSwitch
            // 
            this.gbSerialPortSwitch.Controls.Add(this.btnSerialPortSwitch);
            this.gbSerialPortSwitch.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbSerialPortSwitch.Location = new System.Drawing.Point(128, 335);
            this.gbSerialPortSwitch.Name = "gbSerialPortSwitch";
            this.gbSerialPortSwitch.Size = new System.Drawing.Size(146, 103);
            this.gbSerialPortSwitch.TabIndex = 6;
            this.gbSerialPortSwitch.TabStop = false;
            this.gbSerialPortSwitch.Text = "串口控制";
            // 
            // btnSerialPortSwitch
            // 
            this.btnSerialPortSwitch.Location = new System.Drawing.Point(7, 41);
            this.btnSerialPortSwitch.Name = "btnSerialPortSwitch";
            this.btnSerialPortSwitch.Size = new System.Drawing.Size(130, 39);
            this.btnSerialPortSwitch.TabIndex = 0;
            this.btnSerialPortSwitch.Text = "打开串口";
            this.btnSerialPortSwitch.UseVisualStyleBackColor = true;
            this.btnSerialPortSwitch.Click += new System.EventHandler(this.btnSerialPortSwitch_Click);
            // 
            // gbSerialReceived
            // 
            this.gbSerialReceived.Controls.Add(this.txtDataReceived);
            this.gbSerialReceived.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbSerialReceived.Location = new System.Drawing.Point(280, 9);
            this.gbSerialReceived.Name = "gbSerialReceived";
            this.gbSerialReceived.Size = new System.Drawing.Size(465, 320);
            this.gbSerialReceived.TabIndex = 7;
            this.gbSerialReceived.TabStop = false;
            this.gbSerialReceived.Text = "接收数据";
            // 
            // txtDataReceived
            // 
            this.txtDataReceived.Location = new System.Drawing.Point(7, 26);
            this.txtDataReceived.Multiline = true;
            this.txtDataReceived.Name = "txtDataReceived";
            this.txtDataReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataReceived.Size = new System.Drawing.Size(452, 280);
            this.txtDataReceived.TabIndex = 0;
            // 
            // gbSerialWrite
            // 
            this.gbSerialWrite.Controls.Add(this.rioString);
            this.gbSerialWrite.Controls.Add(this.rioHex);
            this.gbSerialWrite.Controls.Add(this.chkSerialWriteLoop);
            this.gbSerialWrite.Controls.Add(this.txtSerialWriteInterval);
            this.gbSerialWrite.Controls.Add(this.btnSerialWrite);
            this.gbSerialWrite.Controls.Add(this.txtSerialWrite);
            this.gbSerialWrite.Controls.Add(this.labMs);
            this.gbSerialWrite.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbSerialWrite.Location = new System.Drawing.Point(281, 335);
            this.gbSerialWrite.Name = "gbSerialWrite";
            this.gbSerialWrite.Size = new System.Drawing.Size(464, 103);
            this.gbSerialWrite.TabIndex = 8;
            this.gbSerialWrite.TabStop = false;
            this.gbSerialWrite.Text = "发送数据";
            // 
            // btnSerialWrite
            // 
            this.btnSerialWrite.Location = new System.Drawing.Point(394, 27);
            this.btnSerialWrite.Name = "btnSerialWrite";
            this.btnSerialWrite.Size = new System.Drawing.Size(64, 27);
            this.btnSerialWrite.TabIndex = 1;
            this.btnSerialWrite.Text = "发送";
            this.btnSerialWrite.UseVisualStyleBackColor = true;
            this.btnSerialWrite.Click += new System.EventHandler(this.btnSerialWrite_Click);
            // 
            // txtSerialWrite
            // 
            this.txtSerialWrite.Location = new System.Drawing.Point(7, 27);
            this.txtSerialWrite.Name = "txtSerialWrite";
            this.txtSerialWrite.Size = new System.Drawing.Size(381, 27);
            this.txtSerialWrite.TabIndex = 0;
            // 
            // txtSerialWriteInterval
            // 
            this.txtSerialWriteInterval.Location = new System.Drawing.Point(101, 64);
            this.txtSerialWriteInterval.Name = "txtSerialWriteInterval";
            this.txtSerialWriteInterval.Size = new System.Drawing.Size(57, 27);
            this.txtSerialWriteInterval.TabIndex = 3;
            this.txtSerialWriteInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialWriteInterval_KeyPress);
            // 
            // chkSerialWriteLoop
            // 
            this.chkSerialWriteLoop.AutoSize = true;
            this.chkSerialWriteLoop.Location = new System.Drawing.Point(7, 66);
            this.chkSerialWriteLoop.Name = "chkSerialWriteLoop";
            this.chkSerialWriteLoop.Size = new System.Drawing.Size(88, 24);
            this.chkSerialWriteLoop.TabIndex = 4;
            this.chkSerialWriteLoop.Text = "定时发送";
            this.chkSerialWriteLoop.UseVisualStyleBackColor = true;
            this.chkSerialWriteLoop.CheckedChanged += new System.EventHandler(this.chkSerialWriteLoop_CheckedChanged);
            // 
            // labMs
            // 
            this.labMs.AutoSize = true;
            this.labMs.Location = new System.Drawing.Point(156, 67);
            this.labMs.Name = "labMs";
            this.labMs.Size = new System.Drawing.Size(30, 20);
            this.labMs.TabIndex = 5;
            this.labMs.Text = "ms";
            // 
            // rioHex
            // 
            this.rioHex.AutoSize = true;
            this.rioHex.Checked = true;
            this.rioHex.Location = new System.Drawing.Point(293, 66);
            this.rioHex.Name = "rioHex";
            this.rioHex.Size = new System.Drawing.Size(87, 24);
            this.rioHex.TabIndex = 6;
            this.rioHex.TabStop = true;
            this.rioHex.Text = "十六进制";
            this.rioHex.UseVisualStyleBackColor = true;
            // 
            // rioString
            // 
            this.rioString.AutoSize = true;
            this.rioString.Location = new System.Drawing.Point(386, 66);
            this.rioString.Name = "rioString";
            this.rioString.Size = new System.Drawing.Size(72, 24);
            this.rioString.TabIndex = 7;
            this.rioString.Text = "字符串";
            this.rioString.UseVisualStyleBackColor = true;
            // 
            // timSerialWrite
            // 
            this.timSerialWrite.Tick += new System.EventHandler(this.timSerialWrite_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.gbSerialWrite);
            this.Controls.Add(this.gbSerialReceived);
            this.Controls.Add(this.gbSerialPortSwitch);
            this.Controls.Add(this.gbDetectCom);
            this.Controls.Add(this.gbConfigCom);
            this.Name = "frmMain";
            this.Text = "串口助手类库";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbConfigCom.ResumeLayout(false);
            this.gbConfigCom.PerformLayout();
            this.gbDetectCom.ResumeLayout(false);
            this.gbDetectCom.PerformLayout();
            this.gbSerialPortSwitch.ResumeLayout(false);
            this.gbSerialReceived.ResumeLayout(false);
            this.gbSerialReceived.PerformLayout();
            this.gbSerialWrite.ResumeLayout(false);
            this.gbSerialWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigCom;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDetectCom;
        private System.Windows.Forms.CheckBox chkAutoReflash;
        private System.Windows.Forms.Button btnReflashList;
        private System.Windows.Forms.ListBox listSerialPort;
        private System.Windows.Forms.Button btnGetConfigComData;
        private System.Windows.Forms.Button btnSetConfigComData;
        private System.Windows.Forms.GroupBox gbSerialPortSwitch;
        private System.Windows.Forms.Button btnSerialPortSwitch;
        private System.Windows.Forms.GroupBox gbSerialReceived;
        private System.Windows.Forms.TextBox txtDataReceived;
        private System.Windows.Forms.GroupBox gbSerialWrite;
        private System.Windows.Forms.Button btnSerialWrite;
        private System.Windows.Forms.TextBox txtSerialWrite;
        private System.Windows.Forms.RadioButton rioString;
        private System.Windows.Forms.RadioButton rioHex;
        private System.Windows.Forms.CheckBox chkSerialWriteLoop;
        private System.Windows.Forms.TextBox txtSerialWriteInterval;
        private System.Windows.Forms.Label labMs;
        private System.Windows.Forms.Timer timSerialWrite;
    }
}

