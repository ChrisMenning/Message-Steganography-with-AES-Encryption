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
    public partial class PleaseWait : Form
    {
        
        public PleaseWait(string input)
        {
            InitializeComponent();

            labelWaitMessage.Text = input;

            this.CenterToParent();
        }

        private void labelWaitMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
