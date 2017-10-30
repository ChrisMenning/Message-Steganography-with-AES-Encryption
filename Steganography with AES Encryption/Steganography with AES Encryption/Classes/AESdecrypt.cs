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
    /// The AESDecrypt class.
    /// </summary>
    public class AESDecrypt
    {
        /// <summary>
        /// Initializes a new instance of the AESDecrypt class.
        /// </summary>
        public AESDecrypt()
        {
        }

        /// <summary>
        /// Accepts the cipherText, Key, and IV and decrypts the message.
        /// </summary>
        /// <param name="cipherText">The encrypted message.</param>
        /// <param name="key">The Key</param>
        /// <param name="IV">The initialization vector.</param>
        /// <returns>The decrypted string.</returns>
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] IV)
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
            string plaintext = null;

            // Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
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