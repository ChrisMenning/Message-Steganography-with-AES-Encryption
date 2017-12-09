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
    using System.Windows.Forms;

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

        /// <summary>
        /// Calculates the maxLength for the input textbox, based on image dimensions.
        /// </summary>
        /// <returns>An integer</returns>
        public int CalcMax()
        {
            int ret = 0;

            if (Main.GetCheckedEncrypt() == false)
            {
                // Without encryption, it's just the (total pixels / 2) minus the 32 bits reserved for storing
                // information about the length of the message.
                ret = ((this.Width * this.Height) / 2) - 32;
            }
            else
            {
                // With encryption, this calculation is experimental. It is not based on anything but the observed effects
                // of experimenting with how many characters could fit in the 32x32 crab.
                ret = ((((this.Width * this.Height) / 2) - 32) / 10) - 2;
            }

            Console.WriteLine(ret);
            return ret;
        }

        /// <summary>
        /// Calculates the number of characters left. Used for displaying on main form. Called with each keystroke.
        /// </summary>
        /// <returns>An integer.</returns>
        public int CalcRemainingSpace()
        {
            int ret = 0;
            ret = CalcMax() - Main.GetTextBoxInput().Text.Length;

            // If the textbox already holds more than the new maximum, truncate it.
            if (Main.GetTextBoxInput().Text.Length > Main.GetTextBoxInput().MaxLength)
            {
                MessageBox.Show("Your message is too long to fit in the image. It has been truncated to fit. \n" + 
                    "If you would like to hide the whole message, please choose a larger image.", "Message Too Long", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main.GetTextBoxInput().Text = Main.GetTextBoxInput().Text.Substring(0, Main.GetTextBoxInput().MaxLength);
            }

            return ret;
        }

    }
}
