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
    public partial class Frmcheck : Form
    {
        public Frmcheck()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if (ChkDount.Checked == true)
            {
                msg = msg + "" + ChkDount.Text;
            }
            if (ChkBrownie.Checked == true)
            {
                msg = msg + "" + ChkBrownie.Text;
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + "Ordered");
            }
            else
            {
                MessageBox.Show("Nothing ordered,sir/MmE");
            }
        }
    }
}
