namespace SpaceLauncher
{
    partial class addCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCommand));
            this.Command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProgram = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.OpenFileDialog();
            this.resourceType = new System.Windows.Forms.ComboBox();
            this.programName = new System.Windows.Forms.Label();
            this.args = new System.Windows.Forms.TextBox();
            this.argsLable = new System.Windows.Forms.Label();
            this.resource = new System.Windows.Forms.Label();
            this.resourceFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folder = new System.Windows.Forms.Label();
            this.webSite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Command.Location = new System.Drawing.Point(76, 6);
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            this.Command.Size = new System.Drawing.Size(117, 27);
            this.Command.TabIndex = 0;
            this.Command.Text = "Space+";
            this.Command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Command_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "启动指令:";
            // 
            // addProgram
            // 
            this.addProgram.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addProgram.Location = new System.Drawing.Point(146, 146);
            this.addProgram.Margin = new System.Windows.Forms.Padding(0);
            this.addProgram.Name = "addProgram";
            this.addProgram.Size = new System.Drawing.Size(65, 28);
            this.addProgram.TabIndex = 3;
            this.addProgram.Text = "添加";
            this.addProgram.UseVisualStyleBackColor = true;
            this.addProgram.Click += new System.EventHandler(this.addProgram_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoEllipsis = true;
            this.selectLabel.AutoSize = true;
            this.selectLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectLabel.Location = new System.Drawing.Point(12, 36);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(39, 20);
            this.selectLabel.TabIndex = 5;
            this.selectLabel.Text = "选择";
            // 
            // resourceType
            // 
            this.resourceType.DropDownHeight = 72;
            this.resourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceType.DropDownWidth = 42;
            this.resourceType.FormattingEnabled = true;
            this.resourceType.IntegralHeight = false;
            this.resourceType.Items.AddRange(new object[] {
            "文件",
            "文件夹",
            "URL"});
            this.resourceType.Location = new System.Drawing.Point(40, 32);
            this.resourceType.Margin = new System.Windows.Forms.Padding(0);
            this.resourceType.Name = "resourceType";
            this.resourceType.Size = new System.Drawing.Size(60, 28);
            this.resourceType.TabIndex = 6;
            this.resourceType.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // programName
            // 
            this.programName.AutoEllipsis = true;
            this.programName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programName.Location = new System.Drawing.Point(16, 60);
            this.programName.Margin = new System.Windows.Forms.Padding(0);
            this.programName.Name = "programName";
            this.programName.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.programName.Size = new System.Drawing.Size(329, 24);
            this.programName.TabIndex = 7;
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Click += new System.EventHandler(this.selectProgram_Click);
            // 
            // args
            // 
            this.args.Location = new System.Drawing.Point(76, 87);
            this.args.Margin = new System.Windows.Forms.Padding(0);
            this.args.Name = "args";
            this.args.Size = new System.Drawing.Size(100, 27);
            this.args.TabIndex = 8;
            // 
            // argsLable
            // 
            this.argsLable.AutoSize = true;
            this.argsLable.Location = new System.Drawing.Point(21, 90);
            this.argsLable.Name = "argsLable";
            this.argsLable.Size = new System.Drawing.Size(51, 20);
            this.argsLable.TabIndex = 9;
            this.argsLable.Text = "参  数:";
            // 
            // resource
            // 
            this.resource.AutoEllipsis = true;
            this.resource.AutoSize = true;
            this.resource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resource.Location = new System.Drawing.Point(14, 114);
            this.resource.Margin = new System.Windows.Forms.Padding(0);
            this.resource.Name = "resource";
            this.resource.Padding = new System.Windows.Forms.Padding(2);
            this.resource.Size = new System.Drawing.Size(75, 26);
            this.resource.TabIndex = 10;
            this.resource.Text = "选择文件";
            this.resource.Click += new System.EventHandler(this.selectResource);
            // 
            // folder
            // 
            this.folder.AutoEllipsis = true;
            this.folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folder.Location = new System.Drawing.Point(16, 60);
            this.folder.Name = "folder";
            this.folder.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.folder.Size = new System.Drawing.Size(329, 24);
            this.folder.TabIndex = 11;
            this.folder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.folder.Click += new System.EventHandler(this.openFolderDialog);
            // 
            // webSite
            // 
            this.webSite.Location = new System.Drawing.Point(16, 60);
            this.webSite.Name = "webSite";
            this.webSite.Size = new System.Drawing.Size(329, 27);
            this.webSite.TabIndex = 12;
            // 
            // addCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 183);
            this.Controls.Add(this.webSite);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.resource);
            this.Controls.Add(this.argsLable);
            this.Controls.Add(this.args);
            this.Controls.Add(this.programName);
            this.Controls.Add(this.resourceType);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.addProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Command);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addCommand";
            this.Text = "真知奥秘，唯我知晓！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.OpenFileDialog program;
        private System.Windows.Forms.ComboBox resourceType;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.TextBox args;
        private System.Windows.Forms.Label argsLable;
        private System.Windows.Forms.Label resource;
        private System.Windows.Forms.OpenFileDialog resourceFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label folder;
        private System.Windows.Forms.TextBox webSite;
    }
}