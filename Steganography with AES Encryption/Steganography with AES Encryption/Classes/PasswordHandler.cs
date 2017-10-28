using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Steganography_with_AES_Encryption
{
    class PasswordHandler
    {
        private string password;
        private byte[] encryptionKey;

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

        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
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
