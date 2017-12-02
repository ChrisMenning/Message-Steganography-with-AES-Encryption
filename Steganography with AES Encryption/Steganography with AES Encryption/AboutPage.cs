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
using Steganography_with_AES_Encryption.Properties;

namespace Steganography_with_AES_Encryption
{
    public partial class frmAboutPage : Form
    {
        public frmAboutPage()
        {
            InitializeComponent();
        }

        private void frmAboutPage_Load(object sender, EventArgs e)
        {

            rtbAboutSection.Text = System.Text.Encoding.Default.GetString(Properties.Resources.README);

        }

        private void btnCloseAboutPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
