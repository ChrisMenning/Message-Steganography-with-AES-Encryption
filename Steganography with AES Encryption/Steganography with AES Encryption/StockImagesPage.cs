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
            try
            {

                String message = "";
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            try
            {
                if (rdbDog.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "2048 X 2048";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "1024 X 1024";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbDog.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cute puppy\n";
                    message += "\nSize:\n";
                    message += "512 X 512";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Dog_Medium;
                }
                else if (rdbPenguin.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "1900 X 1899";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "950 X 950";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbPenguin.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a group of penguins\n";
                    message += "\nSize:\n";
                    message += "475 X 475";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Penguin_Medium;
                }
                else if (rdbRocks.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "4000 X 2248";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "2000 X 1124";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbRocks.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a cool looking rock\n";
                    message += "\nSize:\n";
                    message += "1000 X 562";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Rocks_Medium;
                }
                else if (rdbTiger.Checked && rdbLarge.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "1600 X 1200";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbMedium.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "800 X 600";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
                }
                else if (rdbTiger.Checked && rdbSmall.Checked)
                {
                    message += "Picture Description:\n";
                    message += "Picture of a tiger\n";
                    message += "\nSize:\n";
                    message += "400 X 300";
                    rtbStockImage.Text = message;
                    ptbStockImage.Image = Properties.Resources.Tiger_Medium;
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
            Bitmap image;
            
            try
            {
                if (rdbDog.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Dog_Large;
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Dog_Medium;
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Dog_Small;
                    }
                }
                else if (rdbPenguin.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Penguin_Large;
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Penguin_Medium;
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Penguin_Small;
                    }
                }
                else if (rdbRocks.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Rocks_Large;
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Rocks_Medium;
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Rocks_Small;
                    }
                }
                else if (rdbTiger.Checked)
                {
                    if (rdbLarge.Checked)
                    {
                        main.Pubpicture.Image = Resources.Tiger_Large;
                    }
                    else if (rdbMedium.Checked)
                    {
                        main.Pubpicture.Image = Resources.Tiger_Medium;
                    }
                    else if (rdbSmall.Checked)
                    {
                        main.Pubpicture.Image = Resources.Tiger_Small;
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
