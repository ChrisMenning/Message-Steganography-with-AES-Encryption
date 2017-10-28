using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Steganography_with_AES_Encryption
{
    /// <summary>
    /// The Password Handler accepts a password string and returns an encryption key as a bit array.
    /// Some code from Stack Overflow: https://stackoverflow.com/questions/17195969/generating-aes-256-bit-key-value
    /// Password Salt & Hash info on Wikipedia: https://en.wikipedia.org/wiki/PBKDF2
    /// </summary>
    class PasswordHandler
    {
        private string password;
        private byte[] encryptionKey;

        /// <summary>
        /// Mode 1 = 128 bits / (16 bytes), Mode 2 = 192 bits (24 bytes), Mode 3 = 256 bits (32 bytes).
        /// </summary>
        private int mode;

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
        public PasswordHandler(string pw)
        {
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
            // By default, use 32 bytes (256 bits) for AES key.
            int keyBytes = 32;

            switch (mode)
            {
                case 1:
                    keyBytes = 16;
                    break;
                case 2:
                    keyBytes = 24;
                    break;
                case 3:
                    keyBytes = 32;
                    break;
            }

            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        /// <summary>
        /// The standard salt this program will always use.
        /// </summary>
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

    }
}
