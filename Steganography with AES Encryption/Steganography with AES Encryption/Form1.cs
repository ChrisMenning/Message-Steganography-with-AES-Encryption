/***
 *        __                              __                
 *       / /   ___  ____ ____  ____  ____/ /___ ________  __
 *      / /   / _ \/ __ `/ _ \/ __ \/ __  / __ `/ ___/ / / /
 *     / /___/  __/ /_/ /  __/ / / / /_/ / /_/ / /  / /_/ / 
 *    /_____/\___/\__, /\___/_/ /_/\__,_/\__,_/_/   \__, /  
 *               /____/  __    _      __           /____/   
 *                      / /   (_)____/ /_  ___  ____  _____ 
 *                     / /   / / ___/ __ \/ _ \/ __ \/ ___/ 
 *                    / /___/ / /__/ / / /  __/ / / (__  )  
 *                   /_____/_/\___/_/ /_/\___/_/ /_/____/   
 *                                                          
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public partial class FormMain : Form
    {
        // Declare a bitmap for the raw image.
        private Bitmap rawImage;
        private Bitmap encodedImage;

        // Declare our image encoder and decoder.
        ImageEncoder imgEnc;
        ImageDecoder imgDec;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rawImage = new Bitmap(Bitmap.FromFile(openFileDialog1.FileName));
                pictureBoxRaw.Image = rawImage;

                // Instantiate the Image Encoder and the Image Decoder.
                imgEnc = new ImageEncoder(this.openFileDialog1, this.saveFileDialog1, rawImage, pictureBoxEncoded);

                // Turn on encode button.
                buttonEncodeImage.Enabled = true;
            }
        }

        private void buttonEncodeImage_Click(object sender, EventArgs e)
        {
            imgEnc.Encoder(textBoxInputMessage.Text);
        }

        private void buttonOpenImage2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                encodedImage = new Bitmap(Bitmap.FromFile(openFileDialog1.FileName));
                pictureBoxEncoded2.Image = encodedImage;
                buttonDecode.Enabled = true;
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            imgDec = new ImageDecoder(textBoxOutput);
            imgDec.Decoder(encodedImage);
        }
    }
}
