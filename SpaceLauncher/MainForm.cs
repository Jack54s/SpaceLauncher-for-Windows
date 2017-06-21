using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SpaceLauncher
{
    public partial class MainForm : Form
    {
        LoadConfig config;
        HintDialog hi;  //提示框

        [DllImport("user32")]
        static extern int SetForegroundWindow(IntPtr hwnd);

        public MainForm()
        {
            InitializeComponent();
            config = new LoadConfig(Application.StartupPath + @"\command.ini");
            hi = new HintDialog();
            SetHotkey(config, Handle);
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
            MouseEventArgs Mouse_e = (MouseEventArgs) e;
            if (Mouse_e.Button == MouseButtons.Left)
            {
                this.Show();
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
            Set set = Set.getInstance(config);
            set.Show();
        }

        /// <summary>
        /// 主窗口textBox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void command_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                String comtxt = command.Text.Trim();
                String fileName = config.ReadIni("Command List", comtxt);

                if (fileName != "")
                {
                    String[] progargs = fileName.Split('?');
                    String program = progargs[0];
                    
                    if (progargs.Length < 2)
                    {
                        if (File.Exists(program))
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(program);
                            }
                            catch (Exception pse)
                            {
                                MessageBox.Show(pse.Message);
                            }
                        }
                        else
                        {
                            hi.setHint("文件“" + program + "”不存在！");
                            hi.Show();
                        }
                    }
                    else
                    {
                        if (Directory.Exists(progargs[1].Trim()) || progargs[1].Contains(":"))
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(program, progargs[1].Trim());
                            }
                            catch (Exception pse)
                            {
                                MessageBox.Show(pse.Message);
                            }
                        }
                        else
                        {
                            hi.setHint("路径" + progargs[1].Trim() + "不存在");
                            hi.Show();
                        }
                    }
                }
                else
                {
                    hi.setHint("记忆有误！");
                    hi.Show();
                }
                command.Text = "";
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
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToString())
                    {
                        case "100":
                            if(this.Visible == false)
                            {
                                this.Console_Display(new object(), new EventArgs());
                            }
                            else
                            {
                                this.Close();
                            }
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

        /// <summary>
        /// 按下Esc键的效果，设置了CancelButton并将Button.Size(0,0)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
