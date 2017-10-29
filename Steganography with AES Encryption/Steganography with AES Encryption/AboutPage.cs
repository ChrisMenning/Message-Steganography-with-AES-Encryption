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
            

            string path = Directory.GetCurrentDirectory();
            for(int i = 1; i <= 2; i++)
            {
                path = Directory.GetParent(path).ToString();
            }
            
            path += "\\Resources\\README.md";        

            try
            {
                using (StreamReader reader = new StreamReader(path))
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
