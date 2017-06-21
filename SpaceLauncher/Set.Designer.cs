namespace SpaceLauncher
{
    partial class Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set));
            this.startWithBoot = new System.Windows.Forms.CheckBox();
            this.HotKey = new System.Windows.Forms.Label();
            this.HotKeyText = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.addCommand = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.ViewCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startWithBoot
            // 
            this.startWithBoot.AutoSize = true;
            this.startWithBoot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startWithBoot.Location = new System.Drawing.Point(8, 6);
            this.startWithBoot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.startWithBoot.Name = "startWithBoot";
            this.startWithBoot.Size = new System.Drawing.Size(91, 24);
            this.startWithBoot.TabIndex = 3;
            this.startWithBoot.Text = "开机启动";
            this.startWithBoot.UseVisualStyleBackColor = true;
            // 
            // HotKey
            // 
            this.HotKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HotKey.Location = new System.Drawing.Point(98, 7);
            this.HotKey.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.HotKey.Name = "HotKey";
            this.HotKey.Size = new System.Drawing.Size(58, 23);
            this.HotKey.TabIndex = 4;
            this.HotKey.Text = "快捷键:";
            this.HotKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotKeyText
            // 
            this.HotKeyText.Location = new System.Drawing.Point(155, 4);
            this.HotKeyText.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.HotKeyText.Name = "HotKeyText";
            this.HotKeyText.ReadOnly = true;
            this.HotKeyText.Size = new System.Drawing.Size(173, 27);
            this.HotKeyText.TabIndex = 5;
            this.HotKeyText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyText_KeyDown);
            this.HotKeyText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotKeyText_KeyUp);
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Location = new System.Drawing.Point(49, 60);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(57, 27);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "确定";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // addCommand
            // 
            this.addCommand.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addCommand.Location = new System.Drawing.Point(8, 30);
            this.addCommand.Margin = new System.Windows.Forms.Padding(0);
            this.addCommand.Name = "addCommand";
            this.addCommand.Size = new System.Drawing.Size(70, 25);
            this.addCommand.TabIndex = 7;
            this.addCommand.Text = "添加命令";
            this.addCommand.UseVisualStyleBackColor = true;
            this.addCommand.Click += new System.EventHandler(this.addCommand_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(123, 60);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(57, 27);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(228, 60);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(57, 27);
            this.Apply.TabIndex = 9;
            this.Apply.Text = "应用";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ViewCommand
            // 
            this.ViewCommand.Location = new System.Drawing.Point(90, 29);
            this.ViewCommand.Margin = new System.Windows.Forms.Padding(0);
            this.ViewCommand.Name = "ViewCommand";
            this.ViewCommand.Size = new System.Drawing.Size(70, 25);
            this.ViewCommand.TabIndex = 10;
            this.ViewCommand.Text = "管理命令";
            this.ViewCommand.UseVisualStyleBackColor = true;
            this.ViewCommand.Click += new System.EventHandler(this.ViewCommand_Click);
            // 
            // Set
            // 
            this.AcceptButton = this.Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 88);
            this.ControlBox = false;
            this.Controls.Add(this.ViewCommand);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.addCommand);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.HotKeyText);
            this.Controls.Add(this.HotKey);
            this.Controls.Add(this.startWithBoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Set";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "真知奥术永世传承";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startWithBoot;
        private System.Windows.Forms.Label HotKey;
        private System.Windows.Forms.TextBox HotKeyText;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button addCommand;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button ViewCommand;
    }
}