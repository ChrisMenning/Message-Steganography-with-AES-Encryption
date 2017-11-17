using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Steganography_with_AES_Encryption.Classes
{
    public class FractalGenerator
    {
       
       public Bitmap generateFractal(int height, int width, double xMax, double xMin, double yMax, double yMin)
        {
            double pXmax = xMax;
            double pXmin = xMin;
            double pYmax = yMax;
            double pYmin = yMin;
            Bitmap fractal = new Bitmap(height, width);

            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            double xzoom = ((xMax - xMin) / Convert.ToDouble(fractal.Width));
            double yzoom = ((yMax - yMin) / Convert.ToDouble(fractal.Height));
            double tempzx = 0;

            int loopgo = 0;
            for (int x = 0; x < fractal.Width; x++)
            {
                cx = (xzoom * x) - Math.Abs(xMin);
                loopgo = 0; //added for gradient
                for (int y = 0; y < fractal.Height; y++)
                {
                    zx = 0;
                    zy = 0;
                    cy = (yzoom * y) - Math.Abs(yMin);
                    //loopgo = 0; Changed for gradient
                    loopgo++;
                    while (zx * zx + zy * zy <= 4 && loopgo < 1000)
                    {
                        loopgo++;
                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = (2 * tempzx * zy) + cy;
                    }

                   //if (loopgo != 1000)Removed for gradient
                        fractal.SetPixel(x, y, Color.FromArgb(loopgo % 128 * 2, loopgo % 32 * 7, loopgo % 16 * 14));
                  // else
                     //  fractal.SetPixel(x, y, Color.Black);
                }
    }
            return fractal;
        }

    }
}
