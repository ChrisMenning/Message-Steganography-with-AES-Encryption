//-----------------------------------------------------------------------
// <copyright file="ImageDecoder.cs" company="Legendary Lichens">
//     Copyright (c) Legendary Lichens. All rights reserved.
// </copyright>
// <author>Chris Menning</author>
//-----------------------------------------------------------------------

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The ImageDecoder Class.
    /// </summary>
    public class ImageDecoder
    {
        /// <summary>
        /// The encodedImage Bitmap.
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// The textBoxOutput TextBox.
        /// </summary>
        private TextBox textBoxOutput;

        /// <summary>
        /// The bytesFromImage List of integers.
        /// </summary>
        private List<int> bytesFromImage;

        /// <summary>
        /// The decodedText string.
        /// </summary>
        private string decodedText;

        /// <summary>
        /// Initializes a new instance of the ImageDecoder class.
        /// </summary>
        /// <param name="output">The Textbox where the decoded message is displayed.</param>
        public ImageDecoder(TextBox output)
        {
            this.textBoxOutput = output;
            this.bytesFromImage = new List<int>();
        }

        /// <summary>
        /// Accepts a byte, determines if it is even or odd, and adds either a 1 or 0 to the bytesFromImage list.
        /// </summary>
        /// <param name="colorChannel">A byte that should come from a color channel</param>
        public void LastBitFromColorChannel(byte colorChannel)
        {
            if (colorChannel % 2 == 0)
            {
                this.bytesFromImage.Add(0);
            }
            else
            {
                this.bytesFromImage.Add(1);
            }
        }

        /// <summary>
        /// Accepts a bitmap and decodes the message hidden in the LSB of each color channel of each pixel.
        /// </summary>
        /// <param name="encoded">The bitmap with a hidden message in it.</param>
        public void Decoder(Bitmap encoded)
        {
            Console.WriteLine("Trying to decode");
            this.encodedImage = encoded;

            // Loop through each pixel of the encoded image.
            for (int column = 0; column < this.encodedImage.Width; column++)
            {
                for (int row = 0; row < this.encodedImage.Height; row++)
                {
                    Color pixelColor = this.encodedImage.GetPixel(column, row);

                    // Pull the last bit out of each color channel and concatenate them onto our string.
                    this.LastBitFromColorChannel(pixelColor.R);
                    this.LastBitFromColorChannel(pixelColor.G);
                    this.LastBitFromColorChannel(pixelColor.B);
                }
            }

            int eightCounter = 1;
            string eightDigitByte = string.Empty;

            Queue<string> bytesList = new Queue<string>();

            // Loop through each digit of the bytesFromImage string.
            for (int i = 1; i < this.bytesFromImage.Count; i++)
            {
                // Create new 8-digit groups.
                if (eightCounter <= 8)
                {
                    eightDigitByte += this.bytesFromImage[i - 1].ToString();
                    eightCounter++;
                }

                if (i % 8 == 0)
                {
                    if (eightDigitByte != "00000000")
                    {
                        bytesList.Enqueue(eightDigitByte);
                        eightCounter = 1;
                        eightDigitByte = string.Empty;
                    }
                    else
                    {
                        Console.WriteLine("FOUND THE END OF THE MESSAGE!");
                        bytesList.Enqueue(eightDigitByte);
                        break;
                    }
                }
            }

            // Loop through the list of eight-digit numbers
            foreach (string d in bytesList)
            {
                if (d != "00000000")
                {
                    // Convert the byte string into a char.
                    this.decodedText += (char)Convert.ToByte(d, 2); 
                }
                else
                {
                    // Stop appending bytes to the output string.
                    break;
                }
            }

            // Update the output textbox's text.
            this.textBoxOutput.Text = this.decodedText.ToString();
        }
    }
}
