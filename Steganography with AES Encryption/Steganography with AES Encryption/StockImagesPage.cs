// <copyright file="StockImagesPage.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
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

    /// <summary>
    /// Code for the Stock Images Form.
    /// </summary>
    public partial class FrmStockImagesPage : Form
    {
        /// <summary>
        /// Reference to the Main Form; used to send a copy of user's selected image to the Main Form.
        /// </summary>
        private FormMain main;

        /// <summary>
        /// Instance of the Character Computer.
        /// </summary>
        private CharacterCompute charComp;

        /// <summary>
        /// String variable used to hold and display information on user's selected image in the Rich Text Box on the Stock Images Form.
        /// </summary>
        private string message = string.Empty;

        /// <summary>
        /// Image variable which holds a copy of user's selected stock image.
        /// </summary>
        private Image selectedImage;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmStockImagesPage"/> class.
        /// </summary>
        /// <param name="main">Reference to the Main Form.</param>
        public FrmStockImagesPage(FormMain main)
        {
            this.InitializeComponent();
            this.main = main;
            this.CenterToParent();
        }

        /// <summary>
        /// Click event for the Close Button on the Stock Images Page.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnStockImagesClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method which updates all the information on user's selected image in the Rich Text Box on the form 
        /// and sets the picture in the Picture Box to a copy of user's selected image.
        /// </summary>
        /// <param name="desc">String that holds the description of user's selected image.</param>
        /// <param name="size">String that holds the size of user's selected image.</param>
        /// <param name="img">Image object that holds user's selected image.</param>
        private void DoRepetitiveTasks(string desc, string size, Image img)
        {
            this.message = string.Empty;
            this.message += "Picture Description:\n";
            this.message += desc;
            this.message += "\nSize:\n";
            this.message += size;
            this.rtbStockImage.Text = this.message;
            this.ptbStockImage.Image = img;
            this.selectedImage = img;
            this.charComp = new CharacterCompute(img.Width, img.Height, this.main);
        }

        /// <summary>
        /// Method which runs the DoRepetitiveTasks method whenever a Radio Button on the Stock Images Form is checked;
        /// Passes a String containing the description of the image, a String containing the size of the image,
        /// and the selected image itself to the DoRepetitiveTasks method based in what Radio Buttons are checked
        /// </summary>
        private void AllRadioButtonConditions()
        {
            try
            {
                if (this.rdbDog.Checked && this.rdbLarge.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a cute puppy\n", "Approximately 21.33 Inches by 21.33 Inches", Properties.Resources.Dog_Large);
                }
                else if (this.rdbDog.Checked && this.rdbMedium.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a cute puppy\n", "Approximately 10.67 Inches by 10.67 Inches", Properties.Resources.Dog_Medium);
                }
                else if (this.rdbDog.Checked && this.rdbSmall.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a cute puppy\n", "Approximately 5.33 Inches by 5.33 Inches", Properties.Resources.Dog_Small);
                }
                else if (this.rdbPenguin.Checked && this.rdbLarge.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a group of penguins\n", "Approximately 19.79 Inches by 19.78 Inches", Properties.Resources.Penguin_Large);
                }
                else if (this.rdbPenguin.Checked && this.rdbMedium.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a group of penguins\n", "Approximately 9.9 Inches by 9.9 Inches", Properties.Resources.Penguin_Medium);
                }
                else if (this.rdbPenguin.Checked && this.rdbSmall.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a group of penguins\n", "Approximately 4.95 Inches by 4.95 Inches", Properties.Resources.Penguin_Small);
                }
                else if (this.rdbRocks.Checked && this.rdbLarge.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a cool looking rock\n", "Approximately 41.67 Inches by 23.42 Inches", Properties.Resources.Rocks_Large);
                }
                else if (this.rdbRocks.Checked && this.rdbMedium.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a cool looking rock\n", "Approximately 20.83 Inches by 11.71 Inches", Properties.Resources.Rocks_Medium);
                }
                else if (this.rdbRocks.Checked && this.rdbSmall.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a cool looking rock\n", "Approximately 10.42 Inches by 5.85 Inches", Properties.Resources.Rocks_Small);
                }
                else if (this.rdbTiger.Checked && this.rdbLarge.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a tiger\n", "Approximately 16.67 Inches by 12.5 Inches", Properties.Resources.Tiger_Large);
                }
                else if (this.rdbTiger.Checked && this.rdbMedium.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a tiger\n", "Approximately 8.33 Inches by 6.25 Inches", Properties.Resources.Tiger_Medium);
                }
                else if (this.rdbTiger.Checked && this.rdbSmall.Checked)
                {
                    this.DoRepetitiveTasks(
                        "Picture of a tiger\n", "Approximately 4.17 Inches by 3.13 Inches", Properties.Resources.Tiger_Small);
                }
            }
            catch (Exception ex)
            {
                string error = "There was an error loading a copy of the image into the picturebox: \n" + ex.Message;
                MessageBox.Show(error);
            }
        }

        /// <summary>
        /// Dog Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbDog_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// Penguin Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbPenguin_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// Rocks Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbRocks_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// Tiger Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbTiger_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// Large Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// Medium Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// Small Radio Button Checked Changed Event; Updates Image Information on Stock Images Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void RdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            this.AllRadioButtonConditions();
        }

        /// <summary>
        /// SaveStockImage Button Click Event; Sends a copy of user's selected image to the Main Form
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void BtnSaveStockImage_Click(object sender, EventArgs e)
        {   
            try
            {
                this.main.Pubpicture.Image = this.selectedImage;
                this.main.GetTextBoxInput().MaxLength = this.charComp.CalcMax();
            }
            catch (Exception ex)
            {
                string error = "There was an error trying to save your image: \n" + ex.Message;
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        /// <summary>
        /// Stock Images Page Form Load Event; checks the Large Radio Button when the form loads so a
        /// Radio Button in both Group Boxes (Images and Size) are checked, preventing a bug where
        /// an Image is selected but not a specific Size, which would crash the program if they user tried to
        /// Open an image without a Size selected
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void FrmStockImagesPage_Load(object sender, EventArgs e)
        {
            this.rdbLarge.Checked = true;
        }
    }
}
