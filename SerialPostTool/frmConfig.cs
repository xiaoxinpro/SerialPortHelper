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
        private SerialWriteConfig[] arrSerialWriteConfigs;
        private ComboBox cbSerialWrite1;
        private ComboBox cbSerialWrite2;
        #endregion

        #region 初始化
        public frmConfig(SerialWriteConfig[] writeConfig, ComboBox cb1, ComboBox cb2)
        {
            InitializeComponent();

            //初始化字段
            arrSerialWriteConfigs = writeConfig;
            cbSerialWrite1 = cb1;
            cbSerialWrite2 = cb2;
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
                for (int i = 0; i < arrSerialWriteConfigs.Length; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = (i + 1).ToString();
                    listViewItem.SubItems.Add(arrSerialWriteConfigs[i].Name);
                    listViewItem.SubItems.Add(arrSerialWriteConfigs[i].Data);
                    listView.Items.Add(listViewItem);
                }
            }
            catch (Exception)
            {
                listView.Items.Clear();
            }
            listView.EndUpdate();
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

            serialWriteConfig.Name = txtWriteConfigName.Text;
            serialWriteConfig.Data = txtWriteConfigData.Text;
            serialWriteConfig.Format = frmMain.ComboToSerialFormat(cbWriteConfigFormat);
            serialWriteConfig.IsTimer = chkWriteConfigTimer.Checked;
            serialWriteConfig.Timer = Convert.ToInt32(numWriteConfigTimer.Value);

            if (listView.SelectedIndices.Count > 0)
            {
                //修改数据
                int i = listView.SelectedIndices[0];
                EditWriteConfig(serialWriteConfig, i);
            }
            else
            {
                //添加数据
                AddWriteConfig(serialWriteConfig);
            }

            Json.WriteFile(SerialWriteConfig.Path, arrSerialWriteConfigs);
            InitListViewWriteConfig(listViewWriteConfig);
            InitSerialWriteUI();
        }

        /// <summary>
        /// 添加快捷发送数据
        /// </summary>
        /// <param name="serialWriteConfig"></param>
        private void AddWriteConfig(SerialWriteConfig serialWriteConfig)
        {
            List<SerialWriteConfig> listSerialWriteConfigs = arrSerialWriteConfigs.ToList();
            listSerialWriteConfigs.Add(serialWriteConfig);
            arrSerialWriteConfigs = listSerialWriteConfigs.ToArray();
        }

        /// <summary>
        /// 编辑快捷发送数据
        /// </summary>
        /// <param name="serialWriteConfig"></param>
        /// <param name="index"></param>
        private void EditWriteConfig(SerialWriteConfig serialWriteConfig, int index)
        {
            arrSerialWriteConfigs[index].Name = serialWriteConfig.Name;
            arrSerialWriteConfigs[index].Data = serialWriteConfig.Data;
            arrSerialWriteConfigs[index].Format = serialWriteConfig.Format;
            arrSerialWriteConfigs[index].IsTimer = serialWriteConfig.IsTimer;
            arrSerialWriteConfigs[index].Timer = serialWriteConfig.Timer;
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
                LoadSerialWriteUI(arrSerialWriteConfigs[i]);
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

    }
}
