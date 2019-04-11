using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPostTool
{
    public partial class frmConfig : Form
    {
        #region 字段
        private frmMain FormMain;
        private FontDialog InfoFont = new FontDialog();
        private ColorDialog InfoFontColor = new ColorDialog();
        #endregion

        #region 初始化
        public frmConfig(frmMain main, int tab = 0)
        {
            InitializeComponent();

            //初始化字段
            FormMain = main;

            //切换初始Tab
            tabConfig.SelectedIndex = tab;
        }

        /// <summary>
        /// 加载页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConfig_Load(object sender, EventArgs e)
        {
            //初始化快捷管理UI
            InitSerialWriteUI();
            
            //初始化表格
            InitListViewWriteConfig(listViewWriteConfig);

            //初始化串口消息UI
            InitSerialInfoUI(FormMain.objSerialInfoConfig);
        }

        /// <summary>
        /// 初始化快捷管理UI
        /// </summary>
        private void InitSerialWriteUI()
        {
            txtWriteConfigName.Text = "";
            txtWriteConfigData.Text = "";
            cbWriteConfigFormat.SelectedIndex = 0;
            chkWriteConfigTimer.Checked = false;
            numWriteConfigTimer.Value = 500;
            btnWriteConfigSave.Text = "添加";
        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        private void InitListViewWriteConfig(ListView listView)
        {
            //基本属性设置
            listView.Clear();
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;

            //创建列表头
            listView.Columns.Add("序号", 40, HorizontalAlignment.Center);
            listView.Columns.Add("名称", 90, HorizontalAlignment.Center);
            listView.Columns.Add("内容", 130, HorizontalAlignment.Center);

            //添加数据
            listView.BeginUpdate();
            try
            {
                for (int i = 0; i < FormMain.arrSerialWriteConfig.Length; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = (i + 1).ToString();
                    listViewItem.SubItems.Add(FormMain.arrSerialWriteConfig[i].Name);
                    listViewItem.SubItems.Add(FormMain.arrSerialWriteConfig[i].Data);
                    listView.Items.Add(listViewItem);
                }
            }
            catch (Exception)
            {
                listView.Items.Clear();
            }
            listView.EndUpdate();
        }

        /// <summary>
        /// 初始化串口消息UI
        /// </summary>
        private void InitSerialInfoUI(SerialInfoConfig serialInfoConfig)
        {
            txtInfoFont.Font = serialInfoConfig.Font;
            BtnInfoFontColor1.ForeColor = serialInfoConfig.Color1Write;
            BtnInfoFontColor2.ForeColor = serialInfoConfig.Color1Receive;
            BtnInfoFontColor3.ForeColor = serialInfoConfig.Color2Write;
            BtnInfoFontColor4.ForeColor = serialInfoConfig.Color2Receive;
            txtTimeFormat.Text = serialInfoConfig.TimeFormat;
            ShowTimeFormat(serialInfoConfig.TimeFormat);
        }
        #endregion

        #region 添加/编辑快捷数据
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteConfigSave_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ListView listView = listViewWriteConfig;
            SerialWriteConfig serialWriteConfig = new SerialWriteConfig();

            if (txtWriteConfigName.Text.Trim() == "")
            {
                MessageBox.Show("名称不能为空，请重新输入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtWriteConfigData.Text.Trim() == "")
            {
                MessageBox.Show("数据不能为空，请重新输入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            serialWriteConfig.Name = txtWriteConfigName.Text;
            serialWriteConfig.Data = txtWriteConfigData.Text;
            serialWriteConfig.Format = frmMain.ComboToSerialFormat(cbWriteConfigFormat);
            serialWriteConfig.IsTimer = chkWriteConfigTimer.Checked;
            serialWriteConfig.Timer = Convert.ToInt32(numWriteConfigTimer.Value);

            if (listView.SelectedIndices.Count > 0)
            {
                int selectIndex = listView.SelectedIndices[0];
                int getIndex = SerialWriteConfig.GetIndex(FormMain.arrSerialWriteConfig, txtWriteConfigName.Text.Trim());
                if (selectIndex != getIndex && getIndex >= 0)
                {
                    MessageBox.Show("名称已经存在，请重新输入。", "冲突", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //修改数据
                EditWriteConfig(serialWriteConfig, selectIndex);
            }
            else
            {
                if (SerialWriteConfig.GetIndex(FormMain.arrSerialWriteConfig, txtWriteConfigName.Text.Trim()) >= 0)
                {
                    MessageBox.Show("名称已经存在，请重新输入。", "冲突", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //添加数据
                AddWriteConfig(serialWriteConfig);
            }

            Json.WriteFile(SerialWriteConfig.Path, FormMain.arrSerialWriteConfig);
            InitListViewWriteConfig(listViewWriteConfig);
            InitSerialWriteUI();
            FormMain.InitSerialWriteConfig();
        }

        /// <summary>
        /// 添加快捷发送数据
        /// </summary>
        /// <param name="serialWriteConfig"></param>
        private void AddWriteConfig(SerialWriteConfig serialWriteConfig)
        {
            List<SerialWriteConfig> listSerialWriteConfigs = FormMain.arrSerialWriteConfig.ToList();
            listSerialWriteConfigs.Add(serialWriteConfig);
            FormMain.arrSerialWriteConfig = listSerialWriteConfigs.ToArray();
        }

        /// <summary>
        /// 编辑快捷发送数据
        /// </summary>
        /// <param name="serialWriteConfig"></param>
        /// <param name="index"></param>
        private void EditWriteConfig(SerialWriteConfig serialWriteConfig, int index)
        {
            FormMain.arrSerialWriteConfig[index].Name = serialWriteConfig.Name;
            FormMain.arrSerialWriteConfig[index].Data = serialWriteConfig.Data;
            FormMain.arrSerialWriteConfig[index].Format = serialWriteConfig.Format;
            FormMain.arrSerialWriteConfig[index].IsTimer = serialWriteConfig.IsTimer;
            FormMain.arrSerialWriteConfig[index].Timer = serialWriteConfig.Timer;
        }

        /// <summary>
        /// 删除快捷发送数据
        /// </summary>
        /// <param name="index"></param>
        private void DeleteWriteConfig(int index)
        {
            if (index >= 0 && index < FormMain.arrSerialWriteConfig.Length)
            {
                List<SerialWriteConfig> listSerialWriteConfigs = FormMain.arrSerialWriteConfig.ToList();
                listSerialWriteConfigs.RemoveAt(index);
                FormMain.arrSerialWriteConfig = listSerialWriteConfigs.ToArray();
            }
        }

        /// <summary>
        /// 快捷数据表格双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewWriteConfig_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedIndices.Count > 0)
            {
                DeleteWriteConfig(listView.SelectedIndices[0]);
                Json.WriteFile(SerialWriteConfig.Path, FormMain.arrSerialWriteConfig);
                InitSerialWriteUI();
                InitListViewWriteConfig(listView);
                FormMain.InitSerialWriteConfig();
            }
        }

        /// <summary>
        /// 快捷数据表格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewWriteConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedIndices.Count > 0)
            {
                //修改数据
                int i = listView.SelectedIndices[0];
                LoadSerialWriteUI(FormMain.arrSerialWriteConfig[i]);
            }
            else
            {
                //添加数据
                InitSerialWriteUI();
            }
        }

        /// <summary>
        /// 加载快捷发送数据UI
        /// </summary>
        /// <param name="serialWriteConfig"></param>
        private void LoadSerialWriteUI(SerialWriteConfig serialWriteConfig)
        {
            txtWriteConfigName.Text = serialWriteConfig.Name;
            txtWriteConfigData.Text = serialWriteConfig.Data;
            frmMain.SerialFormatToCombo(cbWriteConfigFormat, serialWriteConfig.Format);
            chkWriteConfigTimer.Checked = serialWriteConfig.IsTimer;
            numWriteConfigTimer.Value = serialWriteConfig.Timer;
            btnWriteConfigSave.Text = "修改";
        }
        #endregion

        #region 显示设置 - 文字设置
        /// <summary>
        /// 字体选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoFont_Click(object sender, EventArgs e)
        {
            InfoFont.Font = txtInfoFont.Font;
            DialogResult result = InfoFont.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtInfoFont.Font = InfoFont.Font;
                FormMain.objSerialInfoConfig.Font = InfoFont.Font;
                Json.WriteFile(SerialInfoConfig.Path, FormMain.objSerialInfoConfig);
            }
        }

        /// <summary>
        /// 字体颜色按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoFontColor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            InfoFontColor.Color = btn.ForeColor;
            DialogResult result = InfoFontColor.ShowDialog(btn);
            if (result == DialogResult.OK)
            {
                btn.ForeColor = InfoFontColor.Color;
                switch (btn.Tag.ToString())
                {
                    case "1":
                        FormMain.objSerialInfoConfig.Color1Write = InfoFontColor.Color;
                        break;
                    case "2":
                        FormMain.objSerialInfoConfig.Color1Receive = InfoFontColor.Color;
                        break;
                    case "3":
                        FormMain.objSerialInfoConfig.Color2Write = InfoFontColor.Color;
                        break;
                    case "4":
                        FormMain.objSerialInfoConfig.Color2Receive = InfoFontColor.Color;
                        break;
                    default:
                        break;
                }
                Json.WriteFile(SerialInfoConfig.Path, FormMain.objSerialInfoConfig);
            }
        }
        #endregion

        #region 显示设置 - 时间格式
        /// <summary>
        /// 帮助链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkTimeFormatHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            System.Diagnostics.Process.Start(link.Tag.ToString());
        }

        /// <summary>
        /// 时间格式保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimeFormat_Click(object sender, EventArgs e)
        {
            string strFormat = txtTimeFormat.Text.Trim();
            try
            {
                ShowTimeFormat(strFormat);
                FormMain.objSerialInfoConfig.TimeFormat = strFormat;
                Json.WriteFile(SerialInfoConfig.Path, FormMain.objSerialInfoConfig);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        /// <summary>
        /// 显示时间格式
        /// </summary>
        /// <param name="strFormat">格式字符串</param>
        private void ShowTimeFormat(string strFormat)
        {
            txtShowTimeFormat.Text = DateTime.Now.ToString(strFormat);
        }

        #endregion
    }
}
