//----------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace ImageSteganographyWithEncryptionTest
{
    using System;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Steganography_with_AES_Encryption;
    using System.Threading.Tasks;

    [TestClass]
    public class AEStest
    {
        /// <summary>
        /// Test that the encoder will output a bitmap when fed a message.
        /// </summary>
        [TestMethod]
        public void EncoderTest()
        {
            /// <summary>
            /// arrange
            /// </summary>
            string message = "This string is my test message";
            BitmapEncoder be = new BitmapEncoder();
            Bitmap encodedImage;

            /// <summary>
            /// act
            /// </summary>
            encodedImage = be.Encoder(message);

            /// <summary>
            /// assert
            /// </summary>
            Assert.IsNotNull(encodedImage);
        }

        [TestMethod]
        public void thereAndBackAgain()
        {
            /// <summary>
            /// arrange
            /// </summary>
            string message = "This string is my test message";
            BitmapEncoder be = new BitmapEncoder();
            BitmapDecoder bd = new BitmapDecoder();
            Bitmap encodedImage;

            /// <summary>
            /// act
            /// </summary>
            encodedImage = be.Encoder(message);
            string decodedMessage = bd.Decoder(encodedImage);

            /// <summary>
            /// assert
            /// </summary>
            Assert.AreEqual(message, decodedMessage);
        }
    }
}
