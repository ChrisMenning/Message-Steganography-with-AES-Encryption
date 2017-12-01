//----------------------------------------------------------------------------------
// <copyright file="PasswordHandler.cs" company="Legendary Lichens">
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
    /// </summary>
    public class PasswordHandler
    {
        /// <summary>
        /// The standard salt this program will always use.
        /// </summary>
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        /// <summary>
        /// A string for temporarily storing the password.
        /// </summary>
        private string password;

        /// <summary>
        /// A byte array for temporarily storing the encryption key.
        /// </summary>
        private byte[] encryptionKey;

        /// <summary>
        /// A reference to the main form.
        /// </summary>
        private FormMain main;

        /// <summary>
        /// Initializes a new instance of the PasswordHandler class.
        /// </summary>
        /// <param name="pw">The password String</param>
        /// <param name="main">A reference to the main form</param>
        public PasswordHandler(string pw, FormMain main)
        {
            this.main = main;
            this.Password = pw;
            this.EncryptionKey = this.CreateKey(pw);
        }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Gets or sets the EncryptionKey
        /// </summary>
        public byte[] EncryptionKey
        {
            get
            {
                return this.encryptionKey;
            }

            set
            {
                this.encryptionKey = value;
            }
        }

        /// <summary>
        /// Returns a byte array to be used as encryption key.
        /// </summary>
        /// <param name="password">The password as a string</param>
        /// <returns>A byte array</returns>
        public byte[] CreateKey(string password)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(this.main.AesKeySize);
        }
    }
}