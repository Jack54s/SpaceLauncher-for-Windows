namespace SpaceLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.command = new System.Windows.Forms.TextBox();
            this.Esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // command
            // 
            this.command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.command.Location = new System.Drawing.Point(6, 4);
            this.command.Margin = new System.Windows.Forms.Padding(10);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(224, 27);
            this.command.TabIndex = 0;
            this.command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.command_Press);
            // 
            // Esc
            // 
            this.Esc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Esc.Location = new System.Drawing.Point(180, 4);
            this.Esc.Name = "Esc";
            this.Esc.Size = new System.Drawing.Size(0, 0);
            this.Esc.TabIndex = 1;
            this.Esc.Text = "关闭";
            this.Esc.UseVisualStyleBackColor = true;
            this.Esc.Click += new System.EventHandler(this.Esc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.Esc;
            this.ClientSize = new System.Drawing.Size(236, 35);
            this.Controls.Add(this.Esc);
            this.Controls.Add(this.command);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceLauncher";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button Esc;
    }
}

