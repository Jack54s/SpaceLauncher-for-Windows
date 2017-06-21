using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceLauncher
{
    public partial class HintDialog : Form
    {
        public HintDialog()
        {
            InitializeComponent();
        }

        public void setHint(String text)
        {
            hint.Text = text;
        }

        private void closeHint_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
