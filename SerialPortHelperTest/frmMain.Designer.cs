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
            this.listSerialPort = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReflashList = new System.Windows.Forms.Button();
            this.chkAutoReflash = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listSerialPort
            // 
            this.listSerialPort.FormattingEnabled = true;
            this.listSerialPort.ItemHeight = 12;
            this.listSerialPort.Location = new System.Drawing.Point(12, 43);
            this.listSerialPort.Name = "listSerialPort";
            this.listSerialPort.Size = new System.Drawing.Size(75, 352);
            this.listSerialPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口列表：";
            // 
            // btnReflashList
            // 
            this.btnReflashList.Location = new System.Drawing.Point(12, 401);
            this.btnReflashList.Name = "btnReflashList";
            this.btnReflashList.Size = new System.Drawing.Size(75, 23);
            this.btnReflashList.TabIndex = 2;
            this.btnReflashList.Text = "手动刷新";
            this.btnReflashList.UseVisualStyleBackColor = true;
            this.btnReflashList.Click += new System.EventHandler(this.btnReflashList_Click);
            // 
            // chkAutoReflash
            // 
            this.chkAutoReflash.AutoSize = true;
            this.chkAutoReflash.Checked = true;
            this.chkAutoReflash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoReflash.Location = new System.Drawing.Point(12, 24);
            this.chkAutoReflash.Name = "chkAutoReflash";
            this.chkAutoReflash.Size = new System.Drawing.Size(72, 16);
            this.chkAutoReflash.TabIndex = 3;
            this.chkAutoReflash.Text = "自动刷新";
            this.chkAutoReflash.UseVisualStyleBackColor = true;
            this.chkAutoReflash.CheckedChanged += new System.EventHandler(this.chkAutoReflash_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.chkAutoReflash);
            this.Controls.Add(this.btnReflashList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSerialPort);
            this.Name = "frmMain";
            this.Text = "串口助手类库";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReflashList;
        private System.Windows.Forms.CheckBox chkAutoReflash;
    }
}

