﻿//----------------------------------------------------------------------------------
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
        
        /// <summary>
        /// Declare the character compute.
        /// </summary>
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
            this.Height = 755;
            this.CenterToScreen();
            this.textBoxOutputMessage.ReadOnly = true;

            radioButtonEncode.Checked = true;
            groupBoxEncode.Location = new Point(5, 208);

            // Instantiate Advanced Options once, to load the last encryption settings used.
            FormAdvancedOptions ad = new FormAdvancedOptions(this);

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

        /// <summary>
        /// Gets the TextBox input text.
        /// </summary>
        /// <returns>A TextBox</returns>
        public TextBox GetTextBoxInput()
        {
            return this.textBoxInputMessage;
        }

        /// <summary>
        /// Gets the status of the "Use Encryption" checkbox.
        /// </summary>
        /// <returns>A boolean</returns>
        public bool GetCheckedEncrypt()
        {
            return this.checkBoxEncryption.Checked;
        }

        /// <summary>
        /// Accepts unicode and outputs ascii.
        /// </summary>
        /// <param name="inputUnicode">A string.</param>
        /// <returns>Another string.</returns>
        private string UnicodeToAscii(string inputUnicode)
        {
            // Force string to be ASCII in case there is other encoding (UTF-8, etc) contained therein.
            // Non-ASCII chars may be more than one byte long, but the encoder and decoder can only handle
            // one byte at this time.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(inputUnicode);

            foreach (byte b in unicodeBytes)
            {
                if (b > 127 && b < 160)
                {
                    MessageBox.Show("It looks like this text contains Unicode. \n" +
                        "Please note that only ASCII characters will be retained." ,
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

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
            this.checkBoxEncryption.Checked = false;
            saveDecodedMessageToolStripMenuItem.Enabled = false;
            saveEncodedImageToolStripMenuItem.Enabled = false;

            this.pubpicture.Image = null;
            this.pictureBoxEncoded.Image = null;
            this.bmpEnc = null;
            this.imgDec = null;
            this.textBoxInputMessage.MaxLength = 0;

            btnEncodeImage.Enabled = false;
            btnDecode.Enabled = false;
            this.labelCharLimit.Text = "Characters Left: (select an image)";
            this.comboBoxImageSelect.Text = "Choose Your Image";
        }

        /// <summary>
        /// A method that sets many of the common traits across input images.
        /// </summary>
        private void RepetativeRawImageTasks()
        {
            this.pictureBoxRaw.Image = this.rawImage;
            if (this.rawImage.Width * this.rawImage.Height > 15)
            {
                this.charComp = new CharacterCompute(this.rawImage.Width, this.rawImage.Height, this);
                textBoxInputMessage.MaxLength = this.charComp.CalcMax();
                this.charComp.CalcRemainingSpace();
                labelCharLimit.Text = "Characters Left: " + this.charComp.CalcRemainingSpace().ToString();
                saveEncodedImageToolStripMenuItem.Enabled = false;
                if (textBoxInputMessage.Text.Length > 0)
                {
                    btnEncodeImage.Enabled = true;
                }

                this.Update();
            }
            else
            {
                this.pictureBoxRaw.Image = null;
                MessageBox.Show("Image too small to hold any text. \n" + "Please select another image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                try
                {
                    this.rawImage = new Bitmap(Bitmap.FromFile(this.dialogOpenRawImage.FileName));
                    this.RepetativeRawImageTasks();
                }
                catch
                {
                    MessageBox.Show("That does not appear to be a supported image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            this.rawImage = fractal;
            pw.Close();
            Cursor.Current = Cursors.Default;
            this.RepetativeRawImageTasks();
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
            this.rawImage = generator.GenerateGradient(1000, 1000, 34, 23, 12, 13);
            pw.Close();
            Cursor.Current = Cursors.Default;
            this.RepetativeRawImageTasks();
        }

        /// <summary>
        /// A method that calls the StockPhoto form.
        /// </summary>
        private void SelectStockPhoto()
        {
            FrmStockImagesPage stockImage = new FrmStockImagesPage(this);
            stockImage.ShowDialog();

            if (this.pictureBoxRaw.Image != null)
            {
                this.rawImage = (Bitmap)this.pictureBoxRaw.Image;
                this.RepetativeRawImageTasks();
            }
        }

        /// <summary>
        /// Opens an encoded image and gets it ready to be decoded.
        /// </summary>
        private void OpenEncodedImage()
        {
            saveDecodedMessageToolStripMenuItem.Enabled = false;
            buttonSaveText.Enabled = false;
            textBoxOutputMessage.Clear();

            this.dialogOpenRawImage.Filter = "PNG Image|*.png";
            this.dialogOpenRawImage.ShowHelp = true;
            this.dialogOpenRawImage.FileName = "*.png";
            if (this.dialogOpenRawImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.encodedImage = new Bitmap(this.dialogOpenRawImage.FileName);
                    this.pictureBoxEncoded.Image = this.encodedImage;
                    this.btnDecode.Enabled = true;
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show("Invalid file. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            

            if (dialogSaveImage.FileName != string.Empty)
            {
                try
                {
                    dialogSaveImage.ShowDialog();
                    this.encodedImage.Save(dialogSaveImage.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch
                {
                    MessageBox.Show("Save Cancelled.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            bool success = false;

            // Call the image encoder's main encoder method, passing in the text from the input box,
            // return the encoded bitmap, and assign the encoded bitmap to this.encodedImage for later saving.

            // But if using encryption...
            if (checkBoxEncryption.Checked)
            {
                // Prompt the user to enter a password.
                PasswordInputDialog pwid = new PasswordInputDialog(this);
                pwid.ShowDialog();

                try
                {
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
                    success = true;
                }
                catch
                {
                    MessageBox.Show("Encryption cancelled.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    // Instantiate a bitmap encoder, passing the raw image into it.
                    this.bmpEnc = new BitmapEncoder(this.rawImage);

                    // Pass the un-encrypted message into the encoder, hiding the message in the image.
                    this.encodedImage = this.bmpEnc.Encoder(ascii);
                    success = true;
                }
                catch
                {
                    MessageBox.Show("Encoding failed. Please try a different message or a different image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (success == true)
            {
                // Save the image.
                this.SaveEncodedImage();

                saveEncodedImageToolStripMenuItem.Enabled = true;
            }
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
                this.imgDec = new BitmapDecoder(this);

                try
                {
                    // Decode the message from the image.
                    this.imgDec.Decoder(this.encodedImage);

                    // Declare a list of strings, returned from the image decoder.
                    // These are the 1s and 0s, grouped into 8-digit bytes, as strings.
                    List<string> byteStringsFromImage = this.imgDec.BytesList;

                    // In that list of bytes, the Initialization Vector is stored in the first 16 bytes.
                    // Assign the IV to a byte array.
                    byte[] derivedIV = new byte[16];

                    for (int i = 0; i < 16; i++)
                    {
                        derivedIV[i] = Convert.ToByte(this.imgDec.BytesList[i], 2);
                    }

                    this.Update();

                    // Instantiate a new AESDecrypt object, and pass in a reference to the main form.
                    AESDecrypt aes = new AESDecrypt(this);

                    // Erase IV from bytesFomImage list. This doesn't need to appear alongside
                    // the decoded message.
                    for (int i = 0; i < 16; i++)
                    {
                        // remove the first from the list, 16, 24, or 32 times.
                        byteStringsFromImage.RemoveAt(0);
                    }

                    // Convert the List of binary strings into a byte array.
                    int c = byteStringsFromImage.Count;
                    byte[] bytesFromImage = new byte[c];
                    for (int i = 0; i < c; i++)
                    {
                        bytesFromImage[i] = Convert.ToByte(byteStringsFromImage[i], 2);
                    }

                    // Pull the first byte from the list. Convert this byte to an int. This should
                    // represent how many bytes are in the message, which should correspond to the length of the
                    // message, because in ASCII 1 char is 1 byte.
                    int messageLength = bytesFromImage[0];

                    // Pass the byteStringsToBytes byte array, encryption key, and derived IV to the decrypter.
                    textBoxOutputMessage.Text = aes.DecryptStringFromBytes_Aes(bytesFromImage, passwordHandler.EncryptionKey, derivedIV);

                    if (textBoxOutputMessage.Text.Contains("�"))
                    {
                        MessageBox.Show("It looks like the message didn't come out quite right. \n\n" +
                            "Try changin the AES key size in Settings ->Advanced Options.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show("There is something wrong with this image. \n " +
                        "It is possible there is no hidden message in this image, " +
                         "or the wrong encryption is being used for decoding. \n \n" +
                        "Try changing the AES Key Size in Advanced Options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    this.imgDec = new BitmapDecoder(this);
                    this.textBoxOutputMessage.Text = this.imgDec.Decoder(this.encodedImage);
                }
                catch
                {
                    MessageBox.Show("There is something wrong with this image. \n" + 
                        "It is likely there is no hidden message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            saveDecodedMessageToolStripMenuItem.Enabled = true;
            buttonSaveText.Enabled = true;
        }

        /// <summary>
        /// The ToolStrip Menu Item for viewing the About menu.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutPage aboutPage = new FrmAboutPage();
            aboutPage.Show();
        }

        /// <summary>
        /// The Toolstrip Menu Item for viewing Help.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelpPage helpPage = new FrmHelpPage();
            helpPage.Show();
        }

        /// <summary>
        /// The Tool Strip Menu Item for viewing the Website Wikipedia for Fractal.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void WhatIsAFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string Message = "You will be directed to an external website, Wikipedia, in a moment.  If you wish to cancel and return to this application, please select 'Cancel', otherwise select 'Ok'.";
            const string Caption = "External Website";
            var result = MessageBox.Show(Message, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // If the cancel button was pressed 
            if (result == DialogResult.Cancel)
            {
                // return to the form
                this.Focus();
            }
            else
            {
                // continue to website
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Fractal");
            }
        }

        /// <summary>
        /// The ToolStrip Menu Item for viewing Advanced Options
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void AdvancedOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdvancedOptions ao = new FormAdvancedOptions(this);
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
            this.SelectStockPhoto();
        }

        /// <summary>
        /// The toolstrip menu item for saving an encoded image.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void SaveEncodedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonEncode.Checked = true;
            this.DoEncoding();
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
        /// When tool strip menu is clicked.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxInputMessage.SelectionLength > 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }

            if (Clipboard.ContainsText())
            {
                pasteToolStripMenuItem.Enabled = true;
            }
            else
            {
                pasteToolStripMenuItem.Enabled = false;
            }
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
                // this.AcceptButton = this.btnEncodeImage;
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
        private void CheckBoxEncryption_CheckedChanged(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\showWarning.txt";
            FormLessChars flc = new FormLessChars();

            if (checkBoxEncryption.Checked == true)
            {
                EncryptionToolStripMenuItem.Checked = true;

                if (!File.Exists(filePath))
                {
                    flc.ShowDialog();
                }
                else
                {
                    string pref = System.IO.File.ReadAllText(filePath);
                    if (pref == "True")
                    {
                        flc.ShowDialog();
                    }
                }
            }
            else
            {
                EncryptionToolStripMenuItem.Checked = false;
            }

            this.textBoxInputMessage.MaxLength = this.charComp.CalcMax();
            this.charComp.CalcRemainingSpace();
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
                this.SelectStockPhoto();
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

        private void ComboBoxImageSelect_TextChanged(object sender, EventArgs e)
        {
            comboBoxImageSelect.Text = "Choose Your Image";
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
                if (textBoxInputMessage.Text.Length > 0)
                {
                    this.btnEncodeImage.Enabled = true;
                    saveEncodedImageToolStripMenuItem.Enabled = true;
                    labelCharLimit.Text = "Characters Left: " + this.charComp.CalcRemainingSpace().ToString();
                    this.Update();
                }
                else
                {
                    btnEncodeImage.Enabled = false;
                }
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
