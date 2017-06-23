using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SpaceLauncher
{
    public partial class commandView : Form
    {
        LoadConfig ini;
        HintDialog hi;
        String appName = "SpaceLauncher";

        [DllImport("user32")]
        static extern int SetForegroundWindow(IntPtr hwnd);

        public commandView()
        {
            InitializeComponent();
            ini = new LoadConfig(Application.StartupPath + @"\command.ini");
            hi = new HintDialog();
            InitList();
            Keys
            //SetHotKey(ini, this.Handle);
            this.WindowState = FormWindowState.Minimized;
            if (AutoRun.isAutoRun(appName, Application.ExecutablePath))
            {
                startWithBoot.Checked = true;
            }
            else
            {
                startWithBoot.Checked = false;
            }
        }

        /// <summary>
        /// 程序初始化时设置热键
        /// </summary>
        /// <param name="config">配置类</param>
        /// <param name="handle">主窗体句柄</param>
        public static void SetHotkey(LoadConfig config, IntPtr handle)
        {
            try
            {
                HotKey.UnregisterHotKey(handle, 100);
                if (!config.ExistINIFile())
                {
                    MessageBox.Show("ini文件不存在");
                    Application.Exit();
                }
                int hotkeycode = (config.ReadIni("Set", "Ctrl") == "True" ? 100 : 0) + (config.ReadIni("Set", "Alt") == "True" ? 10 : 0) + (config.ReadIni("Set", "Shift") == "True" ? 1 : 0);
                if (config.ReadIni("Set", "KeyCode") == "")
                {
                    MessageBox.Show("Something Wrong!\n KeyCode = \"\"");
                    Application.Exit();
                }
                Keys vk = (Keys)Enum.Parse(typeof(Keys), config.ReadIni("Set", "KeyCode")); ;
                switch (hotkeycode)
                {
                    case 0:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.None, vk);
                        break;
                    case 1:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Shift, vk);
                        break;
                    case 10:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Alt, vk);
                        break;
                    case 11:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Shift, vk);
                        break;
                    case 100:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Ctrl, vk);
                        break;
                    case 101:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Shift, vk);
                        break;
                    case 110:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Alt, vk);
                        break;
                    case 111:
                        HotKey.RegisterHotKey(handle, 100, HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Shift, vk);
                        break;
                    default:
                        MessageBox.Show("肯定有什么地方错了，嗯~");
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// 菜单退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuExit(object sender, EventArgs e)
        {
            hi.Close();
            HotKey.UnregisterHotKey(Handle, 100);
            Application.Exit();
        }

        /// <summary>
        /// 托盘图标左击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Console_MouseDown(object sender, EventArgs e)
        {
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Left)
            {
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
            }

        }

        /// <summary>
        /// 托盘图标显示按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Console_Display(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            SetForegroundWindow(this.Handle);
        }

        /// <summary>
        /// 改变窗口关闭按钮的行为
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            e.Cancel = true;
        }

        /// <summary>
        /// 托盘设置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Set_Click(object sender, EventArgs e)
        {
            Set set = Set.getInstance(ini);
            set.Show();
        }

        /// <summary>
        /// 读取ini文件初始化列表
        /// </summary>
        public void InitList()
        {
            String temp = ini.getAllKeyInIni("Command List");
            if(temp == "")
            {
                return;
            }
            String[] keys = temp.Split('\0');
            ListViewItem[] commands = new ListViewItem[keys.Length];
            for(int i=0; i < keys.Length; i++)
            {
                String value = ini.ReadIni("Command List", keys[i]);
                commands[i] = new ListViewItem(new ListViewItem.ListViewSubItem[] {
            new ListViewItem.ListViewSubItem(null, keys[i], System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new ListViewItem.ListViewSubItem(null, value, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))))}, -1);
                commands[i].ToolTipText = value;
            }
            this.commandList.Items.AddRange(commands);
        }

        /// <summary>
        /// 添加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            addCommand ac = addCommand.getInstance();
            ac.FormClosing += Ac_FormClosing;
            ac.Show();
        }

        /// <summary>
        /// 添加命令窗口关闭时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ac_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.commandList.Items.Clear();
                InitList();
            }
            catch(Exception ace)
            {
                MessageBox.Show(ace.Message);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, EventArgs e)
        {
            this.commandList.BeginUpdate();
            foreach(ListViewItem item in this.commandList.CheckedItems)
            {
                ini.IniWriteValue("Command List", item.Text, null);
                item.Remove();
            }
            this.commandList.EndUpdate();
        }

        private void commandView_Load(object sender, EventArgs e)
        {
            this.commandList.Columns[1].Width = this.commandList.ClientSize.Width - this.commandList.Columns[0].Width;
        }

        private void commandView_SizeChanged(object sender, EventArgs e)
        {
            this.commandList.Columns[1].Width = this.commandList.ClientSize.Width - this.commandList.Columns[0].Width;
        }

        /// <summary>
        /// 右键删除单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItem(object sender, EventArgs e)
        {
            this.commandList.BeginUpdate();
            foreach (ListViewItem item in this.commandList.SelectedItems)
            {
                ini.IniWriteValue("Command List", item.Text, null);
                item.Remove();
            }
            this.commandList.EndUpdate();
        }

        /// <summary>
        /// 右击刷新单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadList(object sender, EventArgs e)
        {
            try
            {
                this.commandList.Items.Clear();
                InitList();
            }
            catch (Exception ace)
            {
                MessageBox.Show(ace.Message);
            }
        }

        private void checkAutoRun(object sender, EventArgs e)
        {
            if (startWithBoot.Checked != AutoRun.isAutoRun(appName, Application.ExecutablePath))
            {
                AutoRun.setAutoRun(appName, Application.ExecutablePath, startWithBoot.Checked);
            }
        }
    }
}
