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
        FormMain main;
        CharacterCompute charComp;
        public frmStockImagesPage(FormMain main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnStockImagesClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDog_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap image;
            String message = "";
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }

            }
            catch(Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }

        }

        private void rdbPenguin_CheckedChanged(object sender, EventArgs e)
        {
            String message = "";
            Bitmap image;
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
            }

            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }
        }

        private void rdbRocks_CheckedChanged(object sender, EventArgs e)
        {
            String message = "";
            Bitmap image;
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);

                }
            }
            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }
        }

        private void rdbTiger_CheckedChanged(object sender, EventArgs e)
        {
            String message = "";
            Bitmap image;
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);

                }
            }
            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            String message = "";
            Bitmap image;
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);

                }
            }
            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            String message = "";
            Bitmap image;
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);

                }
            }
            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            String message = "";
            Bitmap image;
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 21.33 Inches by 21.33 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.67 Inches by 10.67 Inches";
                    rtbStockImage.Text = message;
                    image = Properties.Resources.Dog_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "Approximately 5.33 Inches by 5.33 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                    image = Properties.Resources.Dog_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 19.79 Inches by 19.78 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 9.9 Inches by 9.9 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.95 Inches by 4.95 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                    image = Properties.Resources.Penguin_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 41.67 Inches by 23.42 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 20.83 Inches by 11.71 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "Approximately 10.42 Inches by 5.85 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                    image = Properties.Resources.Rocks_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 16.67 Inches by 12.5 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Large;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 8.33 Inches by 6.25 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Medium;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "Approximately 4.17 Inches by 3.13 Inches";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                    image = Properties.Resources.Tiger_Small;
                    charComp = new CharacterCompute(image.Width, image.Height, main);
                }
            }
            catch (Exception ex)
            {
                String error = "There was an error accessing loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);

            }

        }

        private void btnSaveStockImage_Click(object sender, EventArgs e)
        {
               
            try
            {
                if (rdbDog.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Dog_Large;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Dog_Medium;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Dog_Small;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                }
                else if (rdbPenguin.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Penguin_Large;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Penguin_Medium;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Penguin_Small;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                }
                else if (rdbRocks.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Rocks_Large;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Rocks_Medium;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Rocks_Small;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                }
                else if (rdbTiger.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Tiger_Large;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Tiger_Medium;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Tiger_Small;
                        main.getTextBoxInput().MaxLength = charComp.CalcMax();
                    }
                }
            }
            catch (Exception ex)
            {
                String error = "There was an error trying to save your image: \n" + ex.Message;
                MessageBox.Show(error);
            }
        }

        private void frmStockImagesPage_Load(object sender, EventArgs e)
        {
            rdbLarge.Checked = true;
        }
    }
}
