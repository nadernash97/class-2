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
    public partial class frmrandomcombo : Form
    {
        Random c = new Random();

        public frmrandomcombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            cmbrand.ResetText();
            cmbrand.Items.Clear();
            for (int j = 1; j <= c.Next(1, 50); j++)
            {
                cmbrand.Items.Add(c.Next(100, 999));
            }
        }
    }
}
