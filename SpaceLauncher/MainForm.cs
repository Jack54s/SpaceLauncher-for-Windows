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
