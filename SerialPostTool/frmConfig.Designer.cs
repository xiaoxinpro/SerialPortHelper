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
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabPageWrite = new System.Windows.Forms.TabPage();
            this.groupBoxWriteConfigList = new System.Windows.Forms.GroupBox();
            this.listViewWriteConfig = new System.Windows.Forms.ListView();
            this.groupBoxWriteConfigAddOrEdit = new System.Windows.Forms.GroupBox();
            this.btnWriteConfigSave = new System.Windows.Forms.Button();
            this.numWriteConfigTimer = new System.Windows.Forms.NumericUpDown();
            this.txtWriteConfigData = new System.Windows.Forms.TextBox();
            this.txtWriteConfigName = new System.Windows.Forms.TextBox();
            this.cbWriteConfigFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkWriteConfigTimer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.tabConfig.SuspendLayout();
            this.tabPageWrite.SuspendLayout();
            this.groupBoxWriteConfigList.SuspendLayout();
            this.groupBoxWriteConfigAddOrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWriteConfigTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabPageWrite);
            this.tabConfig.Controls.Add(this.tabPageInfo);
            this.tabConfig.Controls.Add(this.tabPageSerial);
            this.tabConfig.Location = new System.Drawing.Point(12, 12);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(320, 417);
            this.tabConfig.TabIndex = 0;
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
            // listViewWriteConfig
            // 
            this.listViewWriteConfig.Location = new System.Drawing.Point(7, 20);
            this.listViewWriteConfig.MultiSelect = false;
            this.listViewWriteConfig.Name = "listViewWriteConfig";
            this.listViewWriteConfig.Size = new System.Drawing.Size(287, 230);
            this.listViewWriteConfig.TabIndex = 0;
            this.listViewWriteConfig.UseCompatibleStateImageBehavior = false;
            this.listViewWriteConfig.SelectedIndexChanged += new System.EventHandler(this.listViewWriteConfig_SelectedIndexChanged);
            this.listViewWriteConfig.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewWriteConfig_MouseDoubleClick);
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
            // btnWriteConfigSave
            // 
            this.btnWriteConfigSave.Location = new System.Drawing.Point(220, 20);
            this.btnWriteConfigSave.Name = "btnWriteConfigSave";
            this.btnWriteConfigSave.Size = new System.Drawing.Size(74, 24);
            this.btnWriteConfigSave.TabIndex = 6;
            this.btnWriteConfigSave.Text = "保存";
            this.btnWriteConfigSave.UseVisualStyleBackColor = true;
            this.btnWriteConfigSave.Click += new System.EventHandler(this.btnWriteConfigSave_Click);
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
            this.numWriteConfigTimer.TabIndex = 5;
            this.numWriteConfigTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWriteConfigTimer.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtWriteConfigData
            // 
            this.txtWriteConfigData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWriteConfigData.Location = new System.Drawing.Point(50, 50);
            this.txtWriteConfigData.Name = "txtWriteConfigData";
            this.txtWriteConfigData.Size = new System.Drawing.Size(244, 23);
            this.txtWriteConfigData.TabIndex = 2;
            // 
            // txtWriteConfigName
            // 
            this.txtWriteConfigName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWriteConfigName.Location = new System.Drawing.Point(50, 21);
            this.txtWriteConfigName.Name = "txtWriteConfigName";
            this.txtWriteConfigName.Size = new System.Drawing.Size(164, 23);
            this.txtWriteConfigName.TabIndex = 1;
            // 
            // cbWriteConfigFormat
            // 
            this.cbWriteConfigFormat.BackColor = System.Drawing.SystemColors.Window;
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
            this.cbWriteConfigFormat.TabIndex = 3;
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
            // chkWriteConfigTimer
            // 
            this.chkWriteConfigTimer.AutoSize = true;
            this.chkWriteConfigTimer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWriteConfigTimer.Location = new System.Drawing.Point(153, 80);
            this.chkWriteConfigTimer.Name = "chkWriteConfigTimer";
            this.chkWriteConfigTimer.Size = new System.Drawing.Size(56, 24);
            this.chkWriteConfigTimer.TabIndex = 4;
            this.chkWriteConfigTimer.Text = "定时";
            this.chkWriteConfigTimer.UseVisualStyleBackColor = true;
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
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.tabConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置选项";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tabConfig.ResumeLayout(false);
            this.tabPageWrite.ResumeLayout(false);
            this.groupBoxWriteConfigList.ResumeLayout(false);
            this.groupBoxWriteConfigAddOrEdit.ResumeLayout(false);
            this.groupBoxWriteConfigAddOrEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWriteConfigTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfig;
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