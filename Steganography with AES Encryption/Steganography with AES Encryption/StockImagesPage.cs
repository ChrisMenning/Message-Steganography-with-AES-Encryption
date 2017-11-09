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

        private void btnSaveStockImage_Click(object sender, EventArgs e)
        {
            Bitmap image;

            if (rdbTiger.Checked)
            {
                if (cboTiger.SelectedIndex == 0)
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
                else if(cboTiger.SelectedIndex == 1)
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
                else if(cboTiger.SelectedIndex == 2)
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
                
            }
            else if (rdbRocks.Checked)
            {
                if (cboRocks.SelectedIndex == 0)
                {
                    image = Resources.IMG_1650;
                    sfdStockImage.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
                    sfdStockImage.Title = "Save an Image File";
                    sfdStockImage.ShowDialog();
                    if (sfdStockImage.FileName != string.Empty)
                    {
                        image.Save(sfdStockImage.FileName);
                    }
                }
                else if(cboRocks.SelectedIndex == 1)
                {
                    image = Resources.IMG_1650;
                    sfdStockImage.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
                    sfdStockImage.Title = "Save an Image File";
                    sfdStockImage.ShowDialog();
                    if (sfdStockImage.FileName != string.Empty)
                    {
                        image.Save(sfdStockImage.FileName);
                    }
                }
                else if(cboRocks.SelectedIndex == 2)
                {
                    image = Resources.IMG_1650;
                    sfdStockImage.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
                    sfdStockImage.Title = "Save an Image File";
                    sfdStockImage.ShowDialog();
                    if (sfdStockImage.FileName != string.Empty)
                    {
                        image.Save(sfdStockImage.FileName);
                    }
                }
                
            }

            
        }

        private void btnCloseStockImagePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTiger_CheckedChanged(object sender, EventArgs e)
        {
            String message = "Picture Description:\n";
            message += "A close up of a tiger's face";
            Bitmap image = Resources.Tiger;
            ptbStockImages.Image = image;
        }

        private void cboTiger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbTiger.Checked)
            {
                if (cboTiger.SelectedIndex == 0)
                {
                    String message = rtbStockImages.Text;
                    message += "\nSize:\n1600 x 1200";
                    rtbStockImages.Text = message;
                }
                else if(cboTiger.SelectedIndex == 1)
                {
                    String message = rtbStockImages.Text;
                    message += "\nSize:\n800 x 600";
                    rtbStockImages.Text = message;
                }
                else if (cboRocks.SelectedIndex == 2){
                    String message = rtbStockImages.Text;
                    message += "\nSize:\n400 x 300";
                    rtbStockImages.Text = message;
                }
            }
        }

        private void rdbRocks_CheckedChanged(object sender, EventArgs e)
        {
            String message = "Picture Description:\n";
            message += "A picture of some shiny rocks";
            Bitmap image = Resources.IMG_1650;
            ptbStockImages.Image = image;
        }

        private void cboRocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbRocks.Checked)
            {
                if (cboRocks.SelectedIndex == 0)
                {
                    String message = rtbStockImages.Text;
                    message += "\nSize:\n4000 x 2248";
                    rtbStockImages.Text = message;
                }
                else if (cboTiger.SelectedIndex == 1)
                {
                    String message = rtbStockImages.Text;
                    message += "\nSize:\n2000 x 1124";
                    rtbStockImages.Text = message;
                }
                else
                {
                    String message = rtbStockImages.Text;
                    message += "\nSize:\n1000 x 562";
                    rtbStockImages.Text = message;
                }
            }
        }
    }
}
