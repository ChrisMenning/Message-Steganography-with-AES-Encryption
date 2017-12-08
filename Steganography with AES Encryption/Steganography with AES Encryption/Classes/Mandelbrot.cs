using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography_with_AES_Encryption
{
    public class Mandelbrot
    {
        private double m_Xmin, m_Xmax, m_Ymin, m_Ymax;

        public int MaxIterations;
        public double Zr, Zim, Z2r, Z2im;

        public List<Color> Colors = new List<Color>();

        private Bitmap m_Bm;

        private const double MIN_X = -2.2;
        private const double MAX_X = 1;
        private const double MIN_Y = -1.2;
        private const double MAX_Y = 1.2;

        public Mandelbrot()
        {
            MaxIterations = 64;

            // Create some default colors.
            ResetColors();

            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                Colors.Add(Color.FromArgb(rnd.Next(1, 256), rnd.Next(1, 256), rnd.Next(1, 256)));
            }

            // Display the first Mandelbrot set.
            m_Xmin = MIN_X;
            m_Xmax = MAX_X;
            m_Ymin = MIN_Y;
            m_Ymax = MAX_Y;

            DrawMandelbrot(1000, 1000);
        }

        // Reset the number of colors to 0.
        public void ResetColors()
        {
            Colors = new List<Color>();
        }

        // Draw the Mandelbrot set.
        public Bitmap DrawMandelbrot(int width, int height)
        {
            // Work until the magnitude squared > 4.
            const int MAX_MAG_SQUARED = 4;
            
            // Make a Bitmap to draw on.
            m_Bm = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gr = Graphics.FromImage(m_Bm);

            // Adjust the coordinate bounds to fit.

            // dReaC is the change in the real part
            // (X value) for C. dImaC is the change in the
            // imaginary part (Y value).
            int wid = width;
            int hgt = height;
            double dReaC = (m_Xmax - m_Xmin) / (wid - 1);
            double dImaC = (m_Ymax - m_Ymin) / (hgt - 1);

            // Randomize some values
            Random rnd = new Random();
            Zr = 0;
            Zim = rnd.NextDouble();
            Z2r = rnd.NextDouble();
            Z2im = 0;

            // Calculate the values.
            int num_colors = Colors.Count;
            double ReaC = m_Xmin;
            for (int X = 0; X < wid; X++)
            {
                double ImaC = m_Ymin;
                for (int Y = 0; Y < hgt; Y++)
                {
                    double ReaZ = Zr;
                    double ImaZ = Zim;
                    double ReaZ2 = Z2r;
                    double ImaZ2 = Z2im;
                    int clr = 1;
                    while ((clr < MaxIterations) && (ReaZ2 + ImaZ2 < MAX_MAG_SQUARED))
                    {
                        // Calculate Z(clr).
                        ReaZ2 = ReaZ * ReaZ;
                        ImaZ2 = ImaZ * ImaZ;
                        ImaZ = 2 * ImaZ * ReaZ + ImaC;
                        ReaZ = ReaZ2 - ImaZ2 + ReaC;
                        clr++;
                    }

                    // Set the pixel's value.
                    m_Bm.SetPixel(X, Y, Colors[clr % num_colors]);

                    ImaC += dImaC;
                }
                ReaC += dReaC;
            }
            return m_Bm;
        }
    }
}
