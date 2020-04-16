using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RDORed_CheckedChanged(object sender, EventArgs e)
        {
            if (RDORed.Checked == true)

            {
                RDORed.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
                RDORed.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RDOGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOGreen.Checked == true)

            {
                RDOGreen.ForeColor = Color.FromName("green");
            }
            else
                RDOGreen.ForeColor = Color.FromName("black");
        }

        private void RDOBlue_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (RDOBlue.Checked == true)
                    RDOBlue.ForeColor = Color.FromName("Blue");
                else
                    RDOBlue.ForeColor = Color.FromName("Black");
            }
        }

        private void RDOYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOYellow.Checked == true)
                RDOYellow.ForeColor = Color.FromName("Yellow");
            else
                RDOYellow.ForeColor = Color.FromName("Black");
        }
    }
    }
