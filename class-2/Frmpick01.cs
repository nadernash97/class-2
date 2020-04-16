using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace class_2
{
    public partial class Frmpick01 : Form
    {
        Assembly _assembly;
        Stream _ImageStream;
        public Frmpick01()
        {
            InitializeComponent();
            Pictry.SizeMode = PictureBoxSizeMode.StretchImage;
            Pictry1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void BtnLoadimg_Click(object sender, EventArgs e)
        {
            try
            {
                Pictry.Image = Image.FromFile("C:\\Users\\nader\\Desktop\\images\\dsfdf.jpg");

            }
            catch
            {

                MessageBox.Show("The image is not there");
            }
        }

        private void BtnimagefResource_Click(object sender, EventArgs e)
        {
            Pictry1.Image = Image.FromStream(_ImageStream);
        }

        private void Frmpick01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _ImageStream = _assembly.GetManifestResourceStream("class_2.res.Cr.jpg");
        }
    }
}
