using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography_with_AES_Encryption
{
    public class JpegEncoder
    {
        private Image rawJpeg;
        private Image testImage;

        /// <summary>
        /// Gets and sets the testImage property.
        /// </summary>
        public Image TestImage
        {
            get
            {
                return testImage;
            }

            set
            {
                testImage = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the JpegEncoder class.
        /// </summary>
        public JpegEncoder()
        {
            // By default, the rawJpeg used is a test image.
            this.TestImage = Properties.Resources.IMG_1650; // A JPG file
            this.rawJpeg = testImage;
        }

        /// <summary>
        /// An overloaded constructor of the JpegEncoder that accepts an image.
        /// </summary>
        /// <param name="img"></param>
        public JpegEncoder(Image img)
        {
            // When an image is passed in, that is the image used instead of the testimage.
            // By default, the rawJpeg used is a test image.
            this.rawJpeg = img;
            this.TestImage = Properties.Resources.IMG_1650;
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
