using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public partial class FormLessChars : Form
    {
        /// <summary>
        /// A string for storing the selected user preference(s).
        /// </summary>
        private string pref;

        /// <summary>
        /// The file path for saving the preference(s).
        /// </summary>
        private string filePath;

        public FormLessChars()
        {
            InitializeComponent();
            this.CenterToParent();
            this.filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\showWarning.txt";
            if (File.Exists(this.filePath))
            {
                this.pref = System.IO.File.ReadAllText(this.filePath);
                if (this.pref == "True")
                {
                    checkBoxShowNextTime.Checked = true;
                }
                else
                {
                    checkBoxShowNextTime.Checked = false;
                }
            }
        }

        private void formLessChars_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SavePreferences();
            this.Close();
        }

        private void checkBoxShowNextTime_CheckedChanged(object sender, EventArgs e)
        {
            SavePreferences();
        }

        /// <summary>
        /// Saves the preferences.
        /// </summary>
        private void SavePreferences()
        {
            File.Delete(this.filePath);
            this.pref = checkBoxShowNextTime.Checked.ToString();
            System.IO.File.WriteAllText(this.filePath, this.pref);
            File.SetAttributes(this.filePath, FileAttributes.Hidden);
        }
    }
}
