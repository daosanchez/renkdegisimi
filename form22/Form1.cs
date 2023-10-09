using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(cbBlue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void cbPurple_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPurple.Checked == true)
            {
                this.BackColor = Color.Purple;
            }
        }

        private void cbBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBrown.Checked == true)
            {
                this.BackColor = Color.Brown;
            }
        }

        private void cbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRed.Checked == true)
            {
                this.BackColor = Color.Red;
            }
        }

        private void cbYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYellow.Checked == true)
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}
