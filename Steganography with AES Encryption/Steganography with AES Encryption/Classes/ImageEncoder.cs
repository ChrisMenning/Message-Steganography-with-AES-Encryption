//----------------------------------------------------------------------------------
// <copyright file="ImageEncoder.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

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
        /// The rawImage bitmap.
        /// </summary>
        private Bitmap rawImage;

        /// <summary>
        /// The encodedImage bitmap.
        /// </summary>
        private Bitmap encodedImage;

        /// <summary>
        /// The initializationVector byte array from the encrypter.
        /// </summary>
        private byte[] initializationVector;

        /// <summary>
        /// The pictureBox that displays the encoded image.
        /// </summary>
        private PictureBox pictureBoxEncoded;

        /// <summary>
        /// A StringBuilder. Used for ensuring all the zeros are kept when encoding binary into the pixels.
        /// </summary>
        private StringBuilder bytesString;

        /// <summary>
        /// Modes determine which color channels are being encoded. Changed in "Advanced Options."
        /// </summary>
        private int mode;

        /// <summary>
        /// Initializes a new instance of the ImageEncoder class.
        /// </summary>
        /// <param name="raw">The raw Bitmap</param>
        /// <param name="encoded">The PictureBox that displays the encoded image</param>
        public ImageEncoder(Bitmap raw, PictureBox encoded)
        {
            this.rawImage = raw;
            this.pictureBoxEncoded = encoded;
            this.bytesString = new StringBuilder();
            this.mode = 1; // By default.
            this.initializationVector = new byte[0]; // Initialize at 0.
        }

        /// <summary>
        /// Initializes a new instance of the ImageEncoder class, overloaded to accept an initialization
        /// vector as a byte array.
        /// </summary>
        /// <param name="raw">The raw Bitmap</param>
        /// <param name="encoded">The PictureBox that displays the encoded image</param>
        public ImageEncoder(Bitmap raw, PictureBox encoded, byte[] initVect)
        {
            this.rawImage = raw;
            this.pictureBoxEncoded = encoded;
            this.bytesString = new StringBuilder();
            this.mode = 1; // By default.
            this.initializationVector = initVect;
        }

        /// <summary>
        /// Finalizes an instance of the ImageEncoder class.
        /// </summary>
        ~ImageEncoder()
        {
            // Cleanup Statements.
            this.encodedImage.Dispose();
            this.rawImage.Dispose();
            this.bytesString = new StringBuilder();

            GC.ReRegisterForFinalize(this);
        }

        /// <summary>
        /// Accepts a string and encodes it into the new bitmap.
        /// </summary>
        /// <param name="rawText">The unencoded input text</param>
        /// <returns>Bitmap with message hidden in LSB.</returns>
        public Bitmap Encoder(string rawText)
        {
            // Declare a bitmap for encoding the image. Make it the same width and height as the original.
            this.encodedImage = new Bitmap(this.rawImage.Width, this.rawImage.Height);

            // If we're using encryption, then prepend the rawText string with the Initialization Vector.
            if (initializationVector.Length != 0)
            {
                rawText = PrependIV(rawText);
            }

            // Convert the entire rawText into one long string of binary.
            StringBuilder forEncoding = this.StringToBytesString(rawText);

            // Append an empty byte to mark the end of the message.
            forEncoding.Append("00000000");

            // Declare a counter.
            int counter = 0;

            // Loop through every row and every column of pixels in the original image.
            for (int row = 0; row < this.rawImage.Height; row++)
            {
                for (int column = 0; column < this.rawImage.Width; column++)
                {
                    // Get the precise color value of the pixel at this row and this column.
                    Color pixelColor = this.rawImage.GetPixel(column, row);

                    // NOTE: Allowing any encoded pixels to have an alpha value of 0 seems to cause the RGB
                    // elements to zero out as well, if they're as low as 1 or 0. But when the Alpha channel
                    // has a value, the the RGB are retained.

                    // Now create a copy of the pixelColor, but with the Least Significant Bit of each color cleared out.
                    Color sanitizedColor = Color.FromArgb(
                        pixelColor.A - (pixelColor.A % 2),
                        pixelColor.R - (pixelColor.R % 2),
                        pixelColor.G - (pixelColor.G % 2),
                        pixelColor.B - (pixelColor.B % 2));

                    // Now, in the new bitmap image, let's set the pixel value to be the same as the original pixelColor, plus
                    // a bit from our long string of bytes, for each color channel.
                    if (counter + 3 < this.bytesString.Length)
                    {
                        // Next, declare a newR, newG, and newB consisting of the sanitized value, plus a bit from the byteString.
                        int newA = sanitizedColor.A + int.Parse(forEncoding[counter].ToString());
                        int newR = sanitizedColor.R + int.Parse(forEncoding[counter + 1].ToString());
                        int newG = sanitizedColor.G + int.Parse(forEncoding[counter + 2].ToString());
                        int newB = sanitizedColor.B + int.Parse(forEncoding[counter + 3].ToString());

                        this.encodedImage.SetPixel(column, row, Color.FromArgb(newA, newR, newG, newB));

                        // Console.WriteLine("Encoder | Pixel color: " + this.encodedImage.GetPixel(column, row));
                    }
                    else
                    {
                        // Otherwise just give the image a pixel equal to the original pixel value.
                        this.encodedImage.SetPixel(column, row, pixelColor);
                    }

                    counter = counter + 4;
                }
            }

            return this.encodedImage;
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
                    Console.WriteLine(this.encodedImage.GetPixel(col, row));
                }
            }
        }

        /// <summary>
        /// Accept an input string and add them to the byteStrings queue.
        /// </summary>
        /// <param name="input">The string that's passed in.</param>
        private StringBuilder StringToBytesString(string input)
        {
            Console.WriteLine("Input string is " + input.Length + " chars long");

            // Force string to be ASCII in case there is other encoding (UTF-8, etc) contained therein.
            // Non-ASCII chars may be more than one byte long, but this method can only handle one byte at this time.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(input);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);
            input = asciiString;

            this.bytesString.Clear();
            foreach (char c in input)
            {
                // Convert each char to a binary.
                byte charByte = Convert.ToByte(c);
                StringBuilder charAsBinaryString = new StringBuilder();

                charAsBinaryString.Append(Convert.ToString(charByte, 2).PadLeft(8, '0'));
                    

                // Add it to the bytes list.
                this.bytesString.Append(charAsBinaryString);
            }

            return this.bytesString;
        }

        private string PrependIV(string input)
        { 
            // Decalre a temp stringbuilder.
            StringBuilder sb = new StringBuilder();

            // Append each byte of the intialization vector to the new stringbuilder.
            foreach (byte b in initializationVector)
            {
                // Ensure that the byte is encoded as a string of exactly eight 1s and 0s.
                sb.Append(StringToBytesString(b.ToString()));
            }

            // Append the rawText onto the stringbuilder.
            sb.Append(input);

            // Assign the stringbuilder's contents to the rawString.
            return sb.ToString();
        }
    }
}

/*
 *                                                                                                 
 *                                                            ,,                                   
 *    `7MMF'                                                `7MM                                   
 *      MM                                                    MM                                   
 *      MM         .gP"Ya   .P"Ybmmm .gP"Ya `7MMpMMMb.   ,M""bMM   ,6"Yb.  `7Mb,od8 `7M'   `MF'    
 *      MM        ,M'   Yb :MI  I8  ,M'   Yb  MM    MM ,AP    MM  8)   MM    MM' "'   VA   ,V      
 *      MM      , 8M""""""  WmmmP"  8M""""""  MM    MM 8MI    MM   ,pm9MM    MM        VA ,V       
 *      MM     ,M YM.    , 8M       YM.    ,  MM    MM `Mb    MM  8M   MM    MM         VVV        
 *    .JMMmmmmMMM  `Mbmmd'  YMMMMMb  `Mbmmd'.JMML  JMML.`Wbmd"MML.`Moo9^Yo..JMML.       ,V         
 *                         6'     dP                                                   ,V          
 *                         Ybmmmd'                                                  OOb"           
 *                                                                                                 
 *                  ,,          ,,                                                                 
 *    `7MMF'        db        `7MM                                                                 
 *      MM                      MM                                                                 
 *      MM        `7MM  ,p6"bo  MMpMMMb.  .gP"Ya `7MMpMMMb.  ,pP"Ybd                               
 *      MM          MM 6M'  OO  MM    MM ,M'   Yb  MM    MM  8I   `"                               
 *      MM      ,   MM 8M       MM    MM 8M""""""  MM    MM  `YMMMa.                               
 *      MM     ,M   MM YM.    , MM    MM YM.    ,  MM    MM  L.   I8                               
 *    .JMMmmmmMMM .JMML.YMbmd'.JMML  JMML.`Mbmmd'.JMML  JMML.M9mmmP'                               
 *                                                                                                 
 *                                                                                                 
 */