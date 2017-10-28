//----------------------------------------------------------------------------------
// <copyright file="AESdecrypt.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /*
     * About:
     * To use this class, instantiate a new AESdecrypt object and pass in the encrypted bytes and a password.
     * The encoded message is retrieved using the AESencrypt object's EncryptedMessage byte array.
     * 
     * References: 
     * https://msdn.microsoft.com/en-us/library/system.security.cryptography.aes(v=vs.110).aspx
     */

    /// <summary>
    /// The AESdecrypt class.
    /// </summary>
    public class AESdecrypt
    {
        /// <summary>
        /// Initializes a new instance of the AESdecrypt class.
        /// </summary>
        public AESdecrypt()
        {
        }

        /// <summary>
        /// Accepts the cipherText, Key, and IV and decrypts the message.
        /// </summary>
        /// <param name="cipherText">The encrypted message.</param>
        /// <param name="Key">The Key</param>
        /// <param name="IV">The initialization vector.</param>
        /// <returns>The decrypted string.</returns>
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }

            if (Key == null || Key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream memoryStreamDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream cryptoStreamDecrypt = new CryptoStream(memoryStreamDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReaderDecrypt = new StreamReader(cryptoStreamDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            plaintext = streamReaderDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}