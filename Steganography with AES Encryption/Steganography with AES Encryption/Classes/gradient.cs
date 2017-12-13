//----------------------------------------------------------------------------------
// <copyright file="Gradient.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The Gradient Image class
    /// </summary>
    public class Gradient
    {
        /// <summary>
        /// Method to create the gradient image
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width</param>
        /// <param name="xMax">The max x axis.</param>
        /// <param name="xMin">The min x axis.</param>
        /// <param name="yMax">The max y axis.</param>
        /// <param name="yMin">The min y axis.</param>
        /// <returns>The gradient image.</returns>
        public Bitmap GenerateGradient(int height, int width, double xMax, double xMin, double yMax, double yMin)
        {
            double pXmax = xMax;
            double pXmin = xMin;
            double pYmax = yMax;
            double pYmin = yMin;
            Bitmap gradient = new Bitmap(height, width);

            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            double xzoom = (xMax - xMin) / (Convert.ToDouble(gradient.Width) - 1);
            double yzoom = (yMax - yMin) / (Convert.ToDouble(gradient.Height) - 1);
            double tempzx = 0;
            int loopgo = 0;

            for (int x = 0; x < gradient.Width; x++)
            {
                cx = (xzoom * x) - Math.Abs(xMin);
                loopgo = 0;

                for (int y = 0; y < gradient.Height; y++)
                {
                    zx = 0;
                    zy = 0;
                    cy = (yzoom * y) - Math.Abs(yMin);
                    loopgo++;

                    while ((zx * zx) + (zy * zy) <= 4 && loopgo < 2000)
                    {
                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx; // width = width*2 - height*2 + width cx
                        zy = (2 * tempzx * zy) + cy; // height= 2*width*height + height cy

                        loopgo++;
                    }

                    gradient.SetPixel(x, y, Color.FromArgb(loopgo % (120 * 2), loopgo % (22 * 7), loopgo % (16 * 14)));

                    cy += yzoom;
                }

                cx += xzoom;
            }

            return gradient;
        }
    }
}