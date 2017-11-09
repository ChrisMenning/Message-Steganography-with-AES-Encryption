using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public partial class PasswordInputDialog : Form
    {
        FormMain main;

        public PasswordInputDialog(FormMain mainform)
        {
            this.main = mainform;
            InitializeComponent();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.main.Password = textBoxInput.Text;
            this.Close();
        }
    }
}
