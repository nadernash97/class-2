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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");

       }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnssm1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void btnssm2_Click(object sender, EventArgs e)
        {
            var item = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void btnrbn_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void btnrbi_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }
    }
}
