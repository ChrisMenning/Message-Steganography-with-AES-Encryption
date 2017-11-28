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
    using Classes;
    using PNGCompression;

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
        /// Declare an image for use in stripping color
        /// </summary>
        private Image lossless;

        /// <summary>
        /// Declare a bitmap for the encoded image
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// Declare the image encoder.
        /// </summary>
        private BitmapEncoder imgEnc;

        /// <summary>
        /// Declare the image decoder
        /// </summary>
        private BitmapDecoder imgDec;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// the size of the AES block (16, 24, or 32)
        /// </summary>
        private int aesBlockSize;

        /// <summary>
        /// Declare compressor for PNG formats
        /// </summary>
        private PNGCompressor pngCompressor;

        /// <summary>
        /// Declare a picture box for the image
        /// </summary>
        private PictureBox pubpicture;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class 
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();
            this.pubpicture = this.pcbImage;
            this.aesBlockSize = 16;
            this.pngCompressor = new PNGCompressor();
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
        /// Gets or sets the AES Block Size field.
        /// </summary>
        public int AesBlockSize
        {
            get
            {
                return this.aesBlockSize;
            }

            set
            {
                this.aesBlockSize = value;
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
        /// Accepts unicode and outputs ASCII.
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
        /// Accepts a mimeType and returns ImageCodecInfo.
        /// </summary>
        /// <param name="mimeType">mime Type</param>
        /// <returns>Image Codec Info</returns>
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                {
                    return encoders[j];
                }
            }

            return null;
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

                this.rawImage.Save(Path.GetFullPath(@"temp1.png"), ImageFormat.Png);
                File.SetAttributes(@"temp1.png", FileAttributes.Hidden);

                Cursor.Current = Cursors.WaitCursor;

                PleaseWait pw = new PleaseWait("Ensuring Lossless Compression." + "\n" + "Depending on your image, this process could take awhile." + "\n" + "Thank you for your patience.");
                pw.Show();

                // Save a temporary lossless copy of the the just-opened image. Hide it.
                this.pngCompressor.CompressImageLossLess(Path.GetFullPath(@"temp1.png"), Path.GetFullPath(@"temp2.png"));
                File.SetAttributes(Path.GetFullPath(@"temp2.png"), FileAttributes.Hidden);

                // Declare a new image and assign it a reference to the lossless copy.
                this.lossless = Image.FromFile(Path.GetFullPath(@"temp2.png"));

                // Draw the picturebox using the lossless copy.
                this.pcbImage.Image = this.lossless;
                this.rawImage = (Bitmap)this.lossless;

                pw.Close();

                // Delete the lossless copy.
                // lossless = null;
                File.Delete(Path.GetFullPath(@"temp1.png"));
            }
        }

        /// <summary>
        /// Save the new image.
        /// </summary>
        private void SaveEncodedImage()
        {
            // Save the image.
            this.dialogSaveImage.Filter = "PNG Image|*.png";
            this.dialogSaveImage.Title = "Save an Image File";
            this.dialogSaveImage.ShowHelp = true;
            this.dialogSaveImage.FileName = string.Empty;
            this.dialogSaveImage.ShowDialog();

            ImageCodecInfo myImageCodecInfo;
            System.Drawing.Imaging.Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            // Get an ImageCodecInfo object that represents the JPEG codec.
            myImageCodecInfo = GetEncoderInfo("image/png");

            Console.WriteLine("Saving with codec: " + myImageCodecInfo.FormatDescription);

            // Create an Encoder object based on the GUID

            // for the Quality parameter category.
            myEncoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.

            // An EncoderParameters object has an array of EncoderParameter

            // objects. In this case, there is only one

            // EncoderParameter object in the array.
            myEncoderParameters = new EncoderParameters(1);

            myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            if (this.dialogSaveImage.FileName != string.Empty)
            {
                this.encodedImage.Save(this.dialogSaveImage.FileName, myImageCodecInfo, myEncoderParameters);
                // this.pictureBoxEncoded.Image = this.encodedImage;
                //this.pcbImage.Image = this.encodedImage;
            }

            // Clean up.
            this.lossless.Dispose();

            // pictureBoxEncoded.Image = Bitmap.FromFile(dialogSaveImage.FileName);
            // pictureBoxRaw.Image = Bitmap.FromFile(dialogSaveImage.FileName);
            //pcbImage.Image = Bitmap.FromFile(dialogSaveImage.FileName);
            //this.encodedImage.Dispose();
            //this.rawImage.Dispose();
            File.Delete(Path.GetFullPath(@"temp2.png")); //Erroring out at this point encoding stock image
        }

        /// <summary>
        /// Collects the text from the textbox and the image, passes them into the encoder, and if necessary
        /// the Encryption, and then calls the Save method.
        /// </summary>
        private void DoEncoding()
        {
            // First, make sure whatever unicode has been entered into the input box is forced into ASCII.
            string ascii = this.UnicodeToAscii(this.txtMessage.Text);

            // Call the image encoder's main encoder method, passing in the text from the input box,
            // return the encoded bitmap, and assign the encoded bitmap to this.encodedImage for later saving.

            // But if using encryption...
            if (this.checkBoxEncryption.Checked)
            {
                // Prompt the user to enter a password.
                PasswordInputDialog pwid = new PasswordInputDialog(this);
                pwid.ShowDialog();

                // Instantiate the Encrypter and pass in the message and password.
                AESEncrypt aes = new AESEncrypt(ascii, this.password, this);

                // Encrypt the message.
                aes.EncryptMessage();

                this.Update();

                // Instantiate the Image Encoder, passing in the raw image and the Initialization Vector from 
                // the AES encrypter.
                this.imgEnc = new BitmapEncoder(this.rawImage, aes.InitializationVector);

                // Console.WriteLine("Encrypted string is " + aes.EncryptedMessageString().Length + " characters long.");
                string toBeEncoded = aes.EncryptedMessageString();
                this.encodedImage = this.imgEnc.Encoder(toBeEncoded);
            }
            else
            {
                this.imgEnc = new BitmapEncoder(this.rawImage);
                this.encodedImage = this.imgEnc.Encoder(ascii);
                this.pcbImage.Image = this.encodedImage;
            }

            // Save the image.
            this.SaveEncodedImage();
            this.pcbImage.Image.Dispose();

            // pictureBoxRaw.Image.Dispose();
        }

        /// <summary>
        /// If using encryption, this will go through many additional steps to parse out the Initialization Vector and 
        /// the message length from the encoded bytes, then trim the decoded bytes down to just the cipher, before
        /// finally passing the cipher, the IV, and the Key into the Decryption.
        /// </summary>
        private void DoDecoding()
        {
            if (this.checkBoxEncryption.Checked)
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
                List<string> bytesFomImage = this.imgDec.BytesList;

                Console.WriteLine("BytesList is " + this.imgDec.BytesList.Count + " long.");

                // 32 for 256 bits, 24 for 192 bits, and 16 for 128 bits
                Console.WriteLine("Using AES block size: " + this.aesBlockSize);
                byte[] derivedIV = new byte[this.aesBlockSize];
                for (int i = 0; i < this.aesBlockSize; i++)
                {
                    derivedIV[i] = Convert.ToByte(bytesFomImage[i], 2);
                }

                Console.WriteLine("Derived IV is " + derivedIV.Count() + " bytes long.");

                this.Update();

                AESDecrypt aes = new AESDecrypt(this);

                // Confirm that the derivedIV is the same length as the aesBlockSize.
                if (derivedIV.Length != this.aesBlockSize)
                {
                    Console.WriteLine("!!!!!!!! DERIVED IV BLOCK SIZE MISMATCH !!!!!!!!");
                }

                // Erase IV from bytesFomImage list.
                for (int i = 0; i < this.aesBlockSize; i++)
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
                // represent how many bytes are in the message.
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
        }

        /// <summary>
        /// Method to encode and decode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnCoding_Click(object sender, EventArgs e)
        {
            if ((this.cmbFunction.SelectedIndex == 0) && (this.cmbImage.SelectedIndex != 4) && (this.btnCoding.Text == "3. Encode (Hide) Message") && (this.txtMessage.TextLength > 0))
            {
                Cursor.Current = Cursors.WaitCursor;
                PleaseWait pw = new PleaseWait("Encoding. Thank you for your patience.");
                pw.Show();
                pw.Update();
                this.DoEncoding();
                pw.Close();
            }

            if ((this.cmbFunction.SelectedIndex == 1) && (this.cmbImage.SelectedIndex == 4) && (this.btnCoding.Text == "3. Decode (Retrieve) Message"))
            {

                Cursor.Current = Cursors.WaitCursor;
                PleaseWait pw = new PleaseWait("Decoding. Thank you for your patience.");
                pw.Show();
                pw.Update();
                this.DoDecoding();
                pw.Close();
            }

        }

        /// <summary>
        /// Method used to create the mandelbrot fractal
        /// </summary>
        private void GenerateFractal()
        {
            Mandelbrot mb = new Mandelbrot();
            Bitmap fractal = mb.DrawMandelbrot(1000, 1000);
            this.pcbImage.Image = fractal;
            Cursor.Current = Cursors.WaitCursor;
            PleaseWait pw = new PleaseWait("Ensuring Lossless Compression." + "\n" + "Depending on your image, this process could take awhile." + "\n" + "Thank you for your patience.");
            pw.Show();

            fractal.Save(Path.GetFullPath(@"temp1.png"), ImageFormat.Png);
            File.SetAttributes(@"temp1.png", FileAttributes.Hidden);

            this.pngCompressor.CompressImageLossLess(Path.GetFullPath(@"temp1.png"), Path.GetFullPath(@"temp2.png"));
            File.SetAttributes(@"temp2.png", FileAttributes.Hidden);

            pw.Close();

            // Declare a new image and assign it a reference to the lossless copy.
            this.lossless = Image.FromFile(Path.GetFullPath(@"temp2.png"));

            // Draw the picturebox using the lossless copy.
            // this.pictureBoxRaw.Image = this.lossless;
            this.pcbImage.Image = this.lossless;
            fractal = (Bitmap)this.lossless;

            this.rawImage = (Bitmap)this.lossless;

            File.Delete(Path.GetFullPath(@"temp1.png"));
        }

        /// <summary>
        /// Method used to create the Gradient Image
        /// </summary>
        private void GenerateGradient()
        {
            Gradient gd = new Gradient();
            Bitmap gradient = gd.GenerateGradient(1000, 1000, 34, 23, 12, 13);
            Bitmap pic = new Bitmap(1000, 1000);
            this.pcbImage.Image = gradient;
            Cursor.Current = Cursors.WaitCursor;
            PleaseWait pw = new PleaseWait("Ensuring Lossless Compression." + "\n" + "Depending on your image, this process could take awhile." + "\n" + "Thank you for your patience.");
            pw.Show();

            gradient.Save(Path.GetFullPath(@"temp1.png"), ImageFormat.Png);
            File.SetAttributes(@"temp1.png", FileAttributes.Hidden);

            this.pngCompressor.CompressImageLossLess(Path.GetFullPath(@"temp1.png"), Path.GetFullPath(@"temp2.png"));
            File.SetAttributes(@"temp2.png", FileAttributes.Hidden);

            pw.Close();

            // Declare a new image and assign it a reference to the lossless copy.
            this.lossless = Image.FromFile(Path.GetFullPath(@"temp2.png"));

            // Draw the picturebox using the lossless copy.
            //this.pictureBoxRaw.Image = this.lossless;
            this.pcbImage.Image = this.lossless;
            gradient = (Bitmap)this.lossless;

            this.rawImage = (Bitmap)this.lossless;

            File.Delete(Path.GetFullPath(@"temp1.png"));
        }

        /// <summary>
        /// The Tool Strip Menu Item for opening an image to encode.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiOpenImageEncode_Click(object sender, EventArgs e)
        {
            if (cmbImage.Visible == false)
            {
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 0;
                this.OpenRawImage();
            }
            else
            {
                this.ResetImage();
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 0;
                this.OpenRawImage();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for opening an encoded image to decode.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiOpenImageDecode_Click(object sender, EventArgs e)
        {
            if (cmbImage.Visible == false)
            {
                this.cmbFunction.SelectedIndex = 1;
                this.cmbImage.SelectedIndex = 4;
                this.OpenRawImage();
            }
            else
            {
                this.ResetImage();
                this.cmbFunction.SelectedIndex = 1;
                this.cmbImage.SelectedIndex = 4;
                this.OpenRawImage();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for generating a stock image.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiStockImage_Click(object sender, EventArgs e)
        {
            if (cmbImage.Visible == false)
            {
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 1;
                frmStockImagesPage stockImage = new frmStockImagesPage(this);
                stockImage.ShowDialog();

            }
            else
            {
                this.ResetImage();
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 1;
                frmStockImagesPage stockImage = new frmStockImagesPage(this);
                stockImage.ShowDialog();
            }
        }

        /// <summary>
        /// Tool Strip Menu Item for generating a fractal.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiFractalImage_Click(object sender, EventArgs e)
        {
            if (cmbImage.Visible == false)
            {
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 2;
                this.GenerateFractal();
            }
            else
            {
                this.ResetImage();
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 2;
                this.GenerateFractal();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for generating a gradient image.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiGradientImage_Click(object sender, EventArgs e)
        {
            if (cmbImage.Visible == false)
            {
                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 3;
                this.GenerateGradient();
            }
            else
            {
                this.ResetImage();

                this.cmbFunction.SelectedIndex = 0;
                this.cmbImage.SelectedIndex = 3;
                this.GenerateGradient();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for cutting text from textbox.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiCut_Click(object sender, EventArgs e)
        {
            if (this.txtMessage.SelectedText != " ")
            {
                MessageBox.Show("You must select and highlight the text you wish to cut before continuing.  Please try again.", "Please Try Again");
            }
            else
            {
                Clipboard.SetText(this.txtMessage.SelectedText);
                this.txtMessage.Cut();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for copying text from textbox.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiCopy_Click(object sender, EventArgs e)
        {
            if (this.txtMessage.SelectedText != " ")
            {
                MessageBox.Show("You must select and highlight the text you wish to copy before continuing.  Please try again.", "Please Try Again");
            }
            else
            {
                Clipboard.SetText(this.txtMessage.SelectedText);
                this.txtMessage.Copy();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for pasting text.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiPaste_Click(object sender, EventArgs e)
        {
            Clipboard.GetText();
            this.txtMessage.Paste();
        }

        /// <summary>
        /// The Tool Strip Menu Item for deleting text from the textbox.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.txtMessage.SelectedText != " ")
            {
                MessageBox.Show("You must select and highlight the text you wish to delete before continuing.  Please try again.", "Please Try Again");
            }
            else
            {
                this.txtMessage.Clear();
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for selecting all text from textbox for further action.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiSelectAll_Click(object sender, EventArgs e)
        {
            this.txtMessage.SelectAll();
        }

        /// <summary>
        /// The Tool Strip Menu Item for viewing Advanced Options.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiAO_Click(object sender, EventArgs e)
        {
            AdvancedOptions ao = new AdvancedOptions(this);
            ao.ShowDialog();
        }

        /// <summary>
        /// The tool strip menu item for using encryption.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiUseEncrypt_Click(object sender, EventArgs e)
        {
            if (this.checkBoxEncryption.Checked)
            {
                this.checkBoxEncryption.Checked = false;
            }
            else
            {
                this.checkBoxEncryption.Checked = true;
                this.checkBoxEncryption.Visible = true;
            }
        }

        /// <summary>
        /// The Tool Strip Menu Item for viewing Help.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiViewHelp_Click(object sender, EventArgs e)
        {
            frmHelpPage helpPage = new frmHelpPage();
            helpPage.Show();
        }

        /// <summary>
        /// The Tool Strip Menu Item for viewing the About menu.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            frmAboutPage aboutPage = new frmAboutPage();
            aboutPage.Show();
        }

        /// <summary>
        /// The Tool Strip Menu Item for viewing the Website Wikipedia for Fractal.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void TsmiWhatIsAFractal_Click(object sender, EventArgs e)
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
        /// Method used to reset everything on the form.
        /// </summary>
        private void ResetEverything()
        {
            this.lblFunction.Text = string.Empty;

            this.txtMessage.Clear();
            this.ResetImage();
            this.Refresh();
        }

        /// <summary>
        /// The button command that will reset everything on the form.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnResetAll_Click(object sender, EventArgs e)
        {
            this.ResetEverything();
        }

        /// <summary>
        /// Method used to reset the image only.
        /// </summary>
        private void ResetImage()
        {
            this.lblImageChoice.Text = string.Empty;
            this.lblImageOptions.Visible = false;
            this.cmbImage.Visible = false;
            this.btnCoding.Visible = false;
            this.checkBoxEncryption.Visible = false;
            this.lblType.Visible = false;
            this.cmbImage.Enabled = false;
            this.lossless = new Bitmap(1, 1);
            this.rawImage = new Bitmap(1, 1);
            this.encodedImage = new Bitmap(1, 1);
            this.pcbImage.Image = null;
            this.imgEnc = null;
            this.imgDec = null;
            File.Delete(Path.GetFullPath(@"temp1.png"));
            this.Refresh();
        }

        /// <summary>
        /// The button command that will reset only the image displayed.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnResetImage_Click(object sender, EventArgs e)
        {
            if (pcbImage.Image != null)
            {
                this.ResetImage();
                this.lblImageChoice.Text = string.Empty;
                File.Delete(Path.GetFullPath(@"temp1.png"));
            }
            else
            {
                MessageBox.Show("There is not a picture currently displayed to be able to reset at this time. Please either choose if you wish to encode or decode and then choose your image.", "For Your Information");
            }
        }

        /// <summary>
        /// The button command that will clear the text from the textbox.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (this.txtMessage.TextLength > 0)
            {
                Clipboard.SetText(this.txtMessage.Text);
                this.txtMessage.Clear();
            }
            else
            {
                MessageBox.Show("There are no characters in the textbox above to clear at this time.", "For Your Information");
            }
        }

        /// <summary>
        /// The Method that will get the objects needed for either the encode or decode process.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void GetActionList(object sender, EventArgs e)
        {
            if (this.cmbFunction.SelectedIndex == 0)
            {
                this.checkBoxEncryption.Visible = true;
                this.txtMessage.Enabled = true;
                this.cmbImage.Items.Clear();
                this.cmbImage.Items.Add(cmbImage.SelectedItem = "Open My Image - Encode");
                this.cmbImage.Items.Add(cmbImage.SelectedItem = "Use Stock Image");
                this.cmbImage.Items.Add(cmbImage.SelectedItem = "Create Fractal Image");
                this.cmbImage.Items.Add(cmbImage.SelectedItem = "Create Gradient Image");
            }
            else if (this.cmbFunction.SelectedIndex == 1)
            {
                this.checkBoxEncryption.Visible = false;
                this.cmbImage.Items.Clear();
                this.cmbImage.Items.Add(cmbImage.SelectedItem = "Open My Image - Decode");
            }
            else
            {
                this.lblImageOptions.Visible = true;
                this.cmbImage.Items.Clear();
            }
        }

        /// <summary>
        /// The method that will produce a list of the various options in the image choice dropdown list.
        /// </summary>
        private void GetMessageActionList()
        {
            if (this.cmbFunction.SelectedIndex == 0)
            {
                this.btnCoding.Text = "3. Encode (Hide) Message";
                this.lblType.Visible = true;
            }
            else if (this.cmbFunction.SelectedIndex == 1)
            {
                this.btnCoding.Text = "3. Decode (Retrieve) Message";
                this.lblType.Visible = false;
            }

            this.btnCoding.Visible = true;

        }

        /// <summary>
        /// The method that will produce a list of the various options in the image choice dropdown list.
        /// And perform the task chosen.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void CmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbImage.SelectedIndex == 0)
            {
                this.OpenRawImage();
            }

            if (this.cmbImage.SelectedIndex == 1)
            {
                frmStockImagesPage stockImage = new frmStockImagesPage(this);
                stockImage.ShowDialog();
            }

            if (this.cmbImage.SelectedIndex == 2)
            {
                this.GenerateFractal();
            }

            if (this.cmbImage.SelectedIndex == 3)
            {
                this.GenerateGradient();
            }

            if (this.cmbImage.SelectedIndex == 4)
            {
                this.OpenEncodedImage();
            }


        }

        private void OpenEncodedImage()
        {
            this.dialogOpenRawImage.Filter = "PNG Image|*.png";
            this.dialogOpenRawImage.ShowHelp = true;
            this.dialogOpenRawImage.FileName = "*.png";
            if (this.dialogOpenRawImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.encodedImage = new Bitmap(this.dialogOpenRawImage.FileName);
                this.pcbImage.Image = this.encodedImage;

            }
        }

        /// <summary>
        /// The method that runs when the value in the Image Choice field changes.
        /// To produce the correct options available.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void CmbImage_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lblImageChoice.Text = this.cmbImage.Text;
            this.lblImageChoice.Visible = true;
            this.GetMessageActionList();
            this.lblImageChoice.Focus();
        }

        /// <summary>
        /// The method that runs when the value in the function choice field changes.
        /// To produce the correct options available.
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void CmbFunction_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lblImageOptions.Visible = true;
            this.cmbImage.Visible = true;
            this.lblFunction.Text = this.cmbFunction.Text;
            this.lblFunction.Visible = true;
            this.cmbImage.Enabled = true;
            this.lblImageChoice.Visible = false;
            this.btnCoding.Visible = false;
            this.lblType.Visible = false;
            this.lblFunction.Focus();
        }

        private void TsmiSaveEncodedImage_Click(object sender, EventArgs e)
        {
            if ((this.cmbFunction.SelectedIndex == 0) && (this.cmbImage.SelectedIndex != 4) && (this.btnCoding.Text == "3. Encode (Hide) Message") && (this.txtMessage.TextLength > 0))

            {
                //Waiting for Stock Images to be complete");

                Cursor.Current = Cursors.WaitCursor;
                PleaseWait pw = new PleaseWait("Encoding. Thank you for your patience.");
                pw.Show();
                pw.Update();
                this.DoEncoding();
                pw.Close();
            }
            else
            {
                MessageBox.Show("There are no characters in the textbox or image displayed to encode at this time.", "For Your Information");
            }
        }
    }
}
