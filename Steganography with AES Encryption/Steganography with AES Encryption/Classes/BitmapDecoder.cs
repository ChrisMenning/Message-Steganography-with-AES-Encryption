//----------------------------------------------------------------------------------
// <copyright file="ImageDecoder.cs" company="Legendary Lichens">
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
    /// The ImageDecoder Class.
    /// </summary>
    public class ImageDecoder
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
        private List<int> bytesFromImage;

        /// <summary>
        /// The decodedText string.
        /// </summary>
        private string decodedText;

        /// <summary>
        /// Initializes a new instance of the ImageDecoder class.
        /// </summary>
        public ImageDecoder()
        {
            this.bytesFromImage = new List<int>();
            this.TestImage = Properties.Resources.Tiger;
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
                    this.bytesFromImage.Add(this.LastBitFromColorChannel(pixelColor.A));
                    this.bytesFromImage.Add(this.LastBitFromColorChannel(pixelColor.R));
                    this.bytesFromImage.Add(this.LastBitFromColorChannel(pixelColor.G));
                    this.bytesFromImage.Add(this.LastBitFromColorChannel(pixelColor.B));
                }
            }

            int eightCounter = 1;
            string eightDigitByte = string.Empty;

            Queue<string> bytesList = new Queue<string>();

            // Loop through each digit of the bytesFromImage list.
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
            return this.decodedText.ToString();
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