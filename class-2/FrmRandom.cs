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
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void FrmRandom_Load(object sender, EventArgs e)
        {
            
        }

        private void btngeneraterandom_Click(object sender, EventArgs e)
        {
            btngeneraterandom.Text = Convert.ToString(y.Next(1, 100));
        }
    }
}
