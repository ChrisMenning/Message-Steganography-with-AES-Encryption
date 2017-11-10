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
        private string messageText;

        public PleaseWait(string input)
        {
            InitializeComponent();
            this.messageText = input;
            labelWaitMessage.Text = messageText;
            this.Update();
            this.CenterToParent();
        }

        /// <summary>
        /// Gets or sets the messageText property.
        /// </summary>
        public string MessageText
        {
            get
            {
                return messageText;
            }

            set
            {
                messageText = value;
            }
        }

        private void labelWaitMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
