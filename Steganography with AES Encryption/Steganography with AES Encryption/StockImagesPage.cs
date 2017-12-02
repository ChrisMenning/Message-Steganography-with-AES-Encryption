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
        private FormMain main;
        private CharacterCompute charComp;
        private String message = "";
        private Image selectedImage;

        public frmStockImagesPage(FormMain main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnStockImagesClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doRepetativeTasks(string desc, string size, Image img)
        {
            message = "";
            message += "Picture Description:\n";
            message += desc;
            message += "\nSize:\n";
            message += size;
            rtbStockImage.Text = message;
            ptbStockImage.Image = img;
            selectedImage = img;
            charComp = new CharacterCompute(img.Width, img.Height, main);
        }

        private void AllRadioButtonConditions()
        {
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    doRepetativeTasks("Picture of a cute puppy\n", "Approximately 21.33 Inches by 21.33 Inches",
                        Properties.Resources.Dog_Large);
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    doRepetativeTasks("Picture of a cute puppy\n", "Approximately 10.67 Inches by 10.67 Inches",
                        Properties.Resources.Dog_Medium);
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    doRepetativeTasks("Picture of a cute puppy\n", "Approximately 5.33 Inches by 5.33 Inches",
                        Properties.Resources.Dog_Small);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    doRepetativeTasks("Picture of a group of penguins\n", "Approximately 19.79 Inches by 19.78 Inches",
                        Properties.Resources.Penguin_Large);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    doRepetativeTasks("Picture of a group of penguins\n", "Approximately 9.9 Inches by 9.9 Inches",
                        Properties.Resources.Penguin_Medium);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    doRepetativeTasks("Picture of a group of penguins\n", "Approximately 4.95 Inches by 4.95 Inches",
                        Properties.Resources.Penguin_Small);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    doRepetativeTasks("Picture of a cool looking rock\n", "Approximately 41.67 Inches by 23.42 Inches",
                        Properties.Resources.Rocks_Large);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    doRepetativeTasks("Picture of a cool looking rock\n", "Approximately 20.83 Inches by 11.71 Inches",
                        Properties.Resources.Rocks_Medium);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    doRepetativeTasks("Picture of a cool looking rock\n", "Approximately 10.42 Inches by 5.85 Inches",
                        Properties.Resources.Rocks_Small);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    doRepetativeTasks("Picture of a tiger\n", "Approximately 16.67 Inches by 12.5 Inches",
                        Properties.Resources.Tiger_Large);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    doRepetativeTasks("Picture of a tiger\n", "Approximately 8.33 Inches by 6.25 Inches",
                        Properties.Resources.Tiger_Medium);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    doRepetativeTasks("Picture of a tiger\n", "Approximately 4.17 Inches by 3.13 Inches",
                        Properties.Resources.Tiger_Small);
                }

            }
            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);
            }

        }

        private void rdbDog_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void rdbPenguin_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void rdbRocks_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void rdbTiger_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtonConditions();
        }

        private void btnSaveStockImage_Click(object sender, EventArgs e)
        {   
            try
            {
                main.Pubpicture.Image = selectedImage;
                main.getTextBoxInput().MaxLength = charComp.CalcMax();
            }
            catch (Exception ex)
            {
                String error = "There was an error trying to save your image: \n" + ex.Message;
                MessageBox.Show(error);
            }
            this.Close();
        }

        private void frmStockImagesPage_Load(object sender, EventArgs e)
        {
            rdbLarge.Checked = true;
        }
    }
}
