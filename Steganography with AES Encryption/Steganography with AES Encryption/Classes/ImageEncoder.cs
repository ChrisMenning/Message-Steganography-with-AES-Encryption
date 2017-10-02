using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public class ImageEncoder
    {
        // Declare our private fields.
        private OpenFileDialog openDialog;
        private SaveFileDialog saveDialog;
        private Bitmap rawImage;
        private Bitmap encodedImage;
        private PictureBox PictureBoxEncoded;

        public ImageEncoder(OpenFileDialog open, SaveFileDialog save, Bitmap raw, PictureBox encoded)
        {
            this.openDialog = open;
            this.saveDialog = save;
            this.rawImage = raw;
            this.PictureBoxEncoded = encoded;
        }

        // The Encoder method can accept pretty much any string. 
        public void Encoder(string rawText)
        {
            /*
             * HOW IT WORKS:
             * 
             * Loop through each character of the rawText string. Convert the char into ASCII values
             * between 000-127, then, digit-by-digt, add those digits to an array.
             * 
             * Then loop through every row of pixels and every column of pixels in the image, and 
             * change the Alpha Channel value of each pixel according to the digits from the array.
             * 
             * In RGBA color space, a pixel has a Red, a Green, A Blue, and an Alpha value. The Alpha
             * is displayed as transparency. If we modify the transparency of individual pixels a very
             * small amount, we can encode information that is virtually invisible.
             * 
             * The concept is loosely based on this tutorial: 
             * http://www.c-sharpcorner.com/UploadFile/6f0898/simple-steganography-encryption-and-decryption-huge-message/
             * 
             */

            // Declare a bitmap for encoding the image. Make it the same width and height as the original.
            encodedImage = new Bitmap(rawImage.Width, rawImage.Height);

            // Declare a list of ints for storing the ints derived from the raw message string.
            List<int> ASCII = new List<int>();

            // Loop through each individual character of the input text, convert them to a 3-digit number
            foreach (char c in rawText)
            {
                // Conver the char to its ASCII value, which is an int somewhere between 0 and 127.
                int asciiValue = Convert.ToInt16(c);
                //Console.WriteLine("ASCII value of " + c + ": " + asciiValue);

                // Declare a temporary string for holding all of the digits in the asciiValue integer.
                string avAsString = asciiValue.ToString();

                // If the number is less than 3 digits long, add 0s to the beginning. Ex: "3" becomes "003", 
                // "42" becomes "042". This will make it easier to decode the ASCII back out of the image again.
                if (avAsString.Length == 1)
                {
                    avAsString = "00" + avAsString; // Tack on two 0s to the beginning of this one digit number.
                }
                else if (avAsString.Length == 2)
                {
                    avAsString = "0" + avAsString; // Tack on one 0 to the beginning of this two-digit number.
                }

                // Loop through each character in the string. 
                for (int d = 0; d < avAsString.Length; d++)
                {
                    // Add each digit to the ASCII string list.
                    ASCII.Add(Int32.Parse(avAsString[d].ToString()));
                }
            }

            // Declare a counter.
            int counter = 0;

            // Loop through every row and every column of pixels in the original image.
            for (int row = 0; row < rawImage.Width; row++)
            {
                for (int col = 0; col < rawImage.Height; col++)
                {
                    // Get the precise color value of the pixel at this row and this column.
                    Color pixelColor = rawImage.GetPixel(row, col);

                    // Now, in the new bitmap image, let's set the pixel value, but modify the pixel's alpha channel (transparency) to
                    // contain an ASCII character from our list.
                    if (counter < ASCII.Count)
                    {
                        // Set the Alpha Channel value to 255 minus the small single-digit value from the ASCII int list.
                        encodedImage.SetPixel(row, col, Color.FromArgb(255 - ASCII[counter], pixelColor));
                    }
                    else
                    {
                        encodedImage.SetPixel(row, col, Color.FromArgb(255, pixelColor));
                    }

                    counter++;
                }
            }

            saveEncodedImage();
        }

        void saveEncodedImage()
        {
            // Save the image.
            saveDialog.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            saveDialog.Title = "Save an Image File";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                encodedImage.Save(saveDialog.FileName);

                PictureBoxEncoded.Image = encodedImage;
            }
        }
    }
}
