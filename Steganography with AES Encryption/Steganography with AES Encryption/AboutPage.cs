//----------------------------------------------------------------------------------
// <copyright file="AboutPage.cs" company="Legendary Lichens">
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
    using Steganography_with_AES_Encryption.Properties;

    /// <summary>
    /// Code for the About Page Form.
    /// </summary>
    public partial class FrmAboutPage : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmAboutPage"/> class.
        /// </summary>
        public FrmAboutPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Form Load Event for the About Page.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void FrmAboutPage_Load(object sender, EventArgs e)
        {
            try
            {
                this.rtbAboutSection.Text = System.Text.Encoding.Default.GetString(Properties.Resources.README);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error fetching the Readme.MD file. /n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.rtbAboutSection.Text = "There was an error fetching the Readme.MD file. /n" + ex.Message;
            }
        }

        /// <summary>
        /// Click event for the Close Button on the About Page.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnCloseAboutPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
