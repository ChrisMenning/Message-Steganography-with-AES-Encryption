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
            

            try
            {
                using (StreamReader reader = new StreamReader())
                {
                    String message = reader.ReadToEnd();
                    rtbAboutSection.Text = message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem opening the READEME.md file\nError Message: " + ex.Message);
            }
        }
    }
}
