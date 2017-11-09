namespace Steganography_with_AES_Encryption
{
    partial class frmStockImagesPage
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.sfdStockImage = new System.Windows.Forms.SaveFileDialog();
            this.grbImages = new System.Windows.Forms.GroupBox();
            this.rdbTiger = new System.Windows.Forms.RadioButton();
            this.rtbStockImages = new System.Windows.Forms.RichTextBox();
            this.btnSaveStockImage = new System.Windows.Forms.Button();
            this.btnCloseStockImagePage = new System.Windows.Forms.Button();
            this.ptbStockImages = new System.Windows.Forms.PictureBox();
            this.cboTiger = new System.Windows.Forms.ComboBox();
            this.rdbRocks = new System.Windows.Forms.RadioButton();
            this.cboRocks = new System.Windows.Forms.ComboBox();
            this.grbImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStockImages)).BeginInit();
            this.SuspendLayout();
            // 
            // grbImages
            // 
            this.grbImages.Controls.Add(this.cboRocks);
            this.grbImages.Controls.Add(this.rdbRocks);
            this.grbImages.Controls.Add(this.cboTiger);
            this.grbImages.Controls.Add(this.rdbTiger);
            this.grbImages.Location = new System.Drawing.Point(32, 54);
            this.grbImages.Name = "grbImages";
            this.grbImages.Size = new System.Drawing.Size(185, 198);
            this.grbImages.TabIndex = 0;
            this.grbImages.TabStop = false;
            this.grbImages.Text = "Images";
            // 
            // rdbTiger
            // 
            this.rdbTiger.AutoSize = true;
            this.rdbTiger.Location = new System.Drawing.Point(7, 30);
            this.rdbTiger.Name = "rdbTiger";
            this.rdbTiger.Size = new System.Drawing.Size(49, 17);
            this.rdbTiger.TabIndex = 0;
            this.rdbTiger.TabStop = true;
            this.rdbTiger.Text = "Tiger";
            this.rdbTiger.UseVisualStyleBackColor = true;
            this.rdbTiger.CheckedChanged += new System.EventHandler(this.rdbTiger_CheckedChanged);
            // 
            // rtbStockImages
            // 
            this.rtbStockImages.Location = new System.Drawing.Point(490, 54);
            this.rtbStockImages.Name = "rtbStockImages";
            this.rtbStockImages.Size = new System.Drawing.Size(171, 198);
            this.rtbStockImages.TabIndex = 2;
            this.rtbStockImages.Text = "";
            // 
            // btnSaveStockImage
            // 
            this.btnSaveStockImage.Location = new System.Drawing.Point(194, 312);
            this.btnSaveStockImage.Name = "btnSaveStockImage";
            this.btnSaveStockImage.Size = new System.Drawing.Size(97, 23);
            this.btnSaveStockImage.TabIndex = 3;
            this.btnSaveStockImage.Text = "Save Image";
            this.btnSaveStockImage.UseVisualStyleBackColor = true;
            this.btnSaveStockImage.Click += new System.EventHandler(this.btnSaveStockImage_Click);
            // 
            // btnCloseStockImagePage
            // 
            this.btnCloseStockImagePage.Location = new System.Drawing.Point(430, 312);
            this.btnCloseStockImagePage.Name = "btnCloseStockImagePage";
            this.btnCloseStockImagePage.Size = new System.Drawing.Size(75, 23);
            this.btnCloseStockImagePage.TabIndex = 4;
            this.btnCloseStockImagePage.Text = "Close";
            this.btnCloseStockImagePage.UseVisualStyleBackColor = true;
            this.btnCloseStockImagePage.Click += new System.EventHandler(this.btnCloseStockImagePage_Click);
            // 
            // ptbStockImages
            // 
            this.ptbStockImages.Location = new System.Drawing.Point(262, 54);
            this.ptbStockImages.Name = "ptbStockImages";
            this.ptbStockImages.Size = new System.Drawing.Size(188, 198);
            this.ptbStockImages.TabIndex = 5;
            this.ptbStockImages.TabStop = false;
            // 
            // cboTiger
            // 
            this.cboTiger.FormattingEnabled = true;
            this.cboTiger.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cboTiger.Location = new System.Drawing.Point(7, 53);
            this.cboTiger.Name = "cboTiger";
            this.cboTiger.Size = new System.Drawing.Size(121, 21);
            this.cboTiger.TabIndex = 1;
            this.cboTiger.SelectedIndexChanged += new System.EventHandler(this.cboTiger_SelectedIndexChanged);
            // 
            // rdbRocks
            // 
            this.rdbRocks.AutoSize = true;
            this.rdbRocks.Location = new System.Drawing.Point(6, 91);
            this.rdbRocks.Name = "rdbRocks";
            this.rdbRocks.Size = new System.Drawing.Size(56, 17);
            this.rdbRocks.TabIndex = 2;
            this.rdbRocks.TabStop = true;
            this.rdbRocks.Text = "Rocks";
            this.rdbRocks.UseVisualStyleBackColor = true;
            this.rdbRocks.CheckedChanged += new System.EventHandler(this.rdbRocks_CheckedChanged);
            // 
            // cboRocks
            // 
            this.cboRocks.FormattingEnabled = true;
            this.cboRocks.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cboRocks.Location = new System.Drawing.Point(7, 114);
            this.cboRocks.Name = "cboRocks";
            this.cboRocks.Size = new System.Drawing.Size(121, 21);
            this.cboRocks.TabIndex = 3;
            this.cboRocks.SelectedIndexChanged += new System.EventHandler(this.cboRocks_SelectedIndexChanged);
            // 
            // frmStockImagesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 468);
            this.Controls.Add(this.ptbStockImages);
            this.Controls.Add(this.btnCloseStockImagePage);
            this.Controls.Add(this.btnSaveStockImage);
            this.Controls.Add(this.rtbStockImages);
            this.Controls.Add(this.grbImages);
            this.Name = "frmStockImagesPage";
            this.Text = "StockImagesPage";
            this.grbImages.ResumeLayout(false);
            this.grbImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStockImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdStockImage;
        private System.Windows.Forms.GroupBox grbImages;
        private System.Windows.Forms.RadioButton rdbTiger;
        private System.Windows.Forms.RichTextBox rtbStockImages;
        private System.Windows.Forms.Button btnSaveStockImage;
        private System.Windows.Forms.Button btnCloseStockImagePage;
        private System.Windows.Forms.ComboBox cboRocks;
        private System.Windows.Forms.RadioButton rdbRocks;
        private System.Windows.Forms.ComboBox cboTiger;
        private System.Windows.Forms.PictureBox ptbStockImages;
    }
}