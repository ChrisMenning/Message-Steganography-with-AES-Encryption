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
    public class BitmapEncoder
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
        /// A pre-loaded bitmap used for unit testing.
        /// </summary>
        private Bitmap testImage;

        /// <summary>
        /// The initializationVector byte array from the encrypter.
        /// </summary>
        private byte[] initializationVector;

        /// <summary>
        /// A StringBuilder. Used for ensuring all the zeros are kept when encoding binary into the pixels.
        /// </summary>
        private StringBuilder bytesString;

        /// <summary>
        /// Initializes a new instance of the ImageEncoder class.
        /// For the sake of unit testing, the base constuctor accepts no parameters and 
        /// uses the tiger image.
        /// </summary>
        public BitmapEncoder()
        {
            this.testImage = Properties.Resources.Tiger;
            this.rawImage = this.testImage;
            this.bytesString = new StringBuilder();
            this.initializationVector = new byte[0]; // Initialize at 0.
        }

        /// <summary>
        /// Initializes a new instance of the ImageEncoder class, overloaded to accept a bitmap.
        /// </summary>
        /// <param name="raw">The raw Bitmap</param>
        /// <param name="encoded">The PictureBox that displays the encoded image</param>
        public BitmapEncoder(Bitmap raw)
        {
            this.rawImage = raw;
            this.bytesString = new StringBuilder();
            this.initializationVector = new byte[0]; // Initialize at 0.
        }

        /// <summary>
        /// Initializes a new instance of the ImageEncoder class, overloaded to accept an initialization
        /// vector as a byte array.
        /// </summary>
        /// <param name="raw">The raw Bitmap</param>
        /// <param name="encoded">The PictureBox that displays the encoded image</param>
        public BitmapEncoder(Bitmap raw, byte[] initVect)
        {
            this.rawImage = raw;
            this.bytesString = new StringBuilder();
            this.initializationVector = initVect;
        }

        /// <summary>
        /// Finalizes an instance of the ImageEncoder class.
        /// </summary>
        ~BitmapEncoder()
        {
            Console.WriteLine("!!!! DESTRUCTOR RUNNING !!!!");
            // Cleanup Statements.
            this.encodedImage.Dispose();
            this.rawImage.Dispose();
            this.bytesString.Clear();
     
            GC.ReRegisterForFinalize(this);
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
        /// Accepts a string and encodes it into the new bitmap.
        /// </summary>
        /// <param name="rawText">The unencoded input text</param>
        /// <returns>Bitmap with message hidden in LSB.</returns>
        public Bitmap Encoder(string rawText)
        {
            Console.WriteLine("Encoders's input string is " + rawText.Length + " long.");

            // Get the length of the rawText and convert the int to a byte array.
            // NOTE: an int takes 4 bytes.
            string messageLengthBinaryString = string.Empty;

            // Create a byte array from the rawText.Length, which is an int.
            // Since an int takes 4 bytes, the byte array will be 4 long.
            byte[] rtb = BitConverter.GetBytes(rawText.Length);

            // If the program is running on a LittleEndian machine, reverse the array.
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(rtb);
            }

            // Loop through the array, convert the byte into a binary string, and append onto messageLengthBinaryString.
            for (int i = 0; i < 4; i++)
            {
                messageLengthBinaryString += Convert.ToString(rtb[i], 2).PadLeft(8, '0');
            }

            Console.WriteLine("Encoder | First four bytes: " + messageLengthBinaryString);

            // Append the rawTextLength as a binary string (messageLengthBinaryString) to the message to be encoded.
            // Convert the entire rawText into one long string of binary.
            StringBuilder forEncoding = new StringBuilder();
            forEncoding.Append(messageLengthBinaryString);

            // If we're using encryption, then prepend the Initialization Vector before the forEncoding string.
            if (initializationVector.Length != 0)
            {
                foreach (byte b in initializationVector)
                {
                    forEncoding.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                }

                // Now append the message.
                forEncoding.Append(rawText);          
            }
            else
            {
                forEncoding.Append(this.StringToBytesString(rawText));
            }

            // Console.WriteLine("Encoding " + forEncoding);

            this.bytesString = forEncoding;

            // Declare a bitmap for encoding the image. Make it the same width and height as the original.
            this.encodedImage = new Bitmap(this.rawImage.Width, this.rawImage.Height);

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

                    // Disallow any pixel color channel values from being a true 0 at this point. 
                    Color tempColor = NoZerosAllowed(pixelColor);
                    pixelColor = tempColor;

                    // Now create a copy of the pixelColor, but with the Least Significant Bit of each color cleared out.
                    Color sanitizedColor = Color.FromArgb(
                        pixelColor.A - (pixelColor.A % 2),
                        pixelColor.R - (pixelColor.R % 2),
                        pixelColor.G - (pixelColor.G % 2),
                        pixelColor.B - (pixelColor.B % 2));

                    // Console.WriteLine("Sanitized pixel color: " + sanitizedColor);

                    // Now, in the new bitmap image, set the pixel value to be the same as the original pixelColor, plus
                    // a bit from our long string of bytes, for each color channel.
                    if (counter + 3 < this.bytesString.Length)
                    {
                        // Next, declare a newR, newG, and newB consisting of the sanitized value, plus a bit from the byteString.
                        int newA = sanitizedColor.A + int.Parse(this.bytesString[counter].ToString());
                        int newR = sanitizedColor.R + int.Parse(this.bytesString[counter + 1].ToString());
                        int newG = sanitizedColor.G + int.Parse(this.bytesString[counter + 2].ToString());
                        int newB = sanitizedColor.B + int.Parse(this.bytesString[counter + 3].ToString());

                        this.encodedImage.SetPixel(column, row, Color.FromArgb(newA, newR, newG, newB));
                        // Console.WriteLine(this.encodedImage.GetPixel(column,row));

                    }
                    else
                    {
                        // Otherwise give the image a pixel equal to the sanitized pixel value.
                        this.encodedImage.SetPixel(column, row, sanitizedColor);
                    }

                    counter = counter + 4;
                }
            }

            return this.encodedImage;
        }

        // Don't allow any color channel to have a 0 in its pixel. Instead give it a 2.
        private Color NoZerosAllowed(Color inputColor)
        {
            Color newColor;
            int newA;
            int newR;
            int newG;
            int newB;

            if (inputColor.A == 0)
            {
                newA = 2;
            }
            else
            {
                newA = inputColor.A;
            }

            if (inputColor.R == 0)
            {
                newR = 2;
            }
            else
            {
                newR = inputColor.R;
            }

            if (inputColor.G == 0)
            {
                newG = 2;
            }
            else
            {
                newG = inputColor.G;
            }

            if (inputColor.B == 0)
            {
                newB = 2;
            }
            else
            {
                newB = inputColor.B;
            }

            newColor = Color.FromArgb(newA, newR, newG, newB);

            return newColor;
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
        public StringBuilder StringToBytesString(string input)
        {
            // Console.WriteLine("Input string is " + input.Length + " chars long");

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

            foreach (byte b in initializationVector)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            // Append the rawText onto the stringbuilder.
            sb.Append(input);

            this.bytesString.Append(sb);

            // Assign the stringbuilder's contents to the rawString.
            return sb.ToString();
        }
    }
}