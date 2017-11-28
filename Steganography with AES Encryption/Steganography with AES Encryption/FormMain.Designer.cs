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
            this.btnResetImage = new System.Windows.Forms.Button();
            this.lblLichens = new System.Windows.Forms.Label();
            this.lblOffering = new System.Windows.Forms.Label();
            this.gpbLichens = new System.Windows.Forms.GroupBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenImageEncode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenImageDecode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenerateImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFractalImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGradientImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tssMainFile = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiSaveEncodedImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSaveDecodedMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUseEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWhatIsAFractal = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbLichens = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbImage = new System.Windows.Forms.ComboBox();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.lblImageOptions = new System.Windows.Forms.Label();
            this.lblFunctionOptions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCharLimit = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.lblImageChoice = new System.Windows.Forms.Label();
            this.btnCoding = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.gpbLichens.SuspendLayout();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLichens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEncryption
            // 
            this.checkBoxEncryption.AutoSize = true;
            this.checkBoxEncryption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEncryption.Location = new System.Drawing.Point(107, 389);
            this.checkBoxEncryption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEncryption.Name = "checkBoxEncryption";
            this.checkBoxEncryption.Size = new System.Drawing.Size(405, 24);
            this.checkBoxEncryption.TabIndex = 5;
            this.checkBoxEncryption.Text = "Use Encryption (Recommended, slower but more secure)";
            this.checkBoxEncryption.UseVisualStyleBackColor = true;
            this.checkBoxEncryption.Visible = false;
            // 
            // dialogOpenRawImage
            // 
            this.dialogOpenRawImage.FileName = "openFileDialog1";
            // 
            // btnResetImage
            // 
            this.btnResetImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnResetImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetImage.Location = new System.Drawing.Point(306, 859);
            this.btnResetImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Size = new System.Drawing.Size(171, 34);
            this.btnResetImage.TabIndex = 6;
            this.btnResetImage.Text = "Reset Image";
            this.btnResetImage.UseVisualStyleBackColor = false;
            this.btnResetImage.Click += new System.EventHandler(this.BtnResetImage_Click);
            // 
            // lblLichens
            // 
            this.lblLichens.AutoSize = true;
            this.lblLichens.Font = new System.Drawing.Font("Chiller", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichens.Location = new System.Drawing.Point(520, 26);
            this.lblLichens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLichens.Name = "lblLichens";
            this.lblLichens.Size = new System.Drawing.Size(675, 92);
            this.lblLichens.TabIndex = 9;
            this.lblLichens.Text = "Legendary Lichens - 2017";
            // 
            // lblOffering
            // 
            this.lblOffering.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffering.Location = new System.Drawing.Point(536, 118);
            this.lblOffering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffering.Name = "lblOffering";
            this.lblOffering.Size = new System.Drawing.Size(659, 44);
            this.lblOffering.TabIndex = 10;
            this.lblOffering.Text = "Offering Steganography with AES Encription";
            this.lblOffering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbLichens
            // 
            this.gpbLichens.Controls.Add(this.msMain);
            this.gpbLichens.Controls.Add(this.pcbLichens);
            this.gpbLichens.Controls.Add(this.lblLichens);
            this.gpbLichens.Controls.Add(this.lblOffering);
            this.gpbLichens.Controls.Add(this.lblMenu);
            this.gpbLichens.Location = new System.Drawing.Point(54, 13);
            this.gpbLichens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbLichens.Name = "gpbLichens";
            this.gpbLichens.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbLichens.Size = new System.Drawing.Size(1439, 295);
            this.gpbLichens.TabIndex = 12;
            this.gpbLichens.TabStop = false;
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.msMain.Dock = System.Windows.Forms.DockStyle.None;
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiPreferences,
            this.tsmiHelp});
            this.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMain.Location = new System.Drawing.Point(723, 217);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMain.ShowItemToolTips = true;
            this.msMain.Size = new System.Drawing.Size(292, 33);
            this.msMain.Stretch = false;
            this.msMain.TabIndex = 5;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenImage,
            this.tsmiGenerateImage,
            this.tssMainFile,
            this.TsmiSaveEncodedImage,
            this.TsmiSaveDecodedMessage});
            this.tsmiFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 29);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpenImage
            // 
            this.tsmiOpenImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenImageEncode,
            this.tsmiOpenImageDecode});
            this.tsmiOpenImage.Name = "tsmiOpenImage";
            this.tsmiOpenImage.Size = new System.Drawing.Size(399, 30);
            this.tsmiOpenImage.Text = "My Image";
            // 
            // tsmiOpenImageEncode
            // 
            this.tsmiOpenImageEncode.Name = "tsmiOpenImageEncode";
            this.tsmiOpenImageEncode.Size = new System.Drawing.Size(310, 30);
            this.tsmiOpenImageEncode.Text = "Open Image To Encode";
            this.tsmiOpenImageEncode.Click += new System.EventHandler(this.TsmiOpenImageEncode_Click);
            // 
            // tsmiOpenImageDecode
            // 
            this.tsmiOpenImageDecode.Name = "tsmiOpenImageDecode";
            this.tsmiOpenImageDecode.Size = new System.Drawing.Size(298, 30);
            this.tsmiOpenImageDecode.Text = "Open Image To Decode";
            this.tsmiOpenImageDecode.Click += new System.EventHandler(this.TsmiOpenImageDecode_Click);
            // 
            // tsmiGenerateImage
            // 
            this.tsmiGenerateImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStockImage,
            this.tsmiFractalImage,
            this.tsmiGradientImage});
            this.tsmiGenerateImage.Name = "tsmiGenerateImage";
            this.tsmiGenerateImage.Size = new System.Drawing.Size(399, 30);
            this.tsmiGenerateImage.Text = "Generate Image";
            // 
            // tsmiStockImage
            // 
            this.tsmiStockImage.Name = "tsmiStockImage";
            this.tsmiStockImage.Size = new System.Drawing.Size(228, 30);
            this.tsmiStockImage.Text = "Stock Image";
            this.tsmiStockImage.Click += new System.EventHandler(this.TsmiStockImage_Click);
            // 
            // tsmiFractalImage
            // 
            this.tsmiFractalImage.Name = "tsmiFractalImage";
            this.tsmiFractalImage.Size = new System.Drawing.Size(228, 30);
            this.tsmiFractalImage.Text = "Fractal Image";
            this.tsmiFractalImage.Click += new System.EventHandler(this.TsmiFractalImage_Click);
            // 
            // tsmiGradientImage
            // 
            this.tsmiGradientImage.Name = "tsmiGradientImage";
            this.tsmiGradientImage.Size = new System.Drawing.Size(228, 30);
            this.tsmiGradientImage.Text = "Gradient Image";
            this.tsmiGradientImage.Click += new System.EventHandler(this.TsmiGradientImage_Click);
            // 
            // tssMainFile
            // 
            this.tssMainFile.Name = "tssMainFile";
            this.tssMainFile.Size = new System.Drawing.Size(396, 6);
            // 
            // TsmiSaveEncodedImage
            // 
            this.TsmiSaveEncodedImage.Name = "TsmiSaveEncodedImage";
            this.TsmiSaveEncodedImage.Size = new System.Drawing.Size(399, 30);
            this.TsmiSaveEncodedImage.Text = "Save Encoded Image";
            this.TsmiSaveEncodedImage.Click += new System.EventHandler(this.TsmiSaveEncodedImage_Click);
            // 
            // TsmiSaveDecodedMessage
            // 
            this.TsmiSaveDecodedMessage.Enabled = false;
            this.TsmiSaveDecodedMessage.Name = "TsmiSaveDecodedMessage";
            this.TsmiSaveDecodedMessage.Size = new System.Drawing.Size(399, 30);
            this.TsmiSaveDecodedMessage.Text = "Save Decoded Message to Text File";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.tsmiSelectAll});
            this.tsmiEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(58, 29);
            this.tsmiEdit.Text = "Edit";
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(173, 30);
            this.tsmiCut.Text = "Cut";
            this.tsmiCut.Click += new System.EventHandler(this.TsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(173, 30);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.TsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(173, 30);
            this.tsmiPaste.Text = "Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.TsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(173, 30);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.TsmiDelete_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(173, 30);
            this.tsmiSelectAll.Text = "Select-All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
            // 
            // tsmiPreferences
            // 
            this.tsmiPreferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAO,
            this.tsmiUseEncrypt});
            this.tsmiPreferences.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPreferences.Name = "tsmiPreferences";
            this.tsmiPreferences.Size = new System.Drawing.Size(96, 29);
            this.tsmiPreferences.Text = "Settings";
            // 
            // tsmiAO
            // 
            this.tsmiAO.Enabled = false;
            this.tsmiAO.Name = "tsmiAO";
            this.tsmiAO.Size = new System.Drawing.Size(456, 30);
            this.tsmiAO.Text = "Advanced Options";
            this.tsmiAO.Click += new System.EventHandler(this.TsmiAO_Click);
            // 
            // tsmiUseEncrypt
            // 
            this.tsmiUseEncrypt.CheckOnClick = true;
            this.tsmiUseEncrypt.Name = "tsmiUseEncrypt";
            this.tsmiUseEncrypt.Size = new System.Drawing.Size(456, 30);
            this.tsmiUseEncrypt.Text = "Use Encryption (slower, but more secure)";
            this.tsmiUseEncrypt.Click += new System.EventHandler(this.TsmiUseEncrypt_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewHelp,
            this.tsmiAbout,
            this.tsmiWhatIsAFractal});
            this.tsmiHelp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(66, 29);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiViewHelp
            // 
            this.tsmiViewHelp.Name = "tsmiViewHelp";
            this.tsmiViewHelp.Size = new System.Drawing.Size(242, 30);
            this.tsmiViewHelp.Text = "View Help";
            this.tsmiViewHelp.Click += new System.EventHandler(this.TsmiViewHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(242, 30);
            this.tsmiAbout.Text = "View About";
            this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // tsmiWhatIsAFractal
            // 
            this.tsmiWhatIsAFractal.Name = "tsmiWhatIsAFractal";
            this.tsmiWhatIsAFractal.Size = new System.Drawing.Size(242, 30);
            this.tsmiWhatIsAFractal.Text = "What is a Fractal?";
            this.tsmiWhatIsAFractal.Click += new System.EventHandler(this.TsmiWhatIsAFractal_Click);
            // 
            // pcbLichens
            // 
            this.pcbLichens.BackgroundImage = global::Steganography_with_AES_Encryption.Properties.Resources.Lichens;
            this.pcbLichens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLichens.Location = new System.Drawing.Point(33, 26);
            this.pcbLichens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbLichens.Name = "pcbLichens";
            this.pcbLichens.Size = new System.Drawing.Size(321, 258);
            this.pcbLichens.TabIndex = 11;
            this.pcbLichens.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMenu.Location = new System.Drawing.Point(526, 207);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(659, 55);
            this.lblMenu.TabIndex = 12;
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
            // cmbImage
            // 
            this.cmbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.cmbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbImage.Enabled = false;
            this.cmbImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImage.FormattingEnabled = true;
            this.cmbImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbImage.Items.AddRange(new object[] {
            "Open My Image - Encode",
            "Use Stock Image",
            "Create Fractal Image",
            "Create Gradient Image",
            "Open My Image - Decode"});
            this.cmbImage.Location = new System.Drawing.Point(104, 417);
            this.cmbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbImage.Name = "cmbImage";
            this.cmbImage.Size = new System.Drawing.Size(304, 33);
            this.cmbImage.TabIndex = 2;
            this.cmbImage.Visible = false;
            this.cmbImage.SelectedIndexChanged += new System.EventHandler(this.CmbImage_SelectedIndexChanged);
            this.cmbImage.SelectedValueChanged += new System.EventHandler(this.CmbImage_SelectedValueChanged);
            // 
            // cmbFunction
            // 
            this.cmbFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.cmbFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFunction.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.ItemHeight = 25;
            this.cmbFunction.Items.AddRange(new object[] {
            "Encode - Conceal a message in an image",
            "Decode - Retrieve a message from an image"});
            this.cmbFunction.Location = new System.Drawing.Point(104, 320);
            this.cmbFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(644, 33);
            this.cmbFunction.TabIndex = 1;
            this.cmbFunction.SelectionChangeCommitted += new System.EventHandler(this.GetActionList);
            this.cmbFunction.SelectedValueChanged += new System.EventHandler(this.CmbFunction_SelectedValueChanged);
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbImage.Location = new System.Drawing.Point(98, 497);
            this.pcbImage.Margin = new System.Windows.Forms.Padding(1);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(650, 345);
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
            // lblImageOptions
            // 
            this.lblImageOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.lblImageOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImageOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblImageOptions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageOptions.Location = new System.Drawing.Point(104, 417);
            this.lblImageOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageOptions.Name = "lblImageOptions";
            this.lblImageOptions.Size = new System.Drawing.Size(282, 33);
            this.lblImageOptions.TabIndex = 22;
            this.lblImageOptions.Text = "2. Choose Your Image";
            this.lblImageOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImageOptions.Visible = false;
            // 
            // lblFunctionOptions
            // 
            this.lblFunctionOptions.AccessibleName = "#99CCEE";
            this.lblFunctionOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.lblFunctionOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFunctionOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFunctionOptions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionOptions.Location = new System.Drawing.Point(108, 322);
            this.lblFunctionOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunctionOptions.Name = "lblFunctionOptions";
            this.lblFunctionOptions.Size = new System.Drawing.Size(617, 29);
            this.lblFunctionOptions.TabIndex = 24;
            this.lblFunctionOptions.Text = "1. Choose What You Want To Do";
            this.lblFunctionOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 909);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1438, 43);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nathan Beyer | Chris Hoegger | Chris Menning | Leilani Ray";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 923);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "(©) 2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1407, 923);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Version 7.0";
            // 
            // lblCharLimit
            // 
            this.lblCharLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharLimit.Location = new System.Drawing.Point(995, 470);
            this.lblCharLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharLimit.Name = "lblCharLimit";
            this.lblCharLimit.Size = new System.Drawing.Size(455, 21);
            this.lblCharLimit.TabIndex = 9;
            this.lblCharLimit.Text = "Character Limit: n";
            this.lblCharLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1051, 859);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 34);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Clear Message";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMessage.Enabled = false;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(800, 497);
            this.txtMessage.MaxLength = 0;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(650, 345);
            this.txtMessage.TabIndex = 33;
            // 
            // lblFunction
            // 
            this.lblFunction.CausesValidation = false;
            this.lblFunction.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunction.Location = new System.Drawing.Point(107, 357);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(618, 28);
            this.lblFunction.TabIndex = 34;
            this.lblFunction.Visible = false;
            // 
            // lblImageChoice
            // 
            this.lblImageChoice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageChoice.Location = new System.Drawing.Point(103, 454);
            this.lblImageChoice.Name = "lblImageChoice";
            this.lblImageChoice.Size = new System.Drawing.Size(284, 39);
            this.lblImageChoice.TabIndex = 35;
            this.lblImageChoice.Visible = false;
            // 
            // btnCoding
            // 
            this.btnCoding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnCoding.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoding.Location = new System.Drawing.Point(800, 417);
            this.btnCoding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btnCoding.Name = "btnCoding";
            this.btnCoding.Size = new System.Drawing.Size(301, 34);
            this.btnCoding.TabIndex = 3;
            this.btnCoding.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCoding.UseVisualStyleBackColor = false;
            this.btnCoding.Visible = false;
            this.btnCoding.Click += new System.EventHandler(this.BtnCoding_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.Location = new System.Drawing.Point(1290, 322);
            this.btnResetAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(171, 34);
            this.btnResetAll.TabIndex = 37;
            this.btnResetAll.Text = "New / Reset All ";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.BtnResetAll_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(796, 470);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(184, 20);
            this.lblType.TabIndex = 38;
            this.lblType.Text = "Type your message below.";
            this.lblType.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1441, 682);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnCoding);
            this.Controls.Add(this.lblImageChoice);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCharLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFunctionOptions);
            this.Controls.Add(this.lblImageOptions);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.cmbFunction);
            this.Controls.Add(this.cmbImage);
            this.Controls.Add(this.btnResetImage);
            this.Controls.Add(this.checkBoxEncryption);
            this.Controls.Add(this.gpbLichens);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Steganography with AES Encryption";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpbLichens.ResumeLayout(false);
            this.gpbLichens.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLichens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.CheckBox checkBoxEncryption;
        private System.Windows.Forms.Button btnResetImage;
        private System.Windows.Forms.Label lblLichens;
        private System.Windows.Forms.Label lblOffering;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbLichens;
        private System.Windows.Forms.GroupBox gpbLichens;
        private System.Windows.Forms.ComboBox cmbImage;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenerateImage;
        private System.Windows.Forms.ToolStripSeparator tssMainFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveEncodedImage;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveDecodedMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreferences;
        private System.Windows.Forms.ToolStripMenuItem tsmiAO;
        private System.Windows.Forms.ToolStripMenuItem tsmiUseEncrypt;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenImageEncode;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenImageDecode;
        private System.Windows.Forms.ToolStripMenuItem tsmiFractalImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGradientImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockImage;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Label lblImageOptions;
        private System.Windows.Forms.Label lblFunctionOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tsmiWhatIsAFractal;
        private System.Windows.Forms.Label lblCharLimit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Label lblImageChoice;
        private System.Windows.Forms.Button btnCoding;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Label lblType;
    }
}