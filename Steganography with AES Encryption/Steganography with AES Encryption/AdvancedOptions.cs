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
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The AdvancedOptions form class. Extends the Form class.
    /// </summary>
    public partial class FormAdvancedOptions : Form
    {
        /// <summary>
        /// A reference to the main form.
        /// </summary>
        private FormMain main;

        /// <summary>
        /// A string for storing the selected user preference(s).
        /// </summary>
        private string pref;

        /// <summary>
        /// The file path for saving the preference(s).
        /// </summary>
        private string filePath;

        /// <summary>
        /// Initializes a new instance of the AdvancedOptions class.
        /// </summary>
        /// <param name="main">A reference to the main form.</param>
        public FormAdvancedOptions(FormMain main)
        { 
            this.InitializeComponent();
            this.CenterToParent();
            this.AcceptButton = this.buttonOK;
            this.main = main;
            this.filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AES settings.txt";

            if (File.Exists(this.filePath))
            {
                this.pref = System.IO.File.ReadAllText(this.filePath);

                if (this.pref == "16")
                {
                    radioButton128.Checked = true;
                }
                else if (this.pref == "24")
                {
                    radioButton192.Checked = true;
                }
                else if (this.pref == "32")
                {
                    radioButton256.Checked = true;
                }
            }
        }

        /// <summary>
        /// Saves the preferences.
        /// </summary>
        private void SavePreferences()
        {
            File.Delete(this.filePath);
            this.pref = this.main.AesKeySize.ToString();
            System.IO.File.WriteAllText(this.filePath, this.pref);
            File.SetAttributes(this.filePath, FileAttributes.Hidden);
        }

        /// <summary>
        /// The click event for the Restore Defaults button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ButtonRestoreDefaults_Click(object sender, EventArgs e)
        {
            radioButton128.Checked = true;
            this.main.AesKeySize = 16;
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\showWarning.txt");
            File.Delete(this.filePath);
            this.Update();   
        }

        /// <summary>
        /// The "Remember Settings" checkbox.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CheckBoxRememberSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberSettings.Checked == false)
            {
                // Delete the preferences file.
                File.Delete(this.filePath);
            }
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
                this.main.AesKeySize = 16;
            }
            else if (radioButton192.Checked)
            {
                this.main.AesKeySize = 24;
            }
            else if (radioButton256.Checked)
            {
                this.main.AesKeySize = 32;
            }

            Console.WriteLine("Setting AES encryption to " + this.main.AesKeySize);

            if (checkBoxRememberSettings.Checked == true)
            {
                this.SavePreferences();
            }

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