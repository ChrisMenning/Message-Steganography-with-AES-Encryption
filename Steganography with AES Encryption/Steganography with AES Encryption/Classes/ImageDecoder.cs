using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public class ImageDecoder
    {
        Bitmap encodedImage;
        TextBox TextBoxOutput;

        public ImageDecoder(TextBox output)
        {
            this.TextBoxOutput = output;
        }

        public void Decoder(Bitmap encoded)
        {
            encodedImage = encoded;
            // Declare an int for holding the temporary ASCII value of a character.
            string charValue = "";

            // Declare a string for storing the encoded text.
            string encodedText = "";

            // Declare a list of ints for storing our ASCII character values as they are pulled out of image.
            List<int> ASCII = new List<int>();

            List<string> threeDigits = new List<string>();


            // Loop through each pixel of the encoded image.
            for (int row = 0; row < encodedImage.Width; row++)
            {
                for (int col = 0; col < encodedImage.Height; col++)
                {
                    Color pixelColor = encodedImage.GetPixel(row, col);

                    // Strip the ASCII value out of the pixel's Alpha channel value, and add it to the list.
                    // 255 is the default Alpha channel value.

                    ASCII.Add(255 - pixelColor.A);
                }
            }

            int threeCounter = 1;
            string threeDigitNumber = "";

            // Loop through all single-digit ints in the ASCII array.
            for (int i = 1; i < ASCII.Count; i++)
            {
                // Create new 3-digit groups.
                if (threeCounter <= 3)
                {
                    threeDigitNumber += ASCII[i - 1].ToString();
                    threeCounter++;
                }

                if (i % 3 == 0)
                {
                    if (threeDigitNumber != "000")
                    {
                        Console.WriteLine("Three digit ASCII value = " + threeDigitNumber);

                        threeDigits.Add(threeDigitNumber);
                        threeCounter = 1;
                        threeDigitNumber = "";
                    }
                }
            }
            Console.WriteLine("There are " + threeDigits.Count + " in the list to be decoded.");

            // Loop through the list of three-digit numbers
            foreach (string d in threeDigits)
            {
                Console.WriteLine(d);

                // Append this char to the output string.
                encodedText += (char)(Int32.Parse(d)); // Convert the ASCII characterValue into character.
            }
            TextBoxOutput.Text = encodedText.ToString();
        }
    }
}
