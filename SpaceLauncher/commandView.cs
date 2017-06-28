﻿using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SpaceLauncher
{
    public partial class commandView : Form
    {
        LoadConfig ini;
        HintDialog hi;
        System.Timers.Timer delay;
        System.Timers.Timer t;
        String appName = "SpaceLauncher";
        private KeyBoardHook _keyboardHook = new KeyBoardHook();
        //判断空格是否按下
        private static bool flag = false;
        private static bool istyping = false;
        private static bool RunningFullScreenApp;
        private static bool f = false;
        private DateTime lasttime = DateTime.Now;
        private int uCallBackMsg;

        [DllImport("user32")]
        static extern int SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32")]
        static extern void keybd_event(byte bvk, byte scan, int dwflags, int dwextrainfo);

        public commandView()
        {
            InitializeComponent();
            ini = new LoadConfig(Application.StartupPath + @"\command.ini");
            hi = new HintDialog();
            InitList();
            if (AutoRun.isAutoRun(appName, Application.ExecutablePath))
            {
                startWithBoot.Checked = true;
            }
            else
            {
                startWithBoot.Checked = false;
            }
            _keyboardHook.InstallHook(KeyPress);
            delay = new System.Timers.Timer(200);
            delay.Elapsed += new System.Timers.ElapsedEventHandler(tick);
            delay.AutoReset = false;
            t = new System.Timers.Timer(800);
            t.Elapsed += new System.Timers.ElapsedEventHandler(typing);
            t.AutoReset = false;
        }

        public void typing(object source, System.Timers.ElapsedEventArgs e)
        {
            istyping = false;
        }

        public void tick(object source, System.Timers.ElapsedEventArgs e)
        {
            flag = true;
        }

        /// <summary>
        /// 客户端键盘捕捉事件
        /// </summary>
        /// <param name="hookStruct">由Hook程序发送的按键信息</param>
        /// <param name="handle">是否拦截</param>
        public void KeyPress(KeyBoardHook.HookStruct hookStruct, out bool handle)
        {
            handle = false;
            if (RunningFullScreenApp)
            {
                return;
            }
            if (hookStruct.vkCode != (int)Keys.Space && flag == false)
            {
                istyping = true;
                t.Start();
                delay.Stop();
            }
            if (istyping == false && (flag == true || (hookStruct.vkCode == (int)(Keys.Space) && hookStruct.flags == 0)))
            {
                if(hookStruct.vkCode == (int)Keys.Space && hookStruct.flags == 0)
                {
                    delay.Enabled = true;
                    delay.Start();
                }
                if (hookStruct.vkCode == (int)(Keys.A) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show(RunningFullScreenApp.ToString());
                }
                if (hookStruct.vkCode == (int)(Keys.B) && hookStruct.flags == 0)
                {
                    handle = true;
                }
                if (hookStruct.vkCode == (int)(Keys.C) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.D) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.E) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.F) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.G) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.H) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.I) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.J) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.K) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.L) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.M) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.N) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.O) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
                if (hookStruct.vkCode == (int)(Keys.P) && hookStruct.flags == 0)
                {
                    handle = true;
                    MessageBox.Show("OK");
                }
            }
            if (hookStruct.vkCode == (int)(Keys.Space) && hookStruct.flags == 128)
            {
                handle = false;
                delay.Stop();
                flag = false;
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
            HotKey.UnregisterHotKey(Handle, 101);
            //this.RegisterAppBar(true);
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
                this.Show();
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
            this.Show();
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
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
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
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;
            this.RegisterAppBar(false);
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

        /// <summary>
        /// Windows消息监听，监视是否按下热键
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;//如果m.Msg的值为0x0312那么表示用户按下了热键
            const int WM_QUERYENDSESSION = 0X0011;
            if (m.Msg == uCallBackMsg)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)ABNotify.ABN_FULLSCREENAPP:
                        {
                            if ((int)m.LParam == 1)
                                RunningFullScreenApp = true;
                            else
                                RunningFullScreenApp = false;
                            break;
                        }
                    default:
                        break;
                }
            }
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToString())
                    {
                        case "101":
                            MessageBox.Show("Hll");
                            break;
                        default: break;
                    }
                    break;
                case WM_QUERYENDSESSION:
                    Application.Exit();
                    break;
                default: break;
            }
            base.WndProc(ref m);
        }

        private void RegisterAppBar(bool registered)
        {
            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;
            if (!registered)
            {
                //register  
                uCallBackMsg = CheckFullScreenAPIWrapper.RegisterWindowMessage("APPBARMSG_CSDN_HELPER");
                abd.uCallbackMessage = uCallBackMsg;
                uint ret = CheckFullScreenAPIWrapper.SHAppBarMessage((int)ABMsg.ABM_NEW, ref abd);
            }
            else
            {
                CheckFullScreenAPIWrapper.SHAppBarMessage((int)ABMsg.ABM_REMOVE, ref abd);
            }
        }
    }
}
