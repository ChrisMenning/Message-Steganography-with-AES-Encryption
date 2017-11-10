//----------------------------------------------------------------------------------
// <copyright file="AESDecrypt.cs" company="Legendary Lichens">
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
    /// The AESDecrypt class.
    /// </summary>
    public class AESDecrypt
    {
        FormMain main;

        /// <summary>
        /// Initializes a new instance of the AESDecrypt class.
        /// </summary>
        public AESDecrypt(FormMain main)
        {
            this.main = main;
        }

        /// <summary>
        /// Accepts the cipherText, Key, and IV and decrypts the message.
        /// </summary>
        /// <param name="cipherText">The encrypted message.</param>
        /// <param name="key">The Key</param>
        /// <param name="IV">The initialization vector.</param>
        /// <returns>The decrypted string.</returns>
        public string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }

            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = string.Empty;

            // Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create("AES"))
            {
                // aesAlg.BlockSize = main.AesBlockSize;
                aesAlg.Key = key;
                aesAlg.IV = IV;

                // aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.Zeros;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(key, IV);

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