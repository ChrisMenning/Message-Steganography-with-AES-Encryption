using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steganography_with_AES_Encryption.Properties;

namespace Steganography_with_AES_Encryption
{
    public partial class frmStockImagesPage : Form
    {
        public frmStockImagesPage()
        {
            InitializeComponent();
        }

        private void rdbTiger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTiger.Checked)
            {
                String message = "Image Description:\n";
                message += "Picture of a Tiger\n";
                rtbStockImages.Text = message;
                
            }
        }

        private void btnSaveStockImage_Click(object sender, EventArgs e)
        {
            Bitmap image;

            if (rdbTiger.Checked)
            {
                image = Resources.Tiger;
                sfdStockImage.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
                sfdStockImage.Title = "Save an Image File";
                sfdStockImage.ShowDialog();

                if (sfdStockImage.FileName != string.Empty)
                {
                    image.Save(sfdStockImage.FileName);
                }
            }
            else if (rdbCrab.Checked)
            {
                image = Resources._32x32_crab;
                sfdStockImage.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
                sfdStockImage.Title = "Save an Image File";
                sfdStockImage.ShowDialog();

                if (sfdStockImage.FileName != string.Empty)
                {
                    image.Save(sfdStockImage.FileName);
                }
            }

            
        }

        private void rdbCrab_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCrab.Checked)
            {
                String message = "Image Description:\n";
                message += "Picture of the Pokemon Krabby";
                rtbStockImages.Text = message;
            }
        }

        private void btnCloseStockImagePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
