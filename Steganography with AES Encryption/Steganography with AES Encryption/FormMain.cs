//----------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="Legendary Lichens">
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
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Steganography_with_AES_Encryption.Classes;

    /// <summary>
    /// Main form for user entry
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Declare a bitmap for the raw image.
        /// </summary>
        private Bitmap rawImage;

        /// <summary>
        /// Declare a bitmap for the encoded image
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// Declare the image encoder.
        /// </summary>
        private BitmapEncoder bmpEnc;

        /// <summary>
        /// Declare the image decoder
        /// </summary>
        private BitmapDecoder imgDec;


        private CharacterCompute charComp;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// The size of the AES key in bytes (16, 24, or 32)
        /// </summary>
        private int aesKeySize;

        /// <summary>
        /// A private picture box.
        /// </summary>
        private PictureBox pubpicture;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class 
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();
            this.pubpicture = this.pictureBoxRaw;
            this.aesKeySize = 16;
            this.Width = 1016;
            this.Height = 768;
            this.CenterToScreen();
            this.textBoxOutputMessage.ReadOnly = true;

            radioButtonEncode.Checked = true;
            groupBoxEncode.Location = new Point(5, 208);

            // Instantiate Advanced Options once, to load the last encryption settings used.
            AdvancedOptions ad = new AdvancedOptions(this);

            // Instantiate CharacterCompute once at initialization.
            this.charComp = new CharacterCompute(this.pubpicture.Width, this.pubpicture.Height, this);
        }

        /// <summary>
        /// Gets or sets the password field.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Gets or sets the AES BlockSize field.
        /// </summary>
        public int AesKeySize
        {
            get
            {
                return this.aesKeySize;
            }

            set
            {
                this.aesKeySize = value;
            }
        }

        /// <summary>
        /// Gets or sets the picture box.
        /// </summary>
        public PictureBox Pubpicture
        {
            get
            {
                return this.pubpicture;
            }

            set
            {
                this.pubpicture = value;
            }
        }

        public TextBox getTextBoxInput() {
            return this.textBoxInputMessage;
        }


        public bool getCheckedEncrypt()
        {
            return this.checkBoxEncryption.Checked;
        }

        /// <summary>
        /// Accepts unicode and outputs ascii.
        /// </summary>
        /// <param name="inputUnicode">A string.</param>
        /// <returns>Another string.</returns>
        public string UnicodeToAscii(string inputUnicode)
        {
            // Force string to be ASCII in case there is other encoding (UTF-8, etc) contained therein.
            // Non-ASCII chars may be more than one byte long, but this method can only handle one byte at this time.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(inputUnicode);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);
            inputUnicode = asciiString;

            return inputUnicode;
        }

        /// <summary>
        /// Resets Everything.
        /// </summary>
        private void ResetEverything()
        {
            this.rawImage = new Bitmap(1, 1);
            this.encodedImage = new Bitmap(1, 1);
            textBoxInputMessage.Clear();
            textBoxOutputMessage.Clear();

            this.pubpicture.Image = null;
            this.pictureBoxEncoded.Image = null;
            this.bmpEnc = null;
            this.imgDec = null;

            btnEncodeImage.Enabled = false;
            btnDecode.Enabled = false;
        }

        /// <summary>
        /// Opens an image
        /// </summary>
        private void OpenRawImage()
        {
            this.dialogOpenRawImage.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
                + "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|";

            this.dialogOpenRawImage.ShowHelp = true;
            this.dialogOpenRawImage.FileName = string.Empty;
            if (this.dialogOpenRawImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.rawImage = new Bitmap(Bitmap.FromFile(this.dialogOpenRawImage.FileName));
                this.pictureBoxRaw.Image = this.rawImage;
                this.charComp = new CharacterCompute(this.rawImage.Width, this.rawImage.Height, this);
                textBoxInputMessage.MaxLength = charComp.CalcMax();
            }

            saveEncodedImageToolStripMenuItem.Enabled = false;
            if (textBoxInputMessage.Text.Length > 0)
            {
                btnEncodeImage.Enabled = true;
            }
        }

        /// <summary>
        /// Opens an encoded image and gets it ready to be decoded.
        /// </summary>
        private void OpenEncodedImage()
        {
            saveDecodedMessageToolStripMenuItem.Enabled = false;
            buttonSaveText.Enabled = false;

            this.dialogOpenRawImage.Filter = "PNG Image|*.png";
            this.dialogOpenRawImage.ShowHelp = true;
            this.dialogOpenRawImage.FileName = "*.png";
            if (this.dialogOpenRawImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.encodedImage = new Bitmap(this.dialogOpenRawImage.FileName);
                this.pictureBoxEncoded.Image = this.encodedImage;
                this.btnDecode.Enabled = true;
            }

            saveEncodedImageToolStripMenuItem.Enabled = false;

        }

        /// <summary>
        /// Save the new image.
        /// </summary>
        private void SaveEncodedImage()
        {
            // Save the image.
            dialogSaveImage.Filter = "PNG Image|*.png";
            dialogSaveImage.Title = "Save an Image File";
            this.dialogSaveImage.ShowHelp = true;
            this.dialogSaveImage.FileName = "encoded";
            dialogSaveImage.ShowDialog();
            
            if (dialogSaveImage.FileName != string.Empty)
            {
                try
                {
                    this.encodedImage.Save(dialogSaveImage.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch
                {
                    MessageBox.Show("Something's not right.");
                }
                
            }
        }

        /// <summary>
        /// Saves the text decoded from an image to a text file.
        /// </summary>
        private void SaveTextFile()
        {
            this.dialogSaveText.Filter = "Text File|*.txt";
            this.dialogSaveText.Title = "Save a Text File";
            this.dialogSaveText.ShowHelp = true;
            this.dialogSaveText.FileName = "decoded";
            this.dialogSaveText.ShowDialog();

            if (dialogSaveText.FileName != string.Empty)
            {
                System.IO.File.WriteAllText(dialogSaveText.FileName, this.textBoxOutputMessage.Text);
            }
        }

        /// <summary>
        /// Collects the text from the textbox and the image, passes them into the encoder, and if needed
        /// the AESEncrypt object, and then calls the Save method.
        /// </summary>
        private void DoEncoding()
        {
            // First, make sure whatever unicode has been entered into the input box is forced into ASCII.
            string ascii = this.UnicodeToAscii(this.textBoxInputMessage.Text);

            // Call the image encoder's main encoder method, passing in the text from the input box,
            // return the encoded bitmap, and assign the encoded bitmap to this.encodedImage for later saving.

            // But if using encryption...
            if (checkBoxEncryption.Checked)
            {
                // Prompt the user to enter a password.
                PasswordInputDialog pwid = new PasswordInputDialog(this);
                pwid.ShowDialog();

                // Instantiate the Encrypter and pass in the message and password.
                AESEncrypt aes = new AESEncrypt(ascii, this.password, this);

                // Encrypt the message.
                aes.EncryptMessage();

                this.Update();

                // Instantiate the Bitmap Encoder, passing in the raw image and the Initialization Vector from 
                // the AES encrypter.
                this.bmpEnc = new BitmapEncoder(this.rawImage, aes.InitializationVector);

                // Console.WriteLine("Encrypted string is " + aes.EncryptedMessageString().Length + " characters long.");

                // Now pass the encrypted message into the bitmap encoder, hiding the message in the image.
                string toBeEncoded = aes.EncryptedMessageString();
                this.encodedImage = this.bmpEnc.Encoder(toBeEncoded);
            }
            else
            {
                // Instantiate a bitmap encoder, passing the raw image into it.
                this.bmpEnc = new BitmapEncoder(this.rawImage);

                // Pass the un-encrypted message into the encoder, hiding the message in the image.
                this.encodedImage = this.bmpEnc.Encoder(ascii);
            }

            // Save the image.
            this.SaveEncodedImage();

            saveEncodedImageToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// If using encryption, this will go through many additional steps to parse out the Initialization Vector and 
        /// the message length from the encoded bytes, then trim the decoded bytes down to just the cipher, before
        /// finally passing the cipher, the IV, and the Key into the AESDecrypt object.
        /// </summary>
        private void DoDecoding()
        {
            if (checkBoxEncryption.Checked)
            {
                // Prompt the user to enter a password.
                PasswordInputDialog pwid = new PasswordInputDialog(this);
                pwid.ShowDialog();

                // Instantiate the passwordHandler and pass in the password, to get an encryption key.
                PasswordHandler passwordHandler = new PasswordHandler(this.password, this);

                // Instantiate an image decoder.
                this.imgDec = new BitmapDecoder();

                // Decode the message from the image.
                // Note: The Decoder method must be called, in order to decode the data, 
                // despite not needing to use the string formatted version of the information. 
                // The bytes will be more useful.
                string stillEncryptedButDecoded = this.imgDec.Decoder(this.encodedImage);

                // Declare a list of strings, returned from the image decoder.
                // These are the 1s and 0s, grouped into 8-digit bytes, as strings.
                List<string> bytesFomImage = this.imgDec.BytesList;

                Console.WriteLine("BytesList is " + this.imgDec.BytesList.Count + " long.");

                // In that list of bytes, the Initialization Vector is stored in the first 16 bytes.
                // Assign the IV to a byte array.
                Console.WriteLine("Using AES Key size: " + 16);
                byte[] derivedIV = new byte[16];

                for (int i = 0; i < 16; i++)
                {
                    derivedIV[i] = Convert.ToByte(bytesFomImage[i], 2);
                }

                this.Update();

                // Instantiate a new AESDecrypt object, and pass in a reference to the main form.
                AESDecrypt aes = new AESDecrypt(this);

                // Erase IV from bytesFomImage list. This doesn't need to appear alongside
                // the decoded message.
                for (int i = 0; i < 16; i++)
                {
                    // remove the first from the list, 16, 24, or 32 times.
                    bytesFomImage.RemoveAt(0);
                }

                // Convert the List of binary strings into a byte array.
                int c = bytesFomImage.Count;
                byte[] byteStringsToBytes = new byte[c];
                for (int i = 0; i < c; i++)
                {
                    byteStringsToBytes[i] = Convert.ToByte(bytesFomImage[i], 2);
                }

                // Pull the first byte from the list. Convert this byte to an int. This should
                // represent how many bytes are in the message, which should correspond to the length of the
                // message, because in ASCII 1 char is 1 byte.
                int messageLength = byteStringsToBytes[0];

                Console.WriteLine("The message to be decrypted is " + messageLength);

                // Pass the byteStringsToBytes byte array, encryption key, and derived IV to the decrypter.
                textBoxOutputMessage.Text = aes.DecryptStringFromBytes_Aes(byteStringsToBytes, passwordHandler.EncryptionKey, derivedIV);
            }
            else
            {
                this.imgDec = new BitmapDecoder();
                this.textBoxOutputMessage.Text = this.imgDec.Decoder(this.encodedImage);
            }

            saveDecodedMessageToolStripMenuItem.Enabled = true;
            buttonSaveText.Enabled = true;
        }

        /// <summary>
        /// Generates a fractal and places it into the picture box.
        /// </summary>
        private void GenerateFractal()
        {
            PleaseWait pw = new PleaseWait("Generating Fractal.");
            pw.Show();
            pw.Update();
            Cursor.Current = Cursors.WaitCursor;
            Mandelbrot mb = new Mandelbrot();
            Bitmap fractal = mb.DrawMandelbrot(1000, 1000);
            pw.Close();
            Cursor.Current = Cursors.Default;
            this.rawImage = fractal;
            this.pubpicture.Image = this.rawImage;
            this.btnEncodeImage.Enabled = true;

            if (textBoxInputMessage.Text.Length > 0)
            {
                btnEncodeImage.Enabled = true;
            }

            this.charComp = new CharacterCompute(this.rawImage.Width, this.rawImage.Height, this);
            textBoxInputMessage.MaxLength = charComp.CalcMax();
        }

        /// <summary>
        /// Generates a gradient pattern and places it into the picture box.
        /// </summary>
        private void GenerateGradient()
        {
            radioButtonEncode.Checked = true;
            Gradient generator = new Gradient();
            PleaseWait pw = new PleaseWait("Generating Gradient.");
            pw.Show();
            pw.Update();
            Cursor.Current = Cursors.WaitCursor;
            this.pubpicture.Image = generator.GenerateGradient(1000, 1000, 34, 23, 12, 13);
            pw.Close();
            Cursor.Current = Cursors.Default;
            this.btnEncodeImage.Enabled = true;

            if (textBoxInputMessage.Text.Length > 0)
            {
                btnEncodeImage.Enabled = true;
            }
            this.charComp = new CharacterCompute(this.rawImage.Width, this.rawImage.Height, this);
            textBoxInputMessage.MaxLength = charComp.CalcMax();
        }

        /// <summary>
        /// The ToolStrip Menu Item for viewing the About menu.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutPage aboutPage = new frmAboutPage();
            aboutPage.Show();
        }

        /// <summary>
        /// The Toolstrip Menu Item for viewing Help.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpPage helpPage = new frmHelpPage();
            helpPage.Show();
        }

        /// <summary>
        /// The ToolStrip Menu Item for viewing Advanced Options
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void AdvancedOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvancedOptions ao = new AdvancedOptions(this);
            ao.ShowDialog();
        }

        /// <summary>
        /// The toolstrip menu item for opening an unencoded image.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void UnencodedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonEncode.Checked = true;

            // Open image.
            this.OpenRawImage();
        }

        /// <summary>
        /// The toolstrip menu item for opening an encoded image.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void EncodedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonDecode.Checked = true;
            this.OpenEncodedImage();
        }

        /// <summary>
        /// The toolstrip menu item for choosing a stock photo.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ChooseStockPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonEncode.Checked = true;

            // Select Stock Photo
            frmStockImagesPage stockImage = new frmStockImagesPage(this);
            stockImage.ShowDialog();
            this.rawImage = (Bitmap)this.pubpicture.Image;
            this.charComp = new CharacterCompute(this.rawImage.Width, this.rawImage.Height, this);
            textBoxInputMessage.MaxLength = charComp.CalcMax();

            if (textBoxInputMessage.Text.Length > 0)
            {
                btnEncodeImage.Enabled = true;
            }
        }

        /// <summary>
        /// The toolstrip menu item for saving an encoded image.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void SaveEncodedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonEncode.Checked = true;
            this.SaveEncodedImage();
        }

        /// <summary>
        /// The toolstrip menu item for saving a decoded message to a text file.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void SaveDecodedMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveTextFile();
        }

        /// <summary>
        /// The toolstrip menu item for generating a fractal.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void FractalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonEncode.Checked = true;
            this.Invalidate();
            this.Update();

            // Generate Fractal
            this.GenerateFractal();
            this.rawImage = (Bitmap)this.pubpicture.Image;
        }

        /// <summary>
        /// The click event for the Generate Gradient toolstrip menu item.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event.</param>
        private void GradientImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GenerateGradient();
        }

        /// <summary>
        /// The toolstrip for using Encryption.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void UseEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxEncryption.Checked = true;
        }

        /// <summary>
        /// The toolstrip menu item for turning off encryption.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void NoEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxEncryption.Checked = false;
        }

        /// <summary>
        /// The toolstrip menu item for Edit->Cut.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
                ((TextBox)this.ActiveControl).SelectedText = string.Empty;
            }
        }

        /// <summary>
        /// The toolstrip menu item for Edit->Copy.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
            }
        }

        /// <summary>
        /// Th toolstrip menu item for Edit->Paste
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                int cursorPosition = ((TextBox)this.ActiveControl).SelectionStart;
                this.ActiveControl.Text = this.ActiveControl.Text.Insert(cursorPosition, Clipboard.GetText());
            }
        }

        /// <summary>
        /// The toolstrip menu item for Edit->Delete.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                ((TextBox)this.ActiveControl).SelectedText = string.Empty;
            }
        }

        /// <summary>
        /// The toolstrip menu item for Edit->Select All
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                ((TextBox)this.ActiveControl).SelectAll();
            }
        }

        /// <summary>
        /// The toolstrip menu item for quitting.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The encryption toolstrip menu item.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EncryptionToolStripMenuItem.Checked == true)
            {
                checkBoxEncryption.Checked = true;
            }
            else
            {
                checkBoxEncryption.Checked = false;
            }
        }

        /// <summary>
        /// The radio button for choosing to Encode.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void RadioButtonEncode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEncode.Checked)
            {
                groupBoxEncode.Location = new Point(5, 208);
                this.AcceptButton = this.btnEncodeImage;
            }
            else
            {
                groupBoxEncode.Location = new Point(5, -2000);
            }
        }

        /// <summary>
        /// The radio button for choosing to Decode.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void RadioButtonDecode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDecode.Checked)
            {
                groupBoxDecode.Location = new Point(5, 208);
                this.AcceptButton = this.btnDecode;
            }
            else
            {
                groupBoxDecode.Location = new Point(5, -2000);
            }
        }

        /// <summary>
        /// The checkedChanged event for the Encryption checkbox.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void checkBoxEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEncryption.Checked == true)
            {
                EncryptionToolStripMenuItem.Checked = true;
            }
            else
            {
                EncryptionToolStripMenuItem.Checked = false;
            }
        }

        /// <summary>
        /// The combo box for choosing an image for encoding.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ComboBoxImageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxImageSelect.SelectedIndex == 0)
            {
                // Open image.
                this.OpenRawImage();
            }
            else if (comboBoxImageSelect.SelectedIndex == 1)
            {
                // Select Stock Photo
                frmStockImagesPage stockImage = new frmStockImagesPage(this);
                stockImage.ShowDialog();
                this.rawImage = (Bitmap)this.pictureBoxRaw.Image;
                if (textBoxInputMessage.Text.Length > 0)
                {
                    btnEncodeImage.Enabled = true;
                }
                if (this.rawImage != null)
                {
                    this.charComp = new CharacterCompute(this.rawImage.Width, this.rawImage.Height, this);
                    textBoxInputMessage.MaxLength = charComp.CalcMax();
                }
            }
            else if (comboBoxImageSelect.SelectedIndex == 2)
            {
                // Generate Fractal
                this.GenerateFractal();
                this.rawImage = (Bitmap)this.pictureBoxRaw.Image;
            }
            else if (comboBoxImageSelect.SelectedIndex == 3)
            {
                // Generate Gradient Pattern
                this.GenerateGradient();
            }
        }

        /// <summary>
        /// Checks that the message input textbox has been changed.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void TextBoxInputMessage_TextChanged(object sender, EventArgs e)
        {
            if (this.pictureBoxRaw.Image != null)
            {
                this.btnEncodeImage.Enabled = true;
                labelCharLimit.Text = "Character Limit: " + charComp.CalcRemainingSpace().ToString();
            }
        }

        /// <summary>
        /// Method to encode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnEncodeImage_Click(object sender, EventArgs e)
        {
            PleaseWait pw = new PleaseWait("Encoding...");
            Cursor.Current = Cursors.WaitCursor;
            pw.Show();
            pw.Update();
            this.DoEncoding();
            pw.Close();
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Method used to open image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnOpenEncodedImage_Click(object sender, EventArgs e)
        {
            this.OpenEncodedImage();
        }

        /// <summary>
        /// Method used to decode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnDecode_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PleaseWait pw = new PleaseWait("Decoding.");
            pw.Show();
            pw.Update();
            this.DoDecoding();
            pw.Close();
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// The click event for the Save Text button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void BtnSaveText_Click(object sender, EventArgs e)
        {
            this.SaveTextFile();
        }

        /// <summary>
        /// The click event for the reset button.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ResetEverything();
        }

    }
}
