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
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The Character Compute class
    /// </summary>
    public class CharacterCompute
    {
        private int Width;

        private int Height;

        private FormMain Main;


        public CharacterCompute(int wid, int heigh, FormMain main)
        {
            this.Width = wid;
            this.Height = heigh;
            this.Main = main;
        }

        public int CalcMax()
        {
            int ret = 0;

            if (Main.getCheckedEncrypt() == false)
            {
                ret = ((this.Width * this.Height) / 2) - 32;
            }
            else
            {
                // Note: This calculation is experimental. It is not based on anything but the observed effects
                // of experimenting with how many characters could fit in the 32x32 crab with encryption.
                ret = ((((this.Width * this.Height) / 2) - 32) / 10) - 2;
            }

            Console.WriteLine(ret);
            return ret;
        }

        public int CalcRemainingSpace()
        {
            int ret = 0;
            ret = CalcMax() - Main.getTextBoxInput().Text.Length;

            return ret;
        }

    }
}
