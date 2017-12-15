//----------------------------------------------------------------------------------
// <copyright file="HelpPage.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Code for the Help Page Form.
    /// </summary>
    public partial class FrmHelpPage : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmHelpPage"/> class.
        /// </summary>
        public FrmHelpPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Form Load Event for the Help Page.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void FrmHelpPage_Load(object sender, EventArgs e)
        {
            string message = string.Empty;

            message += "What is Steganography?\n";
            message += "\nSteganography is the process of hiding messages inside of something else. ";
            message += "In the case of this program, users can hide text messages inside of image files.\n";
            message += "\nWhat is ASCII?\n";
            message += "\nASCII (American Standard Code for Information Interchange) is a character encoding standard for electronic communication. This program ";
            message += "can only hide messages whose text is in ASCII.\n";
            message += "\nHow to Hide a Message in an Image:\n";
            message += "1. Click 'File' -> 'Open Image' -> 'Open Plain Image' \n";
            message += "2. Select the Image file you want to hide a message in\n";
            message += "3. Type a message in the textbox on the form\n";
            message += "4. Select whether or not you would like to use encryption by checking the 'Use Encryption' box\n";
            message += "5. If you choose to use encryption, provide a password\n";
            message += "6. Click the 'Hide Message in Image' button\n";
            message += "7. Select where you want to save your new image\n";
            message += "Or";
            message += "\n1. Select 'Open your own Image' from the 'Choose Your Image' dropdown box\n";
            message += "2. Select the Image file you want to hide a message in\n";
            message += "3. Type a message in the textbox on the form\n";
            message += "4. Select whether or not you would like to use encryption by checking the 'Use Encryption' box\n";
            message += "5. If you choose to use encryption, provide a password\n";
            message += "6. Click the 'Hide Message in Image' button\n";
            message += "7. Select where you want to save your new image\n";
            message += "\nHow to Read a Hidden Message from an Image:\n";
            message += "1. Click 'File' -> 'Open Image' -> 'Open Encoded Image' \n";
            message += "2. Select the image with the hidden message you want to read\n";
            message += "3. Click the 'Decode Message from Image' button\n";
            message += "4. If the message is encrypted and needs a password, provide one in the message box that pops up\n";
            message += "5. View the message in the textbox on the form\n";
            message += "Or";
            message += "\n1. Click the 'Retrieve Message From Image' button\n";
            message += "2. Click 'Open Image'\n";
            message += "3. Select the image with the hidden message you want to read\n";
            message += "4. Click the 'Decode Message from Image' button\n";
            message += "5. If the message is encrypted and needs a password, provide one in the message box that pops up\n";
            message += "6. View the message in the textbox on the form\n";
            message += "\nHow to Open a Stock Image:\n";
            message += "1. Click 'File' -> 'Open Image' -> 'Choose Stock Photo'\n";
            message += "2. Choose the Image and Size you want using the buttons in the 'Images' and 'Sizes' boxes\n";
            message += "3. Click the 'Open Image' button\n";
            message += "Or";
            message += "\n1. Select 'Select Stock Image' from the 'Choose Your Image' dropdown box\n";
            message += "2. Choose the Image and Size you want using the buttons in the 'Images' and 'Sizes' boxes\n";
            message += "3. Click the 'Open Image' button\n";
            message += "4. If you wish to cancel out of the Stock Images Page and go back to the Main Page, click the 'Close' button\n";
            message += "\nHow to Generate a Fractal Image:\n";
            message += "1. Click 'File' -> 'Generate Image' -> 'Fractal Image' \n";
            message += "Or";
            message += "\n1. Select 'Generate Fractal' from the 'Choose Your Image' dropdown box\n";
            message += "\nHow to Generate a Gradient Image:\n";
            message += "1. Click 'File' -> 'Generate Image' -> 'Gradient Image' \n";
            message += "Or";
            message += "\n1. Select 'Generate Gradient' from the 'Choose Your Image' dropdown box\n";
            message += "\nHow to View the About Page:\n";
            message += "1. Click 'Help' -> 'About' \n";
            message += "2. When you're done viewing the About Page, click the Close button to close the page\n";
            message += "\nHow to View the Help Page:\n";
            message += "1. Click 'Help' -> 'View Help' \n";
            message += "2. When you're done viewing the Help Page, click the Close button to close the page\n";
            message += "\nHow to Close the Main Form:\n";
            message += "1. Click the Red X button in the top right corner\n";
            message += "Or";
            message += "\n1. Click 'File' -> 'Quit'";

            this.rtbHelpPage.Text = message;
        }

        /// <summary>
        /// Click event for the Close Button on the Help Page.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnCloseHelpPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
