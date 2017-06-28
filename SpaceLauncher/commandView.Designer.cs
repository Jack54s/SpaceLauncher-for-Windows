namespace SpaceLauncher
{
    partial class commandView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commandView));
            this.LineHeight = new System.Windows.Forms.ImageList(this.components);
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.ListContainer = new System.Windows.Forms.TableLayoutPanel();
            this.commandList = new System.Windows.Forms.ListView();
            this.command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Console = new System.Windows.Forms.NotifyIcon(this.components);
            this.startWithBoot = new System.Windows.Forms.CheckBox();
            this.ListContainer.SuspendLayout();
            this.RightClickMenu.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineHeight
            // 
            this.LineHeight.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.LineHeight.ImageSize = new System.Drawing.Size(3, 16);
            this.LineHeight.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(23, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(72, 32);
            this.Add.TabIndex = 1;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(118, 22);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(72, 32);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "删除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ListContainer
            // 
            this.ListContainer.ColumnCount = 1;
            this.ListContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ListContainer.Controls.Add(this.commandList, 0, 0);
            this.ListContainer.Location = new System.Drawing.Point(0, 71);
            this.ListContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.ListContainer.Name = "ListContainer";
            this.ListContainer.RowCount = 1;
            this.ListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ListContainer.Size = new System.Drawing.Size(511, 258);
            this.ListContainer.TabIndex = 3;
            // 
            // commandList
            // 
            this.commandList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.commandList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.commandList.CheckBoxes = true;
            this.commandList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.command,
            this.file});
            this.commandList.ContextMenuStrip = this.RightClickMenu;
            this.commandList.Cursor = System.Windows.Forms.Cursors.Default;
            this.commandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commandList.FullRowSelect = true;
            this.commandList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.commandList.Location = new System.Drawing.Point(10, 3);
            this.commandList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.commandList.Name = "commandList";
            this.commandList.ShowItemToolTips = true;
            this.commandList.Size = new System.Drawing.Size(491, 252);
            this.commandList.SmallImageList = this.LineHeight;
            this.commandList.TabIndex = 1;
            this.commandList.UseCompatibleStateImageBehavior = false;
            this.commandList.View = System.Windows.Forms.View.Details;
            // 
            // command
            // 
            this.command.Text = "     指令";
            this.command.Width = 100;
            // 
            // file
            // 
            this.file.Text = "  文件";
            this.file.Width = 245;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(109, 52);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.RemoveItem);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.ReloadList);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(109, 52);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.Console_Display);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.MenuExit);
            // 
            // Console
            // 
            this.Console.ContextMenuStrip = this.Menu;
            this.Console.Icon = ((System.Drawing.Icon)(resources.GetObject("Console.Icon")));
            this.Console.Text = "SpaceLauncher";
            this.Console.Visible = true;
            this.Console.Click += new System.EventHandler(this.Console_MouseDown);
            // 
            // startWithBoot
            // 
            this.startWithBoot.AutoSize = true;
            this.startWithBoot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startWithBoot.Location = new System.Drawing.Point(23, 336);
            this.startWithBoot.Margin = new System.Windows.Forms.Padding(0);
            this.startWithBoot.Name = "startWithBoot";
            this.startWithBoot.Size = new System.Drawing.Size(91, 24);
            this.startWithBoot.TabIndex = 4;
            this.startWithBoot.Text = "开机启动";
            this.startWithBoot.UseVisualStyleBackColor = true;
            this.startWithBoot.CheckedChanged += new System.EventHandler(this.checkAutoRun);
            // 
            // commandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 364);
            this.Controls.Add(this.startWithBoot);
            this.Controls.Add(this.ListContainer);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 378);
            this.Name = "commandView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceLauncher";
            this.Load += new System.EventHandler(this.commandView_Load);
            this.SizeChanged += new System.EventHandler(this.commandView_SizeChanged);
            this.ListContainer.ResumeLayout(false);
            this.RightClickMenu.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.ImageList LineHeight;
        private System.Windows.Forms.TableLayoutPanel ListContainer;
        private System.Windows.Forms.ListView commandList;
        private System.Windows.Forms.ColumnHeader command;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Console;
        private System.Windows.Forms.CheckBox startWithBoot;
    }
}