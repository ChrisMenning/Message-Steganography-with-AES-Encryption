using System;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public partial class frmHelpPage : Form
    {
        public frmHelpPage()
        {
            InitializeComponent();
        }

        private void frmHelpPage_Load(object sender, EventArgs e)
        {
            String message = "";

            message += "How to Hide a Message in an Image:\n";
            message += "1. Click 'File' -> 'Open Image' -> 'Open Plain Image' \n";
            message += "2. Select the Image file you want to hide a message in\n";
            message += "3. Type a message in the textbox on the form\n";
            message += "4. Select whether or not you would like to use encryption\n";
            message += "5. If you choose to use encryption, provide a password\n";
            message += "6. Click the 'Hide Message in Image' button\n";
            message += "7. Select where you want to save your new image\n";
            message += "\nHow to Read a Hidden Message from an Image:\n";
            message += "1.  Click 'File' -> 'Open Image' -> 'Open Encoded Image' \n";
            message += "2. Select the image bearing the hidden message you want to read\n";
            message += "3. Click the 'Decome Message from Image' button\n";
            message += "4. If the message is encrypted and needs a password, provide one in the message box that pops up\n";
            message += "5. View the message in the textbox on the form\n";
            message += "\nHow to Generate a Fractal Image:\n";
            message += "1. Set the height and width of the fractal\n";
            message += "2. Click the Generate Fractal button\n";
            message += "3. Select where you would like to save the fractal\n";
            message += "\nHow to View the About Page:\n";
            message += "1. Click the About Page link\n";
            message += "2. When you're done viewing the About Page, click the Close button to close the page";

            rtbHelpPage.Text = message;
        }

        private void btnCloseHelpPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
