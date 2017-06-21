namespace SpaceLauncher
{
    partial class HintDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HintDialog));
            this.hint = new System.Windows.Forms.Label();
            this.closeHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hint
            // 
            this.hint.AutoEllipsis = true;
            this.hint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hint.Location = new System.Drawing.Point(50, 30);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(207, 76);
            this.hint.TabIndex = 0;
            this.hint.Text = "hint";
            this.hint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeHint
            // 
            this.closeHint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeHint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeHint.Location = new System.Drawing.Point(108, 75);
            this.closeHint.Name = "closeHint";
            this.closeHint.Size = new System.Drawing.Size(75, 28);
            this.closeHint.TabIndex = 1;
            this.closeHint.Text = "关闭";
            this.closeHint.UseVisualStyleBackColor = true;
            this.closeHint.Click += new System.EventHandler(this.closeHint_Click);
            // 
            // HintDialog
            // 
            this.AcceptButton = this.closeHint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.closeHint;
            this.ClientSize = new System.Drawing.Size(307, 106);
            this.Controls.Add(this.closeHint);
            this.Controls.Add(this.hint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HintDialog";
            this.Padding = new System.Windows.Forms.Padding(50, 30, 50, 0);
            this.Text = "苍天愚弄我";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button closeHint;
    }
}