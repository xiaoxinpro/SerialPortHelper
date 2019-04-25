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
            this.groupBoxInfoConfigFunction = new System.Windows.Forms.GroupBox();
            this.groupBoxInfoConfigMemaryFunction = new System.Windows.Forms.GroupBox();
            this.chkShowSerial = new System.Windows.Forms.CheckBox();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkShowSend = new System.Windows.Forms.CheckBox();
            this.chkMemoryFunction = new System.Windows.Forms.CheckBox();
            this.groupBoxInfoConfigTimeFormat = new System.Windows.Forms.GroupBox();
            this.btnInfoTimeDefault = new System.Windows.Forms.Button();
            this.linkTimeFormatHelp = new System.Windows.Forms.LinkLabel();
            this.txtTimeFormat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimeFormat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShowTimeFormat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxInfoConfigFont = new System.Windows.Forms.GroupBox();
            this.BtnInfoFontDefault = new System.Windows.Forms.Button();
            this.BtnInfoFontColor4 = new System.Windows.Forms.Button();
            this.BtnInfoFontColor3 = new System.Windows.Forms.Button();
            this.BtnInfoFontColor2 = new System.Windows.Forms.Button();
            this.BtnInfoFontColor1 = new System.Windows.Forms.Button();
            this.BtnInfoFont = new System.Windows.Forms.Button();
            this.txtInfoFont = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.tabConfig.SuspendLayout();
            this.tabPageWrite.SuspendLayout();
            this.groupBoxWriteConfigList.SuspendLayout();
            this.groupBoxWriteConfigAddOrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWriteConfigTimer)).BeginInit();
            this.tabPageInfo.SuspendLayout();
            this.groupBoxInfoConfigFunction.SuspendLayout();
            this.groupBoxInfoConfigMemaryFunction.SuspendLayout();
            this.groupBoxInfoConfigTimeFormat.SuspendLayout();
            this.groupBoxInfoConfigFont.SuspendLayout();
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
            this.tabPageInfo.Controls.Add(this.groupBoxInfoConfigFunction);
            this.tabPageInfo.Controls.Add(this.groupBoxInfoConfigTimeFormat);
            this.tabPageInfo.Controls.Add(this.groupBoxInfoConfigFont);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(312, 391);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "信息显示";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfoConfigFunction
            // 
            this.groupBoxInfoConfigFunction.Controls.Add(this.groupBoxInfoConfigMemaryFunction);
            this.groupBoxInfoConfigFunction.Controls.Add(this.chkMemoryFunction);
            this.groupBoxInfoConfigFunction.Location = new System.Drawing.Point(6, 240);
            this.groupBoxInfoConfigFunction.Name = "groupBoxInfoConfigFunction";
            this.groupBoxInfoConfigFunction.Size = new System.Drawing.Size(300, 145);
            this.groupBoxInfoConfigFunction.TabIndex = 2;
            this.groupBoxInfoConfigFunction.TabStop = false;
            this.groupBoxInfoConfigFunction.Text = "附加功能";
            // 
            // groupBoxInfoConfigMemaryFunction
            // 
            this.groupBoxInfoConfigMemaryFunction.Controls.Add(this.chkShowSerial);
            this.groupBoxInfoConfigMemaryFunction.Controls.Add(this.chkShowTime);
            this.groupBoxInfoConfigMemaryFunction.Controls.Add(this.chkShowSend);
            this.groupBoxInfoConfigMemaryFunction.Location = new System.Drawing.Point(10, 36);
            this.groupBoxInfoConfigMemaryFunction.Name = "groupBoxInfoConfigMemaryFunction";
            this.groupBoxInfoConfigMemaryFunction.Size = new System.Drawing.Size(283, 92);
            this.groupBoxInfoConfigMemaryFunction.TabIndex = 6;
            this.groupBoxInfoConfigMemaryFunction.TabStop = false;
            // 
            // chkShowSerial
            // 
            this.chkShowSerial.AutoSize = true;
            this.chkShowSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowSerial.Location = new System.Drawing.Point(6, 12);
            this.chkShowSerial.Name = "chkShowSerial";
            this.chkShowSerial.Size = new System.Drawing.Size(99, 21);
            this.chkShowSerial.TabIndex = 5;
            this.chkShowSerial.Tag = "1";
            this.chkShowSerial.Text = "默认显示串口";
            this.chkShowSerial.UseVisualStyleBackColor = true;
            this.chkShowSerial.Click += new System.EventHandler(this.chkFunction_Click);
            // 
            // chkShowTime
            // 
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowTime.Location = new System.Drawing.Point(6, 66);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(99, 21);
            this.chkShowTime.TabIndex = 3;
            this.chkShowTime.Tag = "3";
            this.chkShowTime.Text = "默认显示时间";
            this.chkShowTime.UseVisualStyleBackColor = true;
            this.chkShowTime.Click += new System.EventHandler(this.chkFunction_Click);
            // 
            // chkShowSend
            // 
            this.chkShowSend.AutoSize = true;
            this.chkShowSend.Checked = true;
            this.chkShowSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowSend.Location = new System.Drawing.Point(6, 39);
            this.chkShowSend.Name = "chkShowSend";
            this.chkShowSend.Size = new System.Drawing.Size(99, 21);
            this.chkShowSend.TabIndex = 4;
            this.chkShowSend.Tag = "2";
            this.chkShowSend.Text = "默认显示发送";
            this.chkShowSend.UseVisualStyleBackColor = true;
            this.chkShowSend.Click += new System.EventHandler(this.chkFunction_Click);
            // 
            // chkMemoryFunction
            // 
            this.chkMemoryFunction.AutoSize = true;
            this.chkMemoryFunction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkMemoryFunction.Location = new System.Drawing.Point(11, 20);
            this.chkMemoryFunction.Name = "chkMemoryFunction";
            this.chkMemoryFunction.Size = new System.Drawing.Size(99, 21);
            this.chkMemoryFunction.TabIndex = 5;
            this.chkMemoryFunction.Tag = "0";
            this.chkMemoryFunction.Text = "记忆附加功能";
            this.chkMemoryFunction.UseVisualStyleBackColor = true;
            this.chkMemoryFunction.Click += new System.EventHandler(this.chkFunction_Click);
            // 
            // groupBoxInfoConfigTimeFormat
            // 
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.btnInfoTimeDefault);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.linkTimeFormatHelp);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.txtTimeFormat);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.label7);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.btnTimeFormat);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.label9);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.txtShowTimeFormat);
            this.groupBoxInfoConfigTimeFormat.Controls.Add(this.label8);
            this.groupBoxInfoConfigTimeFormat.Location = new System.Drawing.Point(6, 124);
            this.groupBoxInfoConfigTimeFormat.Name = "groupBoxInfoConfigTimeFormat";
            this.groupBoxInfoConfigTimeFormat.Size = new System.Drawing.Size(300, 110);
            this.groupBoxInfoConfigTimeFormat.TabIndex = 1;
            this.groupBoxInfoConfigTimeFormat.TabStop = false;
            this.groupBoxInfoConfigTimeFormat.Text = "时间格式";
            // 
            // btnInfoTimeDefault
            // 
            this.btnInfoTimeDefault.Location = new System.Drawing.Point(220, 79);
            this.btnInfoTimeDefault.Name = "btnInfoTimeDefault";
            this.btnInfoTimeDefault.Size = new System.Drawing.Size(74, 24);
            this.btnInfoTimeDefault.TabIndex = 10;
            this.btnInfoTimeDefault.Text = "恢复默认";
            this.btnInfoTimeDefault.UseVisualStyleBackColor = true;
            this.btnInfoTimeDefault.Click += new System.EventHandler(this.btnInfoTimeDefault_Click);
            // 
            // linkTimeFormatHelp
            // 
            this.linkTimeFormatHelp.AutoSize = true;
            this.linkTimeFormatHelp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkTimeFormatHelp.Location = new System.Drawing.Point(46, 79);
            this.linkTimeFormatHelp.Name = "linkTimeFormatHelp";
            this.linkTimeFormatHelp.Size = new System.Drawing.Size(177, 20);
            this.linkTimeFormatHelp.TabIndex = 10;
            this.linkTimeFormatHelp.TabStop = true;
            this.linkTimeFormatHelp.Tag = "https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/standard-date-and-tim" +
    "e-format-strings?view=netframework-3.5";
            this.linkTimeFormatHelp.Text = "标准日期和时间格式字符串";
            this.linkTimeFormatHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTimeFormatHelp_LinkClicked);
            // 
            // txtTimeFormat
            // 
            this.txtTimeFormat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTimeFormat.Location = new System.Drawing.Point(50, 21);
            this.txtTimeFormat.Name = "txtTimeFormat";
            this.txtTimeFormat.Size = new System.Drawing.Size(164, 23);
            this.txtTimeFormat.TabIndex = 8;
            this.txtTimeFormat.Text = "yyyy-MM-dd hh:mm:ss.fff";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "格式：";
            // 
            // btnTimeFormat
            // 
            this.btnTimeFormat.Location = new System.Drawing.Point(220, 20);
            this.btnTimeFormat.Name = "btnTimeFormat";
            this.btnTimeFormat.Size = new System.Drawing.Size(74, 24);
            this.btnTimeFormat.TabIndex = 9;
            this.btnTimeFormat.Text = "保存";
            this.btnTimeFormat.UseVisualStyleBackColor = true;
            this.btnTimeFormat.Click += new System.EventHandler(this.btnTimeFormat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "帮助：";
            // 
            // txtShowTimeFormat
            // 
            this.txtShowTimeFormat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowTimeFormat.Location = new System.Drawing.Point(50, 50);
            this.txtShowTimeFormat.Multiline = true;
            this.txtShowTimeFormat.Name = "txtShowTimeFormat";
            this.txtShowTimeFormat.ReadOnly = true;
            this.txtShowTimeFormat.Size = new System.Drawing.Size(244, 23);
            this.txtShowTimeFormat.TabIndex = 8;
            this.txtShowTimeFormat.Text = "yyyy-MM-dd hh:mm:ss.fff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "实例：";
            // 
            // groupBoxInfoConfigFont
            // 
            this.groupBoxInfoConfigFont.Controls.Add(this.BtnInfoFontDefault);
            this.groupBoxInfoConfigFont.Controls.Add(this.BtnInfoFontColor4);
            this.groupBoxInfoConfigFont.Controls.Add(this.BtnInfoFontColor3);
            this.groupBoxInfoConfigFont.Controls.Add(this.BtnInfoFontColor2);
            this.groupBoxInfoConfigFont.Controls.Add(this.BtnInfoFontColor1);
            this.groupBoxInfoConfigFont.Controls.Add(this.BtnInfoFont);
            this.groupBoxInfoConfigFont.Controls.Add(this.txtInfoFont);
            this.groupBoxInfoConfigFont.Controls.Add(this.label6);
            this.groupBoxInfoConfigFont.Controls.Add(this.label5);
            this.groupBoxInfoConfigFont.Location = new System.Drawing.Point(6, 6);
            this.groupBoxInfoConfigFont.Name = "groupBoxInfoConfigFont";
            this.groupBoxInfoConfigFont.Size = new System.Drawing.Size(300, 112);
            this.groupBoxInfoConfigFont.TabIndex = 0;
            this.groupBoxInfoConfigFont.TabStop = false;
            this.groupBoxInfoConfigFont.Text = "文字设置";
            // 
            // BtnInfoFontDefault
            // 
            this.BtnInfoFontDefault.Location = new System.Drawing.Point(220, 51);
            this.BtnInfoFontDefault.Name = "BtnInfoFontDefault";
            this.BtnInfoFontDefault.Size = new System.Drawing.Size(74, 53);
            this.BtnInfoFontDefault.TabIndex = 10;
            this.BtnInfoFontDefault.Text = "恢复默认";
            this.BtnInfoFontDefault.UseVisualStyleBackColor = true;
            this.BtnInfoFontDefault.Click += new System.EventHandler(this.BtnInfoFontDefault_Click);
            // 
            // BtnInfoFontColor4
            // 
            this.BtnInfoFontColor4.Location = new System.Drawing.Point(135, 80);
            this.BtnInfoFontColor4.Name = "BtnInfoFontColor4";
            this.BtnInfoFontColor4.Size = new System.Drawing.Size(79, 24);
            this.BtnInfoFontColor4.TabIndex = 9;
            this.BtnInfoFontColor4.Tag = "4";
            this.BtnInfoFontColor4.Text = "串口2接收";
            this.BtnInfoFontColor4.UseVisualStyleBackColor = true;
            this.BtnInfoFontColor4.Click += new System.EventHandler(this.BtnInfoFontColor_Click);
            // 
            // BtnInfoFontColor3
            // 
            this.BtnInfoFontColor3.Location = new System.Drawing.Point(50, 80);
            this.BtnInfoFontColor3.Name = "BtnInfoFontColor3";
            this.BtnInfoFontColor3.Size = new System.Drawing.Size(79, 24);
            this.BtnInfoFontColor3.TabIndex = 9;
            this.BtnInfoFontColor3.Tag = "3";
            this.BtnInfoFontColor3.Text = "串口2发送";
            this.BtnInfoFontColor3.UseVisualStyleBackColor = true;
            this.BtnInfoFontColor3.Click += new System.EventHandler(this.BtnInfoFontColor_Click);
            // 
            // BtnInfoFontColor2
            // 
            this.BtnInfoFontColor2.Location = new System.Drawing.Point(135, 50);
            this.BtnInfoFontColor2.Name = "BtnInfoFontColor2";
            this.BtnInfoFontColor2.Size = new System.Drawing.Size(79, 24);
            this.BtnInfoFontColor2.TabIndex = 9;
            this.BtnInfoFontColor2.Tag = "2";
            this.BtnInfoFontColor2.Text = "串口1接收";
            this.BtnInfoFontColor2.UseVisualStyleBackColor = true;
            this.BtnInfoFontColor2.Click += new System.EventHandler(this.BtnInfoFontColor_Click);
            // 
            // BtnInfoFontColor1
            // 
            this.BtnInfoFontColor1.Location = new System.Drawing.Point(50, 50);
            this.BtnInfoFontColor1.Name = "BtnInfoFontColor1";
            this.BtnInfoFontColor1.Size = new System.Drawing.Size(79, 24);
            this.BtnInfoFontColor1.TabIndex = 9;
            this.BtnInfoFontColor1.Tag = "1";
            this.BtnInfoFontColor1.Text = "串口1发送";
            this.BtnInfoFontColor1.UseVisualStyleBackColor = true;
            this.BtnInfoFontColor1.Click += new System.EventHandler(this.BtnInfoFontColor_Click);
            // 
            // BtnInfoFont
            // 
            this.BtnInfoFont.Location = new System.Drawing.Point(220, 20);
            this.BtnInfoFont.Name = "BtnInfoFont";
            this.BtnInfoFont.Size = new System.Drawing.Size(74, 24);
            this.BtnInfoFont.TabIndex = 9;
            this.BtnInfoFont.Text = "选择";
            this.BtnInfoFont.UseVisualStyleBackColor = true;
            this.BtnInfoFont.Click += new System.EventHandler(this.BtnInfoFont_Click);
            // 
            // txtInfoFont
            // 
            this.txtInfoFont.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInfoFont.Location = new System.Drawing.Point(50, 21);
            this.txtInfoFont.Multiline = true;
            this.txtInfoFont.Name = "txtInfoFont";
            this.txtInfoFont.ReadOnly = true;
            this.txtInfoFont.Size = new System.Drawing.Size(164, 23);
            this.txtInfoFont.TabIndex = 8;
            this.txtInfoFont.Text = "串口调试工具 0x55 0xAA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "颜色：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "字体：";
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
            this.tabPageInfo.ResumeLayout(false);
            this.groupBoxInfoConfigFunction.ResumeLayout(false);
            this.groupBoxInfoConfigFunction.PerformLayout();
            this.groupBoxInfoConfigMemaryFunction.ResumeLayout(false);
            this.groupBoxInfoConfigMemaryFunction.PerformLayout();
            this.groupBoxInfoConfigTimeFormat.ResumeLayout(false);
            this.groupBoxInfoConfigTimeFormat.PerformLayout();
            this.groupBoxInfoConfigFont.ResumeLayout(false);
            this.groupBoxInfoConfigFont.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxInfoConfigFont;
        private System.Windows.Forms.Button BtnInfoFontDefault;
        private System.Windows.Forms.Button BtnInfoFontColor4;
        private System.Windows.Forms.Button BtnInfoFontColor3;
        private System.Windows.Forms.Button BtnInfoFontColor2;
        private System.Windows.Forms.Button BtnInfoFontColor1;
        private System.Windows.Forms.Button BtnInfoFont;
        private System.Windows.Forms.TextBox txtInfoFont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxInfoConfigTimeFormat;
        private System.Windows.Forms.TextBox txtTimeFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimeFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShowTimeFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkTimeFormatHelp;
        private System.Windows.Forms.Button btnInfoTimeDefault;
        private System.Windows.Forms.GroupBox groupBoxInfoConfigFunction;
        private System.Windows.Forms.GroupBox groupBoxInfoConfigMemaryFunction;
        private System.Windows.Forms.CheckBox chkShowSerial;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.Windows.Forms.CheckBox chkShowSend;
        private System.Windows.Forms.CheckBox chkMemoryFunction;
    }
}