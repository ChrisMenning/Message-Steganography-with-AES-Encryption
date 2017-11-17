using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;


namespace Steganography_with_AES_Encryption.Classes
{
    public class Gradient
    {

        public Bitmap generateFractal(int height, int width, double xMax, double xMin, double yMax, double yMin)
        {
            double pXmax = xMax;
            double pXmin = xMin;
            double pYmax = yMax;
            double pYmin = yMin;
            Bitmap fractal = new Bitmap(height, width);
            Graphics gr = Graphics.FromImage(fractal);

            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            double xzoom = ((xMax - xMin) / Convert.ToDouble(fractal.Width) - 1);
            double yzoom = ((yMax - yMin) / Convert.ToDouble(fractal.Height) - 1);
            double tempzx = 0;

            /* ResetColors();

             Random rnd = new Random();
             for (int i = 0; i < 8; i++)
             {
                 Colors.Add(Color.FromArgb(rnd.Next(1, 256), rnd.Next(1, 256), rnd.Next(1, 256)));
             }

             // Randomize some values
             Random rnd = new Random();
             Zr = 0;
             Zim = rnd.NextDouble();
             Z2r = rnd.NextDouble();
             Z2im = rnd.NextDouble();
             */
            int loopgo = 0;

            for (int x = 0; x < fractal.Width; x++)
            {
                cx = (xzoom * x) - Math.Abs(xMin);
                loopgo = 0;

                for (int y = 0; y < fractal.Height; y++)
                {
                    zx = 0;
                    zy = 0;
                    cy = (yzoom * y) - Math.Abs(yMin);
                    loopgo++;

                    while ((zx * zx) + (zy * zy) <= 4 && loopgo < 64)
                    {

                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx;//width = width*2 - height*2 + width c
                        zy = (2 * tempzx * zy) + cy;//height= 2*width*height + height c

                        loopgo++;
                    }
                    //if (loopgo != 1000)

                    fractal.SetPixel(x, y, Color.FromArgb(loopgo % 128 * 2, loopgo % 32 * 7, loopgo % 16 * 14));

                    //else

                    // fractal.SetPixel(x, y, Color.Red);
                    cy += yzoom;

                }

                cx += xzoom;
            }
            return fractal;

        }

    }
}

