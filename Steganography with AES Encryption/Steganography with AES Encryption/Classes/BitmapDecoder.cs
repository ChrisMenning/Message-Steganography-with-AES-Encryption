//----------------------------------------------------------------------------------
// <copyright file="ImageDecoder.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

// Test comment. 

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The ImageDecoder Class.
    /// </summary>
    public class BitmapDecoder
    {
        /// <summary>
        /// The encodedImage Bitmap.
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// A pre-loaded bitmap used for unit testing.
        /// </summary>
        private Bitmap testImage;

        /// <summary>
        /// The bytesFromImage List of integers.
        /// </summary>
        private List<int> bitsFromImage;

        /// <summary>
        /// The decodedText string.
        /// </summary>
        private StringBuilder decodedText;

        List<string> bytesList;

        /// <summary>
        /// Initializes a new instance of the ImageDecoder class.
        /// </summary>
        public BitmapDecoder()
        {
            this.bitsFromImage = new List<int>();
            this.testImage = Properties.Resources.Tiger;
            this.decodedText = new StringBuilder();
            this.bytesList = new List<string>();
        }

        /// <summary>
        /// Gets or sets the encodedImage property.
        /// </summary>
        public Bitmap EncodedImage
        {
            get
            {
                return this.encodedImage;
            }

            set
            {
                this.encodedImage = value;
            }
        }

        /// <summary>
        /// Gets or sets the testImage property.
        /// </summary>
        public Bitmap TestImage
        {
            get
            {
                return this.testImage;
            }

            set
            {
                this.testImage = value;
            }
        }

        public List<int> BitsFromImage
        {
            get
            {
                return bitsFromImage;
            }
        }

        public List<string> BytesList
        {
            get
            {
                return bytesList;
            }
        }

        /// <summary>
        /// Accepts a byte, determines if it is even or odd, and adds either a 1 or 0 to the bytesFromImage list.
        /// </summary>
        /// <param name="colorChannel">A byte that should come from a color channel</param>
        /// <returns>The last bit of any byte.</returns>
        public int LastBitFromColorChannel(byte colorChannel)
        {
          // Console.WriteLine("Byte from Color Channel: " + colorChannel);
            if (colorChannel % 2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Accepts a bitmap and decodes the message hidden in the LSB of each color channel of each pixel.
        /// </summary>
        /// <param name="encoded">The bitmap with a hidden message in it.</param>
        /// <returns>A string of bits from the bitmap</returns>
        public string Decoder(Bitmap encoded)
        {
          // Console.WriteLine("Trying to decode");
            this.EncodedImage = encoded;

            // Loop through each pixel of the encoded image.
            for (int row = 0; row < this.EncodedImage.Height; row++)
            {
                for (int column = 0; column < this.EncodedImage.Width; column++)
                {
                    Color pixelColor = this.EncodedImage.GetPixel(column, row);

                    // Console.WriteLine("Decoder | Pixel color: " + pixelColor);

                    // Pull the last bit out of each color channel and concatenate them onto the bytesFromImage list.
                    this.bitsFromImage.Add(this.LastBitFromColorChannel(pixelColor.A));
                    this.bitsFromImage.Add(this.LastBitFromColorChannel(pixelColor.R));
                    this.bitsFromImage.Add(this.LastBitFromColorChannel(pixelColor.G));
                    this.bitsFromImage.Add(this.LastBitFromColorChannel(pixelColor.B));
                }
            }

            Console.WriteLine("Decoder finished pulling bits from pixels. Found " + this.bitsFromImage.Count + " bits.");
            Console.WriteLine("Turning bits to bytes");

            string messageLengthByteAsString = string.Empty;
            int messageLength = 0;

            // Get the first 4 bytes (32 bits). This represents the length of the message.
            for (int i = 0; i < 32; i++)
            {
                messageLengthByteAsString += this.bitsFromImage[i].ToString();
            }

            Console.WriteLine("Decoder | First four bytes: " + messageLengthByteAsString);

            // Convert string of binary back into an int.
            messageLength = Convert.ToInt32(messageLengthByteAsString, 2);


            int eightCounter = 1;
            string eightDigitByte = string.Empty;

            Console.WriteLine("Trimming first 32 bits from " + this.bitsFromImage.Count + " bits.");
         
            // Remove first 4 bits from bitsFromImage list.
            for (int i = 0; i < 32; i++)
            {
                this.bitsFromImage.RemoveAt(0);
            }

            Console.WriteLine("bitsFromImage is now " + this.bitsFromImage.Count + " long.");
            Console.WriteLine("Decoder says message should be " + messageLength + " chars long.");

            // Loop through each digit of the bytesFromImage list.
            for (int i = 1; i <= (messageLength * 8); i++)
            {
                // Create new 8-digit groups.
                if (eightCounter <= 8)
                {
                    eightDigitByte += this.bitsFromImage[i -1].ToString();
                    eightCounter++;
                }

                if (i % 8 == 0 && i !=0)
                {
                    bytesList.Add(eightDigitByte);
                    eightCounter = 1;
                    eightDigitByte = string.Empty;
                }
            }

            Console.WriteLine("Finished turning bits to bytes. Found " + bytesList.Count + " bytes.");

            this.decodedText = new StringBuilder();
            for (int i = 0; i < bytesList.Count; i++)
            {
                // Console.WriteLine(bytesList[i]);
                this.decodedText.Append((char)Convert.ToByte(bytesList[i], 2));
            }

            // Update the output textbox's text.
            return this.decodedText.ToString();
        }
    }
}