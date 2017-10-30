﻿//----------------------------------------------------------------------------------
// <copyright file="FormMain.Designer.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//----------------------------------------------------------------------------------

namespace Steganography_with_AES_Encryption
{
    /// <summary>
    /// Main form for user entry
    /// </summary>
    public partial class FormMain
    {
        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.GroupBox groupBoxEncode;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxEncoded;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxRaw;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Button buttonOpenImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.GroupBox groupBoxDecode;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Button buttonEncodeImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Label labelInput;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.TextBox textBoxInputMessage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Label labelEncodedImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Label labelRawImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Button buttonOpenImage2;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Button buttonDecode;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.TextBox textBoxOutput;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxEncoded2;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Label labelDecodedMessage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Label labelEncodedImage2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEncode = new System.Windows.Forms.GroupBox();
            this.buttonEncodeImage = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInputMessage = new System.Windows.Forms.TextBox();
            this.labelEncodedImage = new System.Windows.Forms.Label();
            this.labelRawImage = new System.Windows.Forms.Label();
            this.pictureBoxEncoded = new System.Windows.Forms.PictureBox();
            this.pictureBoxRaw = new System.Windows.Forms.PictureBox();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.labelDecodedMessage = new System.Windows.Forms.Label();
            this.labelEncodedImage2 = new System.Windows.Forms.Label();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.pictureBoxEncoded2 = new System.Windows.Forms.PictureBox();
            this.buttonOpenImage2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnAboutPageTest = new System.Windows.Forms.Button();
            this.btnHelpPageTest = new System.Windows.Forms.Button();
            this.groupBoxEncode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEncode
            // 
            this.groupBoxEncode.Controls.Add(this.buttonEncodeImage);
            this.groupBoxEncode.Controls.Add(this.labelInput);
            this.groupBoxEncode.Controls.Add(this.textBoxInputMessage);
            this.groupBoxEncode.Controls.Add(this.labelEncodedImage);
            this.groupBoxEncode.Controls.Add(this.labelRawImage);
            this.groupBoxEncode.Controls.Add(this.pictureBoxEncoded);
            this.groupBoxEncode.Controls.Add(this.pictureBoxRaw);
            this.groupBoxEncode.Controls.Add(this.buttonOpenImage);
            this.groupBoxEncode.Location = new System.Drawing.Point(9, 10);
            this.groupBoxEncode.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEncode.Name = "groupBoxEncode";
            this.groupBoxEncode.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEncode.Size = new System.Drawing.Size(458, 249);
            this.groupBoxEncode.TabIndex = 0;
            this.groupBoxEncode.TabStop = false;
            this.groupBoxEncode.Text = "Hide Text in Image";
            // 
            // buttonEncodeImage
            // 
            this.buttonEncodeImage.Enabled = false;
            this.buttonEncodeImage.Location = new System.Drawing.Point(4, 188);
            this.buttonEncodeImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncodeImage.Name = "buttonEncodeImage";
            this.buttonEncodeImage.Size = new System.Drawing.Size(103, 24);
            this.buttonEncodeImage.TabIndex = 8;
            this.buttonEncodeImage.Text = "Encode Image";
            this.buttonEncodeImage.UseVisualStyleBackColor = true;
            this.buttonEncodeImage.Click += new System.EventHandler(this.ButtonEncodeImage_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(4, 113);
            this.labelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(106, 13);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "Input Message Here:";
            // 
            // textBoxInputMessage
            // 
            this.textBoxInputMessage.Location = new System.Drawing.Point(4, 129);
            this.textBoxInputMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInputMessage.Multiline = true;
            this.textBoxInputMessage.Name = "textBoxInputMessage";
            this.textBoxInputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputMessage.Size = new System.Drawing.Size(104, 55);
            this.textBoxInputMessage.TabIndex = 6;
            // 
            // labelEncodedImage
            // 
            this.labelEncodedImage.AutoSize = true;
            this.labelEncodedImage.Location = new System.Drawing.Point(282, 27);
            this.labelEncodedImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEncodedImage.Name = "labelEncodedImage";
            this.labelEncodedImage.Size = new System.Drawing.Size(82, 13);
            this.labelEncodedImage.TabIndex = 5;
            this.labelEncodedImage.Text = "Encoded Image";
            // 
            // labelRawImage
            // 
            this.labelRawImage.AutoSize = true;
            this.labelRawImage.Location = new System.Drawing.Point(110, 27);
            this.labelRawImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRawImage.Name = "labelRawImage";
            this.labelRawImage.Size = new System.Drawing.Size(61, 13);
            this.labelRawImage.TabIndex = 4;
            this.labelRawImage.Text = "Raw Image";
            // 
            // pictureBoxEncoded
            // 
            this.pictureBoxEncoded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEncoded.Location = new System.Drawing.Point(284, 47);
            this.pictureBoxEncoded.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEncoded.Name = "pictureBoxEncoded";
            this.pictureBoxEncoded.Size = new System.Drawing.Size(161, 165);
            this.pictureBoxEncoded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEncoded.TabIndex = 3;
            this.pictureBoxEncoded.TabStop = false;
            // 
            // pictureBoxRaw
            // 
            this.pictureBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRaw.Location = new System.Drawing.Point(112, 47);
            this.pictureBoxRaw.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRaw.Name = "pictureBoxRaw";
            this.pictureBoxRaw.Size = new System.Drawing.Size(161, 165);
            this.pictureBoxRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRaw.TabIndex = 2;
            this.pictureBoxRaw.TabStop = false;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(4, 47);
            this.buttonOpenImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(103, 24);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Open Image";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.ButtonOpenImage_Click);
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.Controls.Add(this.labelDecodedMessage);
            this.groupBoxDecode.Controls.Add(this.labelEncodedImage2);
            this.groupBoxDecode.Controls.Add(this.buttonDecode);
            this.groupBoxDecode.Controls.Add(this.textBoxOutput);
            this.groupBoxDecode.Controls.Add(this.pictureBoxEncoded2);
            this.groupBoxDecode.Controls.Add(this.buttonOpenImage2);
            this.groupBoxDecode.Location = new System.Drawing.Point(9, 263);
            this.groupBoxDecode.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDecode.Size = new System.Drawing.Size(458, 245);
            this.groupBoxDecode.TabIndex = 1;
            this.groupBoxDecode.TabStop = false;
            this.groupBoxDecode.Text = "Retrieve Text from Image";
            // 
            // labelDecodedMessage
            // 
            this.labelDecodedMessage.AutoSize = true;
            this.labelDecodedMessage.Location = new System.Drawing.Point(284, 27);
            this.labelDecodedMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDecodedMessage.Name = "labelDecodedMessage";
            this.labelDecodedMessage.Size = new System.Drawing.Size(97, 13);
            this.labelDecodedMessage.TabIndex = 7;
            this.labelDecodedMessage.Text = "Decoded Message";
            // 
            // labelEncodedImage2
            // 
            this.labelEncodedImage2.AutoSize = true;
            this.labelEncodedImage2.Location = new System.Drawing.Point(110, 27);
            this.labelEncodedImage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEncodedImage2.Name = "labelEncodedImage2";
            this.labelEncodedImage2.Size = new System.Drawing.Size(82, 13);
            this.labelEncodedImage2.TabIndex = 6;
            this.labelEncodedImage2.Text = "Encoded Image";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Enabled = false;
            this.buttonDecode.Location = new System.Drawing.Point(4, 184);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(103, 24);
            this.buttonDecode.TabIndex = 5;
            this.buttonDecode.Text = "Decode Image";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(284, 43);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(162, 166);
            this.textBoxOutput.TabIndex = 4;
            // 
            // pictureBoxEncoded2
            // 
            this.pictureBoxEncoded2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEncoded2.Location = new System.Drawing.Point(112, 43);
            this.pictureBoxEncoded2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEncoded2.Name = "pictureBoxEncoded2";
            this.pictureBoxEncoded2.Size = new System.Drawing.Size(161, 165);
            this.pictureBoxEncoded2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEncoded2.TabIndex = 3;
            this.pictureBoxEncoded2.TabStop = false;
            // 
            // buttonOpenImage2
            // 
            this.buttonOpenImage2.Location = new System.Drawing.Point(4, 43);
            this.buttonOpenImage2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenImage2.Name = "buttonOpenImage2";
            this.buttonOpenImage2.Size = new System.Drawing.Size(103, 24);
            this.buttonOpenImage2.TabIndex = 1;
            this.buttonOpenImage2.Text = "Open Image";
            this.buttonOpenImage2.UseVisualStyleBackColor = true;
            this.buttonOpenImage2.Click += new System.EventHandler(this.ButtonOpenImage2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAboutPageTest
            // 
            this.btnAboutPageTest.Location = new System.Drawing.Point(34, 556);
            this.btnAboutPageTest.Name = "btnAboutPageTest";
            this.btnAboutPageTest.Size = new System.Drawing.Size(120, 23);
            this.btnAboutPageTest.TabIndex = 2;
            this.btnAboutPageTest.Text = "About Page Test";
            this.btnAboutPageTest.UseVisualStyleBackColor = true;
            this.btnAboutPageTest.Click += new System.EventHandler(this.btnAboutPageTest_Click);
            // 
            // btnHelpPageTest
            // 
            this.btnHelpPageTest.Location = new System.Drawing.Point(214, 556);
            this.btnHelpPageTest.Name = "btnHelpPageTest";
            this.btnHelpPageTest.Size = new System.Drawing.Size(110, 23);
            this.btnHelpPageTest.TabIndex = 3;
            this.btnHelpPageTest.Text = "Help Page Test";
            this.btnHelpPageTest.UseVisualStyleBackColor = true;
            this.btnHelpPageTest.Click += new System.EventHandler(this.btnHelpPageTest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 616);
            this.Controls.Add(this.btnHelpPageTest);
            this.Controls.Add(this.btnAboutPageTest);
            this.Controls.Add(this.groupBoxDecode);
            this.Controls.Add(this.groupBoxEncode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Steganography";
            this.groupBoxEncode.ResumeLayout(false);
            this.groupBoxEncode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
            this.groupBoxDecode.ResumeLayout(false);
            this.groupBoxDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnAboutPageTest;
        private System.Windows.Forms.Button btnHelpPageTest;
    }
}