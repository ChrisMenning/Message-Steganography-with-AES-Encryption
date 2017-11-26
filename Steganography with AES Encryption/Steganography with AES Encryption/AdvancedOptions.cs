﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_with_AES_Encryption
{
    public partial class AdvancedOptions : Form
    {
        FormMain main;

        public AdvancedOptions(FormMain main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton128.Checked)
            {
                main.AesBlockSize = 16;
            }
            else if (radioButton192.Checked)
            {
                main.AesBlockSize = 24;
            }
            else if (radioButton256.Checked)
            {
                main.AesBlockSize = 32;
            }
            Console.WriteLine("Setting AES encryption to " + main.AesBlockSize);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}