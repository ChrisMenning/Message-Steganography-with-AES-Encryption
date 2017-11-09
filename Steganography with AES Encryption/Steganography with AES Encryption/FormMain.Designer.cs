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
        private System.Windows.Forms.OpenFileDialog dialogOpenRawImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.SaveFileDialog dialogSaveImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.Button btnEncodeImage;

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
        private System.Windows.Forms.Button btnDecode;

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
            this.labelCharLimit = new System.Windows.Forms.Label();
            this.btnEncodeImage = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInputMessage = new System.Windows.Forms.TextBox();
            this.labelEncodedImage = new System.Windows.Forms.Label();
            this.labelRawImage = new System.Windows.Forms.Label();
            this.pictureBoxEncoded = new System.Windows.Forms.PictureBox();
            this.pictureBoxRaw = new System.Windows.Forms.PictureBox();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.checkBoxEncryption = new System.Windows.Forms.CheckBox();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.labelDecodedMessage = new System.Windows.Forms.Label();
            this.labelEncodedImage2 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.pictureBoxEncoded2 = new System.Windows.Forms.PictureBox();
            this.buttonOpenImage2 = new System.Windows.Forms.Button();
            this.dialogOpenRawImage = new System.Windows.Forms.OpenFileDialog();
            this.dialogSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.btnAboutPageTest = new System.Windows.Forms.Button();
            this.btnHelpPageTest = new System.Windows.Forms.Button();
            this.btnFractalGeneratorTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUnencodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateFractalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEncodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openEncodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDecodedMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useEncryptionslowerButMoreSecureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxEncode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEncode
            // 
            this.groupBoxEncode.Controls.Add(this.labelCharLimit);
            this.groupBoxEncode.Controls.Add(this.btnEncodeImage);
            this.groupBoxEncode.Controls.Add(this.labelInput);
            this.groupBoxEncode.Controls.Add(this.textBoxInputMessage);
            this.groupBoxEncode.Controls.Add(this.labelEncodedImage);
            this.groupBoxEncode.Controls.Add(this.labelRawImage);
            this.groupBoxEncode.Controls.Add(this.pictureBoxEncoded);
            this.groupBoxEncode.Controls.Add(this.pictureBoxRaw);
            this.groupBoxEncode.Controls.Add(this.buttonOpenImage);
            this.groupBoxEncode.Location = new System.Drawing.Point(12, 57);
            this.groupBoxEncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEncode.Name = "groupBoxEncode";
            this.groupBoxEncode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEncode.Size = new System.Drawing.Size(611, 430);
            this.groupBoxEncode.TabIndex = 0;
            this.groupBoxEncode.TabStop = false;
            this.groupBoxEncode.Text = "Hide Text in Image";
            // 
            // labelCharLimit
            // 
            this.labelCharLimit.AutoSize = true;
            this.labelCharLimit.Location = new System.Drawing.Point(477, 33);
            this.labelCharLimit.Name = "labelCharLimit";
            this.labelCharLimit.Size = new System.Drawing.Size(119, 17);
            this.labelCharLimit.TabIndex = 9;
            this.labelCharLimit.Text = "Character Limit: n";
            // 
            // btnEncodeImage
            // 
            this.btnEncodeImage.Enabled = false;
            this.btnEncodeImage.Location = new System.Drawing.Point(5, 275);
            this.btnEncodeImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncodeImage.Name = "btnEncodeImage";
            this.btnEncodeImage.Size = new System.Drawing.Size(137, 53);
            this.btnEncodeImage.TabIndex = 8;
            this.btnEncodeImage.Text = "Hide Text in Image";
            this.btnEncodeImage.UseVisualStyleBackColor = true;
            this.btnEncodeImage.Click += new System.EventHandler(this.btnEncodeImage_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(19, 31);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(139, 17);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "Input Message Here:";
            // 
            // textBoxInputMessage
            // 
            this.textBoxInputMessage.Location = new System.Drawing.Point(14, 62);
            this.textBoxInputMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInputMessage.MaxLength = 0;
            this.textBoxInputMessage.Multiline = true;
            this.textBoxInputMessage.Name = "textBoxInputMessage";
            this.textBoxInputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputMessage.Size = new System.Drawing.Size(582, 116);
            this.textBoxInputMessage.TabIndex = 6;
            // 
            // labelEncodedImage
            // 
            this.labelEncodedImage.AutoSize = true;
            this.labelEncodedImage.Location = new System.Drawing.Point(379, 191);
            this.labelEncodedImage.Name = "labelEncodedImage";
            this.labelEncodedImage.Size = new System.Drawing.Size(106, 17);
            this.labelEncodedImage.TabIndex = 5;
            this.labelEncodedImage.Text = "Encoded Image";
            // 
            // labelRawImage
            // 
            this.labelRawImage.AutoSize = true;
            this.labelRawImage.Location = new System.Drawing.Point(150, 191);
            this.labelRawImage.Name = "labelRawImage";
            this.labelRawImage.Size = new System.Drawing.Size(77, 17);
            this.labelRawImage.TabIndex = 4;
            this.labelRawImage.Text = "Raw Image";
            // 
            // pictureBoxEncoded
            // 
            this.pictureBoxEncoded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEncoded.Location = new System.Drawing.Point(382, 216);
            this.pictureBoxEncoded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEncoded.Name = "pictureBoxEncoded";
            this.pictureBoxEncoded.Size = new System.Drawing.Size(214, 203);
            this.pictureBoxEncoded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEncoded.TabIndex = 3;
            this.pictureBoxEncoded.TabStop = false;
            // 
            // pictureBoxRaw
            // 
            this.pictureBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRaw.Location = new System.Drawing.Point(152, 216);
            this.pictureBoxRaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRaw.Name = "pictureBoxRaw";
            this.pictureBoxRaw.Size = new System.Drawing.Size(214, 203);
            this.pictureBoxRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRaw.TabIndex = 2;
            this.pictureBoxRaw.TabStop = false;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(5, 216);
            this.buttonOpenImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(137, 53);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Open Image";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // checkBoxEncryption
            // 
            this.checkBoxEncryption.AutoSize = true;
            this.checkBoxEncryption.Location = new System.Drawing.Point(12, 31);
            this.checkBoxEncryption.Name = "checkBoxEncryption";
            this.checkBoxEncryption.Size = new System.Drawing.Size(291, 21);
            this.checkBoxEncryption.TabIndex = 5;
            this.checkBoxEncryption.Text = "Use Encryption (slower, but more secure)";
            this.checkBoxEncryption.UseVisualStyleBackColor = true;
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.Controls.Add(this.labelDecodedMessage);
            this.groupBoxDecode.Controls.Add(this.labelEncodedImage2);
            this.groupBoxDecode.Controls.Add(this.btnDecode);
            this.groupBoxDecode.Controls.Add(this.textBoxOutput);
            this.groupBoxDecode.Controls.Add(this.pictureBoxEncoded2);
            this.groupBoxDecode.Controls.Add(this.buttonOpenImage2);
            this.groupBoxDecode.Location = new System.Drawing.Point(629, 57);
            this.groupBoxDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDecode.Size = new System.Drawing.Size(611, 430);
            this.groupBoxDecode.TabIndex = 1;
            this.groupBoxDecode.TabStop = false;
            this.groupBoxDecode.Text = "Retrieve Text from Image";
            // 
            // labelDecodedMessage
            // 
            this.labelDecodedMessage.AutoSize = true;
            this.labelDecodedMessage.Location = new System.Drawing.Point(6, 284);
            this.labelDecodedMessage.Name = "labelDecodedMessage";
            this.labelDecodedMessage.Size = new System.Drawing.Size(126, 17);
            this.labelDecodedMessage.TabIndex = 7;
            this.labelDecodedMessage.Text = "Decoded Message";
            // 
            // labelEncodedImage2
            // 
            this.labelEncodedImage2.AutoSize = true;
            this.labelEncodedImage2.Location = new System.Drawing.Point(249, 14);
            this.labelEncodedImage2.Name = "labelEncodedImage2";
            this.labelEncodedImage2.Size = new System.Drawing.Size(106, 17);
            this.labelEncodedImage2.TabIndex = 6;
            this.labelEncodedImage2.Text = "Encoded Image";
            // 
            // btnDecode
            // 
            this.btnDecode.Enabled = false;
            this.btnDecode.Location = new System.Drawing.Point(468, 33);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(137, 53);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode Image";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 303);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(599, 116);
            this.textBoxOutput.TabIndex = 4;
            // 
            // pictureBoxEncoded2
            // 
            this.pictureBoxEncoded2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEncoded2.Location = new System.Drawing.Point(149, 33);
            this.pictureBoxEncoded2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEncoded2.Name = "pictureBoxEncoded2";
            this.pictureBoxEncoded2.Size = new System.Drawing.Size(313, 266);
            this.pictureBoxEncoded2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEncoded2.TabIndex = 3;
            this.pictureBoxEncoded2.TabStop = false;
            // 
            // buttonOpenImage2
            // 
            this.buttonOpenImage2.Location = new System.Drawing.Point(6, 33);
            this.buttonOpenImage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenImage2.Name = "buttonOpenImage2";
            this.buttonOpenImage2.Size = new System.Drawing.Size(137, 52);
            this.buttonOpenImage2.TabIndex = 1;
            this.buttonOpenImage2.Text = "Open Image";
            this.buttonOpenImage2.UseVisualStyleBackColor = true;
            this.buttonOpenImage2.Click += new System.EventHandler(this.btnOpenImage2_Click);
            // 
            // dialogOpenRawImage
            // 
            this.dialogOpenRawImage.FileName = "openFileDialog1";
            // 
            // btnAboutPageTest
            // 
            this.btnAboutPageTest.Location = new System.Drawing.Point(10, 493);
            this.btnAboutPageTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutPageTest.Name = "btnAboutPageTest";
            this.btnAboutPageTest.Size = new System.Drawing.Size(160, 28);
            this.btnAboutPageTest.TabIndex = 2;
            this.btnAboutPageTest.Text = "About Page Test";
            this.btnAboutPageTest.UseVisualStyleBackColor = true;
            this.btnAboutPageTest.Click += new System.EventHandler(this.btnAboutPageTest_Click);
            // 
            // btnHelpPageTest
            // 
            this.btnHelpPageTest.Location = new System.Drawing.Point(194, 493);
            this.btnHelpPageTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelpPageTest.Name = "btnHelpPageTest";
            this.btnHelpPageTest.Size = new System.Drawing.Size(147, 28);
            this.btnHelpPageTest.TabIndex = 3;
            this.btnHelpPageTest.Text = "Help Page Test";
            this.btnHelpPageTest.UseVisualStyleBackColor = true;
            this.btnHelpPageTest.Click += new System.EventHandler(this.btnHelpPageTest_Click);
            // 
            // btnFractalGeneratorTest
            // 
            this.btnFractalGeneratorTest.Location = new System.Drawing.Point(349, 493);
            this.btnFractalGeneratorTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnFractalGeneratorTest.Name = "btnFractalGeneratorTest";
            this.btnFractalGeneratorTest.Size = new System.Drawing.Size(185, 28);
            this.btnFractalGeneratorTest.TabIndex = 4;
            this.btnFractalGeneratorTest.Text = "Fractal Generator Test";
            this.btnFractalGeneratorTest.UseVisualStyleBackColor = true;
            this.btnFractalGeneratorTest.Click += new System.EventHandler(this.btnFractalGeneratorTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUnencodedImageToolStripMenuItem,
            this.generateFractalImageToolStripMenuItem,
            this.saveEncodedImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.openEncodedImageToolStripMenuItem,
            this.saveDecodedMessageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openUnencodedImageToolStripMenuItem
            // 
            this.openUnencodedImageToolStripMenuItem.Name = "openUnencodedImageToolStripMenuItem";
            this.openUnencodedImageToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.openUnencodedImageToolStripMenuItem.Text = "Open Un-encoded Image";
            this.openUnencodedImageToolStripMenuItem.Click += new System.EventHandler(this.openUnencodedImageToolStripMenuItem_Click);
            // 
            // generateFractalImageToolStripMenuItem
            // 
            this.generateFractalImageToolStripMenuItem.Name = "generateFractalImageToolStripMenuItem";
            this.generateFractalImageToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.generateFractalImageToolStripMenuItem.Text = "Generate Fractal Image";
            this.generateFractalImageToolStripMenuItem.Click += new System.EventHandler(this.generateFractalImageToolStripMenuItem_Click);
            // 
            // saveEncodedImageToolStripMenuItem
            // 
            this.saveEncodedImageToolStripMenuItem.Enabled = false;
            this.saveEncodedImageToolStripMenuItem.Name = "saveEncodedImageToolStripMenuItem";
            this.saveEncodedImageToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.saveEncodedImageToolStripMenuItem.Text = "Save Encoded Image";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // openEncodedImageToolStripMenuItem
            // 
            this.openEncodedImageToolStripMenuItem.Name = "openEncodedImageToolStripMenuItem";
            this.openEncodedImageToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.openEncodedImageToolStripMenuItem.Text = "Open Encoded Image";
            // 
            // saveDecodedMessageToolStripMenuItem
            // 
            this.saveDecodedMessageToolStripMenuItem.Enabled = false;
            this.saveDecodedMessageToolStripMenuItem.Name = "saveDecodedMessageToolStripMenuItem";
            this.saveDecodedMessageToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.saveDecodedMessageToolStripMenuItem.Text = "Save Decoded Message";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.selectAllToolStripMenuItem.Text = "Select-All";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedOptionsToolStripMenuItem,
            this.useEncryptionslowerButMoreSecureToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.preferencesToolStripMenuItem.Text = "Settings";
            // 
            // advancedOptionsToolStripMenuItem
            // 
            this.advancedOptionsToolStripMenuItem.Name = "advancedOptionsToolStripMenuItem";
            this.advancedOptionsToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.advancedOptionsToolStripMenuItem.Text = "Advanced Options";
            this.advancedOptionsToolStripMenuItem.Click += new System.EventHandler(this.advancedOptionsToolStripMenuItem_Click);
            // 
            // useEncryptionslowerButMoreSecureToolStripMenuItem
            // 
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.CheckOnClick = true;
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Name = "useEncryptionslowerButMoreSecureToolStripMenuItem";
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Text = "Use Encryption (slower, but more secure)";
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Click += new System.EventHandler(this.useEncryptionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 531);
            this.Controls.Add(this.checkBoxEncryption);
            this.Controls.Add(this.btnFractalGeneratorTest);
            this.Controls.Add(this.btnHelpPageTest);
            this.Controls.Add(this.btnAboutPageTest);
            this.Controls.Add(this.groupBoxDecode);
            this.Controls.Add(this.groupBoxEncode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Steganography with AES Encryption";
            this.groupBoxEncode.ResumeLayout(false);
            this.groupBoxEncode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
            this.groupBoxDecode.ResumeLayout(false);
            this.groupBoxDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnAboutPageTest;
        private System.Windows.Forms.Button btnHelpPageTest;
        private System.Windows.Forms.Button btnFractalGeneratorTest;
        private System.Windows.Forms.CheckBox checkBoxEncryption;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openUnencodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateFractalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEncodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDecodedMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openEncodedImageToolStripMenuItem;
        private System.Windows.Forms.Label labelCharLimit;
        private System.Windows.Forms.ToolStripMenuItem useEncryptionslowerButMoreSecureToolStripMenuItem;
    }
}