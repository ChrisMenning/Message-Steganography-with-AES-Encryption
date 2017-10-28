//----------------------------------------------------------------------------------
// <copyright file="AESencrypt.cs" company="Legendary Lichens">
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
     * To use this class, instantiate a new AESencrypt object and pass in the raw message and a password.
     * The encoded message is retrieved using the AESencrypt object's EncryptedMessage byte array.
     * 
     * References: 
     * https://msdn.microsoft.com/en-us/library/system.security.cryptography.aes(v=vs.110).aspx
     */

    /// <summary>
    /// The AESEncrypt class.
    /// </summary>
    public class AESEncrypt
    {
        /// <summary>
        /// The rawMessage string.
        /// </summary>
        private string rawMessage;

        /// <summary>
        /// The password string.
        /// </summary>
        private string password;

        /// <summary>
        /// The key used for the AES encryption.
        /// </summary>
        private byte[] AESkey;

        /// <summary>
        /// The encryptedMessage bytes array.
        /// </summary>
        private byte[] encryptedMessage;

        /// <summary>
        /// Initializes a new instance of the AESEncrypt class.
        /// </summary>
        /// <param name="inputMessage">The raw message.</param>
        /// <param name="inputPassword">The password.</param>
        public AESEncrypt(string inputMessage, string inputPassword)
        {
            this.rawMessage = inputMessage;
            this.password = inputPassword;

            // Instantiate a new PasswordHandler.
            PasswordHandler passwordHandler = new PasswordHandler(this.password);

            // Set up the AESkey to be used later, using the PasswordHandler.
            this.AESkey = passwordHandler.CreateKey(this.password);
        }

        /// <summary>
        /// Gets or sets the encryptedMessage field.
        /// </summary>
        public byte[] EncryptedMessage
        {
            get
            {
                return this.encryptedMessage;
            }

            set
            {
                this.encryptedMessage = value;
            }
        }

        /// <summary>
        /// Accepts plainText, the key byte array, and the IV byte array, and returns an encrypted byte array.
        /// </summary>
        /// <param name="plainText">The plainText</param>
        /// <param name="key">The secret key</param>
        /// <param name="IV">The initialization vector</param>
        /// <returns>Byte array</returns>
        private static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            byte[] encrypted;

            // Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream memoryStreamEncrypt = new MemoryStream())
                {
                    using (CryptoStream cryptoStreamEncrypt = new CryptoStream(memoryStreamEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriterEncrypt = new StreamWriter(cryptoStreamEncrypt))
                        {
                            // Write all data to the stream.
                            streamWriterEncrypt.Write(plainText);
                        }

                        encrypted = memoryStreamEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        /// <summary>
        /// Accepts the message string and the AES key and encrypts the message.
        /// </summary>
        private void EncryptMessage()
        {
            try
            {
                // Create a new instance of the Aes class.  
                // This generates a new key and initialization vector (IV).
                using (Aes myAes = Aes.Create())
                {
                    // Encrypt the string to an array of bytes.
                    this.EncryptedMessage = EncryptStringToBytes_Aes(this.rawMessage, this.AESkey, myAes.IV);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}