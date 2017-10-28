using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography_with_AES_Encryption
{
    class JpegEncoder
    {
        private Image rawJpeg;
        /// <summary>
        /// Initializes a new instance of the JpegEncoder class.
        /// </summary>
        public JpegEncoder(Image jpeg)
        {
            this.rawJpeg = jpeg;
        }

        public void Encoder()
        {
            foreach (byte b in ImageToByte(this.rawJpeg))
            {
                // Search through bytes, looking for FFD9, which marks the end of the image within the file.
                Console.WriteLine(b.ToString());

                if (b.ToString() == "FFD9")
                {
                    Console.WriteLine("Found FFD9!");
                    // begin stuffing data in here.
                }
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
