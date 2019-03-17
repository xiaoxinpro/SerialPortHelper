namespace SerialPostTool
{
    partial class frmConfig
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWrite = new System.Windows.Forms.TabPage();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.groupBoxWriteConfigAddOrEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxWriteConfigList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkWriteConfigTimer = new System.Windows.Forms.CheckBox();
            this.numWriteConfigTimer = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWriteConfigFormat = new System.Windows.Forms.ComboBox();
            this.txtWriteConfigName = new System.Windows.Forms.TextBox();
            this.txtWriteConfigData = new System.Windows.Forms.TextBox();
            this.btnWriteConfigSave = new System.Windows.Forms.Button();
            this.listViewWriteConfig = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPageWrite.SuspendLayout();
            this.groupBoxWriteConfigAddOrEdit.SuspendLayout();
            this.groupBoxWriteConfigList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWriteConfigTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWrite);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.tabPageSerial);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageWrite
            // 
            this.tabPageWrite.Controls.Add(this.groupBoxWriteConfigList);
            this.tabPageWrite.Controls.Add(this.groupBoxWriteConfigAddOrEdit);
            this.tabPageWrite.Location = new System.Drawing.Point(4, 22);
            this.tabPageWrite.Name = "tabPageWrite";
            this.tabPageWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWrite.Size = new System.Drawing.Size(312, 391);
            this.tabPageWrite.TabIndex = 0;
            this.tabPageWrite.Text = "快捷管理";
            this.tabPageWrite.UseVisualStyleBackColor = true;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(312, 391);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "信息显示";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageSerial
            // 
            this.tabPageSerial.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerial.Name = "tabPageSerial";
            this.tabPageSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerial.Size = new System.Drawing.Size(312, 391);
            this.tabPageSerial.TabIndex = 2;
            this.tabPageSerial.Text = "串口配置";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // groupBoxWriteConfigAddOrEdit
            // 
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.btnWriteConfigSave);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.numWriteConfigTimer);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.txtWriteConfigData);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.txtWriteConfigName);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.cbWriteConfigFormat);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.label4);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.chkWriteConfigTimer);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.label3);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.label2);
            this.groupBoxWriteConfigAddOrEdit.Controls.Add(this.label1);
            this.groupBoxWriteConfigAddOrEdit.Location = new System.Drawing.Point(6, 6);
            this.groupBoxWriteConfigAddOrEdit.Name = "groupBoxWriteConfigAddOrEdit";
            this.groupBoxWriteConfigAddOrEdit.Size = new System.Drawing.Size(300, 117);
            this.groupBoxWriteConfigAddOrEdit.TabIndex = 0;
            this.groupBoxWriteConfigAddOrEdit.TabStop = false;
            this.groupBoxWriteConfigAddOrEdit.Text = "添加/编辑";
            // 
            // groupBoxWriteConfigList
            // 
            this.groupBoxWriteConfigList.Controls.Add(this.listViewWriteConfig);
            this.groupBoxWriteConfigList.Location = new System.Drawing.Point(6, 129);
            this.groupBoxWriteConfigList.Name = "groupBoxWriteConfigList";
            this.groupBoxWriteConfigList.Size = new System.Drawing.Size(300, 256);
            this.groupBoxWriteConfigList.TabIndex = 0;
            this.groupBoxWriteConfigList.TabStop = false;
            this.groupBoxWriteConfigList.Text = "浏览";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "内容：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "格式：";
            // 
            // chkWriteConfigTimer
            // 
            this.chkWriteConfigTimer.AutoSize = true;
            this.chkWriteConfigTimer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWriteConfigTimer.Location = new System.Drawing.Point(153, 80);
            this.chkWriteConfigTimer.Name = "chkWriteConfigTimer";
            this.chkWriteConfigTimer.Size = new System.Drawing.Size(56, 24);
            this.chkWriteConfigTimer.TabIndex = 1;
            this.chkWriteConfigTimer.Text = "定时";
            this.chkWriteConfigTimer.UseVisualStyleBackColor = true;
            // 
            // numWriteConfigTimer
            // 
            this.numWriteConfigTimer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numWriteConfigTimer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWriteConfigTimer.Location = new System.Drawing.Point(204, 82);
            this.numWriteConfigTimer.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numWriteConfigTimer.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWriteConfigTimer.Name = "numWriteConfigTimer";
            this.numWriteConfigTimer.Size = new System.Drawing.Size(70, 23);
            this.numWriteConfigTimer.TabIndex = 2;
            this.numWriteConfigTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWriteConfigTimer.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(272, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ms";
            // 
            // cbWriteConfigFormat
            // 
            this.cbWriteConfigFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWriteConfigFormat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbWriteConfigFormat.FormattingEnabled = true;
            this.cbWriteConfigFormat.Items.AddRange(new object[] {
            "自动",
            "字符串",
            "十六进制"});
            this.cbWriteConfigFormat.Location = new System.Drawing.Point(50, 79);
            this.cbWriteConfigFormat.Name = "cbWriteConfigFormat";
            this.cbWriteConfigFormat.Size = new System.Drawing.Size(87, 25);
            this.cbWriteConfigFormat.TabIndex = 9;
            // 
            // txtWriteConfigName
            // 
            this.txtWriteConfigName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWriteConfigName.Location = new System.Drawing.Point(50, 21);
            this.txtWriteConfigName.Name = "txtWriteConfigName";
            this.txtWriteConfigName.Size = new System.Drawing.Size(164, 23);
            this.txtWriteConfigName.TabIndex = 10;
            // 
            // txtWriteConfigData
            // 
            this.txtWriteConfigData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWriteConfigData.Location = new System.Drawing.Point(50, 50);
            this.txtWriteConfigData.Name = "txtWriteConfigData";
            this.txtWriteConfigData.Size = new System.Drawing.Size(244, 23);
            this.txtWriteConfigData.TabIndex = 10;
            // 
            // btnWriteConfigSave
            // 
            this.btnWriteConfigSave.Location = new System.Drawing.Point(220, 20);
            this.btnWriteConfigSave.Name = "btnWriteConfigSave";
            this.btnWriteConfigSave.Size = new System.Drawing.Size(74, 24);
            this.btnWriteConfigSave.TabIndex = 11;
            this.btnWriteConfigSave.Text = "保存";
            this.btnWriteConfigSave.UseVisualStyleBackColor = true;
            this.btnWriteConfigSave.Click += new System.EventHandler(this.btnWriteConfigSave_Click);
            // 
            // listViewWriteConfig
            // 
            this.listViewWriteConfig.Location = new System.Drawing.Point(7, 20);
            this.listViewWriteConfig.Name = "listViewWriteConfig";
            this.listViewWriteConfig.Size = new System.Drawing.Size(287, 230);
            this.listViewWriteConfig.TabIndex = 0;
            this.listViewWriteConfig.UseCompatibleStateImageBehavior = false;
            this.listViewWriteConfig.SelectedIndexChanged += new System.EventHandler(this.listViewWriteConfig_SelectedIndexChanged);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置选项";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageWrite.ResumeLayout(false);
            this.groupBoxWriteConfigAddOrEdit.ResumeLayout(false);
            this.groupBoxWriteConfigAddOrEdit.PerformLayout();
            this.groupBoxWriteConfigList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWriteConfigTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWrite;
        private System.Windows.Forms.GroupBox groupBoxWriteConfigList;
        private System.Windows.Forms.GroupBox groupBoxWriteConfigAddOrEdit;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWriteConfigTimer;
        private System.Windows.Forms.CheckBox chkWriteConfigTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewWriteConfig;
        private System.Windows.Forms.Button btnWriteConfigSave;
        private System.Windows.Forms.TextBox txtWriteConfigData;
        private System.Windows.Forms.TextBox txtWriteConfigName;
        private System.Windows.Forms.ComboBox cbWriteConfigFormat;
    }
}