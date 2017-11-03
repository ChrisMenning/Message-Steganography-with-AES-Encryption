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

        /// <summary>
        /// Declare a bitmap for the encoded image
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// Declare the image encoder.
        /// </summary>
        private ImageEncoder imgEnc;

        /// <summary>
        /// Declare the image decoder
        /// </summary>
        private ImageDecoder imgDec;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class 
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Method to open image
        /// </summary>
        /// <param name="sender">The object that initiates this event</param>
        /// <param name="e">The event arguments</param>
        private void ButtonOpenImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.rawImage = new Bitmap(Bitmap.FromFile(this.openFileDialog1.FileName));
                this.pictureBoxRaw.Image = this.rawImage;

                // Instantiate the Image Encoder and the Image Decoder.
                this.imgEnc = new ImageEncoder(this.rawImage, this.pictureBoxEncoded);

                // Turn on encode button.
                this.buttonEncodeImage.Enabled = true;
            }
        }

        /// <summary>
        /// Method to encode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void ButtonEncodeImage_Click(object sender, EventArgs e)
        {
            // Call the image encoder's main encoder method, passing in the text from the input box,
            // return the encoded bitmap, and assign the encoded bitmap to this.encodedImage for later saving.
            this.encodedImage = this.imgEnc.Encoder(this.textBoxInputMessage.Text);

            // Save the image.
            SaveEncodedImage();
        }

        /// <summary>
        /// Method used to open image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void ButtonOpenImage2_Click(object sender, EventArgs e)
        {
           this.openFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.encodedImage = new Bitmap(Bitmap.FromFile(this.openFileDialog1.FileName));
                this.pictureBoxEncoded2.Image = this.encodedImage;
                this.buttonDecode.Enabled = true;
            }
        }

        /// <summary>
        /// Method used to decode image
        /// </summary>
        /// <param name="sender">The object that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            this.imgDec = new ImageDecoder();
            this.textBoxOutput.Text = this.imgDec.Decoder(this.encodedImage);
        }

        /// <summary>
        /// Save the new image.
        /// </summary>
        private void SaveEncodedImage()
        {
            // Save the image.
            saveFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != string.Empty)
            {
                this.encodedImage.Save(saveFileDialog1.FileName);
                this.pictureBoxEncoded.Image = this.encodedImage;
            }
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
    }
}
