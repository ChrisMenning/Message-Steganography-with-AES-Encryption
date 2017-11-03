using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steganography_with_AES_Encryption.Classes;

namespace Steganography_with_AES_Encryption
{
    public partial class frmFractalGeneratorTestForm : Form
    {
        public frmFractalGeneratorTestForm()
        {
            InitializeComponent();
        }

        private void btnGenerateFractal_Click(object sender, EventArgs e)
        {
            FractalGenerator generator = new FractalGenerator();

            Bitmap pic = generator.generateFractal(1000, 1000, 34, 23, 12, 13);

            ptbTest.Image = pic;
            pic.Save("C:\\Users\\nate\\Downloads\\test.png");
        }
    }
}
