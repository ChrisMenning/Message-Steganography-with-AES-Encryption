//----------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    using PNGCompression;
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

    /// <summary>
    /// Main form for user entry
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Declare a bitmap for the raw image.
        /// </summary>
        private Bitmap rawImage;

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

        private PNGCompressor pngCompressor;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class 
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();
            this.aesBlockSize = 16;
            pngCompressor = new PNGCompressor();
            this.CenterToScreen();
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
        /// Gets or sets the aesBlockSize field.
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
        /// Accepts a mimeType and returns ImageCodecInfo.
        /// </summary>
        /// <param name="mimeType"> mimeType </param>
        /// <returns> ImageCodecInfo </returns>
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
            this.dialogOpenRawImage.Filter = "PNG Image|*.png|JPG Image|*.jpg|BMP Image|*.bmp";
            this.dialogOpenRawImage.ShowHelp = true;
            this.dialogOpenRawImage.FileName = string.Empty;
            if (this.dialogOpenRawImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.rawImage = new Bitmap(Bitmap.FromFile(this.dialogOpenRawImage.FileName));

                this.rawImage.Save(Path.GetFullPath(@"temp1.png"), ImageFormat.Png);
                File.SetAttributes((@"temp1.png"), FileAttributes.Hidden);

                PleaseWait pw = new PleaseWait("Ensuring Lossless Compression. \n This may take a minute or three.");
                pw.Show();

                // Save a temporary lossless copy of the the just-opened image. Hide it.
                pngCompressor.CompressImageLossLess(Path.GetFullPath(@"temp1.png"), Path.GetFullPath(@"temp2.png"));
                File.SetAttributes(Path.GetFullPath(@"temp2.png"), FileAttributes.Hidden);
                
                // Declare a new image and assign it a reference to the lossless copy.
                lossless = Image.FromFile(Path.GetFullPath(@"temp2.png"));

                // Draw the picturebox using the lossless copy.
                this.pictureBoxRaw.Image = lossless;
                this.rawImage = (Bitmap)lossless;

                pw.Close();

                // Delete the lossless copy.
                // lossless = null;
                File.Delete(Path.GetFullPath(@"temp1.png"));

                // Turn on encode button.
                this.btnEncodeImage.Enabled = true;
            }
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
                this.encodedImage.Save(dialogSaveImage.FileName);
                this.pictureBoxEncoded.Image = this.encodedImage;
            }

            // Clean up.
            lossless.Dispose();
            // pictureBoxEncoded.Image = Bitmap.FromFile(dialogSaveImage.FileName);
            // pictureBoxRaw.Image = Bitmap.FromFile(dialogSaveImage.FileName);
            // this.encodedImage.Dispose();
            // this.rawImage.Dispose();
            File.Delete(Path.GetFullPath(@"temp2.png"));
        }

        /// <summary>
        /// Collects the text from the textbox and the image, passes them into the encoder, and if neccessary
        /// the encrypter, and then calls the Save method.
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
                this.pictureBoxEncoded.Image = this.encodedImage;
            }

            // Save the image.
            this.SaveEncodedImage();

            pictureBoxRaw.Image.Dispose();
        }

        /// <summary>
        /// If using encryption, this will go through many additional steps to parse out the Initialization Vector and 
        /// the message length from the encoded bytes, then trim the decoded bytes down to just the cipher, before
        /// finally passing the cipher, the IV, and the Key into the decryptor.
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
                List<string> bytesFomImage = this.imgDec.BytesList;

                Console.WriteLine("BytesList is " + this.imgDec.BytesList.Count + " long.");

                // 32 for 256 bits, 24 for 192 bits, and 16 for 128 bits
                byte[] derivedIV = new byte[this.aesBlockSize];
                for (int i = 0; i < this.aesBlockSize; i++)
                {
                    derivedIV[i] = Convert.ToByte(bytesFomImage[i], 2);
                }

                Console.WriteLine("Derived IV is " + derivedIV.Count() + " bytes long.");

                this.Update();

                AESDecrypt aes = new AESDecrypt();

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
                textBoxOutput.Text = aes.DecryptStringFromBytes_Aes(byteStringsToBytes, passwordHandler.EncryptionKey, derivedIV);
            }
            else
            {
                this.imgDec = new BitmapDecoder();
                this.textBoxOutput.Text = this.imgDec.Decoder(this.encodedImage);
            }
        }

        /// <summary>
        /// Method to open image
        /// </summary>
        /// <param name="sender">The object that initiates this event</param>
        /// <param name="e">The event arguments</param>
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            this.OpenRawImage();
        }

        /// <summary>
        /// Method to encode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void btnEncodeImage_Click(object sender, EventArgs e)
        {
            PleaseWait pw = new PleaseWait("Encoding...");
            pw.Show();
            pw.Update();
            this.DoEncoding();
            pw.Close();
        }

        /// <summary>
        /// Method used to open image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void btnOpenEncodedImage(object sender, EventArgs e)
        {
            this.dialogOpenRawImage.Filter = "PNG Image|*.png";
            this.dialogOpenRawImage.ShowHelp = true;
            this.dialogOpenRawImage.FileName = "*.png";
            if (this.dialogOpenRawImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.encodedImage = new Bitmap(Bitmap.FromFile(this.dialogOpenRawImage.FileName));
                this.pictureBoxEncoded2.Image = this.encodedImage;
                this.btnDecode.Enabled = true;
            }
        }

        /// <summary>
        /// Method used to decode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void btnDecode_Click(object sender, EventArgs e)
        {
            PleaseWait pw = new PleaseWait("Decoding.");
            pw.Show();
            pw.Update();
            this.DoDecoding();
            pw.Close();
        }

        private void btnAboutPageTest_Click(object sender, EventArgs e)
        {
            frmAboutPage aboutPage = new frmAboutPage();
            aboutPage.Show();
        }

        private void btnHelpPageTest_Click(object sender, EventArgs e)
        {
            frmHelpPage helpPage = new frmHelpPage();
            helpPage.Show();
        }

        private void btnFractalGeneratorTest_Click(object sender, EventArgs e)
        {
            frmFractalGeneratorTestForm fractalTestForm = new frmFractalGeneratorTestForm();
            fractalTestForm.Show();
        }

        /// <summary>
        /// Toolstrip Menu Item for Generating a fractal.
        /// </summary>
        /// <param name="sender"> sender </param>
        /// <param name="e"> e </param>
        private void generateFractalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mandelbrot mb = new Mandelbrot();
            Bitmap fractal = mb.DrawMandelbrot(1000, 1000);
            pictureBoxRaw.Image = fractal;

            PleaseWait pw = new PleaseWait("Ensuring Lossless Compression. \n This may take a minute or three.");
            pw.Show();

            fractal.Save(Path.GetFullPath(@"temp1.png"), ImageFormat.Png);
            File.SetAttributes(@"temp1.png", FileAttributes.Hidden);

            pngCompressor.CompressImageLossLess(Path.GetFullPath(@"temp1.png"), Path.GetFullPath(@"temp2.png"));
            File.SetAttributes(@"temp2.png", FileAttributes.Hidden);

            pw.Close();

            // Declare a new image and assign it a reference to the lossless copy.
            lossless = Image.FromFile(Path.GetFullPath(@"temp2.png"));

            // Draw the picturebox using the lossless copy.
            this.pictureBoxRaw.Image = lossless;
            fractal = (Bitmap)lossless;

            this.rawImage = (Bitmap)lossless;
            btnEncodeImage.Enabled = true;

            File.Delete(Path.GetFullPath(@"temp1.png"));
        }

        /// <summary>
        /// The ToolStrip Menu Item for opening an unencoded image.
        /// </summary>
        /// <param name="sender"> sender </param>
        /// <param name="e"> e </param>
        private void openUnencodedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenRawImage();
        }

        /// <summary>
        /// The ToolStrip Menu Item for viewing the About menu.
        /// </summary>
        /// <param name="sender"> sender </param>
        /// <param name="e"> e </param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutPage aboutPage = new frmAboutPage();
            aboutPage.Show();
        }

        /// <summary>
        /// The Toolstrip Menu Item for viewing Help.
        /// </summary>
        /// <param name="sender"> sender </param>
        /// <param name="e"> e </param>
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpPage helpPage = new frmHelpPage();
            helpPage.Show();
        }

        /// <summary>
        /// The ToolStrip Menu Item for viewing Advanced Options
        /// </summary>
        /// <param name="sender"> sender </param>
        /// <param name="e"> e </param>
        private void advancedOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvancedOptions ao = new AdvancedOptions(this);
            ao.ShowDialog();
        }

        /// <summary>
        /// The ToolStrip Menu Item for using Encryption.
        /// </summary>
        /// <param name="sender"> sender </param>
        /// <param name="e"> e </param>
        private void useEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBoxEncryption.Checked)
            {
                checkBoxEncryption.Checked = false;
            }
            else
            {
                checkBoxEncryption.Checked = true;
            }
        }
    }
}
