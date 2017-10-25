using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Steganography_with_AES_Encryption;
using System.Threading.Tasks;


namespace ImageSteganographyWithEncryptionTest
{
    [TestClass]
    public class AEStest
    {
        /* Tests will be built here. Behaviors to be tested include:
         * 1. Will we be testing here to makes sure standard characters are used in the message entered?
         * 2. I'm not actually sure what tests need to be done.
         * Ideas from Chris M:
         * There's a Queue<string> bytesList in the ImageDecoder class that should only ever contain strings of binary numbers.
         * The ImageEncoder has a Color sanitizedColor. The RGB values should always be even numbers, never odd.
         * Check that the alpha channel of every pixel on the rawImage is the same as on the encodedImage.
         */

        // Test that the Decoder object can output a string when fed a bitmap.
        // The Decoder has a built-in tiger image called TestImage.
        [TestMethod]
        public void DecoderOutputStringIsNotNull()
        {

            // arrange
            ImageDecoder id = new ImageDecoder();

            // act
            string decodedMessage = id.Decoder(id.TestImage);

            // assert
            Assert.AreNotEqual(null, decodedMessage);
        }
    }
}
