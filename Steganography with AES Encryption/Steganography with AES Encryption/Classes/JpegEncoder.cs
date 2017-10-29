//----------------------------------------------------------------------------------
// <copyright file="JpegEncoder.cs" company="Legendary Lichens">
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

    /// <summary>
    /// The JpegEncoder class. Inserts data after finding the FFD9 token in a JPG file.
    /// </summary>
    public class JpegEncoder
    {
        /// <summary>
        /// The un-encoded JPG image.
        /// </summary>
        private Image rawJpeg;

        /// <summary>
        /// A reference to the JPG image in resources, for testing.
        /// </summary>
        private Image testImage;

        /// <summary>
        /// The bytesString string.
        /// </summary>
        private List<byte> hiddenMessageBytes;

        /// <summary>
        /// Initializes a new instance of the JpegEncoder class.
        /// </summary>
        public JpegEncoder()
        {
            // By default, the rawJpeg used is a test image.
            this.TestImage = Properties.Resources.IMG_1650; // A JPG file
            this.rawJpeg = this.testImage;
            this.hiddenMessageBytes = new List<byte>();
        }

        /// <summary>
        /// Initializes a new instance of the JpegEncoderclass, overloaded to accept an image.
        /// </summary>
        /// <param name="img">The JPG file input.</param>
        public JpegEncoder(Image img)
        {
            // When an image is passed in, that is the image used instead of the testimage.
            // By default, the rawJpeg used is a test image.
            this.rawJpeg = img;
            this.TestImage = Properties.Resources.IMG_1650;
            this.hiddenMessageBytes = new List<byte>();
        }

        /// <summary>
        /// Gets or sets the testImage property.
        /// </summary>
        public Image TestImage
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
        /// The Encoder method looks for the FFD9 token, then inserts the encoded data.
        /// </summary>
        /// <param name="rawText">The text to be encoded.</param>
        /// <returns>An Encoded JPG image.</returns>
        public Image Encoder(string rawText)
        {
            List<byte> firstPartOfFile = new List<byte>();

            // Convert the rawText into an encoded byteString.
            stringToBytesList(rawText);

            int counter = 0;

            // Search the sbytes of the JPEG
            foreach (sbyte sb in ImageToByte(this.rawJpeg))
            {
                // Search through bytes, looking for FFD9, which marks the end of the image within the file.
                Console.WriteLine(sb.ToString());

                // Add the bytes to firstPartOfFile byte list.
                byte unsigned = (byte)sb;
                firstPartOfFile.Add(unsigned);

                // Look for FFD9 "end of image" token.
                unchecked {
                    if (sb == (sbyte)0xFFD9)
                    {
                        Console.WriteLine("Found FFD9!");

                        // At this point, the counter is the line number just before the one where new data
                        // will be inserted.
                        break;
                    }
                }

                // Incremement the counter.
                counter++;
            }

            // TODO: Change all of these nulls to their needed values.

            // Create a byte array of everything after FFD9 until the end of the file.
            List<byte> lastPartOfFile = new List<byte>();

            bool atBeginningOfLastPart = false;
            Console.WriteLine("Trying to identify beginning of last part of file.");
            foreach (sbyte sb in ImageToByte(this.rawJpeg))
            {
                if (atBeginningOfLastPart == true)
                {
                    lastPartOfFile.Add((byte)sb);
                }

                // Look for FFD9 "end of image" token.
                unchecked
                {
                    if (sb == (sbyte)0xFFD9)
                    {
                        atBeginningOfLastPart = true;
                    }
                }  
            }
            Console.WriteLine("Finished compiling last part of file.");

            // Convert this.byteString (hidden message) into a byte array.
            List<byte> hiddenMessage = this.hiddenMessageBytes;

            // Create a third byte array, with the hidden message sandwiched between the first and last parts of the file.
            byte[] newImageBytes = new byte[firstPartOfFile.Count + hiddenMessage.Count + 1 + lastPartOfFile.Count];

            firstPartOfFile.CopyTo(newImageBytes, 0);
            hiddenMessage.CopyTo(newImageBytes, counter + 1);
            lastPartOfFile.CopyTo(newImageBytes, firstPartOfFile.Count + hiddenMessage.Count + 1);

            // Convert newImageBytes into an image.
            Console.WriteLine("Finished encoding message inside JPG file.");
            return (Image)((new ImageConverter()).ConvertFrom(newImageBytes));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /// <summary>
        /// Accept an input string and add them to the byteStrings queue.
        /// </summary>
        /// <param name="input">The string that's passed in.</param>
        private void stringToBytesList(string input)
        {
            foreach (char c in input)
            {
                // Convert each char to a binary.
                byte charByte = Convert.ToByte(c);

                // Add it to the bytes list.
                this.hiddenMessageBytes.Add(charByte);
            }

            Console.WriteLine("Message as binary = " + this.hiddenMessageBytes);
        }
    }
}
