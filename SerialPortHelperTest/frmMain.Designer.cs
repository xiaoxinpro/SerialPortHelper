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
            this.gbConfigCom = new System.Windows.Forms.GroupBox();
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
            this.gbConfigCom.SuspendLayout();
            this.gbDetectCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfigCom
            // 
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
            this.gbConfigCom.Size = new System.Drawing.Size(149, 270);
            this.gbConfigCom.TabIndex = 4;
            this.gbConfigCom.TabStop = false;
            this.gbConfigCom.Text = "串口配置";
            // 
            // btnGetConfigComData
            // 
            this.btnGetConfigComData.Location = new System.Drawing.Point(8, 219);
            this.btnGetConfigComData.Name = "btnGetConfigComData";
            this.btnGetConfigComData.Size = new System.Drawing.Size(139, 38);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.gbDetectCom);
            this.Controls.Add(this.gbConfigCom);
            this.Name = "frmMain";
            this.Text = "串口助手类库";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbConfigCom.ResumeLayout(false);
            this.gbConfigCom.PerformLayout();
            this.gbDetectCom.ResumeLayout(false);
            this.gbDetectCom.PerformLayout();
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
    }
}

