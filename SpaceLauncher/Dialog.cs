using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SpaceLauncher
{
    public partial class addCommand : Form
    {
        HintDialog hi;  //提示框
        private static addCommand _instance = null;
        private String keyCode = "";

        private addCommand()
        {
            InitializeComponent();
            this.resourceType.SelectedIndex = this.resourceType.Items.IndexOf("文件");
            Command.Select(Command.Text.Length, 0);
            hi = new HintDialog();
        }

        public static addCommand getInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new addCommand();
            }
            return _instance;
        }

        /// <summary>
        /// 选择程序label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectProgram_Click(object sender, EventArgs e)
        {
            program.ShowDialog();
            String fileName = program.FileName;
            if (System.IO.File.Exists(fileName))
            {
                programName.Text = fileName;
            }
            if (fileName != "")
            {
                programName.BorderStyle = BorderStyle.None;
                programName.AutoSize = false;
            }
        }

        /// <summary>
        /// 添加命令按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProgram_Click(object sender, EventArgs e)
        {
            String command;
            command = Command.Text.Substring(Command.Text.LastIndexOf('+') + 1);
            LoadConfig writeConfig;
            String rule = @"[A-Z0-9,./;'-=\\\[]|]";
            Match m = Regex.Match(command, rule);
            if(!m.Success)
            {
                MessageBox.Show("Space+后面的字符必须为A-Z0-9,./;'[]\\字符中的一个");
                //hi.Show();
                return;
            }

            switch (resourceType.SelectedIndex)
            {
                case 0:
                    String fileName = program.FileName;
                    if (command.Trim() == "")
                    {
                        hi.setHint("请输入指令！");
                        hi.Show();
                        return;
                    }
                    if (fileName == "")
                    {
                        hi.setHint("请选择程序！");
                        hi.Show();
                        return;
                    }
                    writeConfig = new LoadConfig(Application.StartupPath + @"\command.ini");
                    if (args.Text.Trim() != "")
                    {
                        fileName += "?" + args.Text.Trim();
                    }
                    if (resource.Text != "选择文件" && resource.Text.Trim() != "")
                    {
                        if (args.Text.Trim() == "")
                        {
                            fileName += "?" + resource.Text.Trim();
                        }
                        else
                        {
                            fileName += " " + resource.Text.Trim();
                        }
                    }
                    if (writeConfig.ReadIni("Command List", command) != "")
                    {
                        DialogResult dr = MessageBox.Show(command + "热键已存在，是否覆盖？", "咒语记混了吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            writeConfig.IniWriteValue("Command List", command.Trim(), fileName);
                        }
                        else if (dr == DialogResult.Cancel)
                        {
                        }
                    }
                    else
                    {
                        writeConfig.IniWriteValue("Command List", command.Trim(), fileName);
                    }
                    hi.Close();
                    Close();
                    break;
                case 1:
                    String folderName = "explorer.exe?" + folder.Text;
                    if (command.Trim() == "")
                    {
                        hi.setHint("请输入指令！");
                        hi.Show();
                        return;
                    }
                    if (folder.Text.Trim() == "")
                    {
                        hi.setHint("请选择文件夹！");
                        hi.Show();
                        return;
                    }
                    writeConfig = new LoadConfig(Application.StartupPath + @"\command.ini");
                    if (writeConfig.ReadIni("Command List", command) != "")
                    {
                        DialogResult dr = MessageBox.Show(command + "热键已存在，是否覆盖？", "咒语记混了吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            writeConfig.IniWriteValue("Command List", command.Trim(), folderName);
                        }
                        else if (dr == DialogResult.Cancel)
                        {
                        }
                    }
                    else
                    {
                        writeConfig.IniWriteValue("Command List", command.Trim(), folderName);
                    }
                    hi.Close();
                    Close();
                    break;
                case 2:
                    String url = webSite.Text;
                    if (url.Trim() == "")
                    {
                        hi.setHint("请输入URL！");
                        hi.Show();
                        return;
                    }
                    if (!url.Contains(":"))
                    {
                        MessageBox.Show(url + "URL格式错误！请加上协议头。");
                        return;
                    }
                    String site = "explorer.exe?" + url;
                    if (command.Trim() == "")
                    {
                        hi.setHint("请输入指令！");
                        hi.Show();
                        return;
                    }
                    
                    writeConfig = new LoadConfig(Application.StartupPath + @"\command.ini");
                    if (writeConfig.ReadIni("Command List", command) != "")
                    {
                        DialogResult dr = MessageBox.Show(command + "热键已存在，是否覆盖？", "咒语记混了吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            writeConfig.IniWriteValue("Command List", command.Trim(), site);
                        }
                        else if (dr == DialogResult.Cancel)
                        {
                        }
                    }
                    else
                    {
                        writeConfig.IniWriteValue("Command List", command.Trim(), site);
                    }
                    hi.Close();
                    Close();
                    break;
                default:
                    MessageBox.Show("请选择类型！");
                    break;
            }
        }

        /// <summary>
        /// 选择文件作为参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectResource(object sender, EventArgs e)
        {
            resourceFile.ShowDialog();
            String fileName = resourceFile.FileName;
            if (System.IO.File.Exists(fileName))
            {
                resource.Text = fileName;
            }
            if (fileName != "")
            {
                resource.BorderStyle = BorderStyle.None;
                resource.AutoSize = false;
                resource.Size = new System.Drawing.Size(329, resource.Height);
            }
        }

        /// <summary>
        /// 打开文件夹选择框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFolderDialog(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            String folderName = folderBrowserDialog1.SelectedPath;
            if (folderName != "")
            {
                folder.Text = folderName;
                folder.BorderStyle = BorderStyle.None;
            }
        }

        /// <summary>
        /// 多选框发生变化时，界面相应变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedItem_Changed(object sender, EventArgs e)
        {
            switch (resourceType.SelectedIndex)
            {
                case 0:
                    Height = 230;
                    folder.Visible = false;
                    webSite.Visible = false;
                    programName.Visible = true;
                    argsLable.Visible = true;
                    args.Visible = true;
                    resource.Visible = true;
                    break;
                case 1:
                    Height = 167;
                    folder.Visible = true;
                    webSite.Visible = false;
                    programName.Visible = false;
                    argsLable.Visible = false;
                    args.Visible = false;
                    resource.Visible = false;
                    break;
                case 2:
                    Height = 167;
                    folder.Visible = false;
                    webSite.Visible = true;
                    programName.Visible = false;
                    argsLable.Visible = false;
                    args.Visible = false;
                    resource.Visible = false;
                    break;

            }
        }
        /// <summary>
        /// 设置热键时按下键盘的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Command_KeyPress(object sender, KeyPressEventArgs e)
        {
            Command.Select(Command.Text.Length, 0);
            if((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122)
            {
                e.KeyChar = (char)((int)e.KeyChar - 32);
            }
            keyCode = e.KeyChar.ToString();
            if (keyCode == "")
            {
                this.Command.Text = "Space+";
                Command.Select(Command.Text.Length, 0);
            }
            else if (e.KeyChar == '\b')
            {
                this.Command.Text = "Space+";
                Command.Select(Command.Text.Length, 0);
            }
            else
            {
                this.Command.Text = "Space+" + keyCode;
                Command.Select(Command.Text.Length, 0);
            }
        }
    }
}
