//----------------------------------------------------------------------------------
// <copyright file="BitmapDecoder.cs" company="Legendary Lichens">
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
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The BitmapDecoder Class.
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

        /// <summary>
        /// A list of bytes.
        /// </summary>
        private List<string> bytesList;

        /// <summary>
        /// Initializes a new instance of the BitmapDecoder class.
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

        /// <summary>
        /// Gets the BitsFromImage property.
        /// </summary>
        public List<int> BitsFromImage
        {
            get
            {
                return this.bitsFromImage;
            }
        }

        /// <summary>
        /// Gets the BytesList property.
        /// </summary>
        public List<string> BytesList
        {
            get
            {
                return this.bytesList;
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

                    // Pull the last bit out of each color channel and concatenate them onto the bitsFromImage list.
                    this.bitsFromImage.Add(pixelColor.A % 2);
                    this.bitsFromImage.Add(pixelColor.R % 2);
                    this.bitsFromImage.Add(pixelColor.G % 2);
                    this.bitsFromImage.Add(pixelColor.B % 2);
                }
            }

            Console.WriteLine("Decoder finished pulling bits from pixels. Found " + this.bitsFromImage.Count + " bits.");
            Console.WriteLine("Turning bits to bytes");

            // Decode the part that says how long the cipher is supposed to be, then delete that part.
            // Also, get the length so it may be passed to the part that converts single bits to 
            // groups of 8-bits (bytes).
            int cipherLength = this.DecodeLengthHeaderAndDeleteIt();

            // Turn bits to bytes and pass in the length of the message.
            this.TurnBitsToBytes(cipherLength);

            Console.WriteLine("Finished turning bits to bytes. Found " + this.bytesList.Count + " bytes.");

            this.decodedText = new StringBuilder();

            for (int i = 0; i < this.bytesList.Count; i++)
            {
                char c = (char)Convert.ToByte(this.bytesList[i], 2);
                this.decodedText.Append(c);
            }

            // Update the output textbox's text.
            return this.decodedText.ToString();
        }

        /// <summary>
        /// Decodes the first 32 bits (4 bytes), which is where the length of the encoded cipher is stored.
        /// Then, those first 32 bits are removed from the string, leaving only the cipher and optional IV.
        /// </summary>
        /// <returns>An integer.</returns>
        private int DecodeLengthHeaderAndDeleteIt()
        {
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

            Console.WriteLine("Trimming first 32 bits from " + this.bitsFromImage.Count + " bits.");

            // Remove first 4 bits from bitsFromImage list.
            for (int i = 0; i < 32; i++)
            {
                this.bitsFromImage.RemoveAt(0);
            }

            Console.WriteLine("bitsFromImage is now " + this.bitsFromImage.Count + " long.");
            Console.WriteLine("Decoder says message should be " + messageLength + " chars long.");

            return messageLength;
        }

        /// <summary>
        /// The long list of bits should be grouped into bytes.
        /// </summary>
        /// <param name="messageLength">An integer.</param>
        private void TurnBitsToBytes(int messageLength)
        {
            int eightCounter = 1;
            string eightDigitByte = string.Empty;

            // Loop through each digit of the bytesFromImage list.
            for (int i = 1; i <= (messageLength * 8); i++)
            {
                // Create new 8-digit groups.
                if (eightCounter <= 8)
                {
                    eightDigitByte += this.bitsFromImage[i - 1].ToString();
                    eightCounter++;
                }

                if (i % 8 == 0 && i != 0)
                {
                    this.bytesList.Add(eightDigitByte);
                    eightCounter = 1;
                    eightDigitByte = string.Empty;
                }
            }
        }
    }
}