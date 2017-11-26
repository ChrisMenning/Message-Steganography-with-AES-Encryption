//----------------------------------------------------------------------------------
// <copyright file="AdvancedOptions.cs" company="Legendary Lichens">
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
    /// The AdvancedOptions form class. Extends the Form class.
    /// </summary>
    public partial class AdvancedOptions : Form
    {
        /// <summary>
        /// A reference to the main form.
        /// </summary>
        private FormMain main;

        /// <summary>
        /// Initializes a new instance of the AdvancedOptions class.
        /// </summary>
        /// <param name="main">A reference to the main form.</param>
        public AdvancedOptions(FormMain main)
        {
            this.main = main;
            this.InitializeComponent();
        }

        /// <summary>
        /// The click event for the Restore Defaults button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ButtonRestoreDefaults_Click(object sender, EventArgs e)
        {
            radioButton128.Checked = true;
            this.Update();
        }

        /// <summary>
        /// The "Remember Settings" checkbox.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CheckBoxRememberSettings_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Persistence
        }

        /// <summary>
        /// The click event for the OK button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (radioButton128.Checked)
            {
                this.main.AesBlockSize = 16;
            }
            else if (radioButton192.Checked)
            {
                this.main.AesBlockSize = 24;
            }
            else if (radioButton256.Checked)
            {
                this.main.AesBlockSize = 32;
            }

            Console.WriteLine("Setting AES encryption to " + this.main.AesBlockSize);
            this.Close();
        }

        /// <summary>
        /// The click event for the Cancel button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}