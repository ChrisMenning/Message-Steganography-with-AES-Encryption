//----------------------------------------------------------------------------------
// <copyright file="Mandelbrot.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The main method of the mandelbrot.
    /// </summary>
    public class Mandelbrot
    {
        /// <summary>
        /// Declare min X.
        /// </summary>
        private const double MINX = -2.2;

        /// <summary>
        /// Declare max X.
        /// </summary>
        private const double MAXX = 1;

        /// <summary>
        /// Declare min Y.
        /// </summary>
        private const double MINY = -1.2;

        /// <summary>
        /// Declare max Y.
        /// </summary>
        private const double MAXY = 1.2;

        /// <summary>
        /// Declare an integer for iterations.
        /// </summary>
        private int maxIterations;

        /// <summary>
        /// Declare doubles for both reals and both imaginaries.
        /// </summary>
        private double zr, zim, z2r, z2im;

        /// <summary>
        /// Declare a List of colors.
        /// </summary>
        private List<Color> colors = new List<Color>();

        /// <summary>
        /// Declare a bitmap.
        /// </summary>
        private Bitmap emBm;

        /// <summary>
        /// Declare the doubles for mins and maxes.
        /// </summary>
        private double emXmin, emXmax, emYmin, emYmax;

        /// <summary>
        /// Initializes a new instance of the Mandelbrot class.
        /// </summary>
        public Mandelbrot()
        {
            this.maxIterations = 64;

            // Create some default colors.
            this.ResetColors();

            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                this.colors.Add(Color.FromArgb(rnd.Next(1, 256), rnd.Next(1, 256), rnd.Next(1, 256)));
            }

            // Display the first Mandelbrot set.
            this.emXmin = MINX;
            this.emXmax = MAXX;
            this.emYmin = MINY;
            this.emYmax = MAXY;

            this.DrawMandelbrot(1000, 1000);
        }

        /// <summary>
        /// Reset the number of colors to 0.
        /// </summary>
        public void ResetColors()
        {
            this.colors = new List<Color>();
        }

        /// <summary>
        /// Draw the Mandelbrot set.
        /// </summary>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        /// <returns>A bitmap</returns>
        public Bitmap DrawMandelbrot(int width, int height)
        {
            // Work until the magnitude squared > 4.
            const int MAX_MAG_SQUARED = 4;
            
            // Make a Bitmap to draw on.
            this.emBm = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gr = Graphics.FromImage(this.emBm);

            // Adjust the coordinate bounds to fit.

            // dReaC is the change in the real part
            // (X value) for C. dImaC is the change in the
            // imaginary part (Y value).
            int wid = width;
            int hgt = height;
            double dReaC = (this.emXmax - this.emXmin) / (wid - 1);
            double dImaC = (this.emYmax - this.emYmin) / (hgt - 1);

            // Randomize some values
            Random rnd = new Random();
            this.zr = 0;
            this.zim = rnd.NextDouble();
            this.z2r = rnd.NextDouble();
            this.z2im = 0;

            // Calculate the values.
            int num_colors = this.colors.Count;
            double reaC = this.emXmin;
            for (int x = 0; x < wid; x++)
            {
                double iMaC = this.emYmin;
                for (int y = 0; y < hgt; y++)
                {
                    double reaZ = this.zr;
                    double imaZ = this.zim;
                    double reaZ2 = this.z2r;
                    double imaZ2 = this.z2im;
                    int clr = 1;
                    while ((clr < this.maxIterations) && (reaZ2 + imaZ2 < MAX_MAG_SQUARED))
                    {
                        // Calculate Z(clr).
                        reaZ2 = reaZ * reaZ;
                        imaZ2 = imaZ * imaZ;
                        imaZ = ((2 * imaZ) * reaZ) + iMaC;
                        reaZ = reaZ2 - imaZ2 + reaC;
                        clr++;
                    }

                    // Set the pixel's value.
                    this.emBm.SetPixel(x, y, this.colors[clr % num_colors]);

                    iMaC += dImaC;
                }

                reaC += dReaC;
            }

            return this.emBm;
        }
    }
}
