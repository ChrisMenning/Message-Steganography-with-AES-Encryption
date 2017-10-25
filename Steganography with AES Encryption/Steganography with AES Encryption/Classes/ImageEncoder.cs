﻿//-----------------------------------------------------------------------
// <copyright file="ImageEncoder.cs" company="Legendary Lichens">
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
    /// The ImageEncoder Class.
    /// </summary>
    public class ImageEncoder
    {
        /// <summary>
        /// The SaveFileDialog.
        /// </summary>
        private SaveFileDialog saveDialog;

        /// <summary>
        /// The rawImage bitmap.
        /// </summary>
        private Bitmap rawImage;

        /// <summary>
        /// The encodedImage bitmap.
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// The pictureBox that displays the encoded image.
        /// </summary>
        private PictureBox pictureBoxEncoded;

        /// <summary>
        /// The bytesString string.
        /// </summary>
        private string bytesString;

        /// <summary>
        /// Initializes a new instance of the ImageEncoder class.
        /// </summary>
        /// <param name="open">The OpenFileDialog</param>
        /// <param name="save">The SaveFileDialog</param>
        /// <param name="raw">The raw Bitmap</param>
        /// <param name="encoded">The PictureBox that displays the encoded image</param>
        public ImageEncoder(SaveFileDialog save, Bitmap raw, PictureBox encoded)
        {
            this.saveDialog = save;
            this.rawImage = raw;
            this.pictureBoxEncoded = encoded;
            this.bytesString = string.Empty;
        }

        /// <summary>
        /// Accepts a string and encodes it into the new bitmap.
        /// </summary>
        /// <param name="rawText">The unencoded input text</param>
        public void Encoder(string rawText)
        {
            // Declare a bitmap for encoding the image. Make it the same width and height as the original.
            this.encodedImage = new Bitmap(this.rawImage.Width, this.rawImage.Height);

            // Convert the entire rawText into one long string of binary.
            this.StringToBytesQueue(rawText);

            // Declare a counter.
            int counter = 0;

            // Loop through every row and every column of pixels in the original image.
            for (int column = 0; column < this.rawImage.Width; column++)
            {
                for (int row = 0; row < this.rawImage.Height; row++)
                {
                    // Get the precise color value of the pixel at this row and this column.
                    Color pixelColor = this.rawImage.GetPixel(column, row);

                    // Now create a copy of the pixelColor, but with the Least Significant Bit of each color cleared out.
                    Color sanitizedColor = Color.FromArgb(
                        pixelColor.A - (pixelColor.A % 2),
                        pixelColor.R - (pixelColor.R % 2),
                        pixelColor.G - (pixelColor.G % 2),
                        pixelColor.B - (pixelColor.B % 2));

                    // Now, in the new bitmap image, let's set the pixel value to be the same as the original pixelColor, plus
                    // a bit from our long string of bytes, for each color channel.
                    if (counter + 2 < this.bytesString.Length)
                    {
                        // Next, declare a newR, newG, and newB consisting of the sanitized value, plus a bit from the byteString.
                        int newA = sanitizedColor.A;
                        int newR = sanitizedColor.R + int.Parse(this.bytesString[counter].ToString());
                        int newG = sanitizedColor.G + int.Parse(this.bytesString[counter + 1].ToString());
                        int newB = sanitizedColor.B + int.Parse(this.bytesString[counter + 2].ToString());

                        this.encodedImage.SetPixel(column, row, Color.FromArgb(newA, newR, newG, newB));
                    }
                    else
                    {
                        // Otherwise just give the image a pixel equal to the original pixel value.
                        this.encodedImage.SetPixel(column, row, pixelColor);
                    }

                    counter = counter + 3;
                }
            }

            this.SaveEncodedImage();
        }

        /// <summary>
        /// Save the new image.
        /// </summary>
        public void SaveEncodedImage()
        {
            // Save the image.
            this.saveDialog.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
            this.saveDialog.Title = "Save an Image File";
            this.saveDialog.ShowDialog();

            if (this.saveDialog.FileName != string.Empty)
            {
                this.encodedImage.Save(this.saveDialog.FileName);
                this.pictureBoxEncoded.Image = this.encodedImage;
            }
        }

        /// <summary>
        /// For testing purposes, output the pixel values to the console.
        /// </summary>
        public void OutputPixelValuesToConsole()
        {
            for (int row = 0; row < this.rawImage.Width; row++)
            {
                for (int col = 0; col < this.rawImage.Height; col++)
                {
                    // Get the precise color value of the pixel at this row and this column.
                    Console.WriteLine(this.encodedImage.GetPixel(row, col));
                }
            }
        }

        /// <summary>
        /// Accept an input string and add them to the byteStrings queue.
        /// </summary>
        /// <param name="input">The string that's passed in.</param>
        private void StringToBytesQueue(string input)
        {
            foreach (char c in input)
            {
                // Convert each char to a binary.
                byte charByte = Convert.ToByte(c);
                string charAsBinaryString = Convert.ToString(charByte, 2).PadLeft(8, '0');

                // Add it to the bytes list.
                this.bytesString += charAsBinaryString;
            }

            // After the message, append the string "00000000" so the decoder can detect the end of the message.
            this.bytesString += "00000000";

            Console.WriteLine("Message as binary = " + this.bytesString);
        }
    }
}
