//----------------------------------------------------------------------------------
// <copyright file="PasswordInputDialog.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The PasswordInputDialog form class. Extends the Form class.
    /// </summary>
    public partial class PasswordInputDialog : Form
    {
        /// <summary>
        /// A reference to the main form.
        /// </summary>
        private FormMain main;

        /// <summary>
        /// Initializes a new instance of the PasswordInputDialog object. 
        /// </summary>
        /// <param name="mainform">A reference to the main form.</param>
        public PasswordInputDialog(FormMain mainform)
        {
            this.InitializeComponent();

            this.CenterToParent();
            this.main = mainform;
            this.AcceptButton = this.buttonOK;
        }

        /// <summary>
        /// The click event for the OK button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == null)
            {
                MessageBox.Show("Password can not be blank.");
            }
            else if (textBoxInput.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.");
            }
            else
            {
                this.main.Password = textBoxInput.Text;
                this.Close();
            }
        }
    }
}
