//----------------------------------------------------------------------------------
// <copyright file="CharacterCompute.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The Password Handler accepts a password string and returns an encryption key as a bit array.
    /// Some code from Stack Overflow: https://stackoverflow.com/questions/17195969/generating-aes-256-bit-key-value
    /// Password Salt & Hash info on Wikipedia: https://en.wikipedia.org/wiki/PBKDF2
    /// </summary>
    public class PasswordHandler
    {
        private string password;
        private byte[] encryptionKey;

        FormMain main;

        /// <summary>
        /// Gets and sets the password
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        /// <summary>
        /// Gets and sets the EncryptionKey
        /// </summary>
        public byte[] EncryptionKey
        {
            get
            {
                return encryptionKey;
            }

            set
            {
                encryptionKey = value;
            }
        }

        /// <summary>
        /// Initializes a new isntance of the PasswordHandler class.
        /// </summary>
        /// <param name="pw"></param>
        public PasswordHandler(string pw, FormMain main)
        {
            this.main = main;
            this.Password = pw;
            EncryptionKey = CreateKey(pw);
        }

        /// <summary>
        /// Returns a byte array to be used as encryption key.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="keyBytes"></param>
        /// <returns></returns>
        public byte[] CreateKey(string password)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(main.AesBlockSize);
        }

        /// <summary>
        /// The standard salt this program will always use.
        /// </summary>
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };
    }
}