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
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLichens = new System.Windows.Forms.Label();
            this.lblOffering = new System.Windows.Forms.Label();
            this.gpbLichensHeader = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbLichens = new System.Windows.Forms.PictureBox();
            this.groupBoxActionChoice = new System.Windows.Forms.GroupBox();
            this.radioButtonDecode = new System.Windows.Forms.RadioButton();
            this.radioButtonEncode = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unencodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseStockPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveEncodedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDecodedMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useEncryptionslowerButMoreSecureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useEncryptionRecommendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noEncryptionLessSecureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatIsAFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbImageE = new System.Windows.Forms.ComboBox();
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.tbpEncode = new System.Windows.Forms.TabPage();
            this.tbpDecode = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbImageD = new System.Windows.Forms.ComboBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.textBoxOutputMessage = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.buttonOpenEncodedImage = new System.Windows.Forms.Button();
            this.pictureBoxEncoded = new System.Windows.Forms.PictureBox();
            this.groupBoxEncode = new System.Windows.Forms.GroupBox();
            this.comboBoxImageSelect = new System.Windows.Forms.ComboBox();
            this.btnEncodeImage = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelCharLimit = new System.Windows.Forms.Label();
            this.textBoxInputMessage = new System.Windows.Forms.TextBox();
            this.pictureBoxRaw = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dialogSaveText = new System.Windows.Forms.SaveFileDialog();
            this.gpbLichensHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLichens)).BeginInit();
            this.groupBoxActionChoice.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcTab.SuspendLayout();
            this.tbpEncode.SuspendLayout();
            this.tbpDecode.SuspendLayout();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).BeginInit();
            this.groupBoxEncode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEncryption
            // 
            this.checkBoxEncryption.AutoSize = true;
            this.checkBoxEncryption.Location = new System.Drawing.Point(19, 89);
            this.checkBoxEncryption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkBoxEncryption.Name = "checkBoxEncryption";
            this.checkBoxEncryption.Size = new System.Drawing.Size(345, 27);
            this.checkBoxEncryption.TabIndex = 5;
            this.checkBoxEncryption.Text = "Use Encryption (Slower, but more secure)";
            this.checkBoxEncryption.UseVisualStyleBackColor = true;
            // 
            // dialogOpenRawImage
            // 
            this.dialogOpenRawImage.FileName = "openFileDialog1";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1324, 1404);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 49);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblLichens
            // 
            this.lblLichens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLichens.AutoSize = true;
            this.lblLichens.Font = new System.Drawing.Font("Chiller", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichens.Location = new System.Drawing.Point(183, 25);
            this.lblLichens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLichens.Name = "lblLichens";
            this.lblLichens.Size = new System.Drawing.Size(368, 50);
            this.lblLichens.TabIndex = 9;
            this.lblLichens.Text = "Legendary Lichens - 2017";
            // 
            // lblOffering
            // 
            this.lblOffering.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffering.Location = new System.Drawing.Point(187, 75);
            this.lblOffering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffering.Name = "lblOffering";
            this.lblOffering.Size = new System.Drawing.Size(292, 68);
            this.lblOffering.TabIndex = 10;
            this.lblOffering.Text = "Offering Steganography with AES Encryption";
            this.lblOffering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbLichensHeader
            // 
            this.gpbLichensHeader.Controls.Add(this.buttonReset);
            this.gpbLichensHeader.Controls.Add(this.label3);
            this.gpbLichensHeader.Controls.Add(this.pcbLichens);
            this.gpbLichensHeader.Controls.Add(this.groupBoxActionChoice);
            this.gpbLichensHeader.Controls.Add(this.lblLichens);
            this.gpbLichensHeader.Controls.Add(this.lblOffering);
            this.gpbLichensHeader.Location = new System.Drawing.Point(5, 33);
            this.gpbLichensHeader.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gpbLichensHeader.Name = "gpbLichensHeader";
            this.gpbLichensHeader.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gpbLichensHeader.Size = new System.Drawing.Size(996, 172);
            this.gpbLichensHeader.TabIndex = 12;
            this.gpbLichensHeader.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(898, 20);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(64, 143);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label3.Location = new System.Drawing.Point(165, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nathan Beyer | Chris Hoegger | Chris Menning | Leilani Ray";
            // 
            // pcbLichens
            // 
            this.pcbLichens.BackgroundImage = global::Steganography_with_AES_Encryption.Properties.Resources.Lichens;
            this.pcbLichens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLichens.Location = new System.Drawing.Point(8, 20);
            this.pcbLichens.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pcbLichens.Name = "pcbLichens";
            this.pcbLichens.Size = new System.Drawing.Size(147, 140);
            this.pcbLichens.TabIndex = 11;
            this.pcbLichens.TabStop = false;
            // 
            // groupBoxActionChoice
            // 
            this.groupBoxActionChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.groupBoxActionChoice.Controls.Add(this.radioButtonDecode);
            this.groupBoxActionChoice.Controls.Add(this.radioButtonEncode);
            this.groupBoxActionChoice.Controls.Add(this.checkBoxEncryption);
            this.groupBoxActionChoice.Location = new System.Drawing.Point(510, 20);
            this.groupBoxActionChoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxActionChoice.Name = "groupBoxActionChoice";
            this.groupBoxActionChoice.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxActionChoice.Size = new System.Drawing.Size(382, 142);
            this.groupBoxActionChoice.TabIndex = 33;
            this.groupBoxActionChoice.TabStop = false;
            this.groupBoxActionChoice.Text = "What would you like to do?";
            // 
            // radioButtonDecode
            // 
            this.radioButtonDecode.AutoSize = true;
            this.radioButtonDecode.Location = new System.Drawing.Point(19, 57);
            this.radioButtonDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonDecode.Name = "radioButtonDecode";
            this.radioButtonDecode.Size = new System.Drawing.Size(260, 27);
            this.radioButtonDecode.TabIndex = 1;
            this.radioButtonDecode.TabStop = true;
            this.radioButtonDecode.Text = "Retrieve Message From Image";
            this.radioButtonDecode.UseVisualStyleBackColor = true;
            this.radioButtonDecode.CheckedChanged += new System.EventHandler(this.RadioButtonDecode_CheckedChanged);
            // 
            // radioButtonEncode
            // 
            this.radioButtonEncode.AutoSize = true;
            this.radioButtonEncode.Location = new System.Drawing.Point(19, 24);
            this.radioButtonEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonEncode.Name = "radioButtonEncode";
            this.radioButtonEncode.Size = new System.Drawing.Size(209, 27);
            this.radioButtonEncode.TabIndex = 0;
            this.radioButtonEncode.TabStop = true;
            this.radioButtonEncode.Text = "Hide Message in Image";
            this.radioButtonEncode.UseVisualStyleBackColor = true;
            this.radioButtonEncode.CheckedChanged += new System.EventHandler(this.RadioButtonEncode_CheckedChanged);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1011, 38);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 5;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.generateImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveEncodedImageToolStripMenuItem,
            this.saveDecodedMessageToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unencodedImageToolStripMenuItem,
            this.encodedImageToolStripMenuItem,
            this.chooseStockPhotoToolStripMenuItem});
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.openImageToolStripMenuItem.Text = "Open Image";
            // 
            // unencodedImageToolStripMenuItem
            // 
            this.unencodedImageToolStripMenuItem.Name = "unencodedImageToolStripMenuItem";
            this.unencodedImageToolStripMenuItem.Size = new System.Drawing.Size(264, 28);
            this.unencodedImageToolStripMenuItem.Text = "Open Plain Image...";
            this.unencodedImageToolStripMenuItem.Click += new System.EventHandler(this.UnencodedImageToolStripMenuItem_Click);
            // 
            // encodedImageToolStripMenuItem
            // 
            this.encodedImageToolStripMenuItem.Name = "encodedImageToolStripMenuItem";
            this.encodedImageToolStripMenuItem.Size = new System.Drawing.Size(264, 28);
            this.encodedImageToolStripMenuItem.Text = "Open Encoded Image...";
            this.encodedImageToolStripMenuItem.Click += new System.EventHandler(this.EncodedImageToolStripMenuItem_Click);
            // 
            // chooseStockPhotoToolStripMenuItem
            // 
            this.chooseStockPhotoToolStripMenuItem.Name = "chooseStockPhotoToolStripMenuItem";
            this.chooseStockPhotoToolStripMenuItem.Size = new System.Drawing.Size(264, 28);
            this.chooseStockPhotoToolStripMenuItem.Text = "Choose Stock Photo";
            this.chooseStockPhotoToolStripMenuItem.Click += new System.EventHandler(this.ChooseStockPhotoToolStripMenuItem_Click);
            // 
            // generateImageToolStripMenuItem
            // 
            this.generateImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fractalImageToolStripMenuItem,
            this.gradientImageToolStripMenuItem});
            this.generateImageToolStripMenuItem.Name = "generateImageToolStripMenuItem";
            this.generateImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.generateImageToolStripMenuItem.Text = "Generate Image";
            // 
            // fractalImageToolStripMenuItem
            // 
            this.fractalImageToolStripMenuItem.Name = "fractalImageToolStripMenuItem";
            this.fractalImageToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.fractalImageToolStripMenuItem.Text = "Fractal Image";
            this.fractalImageToolStripMenuItem.Click += new System.EventHandler(this.FractalImageToolStripMenuItem_Click);
            // 
            // gradientImageToolStripMenuItem
            // 
            this.gradientImageToolStripMenuItem.Name = "gradientImageToolStripMenuItem";
            this.gradientImageToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.gradientImageToolStripMenuItem.Text = "Gradient Image";
            this.gradientImageToolStripMenuItem.Click += new System.EventHandler(this.GradientImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // saveEncodedImageToolStripMenuItem
            // 
            this.saveEncodedImageToolStripMenuItem.Enabled = false;
            this.saveEncodedImageToolStripMenuItem.Name = "saveEncodedImageToolStripMenuItem";
            this.saveEncodedImageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.saveEncodedImageToolStripMenuItem.Text = "Save Encoded Image";
            this.saveEncodedImageToolStripMenuItem.Click += new System.EventHandler(this.SaveEncodedImageToolStripMenuItem_Click);
            // 
            // saveDecodedMessageToolStripMenuItem
            // 
            this.saveDecodedMessageToolStripMenuItem.Enabled = false;
            this.saveDecodedMessageToolStripMenuItem.Name = "saveDecodedMessageToolStripMenuItem";
            this.saveDecodedMessageToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.saveDecodedMessageToolStripMenuItem.Text = "Save Decoded Message";
            this.saveDecodedMessageToolStripMenuItem.Click += new System.EventHandler(this.SaveDecodedMessageToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.selectAllToolStripMenuItem.Text = "Select-All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedOptionsToolStripMenuItem,
            this.useEncryptionslowerButMoreSecureToolStripMenuItem});
            this.preferencesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.preferencesToolStripMenuItem.Text = "Settings";
            // 
            // advancedOptionsToolStripMenuItem
            // 
            this.advancedOptionsToolStripMenuItem.Enabled = false;
            this.advancedOptionsToolStripMenuItem.Name = "advancedOptionsToolStripMenuItem";
            this.advancedOptionsToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.advancedOptionsToolStripMenuItem.Text = "Advanced Options";
            this.advancedOptionsToolStripMenuItem.Click += new System.EventHandler(this.AdvancedOptionsToolStripMenuItem_Click);
            // 
            // useEncryptionslowerButMoreSecureToolStripMenuItem
            // 
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useEncryptionRecommendedToolStripMenuItem,
            this.noEncryptionLessSecureToolStripMenuItem});
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Name = "useEncryptionslowerButMoreSecureToolStripMenuItem";
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.useEncryptionslowerButMoreSecureToolStripMenuItem.Text = "Encryption Options";
            // 
            // useEncryptionRecommendedToolStripMenuItem
            // 
            this.useEncryptionRecommendedToolStripMenuItem.Name = "useEncryptionRecommendedToolStripMenuItem";
            this.useEncryptionRecommendedToolStripMenuItem.Size = new System.Drawing.Size(375, 28);
            this.useEncryptionRecommendedToolStripMenuItem.Text = "Use Encryption (Slower, More Secure)";
            this.useEncryptionRecommendedToolStripMenuItem.Click += new System.EventHandler(this.UseEncryptionToolStripMenuItem_Click);
            // 
            // noEncryptionLessSecureToolStripMenuItem
            // 
            this.noEncryptionLessSecureToolStripMenuItem.Name = "noEncryptionLessSecureToolStripMenuItem";
            this.noEncryptionLessSecureToolStripMenuItem.Size = new System.Drawing.Size(375, 28);
            this.noEncryptionLessSecureToolStripMenuItem.Text = "No Encryption (Faster, Less Secure)";
            this.noEncryptionLessSecureToolStripMenuItem.Click += new System.EventHandler(this.NoEncryptionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.whatIsAFractalToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // whatIsAFractalToolStripMenuItem
            // 
            this.whatIsAFractalToolStripMenuItem.Name = "whatIsAFractalToolStripMenuItem";
            this.whatIsAFractalToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.whatIsAFractalToolStripMenuItem.Text = "What is a Fractal?";
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
            this.cmbImageE.Location = new System.Drawing.Point(37, 118);
            this.cmbImageE.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbImageE.Name = "cmbImageE";
            this.cmbImageE.Size = new System.Drawing.Size(260, 31);
            this.cmbImageE.TabIndex = 13;
            this.cmbImageE.Text = "Choose Your Image";
            // 
            // tbcTab
            // 
            this.tbcTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbcTab.Controls.Add(this.tbpEncode);
            this.tbcTab.Controls.Add(this.tbpDecode);
            this.tbcTab.Location = new System.Drawing.Point(549, 1565);
            this.tbcTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(1365, 555);
            this.tbcTab.TabIndex = 17;
            this.tbcTab.Visible = false;
            // 
            // tbpEncode
            // 
            this.tbpEncode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpEncode.Controls.Add(this.cmbImageE);
            this.tbpEncode.Location = new System.Drawing.Point(4, 35);
            this.tbpEncode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbpEncode.Name = "tbpEncode";
            this.tbpEncode.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbpEncode.Size = new System.Drawing.Size(1357, 516);
            this.tbpEncode.TabIndex = 0;
            this.tbpEncode.Text = "Encode - Hide Message";
            this.tbpEncode.UseVisualStyleBackColor = true;
            // 
            // tbpDecode
            // 
            this.tbpDecode.Controls.Add(this.checkBox1);
            this.tbpDecode.Controls.Add(this.cmbImageD);
            this.tbpDecode.Location = new System.Drawing.Point(4, 35);
            this.tbpDecode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbpDecode.Name = "tbpDecode";
            this.tbpDecode.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbpDecode.Size = new System.Drawing.Size(1357, 516);
            this.tbpDecode.TabIndex = 1;
            this.tbpDecode.Text = "Decode - Retrieve Message";
            this.tbpDecode.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 141);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(343, 27);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Use Encryption (slower, but more secure)";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.cmbImageD.Location = new System.Drawing.Point(57, 43);
            this.cmbImageD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbImageD.Name = "cmbImageD";
            this.cmbImageD.Size = new System.Drawing.Size(260, 31);
            this.cmbImageD.TabIndex = 14;
            this.cmbImageD.Text = "Choose Your Image";
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 1473);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1812, 59);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nathan Beyer | Chris Hoegger | Chris Menning | Leilani Ray";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 1486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "(©) 2017";
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.Controls.Add(this.buttonSaveText);
            this.groupBoxDecode.Controls.Add(this.textBoxOutputMessage);
            this.groupBoxDecode.Controls.Add(this.btnDecode);
            this.groupBoxDecode.Controls.Add(this.buttonOpenEncodedImage);
            this.groupBoxDecode.Controls.Add(this.pictureBoxEncoded);
            this.groupBoxDecode.Location = new System.Drawing.Point(1018, 208);
            this.groupBoxDecode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDecode.Size = new System.Drawing.Size(1150, 554);
            this.groupBoxDecode.TabIndex = 31;
            this.groupBoxDecode.TabStop = false;
            this.groupBoxDecode.Text = "Retrieve Text from Image";
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Enabled = false;
            this.buttonSaveText.Location = new System.Drawing.Point(780, 23);
            this.buttonSaveText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(180, 30);
            this.buttonSaveText.TabIndex = 6;
            this.buttonSaveText.Text = "Save Text To File";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.BtnSaveText_Click);
            // 
            // textBoxOutputMessage
            // 
            this.textBoxOutputMessage.Location = new System.Drawing.Point(510, 60);
            this.textBoxOutputMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxOutputMessage.Multiline = true;
            this.textBoxOutputMessage.Name = "textBoxOutputMessage";
            this.textBoxOutputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputMessage.Size = new System.Drawing.Size(450, 450);
            this.textBoxOutputMessage.TabIndex = 4;
            // 
            // btnDecode
            // 
            this.btnDecode.Enabled = false;
            this.btnDecode.Location = new System.Drawing.Point(510, 23);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(262, 30);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode Message From Image";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // buttonOpenEncodedImage
            // 
            this.buttonOpenEncodedImage.Location = new System.Drawing.Point(30, 23);
            this.buttonOpenEncodedImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpenEncodedImage.Name = "buttonOpenEncodedImage";
            this.buttonOpenEncodedImage.Size = new System.Drawing.Size(206, 30);
            this.buttonOpenEncodedImage.TabIndex = 1;
            this.buttonOpenEncodedImage.Text = "Open Image";
            this.buttonOpenEncodedImage.UseVisualStyleBackColor = true;
            this.buttonOpenEncodedImage.Click += new System.EventHandler(this.BtnOpenEncodedImage_Click);
            // 
            // pictureBoxEncoded
            // 
            this.pictureBoxEncoded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEncoded.Location = new System.Drawing.Point(30, 60);
            this.pictureBoxEncoded.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxEncoded.Name = "pictureBoxEncoded";
            this.pictureBoxEncoded.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxEncoded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEncoded.TabIndex = 3;
            this.pictureBoxEncoded.TabStop = false;
            // 
            // groupBoxEncode
            // 
            this.groupBoxEncode.Controls.Add(this.comboBoxImageSelect);
            this.groupBoxEncode.Controls.Add(this.btnEncodeImage);
            this.groupBoxEncode.Controls.Add(this.labelInput);
            this.groupBoxEncode.Controls.Add(this.labelCharLimit);
            this.groupBoxEncode.Controls.Add(this.textBoxInputMessage);
            this.groupBoxEncode.Controls.Add(this.pictureBoxRaw);
            this.groupBoxEncode.Location = new System.Drawing.Point(5, 208);
            this.groupBoxEncode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxEncode.Name = "groupBoxEncode";
            this.groupBoxEncode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxEncode.Size = new System.Drawing.Size(996, 556);
            this.groupBoxEncode.TabIndex = 30;
            this.groupBoxEncode.TabStop = false;
            this.groupBoxEncode.Text = "Hide Text in Image";
            // 
            // comboBoxImageSelect
            // 
            this.comboBoxImageSelect.FormattingEnabled = true;
            this.comboBoxImageSelect.Items.AddRange(new object[] {
            "Open your own Image",
            "Select Stock Photo",
            "Generate Fractal",
            "Generate Gradient Pattern"});
            this.comboBoxImageSelect.Location = new System.Drawing.Point(512, 24);
            this.comboBoxImageSelect.Name = "comboBoxImageSelect";
            this.comboBoxImageSelect.Size = new System.Drawing.Size(242, 31);
            this.comboBoxImageSelect.TabIndex = 10;
            this.comboBoxImageSelect.Text = "Choose Your Image";
            this.comboBoxImageSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxImageSelect_SelectedIndexChanged);
            // 
            // btnEncodeImage
            // 
            this.btnEncodeImage.Enabled = false;
            this.btnEncodeImage.Location = new System.Drawing.Point(761, 24);
            this.btnEncodeImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncodeImage.Name = "btnEncodeImage";
            this.btnEncodeImage.Size = new System.Drawing.Size(201, 30);
            this.btnEncodeImage.TabIndex = 8;
            this.btnEncodeImage.Text = "Hide Text in Image";
            this.btnEncodeImage.UseVisualStyleBackColor = true;
            this.btnEncodeImage.Click += new System.EventHandler(this.BtnEncodeImage_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(25, 24);
            this.labelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(167, 23);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "Input Message Here:";
            // 
            // labelCharLimit
            // 
            this.labelCharLimit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharLimit.Location = new System.Drawing.Point(265, 21);
            this.labelCharLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCharLimit.Name = "labelCharLimit";
            this.labelCharLimit.Size = new System.Drawing.Size(214, 30);
            this.labelCharLimit.TabIndex = 9;
            this.labelCharLimit.Text = "Character Limit: n";
            this.labelCharLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxInputMessage
            // 
            this.textBoxInputMessage.Location = new System.Drawing.Point(30, 60);
            this.textBoxInputMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInputMessage.MaxLength = 0;
            this.textBoxInputMessage.Multiline = true;
            this.textBoxInputMessage.Name = "textBoxInputMessage";
            this.textBoxInputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputMessage.Size = new System.Drawing.Size(450, 450);
            this.textBoxInputMessage.TabIndex = 6;
            this.textBoxInputMessage.TextChanged += new System.EventHandler(this.TextBoxInputMessage_TextChanged);
            // 
            // pictureBoxRaw
            // 
            this.pictureBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRaw.Location = new System.Drawing.Point(510, 60);
            this.pictureBoxRaw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxRaw.Name = "pictureBoxRaw";
            this.pictureBoxRaw.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRaw.TabIndex = 2;
            this.pictureBoxRaw.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(302, 1404);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 49);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxDecode);
            this.Controls.Add(this.groupBoxEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcTab);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gpbLichensHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Steganography with AES Encryption";
            this.gpbLichensHeader.ResumeLayout(false);
            this.gpbLichensHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLichens)).EndInit();
            this.groupBoxActionChoice.ResumeLayout(false);
            this.groupBoxActionChoice.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcTab.ResumeLayout(false);
            this.tbpEncode.ResumeLayout(false);
            this.tbpDecode.ResumeLayout(false);
            this.tbpDecode.PerformLayout();
            this.groupBoxDecode.ResumeLayout(false);
            this.groupBoxDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded)).EndInit();
            this.groupBoxEncode.ResumeLayout(false);
            this.groupBoxEncode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.CheckBox checkBoxEncryption;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLichens;
        private System.Windows.Forms.Label lblOffering;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbLichens;
        private System.Windows.Forms.GroupBox gpbLichensHeader;
        private System.Windows.Forms.ComboBox cmbImageE;
        private System.Windows.Forms.TabControl tbcTab;
        private System.Windows.Forms.TabPage tbpEncode;
        private System.Windows.Forms.TabPage tbpDecode;
        private System.Windows.Forms.ComboBox cmbImageD;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEncodedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
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
        private System.Windows.Forms.ToolStripMenuItem useEncryptionRecommendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noEncryptionLessSecureToolStripMenuItem;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem whatIsAFractalToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDecode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button buttonOpenEncodedImage;
        private System.Windows.Forms.PictureBox pictureBoxEncoded;
        private System.Windows.Forms.TextBox textBoxOutputMessage;
        private System.Windows.Forms.GroupBox groupBoxEncode;
        private System.Windows.Forms.Button btnEncodeImage;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInputMessage;
        private System.Windows.Forms.PictureBox pictureBoxRaw;
        private System.Windows.Forms.Label labelCharLimit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxActionChoice;
        private System.Windows.Forms.RadioButton radioButtonDecode;
        private System.Windows.Forms.RadioButton radioButtonEncode;
        private System.Windows.Forms.ComboBox comboBoxImageSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem chooseStockPhotoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dialogSaveText;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
    }
}