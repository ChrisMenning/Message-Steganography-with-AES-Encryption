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

        public Bitmap generateGradient(int height, int width, double xMax, double xMin, double yMax, double yMin)
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
            double xzoom = ((xMax - xMin) / Convert.ToDouble(gradient.Width) - 1);
            double yzoom = ((yMax - yMin) / Convert.ToDouble(gradient.Height) - 1);
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

                    while ((zx * zx) + (zy * zy) <= 4 && loopgo < 64)
                    {

                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx; //width = width*2 - height*2 + width cx
                        zy = (2 * tempzx * zy) + cy; //height= 2*width*height + height cy

                        loopgo++;
                    }
                   
                    gradient.SetPixel(x, y, Color.FromArgb(loopgo % 128 * 2, loopgo % 32 * 7, loopgo % 16 * 14));

                    cy += yzoom;

                }

                cx += xzoom;
            }
            return gradient;

        }
    }
}

