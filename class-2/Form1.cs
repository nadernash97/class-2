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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {

        }


        int i = 1;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
                while (i <= 3)
                {
                    if (TxtUser.Text == "nader" && TxtPassword.Text == "12345")
                    {
                        MessageBox.Show("Login succesfull");
                        break;

                    }
                    else if (TxtUser.Text == "nader")
                    {


                        MessageBox.Show("Incorrect password");
                        i = i + 1;

                    }
                    else if (TxtPassword.Text == "12345")
                    {
                        MessageBox.Show("Incorrect Username");

                        i = i + 1;
                    }
                    else
                    {
                        MessageBox.Show("incoreect information");
                        i = i + 1;
                    }
                }
            i = 0;
            
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        
        private void BtnCombo_Click_1(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            Frmcheck frm = new Frmcheck();
            frm.ShowDialog();

        }

        private void BtnGeneraterand_Click(object sender, EventArgs e)
        {
            frmrandomcombo frm = new frmrandomcombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            Frmpick01 frm = new Frmpick01();
            frm.ShowDialog();

        }
    }
}

