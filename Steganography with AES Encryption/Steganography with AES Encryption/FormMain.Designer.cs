//----------------------------------------------------------------------------------
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
        private System.Windows.Forms.OpenFileDialog dialogOpenRawImage;

        /// <summary>
        /// Field identified
        /// </summary>
        private System.Windows.Forms.SaveFileDialog dialogSaveImage;

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
            this.checkBoxEncryption = new System.Windows.Forms.CheckBox();
            this.dialogOpenRawImage = new System.Windows.Forms.OpenFileDialog();
            this.dialogSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.btnAboutPageTest = new System.Windows.Forms.Button();
            this.btnHelpPageTest = new System.Windows.Forms.Button();
            this.btnFractalGeneratorTest = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStockImagesTest = new System.Windows.Forms.Button();
            this.lblLichens = new System.Windows.Forms.Label();
            this.lblOffering = new System.Windows.Forms.Label();
            this.gpbLichens = new System.Windows.Forms.GroupBox();
            this.pcbLichens = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbImageE = new System.Windows.Forms.ComboBox();
            this.cmbTextEncode = new System.Windows.Forms.ComboBox();
            this.cmbImageDecode = new System.Windows.Forms.ComboBox();
            this.cmbTextDecode = new System.Windows.Forms.ComboBox();
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.tbpEncode = new System.Windows.Forms.TabPage();
            this.tbpDecode = new System.Windows.Forms.TabPage();
            this.cmbImage = new System.Windows.Forms.ComboBox();
            this.cmbImageD = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.rtbTextMessage = new System.Windows.Forms.RichTextBox();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
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
            this.lblImageOptions = new System.Windows.Forms.Label();
            this.lblMessageOptions = new System.Windows.Forms.Label();
            this.lblFunctionOptions = new System.Windows.Forms.Label();
            this.chbNoEncrypt = new System.Windows.Forms.CheckBox();
            this.useEncryptionRecommendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noEncryptionLessSecureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unencodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.whatIsAFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.labelDecodedMessage = new System.Windows.Forms.Label();
            this.labelEncodedImage2 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.textBoxOutputMessage = new System.Windows.Forms.TextBox();
            this.pictureBoxEncoded2 = new System.Windows.Forms.PictureBox();
            this.buttonOpenImage2 = new System.Windows.Forms.Button();
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
            this.gpbLichens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLichens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcTab.SuspendLayout();
            this.tbpEncode.SuspendLayout();
            this.tbpDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).BeginInit();
            this.groupBoxEncode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEncryption
            // 
            this.checkBoxEncryption.AutoSize = true;
            this.checkBoxEncryption.Checked = true;
            this.checkBoxEncryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEncryption.Location = new System.Drawing.Point(23, 334);
            this.checkBoxEncryption.Name = "checkBoxEncryption";
            this.checkBoxEncryption.Size = new System.Drawing.Size(235, 21);
            this.checkBoxEncryption.TabIndex = 5;
            this.checkBoxEncryption.Text = "Use Encryption (Recommended)";
            this.checkBoxEncryption.UseVisualStyleBackColor = true;
            // 
            // dialogOpenRawImage
            // 
            this.dialogOpenRawImage.FileName = "openFileDialog1";
            // 
            // btnAboutPageTest
            // 
            this.btnAboutPageTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnAboutPageTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAboutPageTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.btnAboutPageTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.btnAboutPageTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnAboutPageTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutPageTest.Location = new System.Drawing.Point(1044, 334);
            this.btnAboutPageTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutPageTest.Name = "btnAboutPageTest";
            this.btnAboutPageTest.Size = new System.Drawing.Size(160, 28);
            this.btnAboutPageTest.TabIndex = 2;
            this.btnAboutPageTest.Text = "About Page Test";
            this.btnAboutPageTest.UseVisualStyleBackColor = false;
            this.btnAboutPageTest.Click += new System.EventHandler(this.btnAboutPageTest_Click);
            // 
            // btnHelpPageTest
            // 
            this.btnHelpPageTest.Location = new System.Drawing.Point(1044, 378);
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
            this.btnFractalGeneratorTest.Location = new System.Drawing.Point(1006, 307);
            this.btnFractalGeneratorTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnFractalGeneratorTest.Name = "btnFractalGeneratorTest";
            this.btnFractalGeneratorTest.Size = new System.Drawing.Size(185, 28);
            this.btnFractalGeneratorTest.TabIndex = 4;
            this.btnFractalGeneratorTest.Text = "Fractal Generator Test";
            this.btnFractalGeneratorTest.UseVisualStyleBackColor = true;
            this.btnFractalGeneratorTest.Click += new System.EventHandler(this.btnFractalGeneratorTest_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(198, 794);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 28);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStockImagesTest
            // 
            this.btnStockImagesTest.Location = new System.Drawing.Point(1033, 357);
            this.btnStockImagesTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockImagesTest.Name = "btnStockImagesTest";
            this.btnStockImagesTest.Size = new System.Drawing.Size(185, 28);
            this.btnStockImagesTest.TabIndex = 7;
            this.btnStockImagesTest.Text = "Stock Images Test";
            this.btnStockImagesTest.UseVisualStyleBackColor = true;
            // 
            // lblLichens
            // 
            this.lblLichens.AutoSize = true;
            this.lblLichens.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichens.Location = new System.Drawing.Point(422, 30);
            this.lblLichens.Name = "lblLichens";
            this.lblLichens.Size = new System.Drawing.Size(514, 69);
            this.lblLichens.TabIndex = 9;
            this.lblLichens.Text = "Legendary Lichens - 2017";
            // 
            // lblOffering
            // 
            this.lblOffering.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffering.Location = new System.Drawing.Point(429, 99);
            this.lblOffering.Name = "lblOffering";
            this.lblOffering.Size = new System.Drawing.Size(475, 36);
            this.lblOffering.TabIndex = 10;
            this.lblOffering.Text = "Offering Steganography with AES Encription";
            this.lblOffering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbLichens
            // 
            this.gpbLichens.Controls.Add(this.menuStrip1);
            this.gpbLichens.Controls.Add(this.pcbLichens);
            this.gpbLichens.Controls.Add(this.lblLichens);
            this.gpbLichens.Controls.Add(this.lblOffering);
            this.gpbLichens.Controls.Add(this.lblMenu);
            this.gpbLichens.Location = new System.Drawing.Point(26, 12);
            this.gpbLichens.Name = "gpbLichens";
            this.gpbLichens.Size = new System.Drawing.Size(1192, 240);
            this.gpbLichens.TabIndex = 12;
            this.gpbLichens.TabStop = false;
            // 
            // pcbLichens
            // 
            this.pcbLichens.BackgroundImage = global::Steganography_with_AES_Encryption.Properties.Resources.Lichens;
            this.pcbLichens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLichens.Location = new System.Drawing.Point(25, 21);
            this.pcbLichens.Name = "pcbLichens";
            this.pcbLichens.Size = new System.Drawing.Size(241, 210);
            this.pcbLichens.TabIndex = 11;
            this.pcbLichens.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 212);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmbImageE
            // 
            this.cmbImageE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.cmbImageE.FormattingEnabled = true;
            this.cmbImageE.Items.AddRange(new object[] {
            "Upload My Image",
            "Use Stock Image",
            "Create Fractal Image",
            "Create Gradient Image",
            "Download Image - Decode"});
            this.cmbImageE.Location = new System.Drawing.Point(25, 67);
            this.cmbImageE.Name = "cmbImageE";
            this.cmbImageE.Size = new System.Drawing.Size(175, 24);
            this.cmbImageE.TabIndex = 13;
            this.cmbImageE.Text = "Choose Your Image";
            this.cmbImageE.SelectedIndexChanged += new System.EventHandler(this.cmbImageEncode_SelectedIndexChanged);
            this.cmbImageE.Enter += new System.EventHandler(this.getActionList);
            // 
            // cmbTextEncode
            // 
            this.cmbTextEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.cmbTextEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextEncode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTextEncode.FormattingEnabled = true;
            this.cmbTextEncode.Location = new System.Drawing.Point(646, 379);
            this.cmbTextEncode.Name = "cmbTextEncode";
            this.cmbTextEncode.Size = new System.Drawing.Size(203, 31);
            this.cmbTextEncode.TabIndex = 14;
            // 
            // cmbImageDecode
            // 
            this.cmbImageDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.cmbImageDecode.FormattingEnabled = true;
            this.cmbImageDecode.Items.AddRange(new object[] {
            "Upload Image"});
            this.cmbImageDecode.Location = new System.Drawing.Point(470, 87);
            this.cmbImageDecode.Name = "cmbImageDecode";
            this.cmbImageDecode.Size = new System.Drawing.Size(175, 24);
            this.cmbImageDecode.TabIndex = 15;
            this.cmbImageDecode.Text = "Choose Your Image";
            // 
            // cmbTextDecode
            // 
            this.cmbTextDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.cmbTextDecode.FormattingEnabled = true;
            this.cmbTextDecode.Location = new System.Drawing.Point(149, 62);
            this.cmbTextDecode.Name = "cmbTextDecode";
            this.cmbTextDecode.Size = new System.Drawing.Size(175, 24);
            this.cmbTextDecode.TabIndex = 16;
            this.cmbTextDecode.Text = "Retrieve Message";
            // 
            // tbcTab
            // 
            this.tbcTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbcTab.Controls.Add(this.tbpEncode);
            this.tbcTab.Controls.Add(this.tbpDecode);
            this.tbcTab.Location = new System.Drawing.Point(366, 885);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(910, 314);
            this.tbcTab.TabIndex = 17;
            this.tbcTab.Enter += new System.EventHandler(this.getActionList);
            // 
            // tbpEncode
            // 
            this.tbpEncode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpEncode.Controls.Add(this.cmbImageE);
            this.tbpEncode.Location = new System.Drawing.Point(4, 28);
            this.tbpEncode.Name = "tbpEncode";
            this.tbpEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEncode.Size = new System.Drawing.Size(902, 282);
            this.tbpEncode.TabIndex = 0;
            this.tbpEncode.Text = "Encode - Hide Message";
            this.tbpEncode.UseVisualStyleBackColor = true;
            // 
            // tbpDecode
            // 
            this.tbpDecode.Controls.Add(this.checkBox1);
            this.tbpDecode.Controls.Add(this.cmbImageD);
            this.tbpDecode.Location = new System.Drawing.Point(4, 28);
            this.tbpDecode.Name = "tbpDecode";
            this.tbpDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDecode.Size = new System.Drawing.Size(902, 282);
            this.tbpDecode.TabIndex = 1;
            this.tbpDecode.Text = "Decode - Retrieve Message";
            this.tbpDecode.UseVisualStyleBackColor = true;
            // 
            // cmbImage
            // 
            this.cmbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.cmbImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImage.FormattingEnabled = true;
            this.cmbImage.Items.AddRange(new object[] {
            "Upload My Image",
            "Use Stock Image",
            "Create Fractal Image",
            "Create Gradient Image",
            "Download Image - Decode"});
            this.cmbImage.Location = new System.Drawing.Point(23, 377);
            this.cmbImage.Name = "cmbImage";
            this.cmbImage.Size = new System.Drawing.Size(224, 31);
            this.cmbImage.TabIndex = 14;
            this.cmbImage.SelectedIndexChanged += new System.EventHandler(this.cmbImage_SelectedIndexChanged);
            this.cmbImage.Enter += new System.EventHandler(this.getActionList);
            // 
            // cmbImageD
            // 
            this.cmbImageD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.cmbImageD.FormattingEnabled = true;
            this.cmbImageD.Items.AddRange(new object[] {
            "Upload My Image",
            "Use Stock Image",
            "Create Fractal Image",
            "Create Gradient Image",
            "Download Image - Decode"});
            this.cmbImageD.Location = new System.Drawing.Point(38, 24);
            this.cmbImageD.Name = "cmbImageD";
            this.cmbImageD.Size = new System.Drawing.Size(175, 24);
            this.cmbImageD.TabIndex = 14;
            this.cmbImageD.Text = "Choose Your Image";
            this.cmbImageD.Enter += new System.EventHandler(this.getActionList);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Use Encryption (slower, but more secure)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(648, 307);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // cmbFunction
            // 
            this.cmbFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.cmbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunction.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.ItemHeight = 23;
            this.cmbFunction.Items.AddRange(new object[] {
            "Encode - Conceal a message in an image",
            "Decode - Retrieve a message from an image"});
            this.cmbFunction.Location = new System.Drawing.Point(26, 277);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(495, 31);
            this.cmbFunction.TabIndex = 19;
            // 
            // rtbTextMessage
            // 
            this.rtbTextMessage.Location = new System.Drawing.Point(14, 437);
            this.rtbTextMessage.Name = "rtbTextMessage";
            this.rtbTextMessage.Size = new System.Drawing.Size(580, 350);
            this.rtbTextMessage.TabIndex = 20;
            this.rtbTextMessage.Text = "";
            // 
            // pcbImage
            // 
            this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbImage.Location = new System.Drawing.Point(648, 438);
            this.pcbImage.Margin = new System.Windows.Forms.Padding(1);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(570, 350);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 21;
            this.pcbImage.TabStop = false;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(477, 125);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(546, 180);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(259, 34);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 5;
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
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openUnencodedImageToolStripMenuItem
            // 
            this.openUnencodedImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unencodedImageToolStripMenuItem,
            this.encodedImageToolStripMenuItem});
            this.openUnencodedImageToolStripMenuItem.Name = "openUnencodedImageToolStripMenuItem";
            this.openUnencodedImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.openUnencodedImageToolStripMenuItem.Text = "Upload Image";
            this.openUnencodedImageToolStripMenuItem.Click += new System.EventHandler(this.openUnencodedImageToolStripMenuItem_Click);
            // 
            // generateFractalImageToolStripMenuItem
            // 
            this.generateFractalImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fractalImageToolStripMenuItem,
            this.gradientImageToolStripMenuItem,
            this.stockImageToolStripMenuItem});
            this.generateFractalImageToolStripMenuItem.Name = "generateFractalImageToolStripMenuItem";
            this.generateFractalImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.generateFractalImageToolStripMenuItem.Text = "Generate Image";
            this.generateFractalImageToolStripMenuItem.Click += new System.EventHandler(this.generateFractalImageToolStripMenuItem_Click);
            // 
            // saveEncodedImageToolStripMenuItem
            // 
            this.saveEncodedImageToolStripMenuItem.Enabled = false;
            this.saveEncodedImageToolStripMenuItem.Name = "saveEncodedImageToolStripMenuItem";
            this.saveEncodedImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.saveEncodedImageToolStripMenuItem.Text = "Save Encoded Image";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // openEncodedImageToolStripMenuItem
            // 
            this.openEncodedImageToolStripMenuItem.Name = "openEncodedImageToolStripMenuItem";
            this.openEncodedImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.openEncodedImageToolStripMenuItem.Text = "Save Encoded Image";
            // 
            // saveDecodedMessageToolStripMenuItem
            // 
            this.saveDecodedMessageToolStripMenuItem.Enabled = false;
            this.saveDecodedMessageToolStripMenuItem.Name = "saveDecodedMessageToolStripMenuItem";
            this.saveDecodedMessageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
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
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 30);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.selectAllToolStripMenuItem.Text = "Select-All";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedOptionsToolStripMenuItem,
            this.useEncryptionslowerButMoreSecureToolStripMenuItem});
            this.preferencesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.preferencesToolStripMenuItem.Text = "Settings";
            // 
            // advancedOptionsToolStripMenuItem
            // 
            this.advancedOptionsToolStripMenuItem.Enabled = false;
            this.advancedOptionsToolStripMenuItem.Name = "advancedOptionsToolStripMenuItem";
            this.advancedOptionsToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.advancedOptionsToolStripMenuItem.Text = "Advanced Options";
            this.advancedOptionsToolStripMenuItem.Click += new System.EventHandler(this.advancedOptionsToolStripMenuItem_Click);
            // 
            // useEncryptionslowerButMoreSecureToolStripMenuItem
            // 
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.CheckOnClick = true;
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useEncryptionRecommendedToolStripMenuItem,
            this.noEncryptionLessSecureToolStripMenuItem});
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Name = "useEncryptionslowerButMoreSecureToolStripMenuItem";
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Text = "Encryption Options";
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Click += new System.EventHandler(this.useEncryptionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.whatIsAFractalToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 30);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblImageOptions
            // 
            this.lblImageOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.lblImageOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImageOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblImageOptions.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageOptions.Location = new System.Drawing.Point(26, 379);
            this.lblImageOptions.Name = "lblImageOptions";
            this.lblImageOptions.Size = new System.Drawing.Size(191, 27);
            this.lblImageOptions.TabIndex = 22;
            this.lblImageOptions.Text = "Choose Your Image";
            this.lblImageOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessageOptions
            // 
            this.lblMessageOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.lblMessageOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessageOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMessageOptions.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageOptions.Location = new System.Drawing.Point(648, 381);
            this.lblMessageOptions.Name = "lblMessageOptions";
            this.lblMessageOptions.Size = new System.Drawing.Size(170, 27);
            this.lblMessageOptions.TabIndex = 23;
            this.lblMessageOptions.Text = "Message Options";
            this.lblMessageOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFunctionOptions
            // 
            this.lblFunctionOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.lblFunctionOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFunctionOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFunctionOptions.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionOptions.Location = new System.Drawing.Point(29, 279);
            this.lblFunctionOptions.Name = "lblFunctionOptions";
            this.lblFunctionOptions.Size = new System.Drawing.Size(463, 27);
            this.lblFunctionOptions.TabIndex = 24;
            this.lblFunctionOptions.Text = "Choose What You Want To Do";
            this.lblFunctionOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbNoEncrypt
            // 
            this.chbNoEncrypt.AutoSize = true;
            this.chbNoEncrypt.Location = new System.Drawing.Point(283, 334);
            this.chbNoEncrypt.Name = "chbNoEncrypt";
            this.chbNoEncrypt.Size = new System.Drawing.Size(210, 21);
            this.chbNoEncrypt.TabIndex = 26;
            this.chbNoEncrypt.Text = "No Encryption (Less secure)";
            this.chbNoEncrypt.UseVisualStyleBackColor = true;
            // 
            // useEncryptionRecommendedToolStripMenuItem
            // 
            this.useEncryptionRecommendedToolStripMenuItem.Name = "useEncryptionRecommendedToolStripMenuItem";
            this.useEncryptionRecommendedToolStripMenuItem.Size = new System.Drawing.Size(329, 28);
            this.useEncryptionRecommendedToolStripMenuItem.Text = "Use Encryption(Recommended)";
            // 
            // noEncryptionLessSecureToolStripMenuItem
            // 
            this.noEncryptionLessSecureToolStripMenuItem.Name = "noEncryptionLessSecureToolStripMenuItem";
            this.noEncryptionLessSecureToolStripMenuItem.Size = new System.Drawing.Size(329, 28);
            this.noEncryptionLessSecureToolStripMenuItem.Text = "No Encryption (Less Secure)";
            // 
            // unencodedImageToolStripMenuItem
            // 
            this.unencodedImageToolStripMenuItem.Name = "unencodedImageToolStripMenuItem";
            this.unencodedImageToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.unencodedImageToolStripMenuItem.Text = "Un-encoded Image";
            // 
            // encodedImageToolStripMenuItem
            // 
            this.encodedImageToolStripMenuItem.Name = "encodedImageToolStripMenuItem";
            this.encodedImageToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.encodedImageToolStripMenuItem.Text = "Encoded Image";
            // 
            // fractalImageToolStripMenuItem
            // 
            this.fractalImageToolStripMenuItem.Name = "fractalImageToolStripMenuItem";
            this.fractalImageToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.fractalImageToolStripMenuItem.Text = "Fractal Image";
            // 
            // gradientImageToolStripMenuItem
            // 
            this.gradientImageToolStripMenuItem.Name = "gradientImageToolStripMenuItem";
            this.gradientImageToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.gradientImageToolStripMenuItem.Text = "Gradient Image";
            // 
            // stockImageToolStripMenuItem
            // 
            this.stockImageToolStripMenuItem.Name = "stockImageToolStripMenuItem";
            this.stockImageToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.stockImageToolStripMenuItem.Text = "Stock Image";
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMenu.Location = new System.Drawing.Point(402, 172);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(521, 44);
            this.lblMenu.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 833);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1208, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nathan Beyer | Chris Hoegger | Chris Menning | Leilani Ray";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 840);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "(©) 2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1131, 842);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Version 1.0";
            // 
            // whatIsAFractalToolStripMenuItem
            // 
            this.whatIsAFractalToolStripMenuItem.Name = "whatIsAFractalToolStripMenuItem";
            this.whatIsAFractalToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.whatIsAFractalToolStripMenuItem.Text = "What is a Fractal?";
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.Controls.Add(this.labelDecodedMessage);
            this.groupBoxDecode.Controls.Add(this.labelEncodedImage2);
            this.groupBoxDecode.Controls.Add(this.btnDecode);
            this.groupBoxDecode.Controls.Add(this.pictureBoxEncoded2);
            this.groupBoxDecode.Controls.Add(this.buttonOpenImage2);
            this.groupBoxDecode.Controls.Add(this.pictureBoxEncoded);
            this.groupBoxDecode.Controls.Add(this.cmbTextDecode);
            this.groupBoxDecode.Location = new System.Drawing.Point(702, 918);
            this.groupBoxDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDecode.Size = new System.Drawing.Size(611, 430);
            this.groupBoxDecode.TabIndex = 31;
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
            // 
            // textBoxOutputMessage
            // 
            this.textBoxOutputMessage.Location = new System.Drawing.Point(100, 36);
            this.textBoxOutputMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutputMessage.Multiline = true;
            this.textBoxOutputMessage.Name = "textBoxOutputMessage";
            this.textBoxOutputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputMessage.Size = new System.Drawing.Size(599, 116);
            this.textBoxOutputMessage.TabIndex = 4;
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
            // 
            // groupBoxEncode
            // 
            this.groupBoxEncode.Controls.Add(this.btnEncodeImage);
            this.groupBoxEncode.Controls.Add(this.labelInput);
            this.groupBoxEncode.Controls.Add(this.textBoxOutputMessage);
            this.groupBoxEncode.Controls.Add(this.textBoxInputMessage);
            this.groupBoxEncode.Controls.Add(this.labelEncodedImage);
            this.groupBoxEncode.Controls.Add(this.labelRawImage);
            this.groupBoxEncode.Controls.Add(this.pictureBoxRaw);
            this.groupBoxEncode.Controls.Add(this.buttonOpenImage);
            this.groupBoxEncode.Controls.Add(this.cmbImageDecode);
            this.groupBoxEncode.Location = new System.Drawing.Point(12, 896);
            this.groupBoxEncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEncode.Name = "groupBoxEncode";
            this.groupBoxEncode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEncode.Size = new System.Drawing.Size(611, 430);
            this.groupBoxEncode.TabIndex = 30;
            this.groupBoxEncode.TabStop = false;
            this.groupBoxEncode.Text = "Hide Text in Image";
            // 
            // labelCharLimit
            // 
            this.labelCharLimit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharLimit.Location = new System.Drawing.Point(253, 408);
            this.labelCharLimit.Name = "labelCharLimit";
            this.labelCharLimit.Size = new System.Drawing.Size(341, 17);
            this.labelCharLimit.TabIndex = 9;
            this.labelCharLimit.Text = "Character Limit: n";
            this.labelCharLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.pictureBoxEncoded.Location = new System.Drawing.Point(47, 0);
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1256, 1019);
            this.Controls.Add(this.labelCharLimit);
            this.Controls.Add(this.groupBoxDecode);
            this.Controls.Add(this.groupBoxEncode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbNoEncrypt);
            this.Controls.Add(this.lblFunctionOptions);
            this.Controls.Add(this.lblMessageOptions);
            this.Controls.Add(this.lblImageOptions);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.rtbTextMessage);
            this.Controls.Add(this.cmbFunction);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmbImage);
            this.Controls.Add(this.tbcTab);
            this.Controls.Add(this.cmbTextEncode);
            this.Controls.Add(this.btnStockImagesTest);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.checkBoxEncryption);
            this.Controls.Add(this.btnFractalGeneratorTest);
            this.Controls.Add(this.btnHelpPageTest);
            this.Controls.Add(this.btnAboutPageTest);
            this.Controls.Add(this.gpbLichens);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Steganography with AES Encryption";
            this.gpbLichens.ResumeLayout(false);
            this.gpbLichens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLichens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcTab.ResumeLayout(false);
            this.tbpEncode.ResumeLayout(false);
            this.tbpDecode.ResumeLayout(false);
            this.tbpDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDecode.ResumeLayout(false);
            this.groupBoxDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).EndInit();
            this.groupBoxEncode.ResumeLayout(false);
            this.groupBoxEncode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnAboutPageTest;
        private System.Windows.Forms.Button btnHelpPageTest;
        private System.Windows.Forms.Button btnFractalGeneratorTest;
        private System.Windows.Forms.CheckBox checkBoxEncryption;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStockImagesTest;
        private System.Windows.Forms.Label lblLichens;
        private System.Windows.Forms.Label lblOffering;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbLichens;
        private System.Windows.Forms.GroupBox gpbLichens;
        private System.Windows.Forms.ComboBox cmbImageE;
        private System.Windows.Forms.ComboBox cmbTextEncode;
        private System.Windows.Forms.ComboBox cmbImageDecode;
        private System.Windows.Forms.ComboBox cmbTextDecode;
        private System.Windows.Forms.TabControl tbcTab;
        private System.Windows.Forms.TabPage tbpEncode;
        private System.Windows.Forms.ComboBox cmbImage;
        private System.Windows.Forms.TabPage tbpDecode;
        private System.Windows.Forms.ComboBox cmbImageD;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.RichTextBox rtbTextMessage;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openUnencodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateFractalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEncodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openEncodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDecodedMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useEncryptionslowerButMoreSecureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unencodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useEncryptionRecommendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noEncryptionLessSecureToolStripMenuItem;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Label lblImageOptions;
        private System.Windows.Forms.Label lblMessageOptions;
        private System.Windows.Forms.Label lblFunctionOptions;
        private System.Windows.Forms.CheckBox chbNoEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem whatIsAFractalToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDecode;
        private System.Windows.Forms.Label labelDecodedMessage;
        private System.Windows.Forms.Label labelEncodedImage2;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.PictureBox pictureBoxEncoded2;
        private System.Windows.Forms.Button buttonOpenImage2;
        private System.Windows.Forms.PictureBox pictureBoxEncoded;
        private System.Windows.Forms.TextBox textBoxOutputMessage;
        private System.Windows.Forms.GroupBox groupBoxEncode;
        private System.Windows.Forms.Button btnEncodeImage;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInputMessage;
        private System.Windows.Forms.Label labelEncodedImage;
        private System.Windows.Forms.Label labelRawImage;
        private System.Windows.Forms.PictureBox pictureBoxRaw;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Label labelCharLimit;
    }
}