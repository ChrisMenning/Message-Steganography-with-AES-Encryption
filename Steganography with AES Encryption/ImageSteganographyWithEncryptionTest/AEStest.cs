using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        // unit test method
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            // act
            // assert
        }
    }
}
