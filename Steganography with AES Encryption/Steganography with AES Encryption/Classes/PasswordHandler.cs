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
            this.mode = 3;  // By default, set mode to 3 for 256 bits (highest security).
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

/*
 *                                                                                                 
 *                                                            ,,                                   
 *    `7MMF'                                                `7MM                                   
 *      MM                                                    MM                                   
 *      MM         .gP"Ya   .P"Ybmmm .gP"Ya `7MMpMMMb.   ,M""bMM   ,6"Yb.  `7Mb,od8 `7M'   `MF'    
 *      MM        ,M'   Yb :MI  I8  ,M'   Yb  MM    MM ,AP    MM  8)   MM    MM' "'   VA   ,V      
 *      MM      , 8M""""""  WmmmP"  8M""""""  MM    MM 8MI    MM   ,pm9MM    MM        VA ,V       
 *      MM     ,M YM.    , 8M       YM.    ,  MM    MM `Mb    MM  8M   MM    MM         VVV        
 *    .JMMmmmmMMM  `Mbmmd'  YMMMMMb  `Mbmmd'.JMML  JMML.`Wbmd"MML.`Moo9^Yo..JMML.       ,V         
 *                         6'     dP                                                   ,V          
 *                         Ybmmmd'                                                  OOb"           
 *                                                                                                 
 *                  ,,          ,,                                                                 
 *    `7MMF'        db        `7MM                                                                 
 *      MM                      MM                                                                 
 *      MM        `7MM  ,p6"bo  MMpMMMb.  .gP"Ya `7MMpMMMb.  ,pP"Ybd                               
 *      MM          MM 6M'  OO  MM    MM ,M'   Yb  MM    MM  8I   `"                               
 *      MM      ,   MM 8M       MM    MM 8M""""""  MM    MM  `YMMMa.                               
 *      MM     ,M   MM YM.    , MM    MM YM.    ,  MM    MM  L.   I8                               
 *    .JMMmmmmMMM .JMML.YMbmd'.JMML  JMML.`Mbmmd'.JMML  JMML.M9mmmP'                               
 *                                                                                                 
 *                                                                                                 
 */