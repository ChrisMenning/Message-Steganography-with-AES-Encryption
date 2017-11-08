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
            this.rdbCrab = new System.Windows.Forms.RadioButton();
            this.rdbTiger = new System.Windows.Forms.RadioButton();
            this.grbImageSize = new System.Windows.Forms.GroupBox();
            this.rtbStockImages = new System.Windows.Forms.RichTextBox();
            this.btnSaveStockImage = new System.Windows.Forms.Button();
            this.btnCloseStockImagePage = new System.Windows.Forms.Button();
            this.grbImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbImages
            // 
            this.grbImages.Controls.Add(this.rdbCrab);
            this.grbImages.Controls.Add(this.rdbTiger);
            this.grbImages.Location = new System.Drawing.Point(32, 54);
            this.grbImages.Name = "grbImages";
            this.grbImages.Size = new System.Drawing.Size(75, 198);
            this.grbImages.TabIndex = 0;
            this.grbImages.TabStop = false;
            this.grbImages.Text = "Images";
            // 
            // rdbCrab
            // 
            this.rdbCrab.AutoSize = true;
            this.rdbCrab.Location = new System.Drawing.Point(7, 54);
            this.rdbCrab.Name = "rdbCrab";
            this.rdbCrab.Size = new System.Drawing.Size(47, 17);
            this.rdbCrab.TabIndex = 1;
            this.rdbCrab.TabStop = true;
            this.rdbCrab.Text = "Crab";
            this.rdbCrab.UseVisualStyleBackColor = true;
            this.rdbCrab.CheckedChanged += new System.EventHandler(this.rdbCrab_CheckedChanged);
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
            // grbImageSize
            // 
            this.grbImageSize.Location = new System.Drawing.Point(123, 54);
            this.grbImageSize.Name = "grbImageSize";
            this.grbImageSize.Size = new System.Drawing.Size(75, 198);
            this.grbImageSize.TabIndex = 1;
            this.grbImageSize.TabStop = false;
            this.grbImageSize.Text = "Size";
            // 
            // rtbStockImages
            // 
            this.rtbStockImages.Location = new System.Drawing.Point(223, 54);
            this.rtbStockImages.Name = "rtbStockImages";
            this.rtbStockImages.Size = new System.Drawing.Size(171, 198);
            this.rtbStockImages.TabIndex = 2;
            this.rtbStockImages.Text = "";
            // 
            // btnSaveStockImage
            // 
            this.btnSaveStockImage.Location = new System.Drawing.Point(53, 332);
            this.btnSaveStockImage.Name = "btnSaveStockImage";
            this.btnSaveStockImage.Size = new System.Drawing.Size(97, 23);
            this.btnSaveStockImage.TabIndex = 3;
            this.btnSaveStockImage.Text = "Save Image";
            this.btnSaveStockImage.UseVisualStyleBackColor = true;
            this.btnSaveStockImage.Click += new System.EventHandler(this.btnSaveStockImage_Click);
            // 
            // btnCloseStockImagePage
            // 
            this.btnCloseStockImagePage.Location = new System.Drawing.Point(262, 332);
            this.btnCloseStockImagePage.Name = "btnCloseStockImagePage";
            this.btnCloseStockImagePage.Size = new System.Drawing.Size(75, 23);
            this.btnCloseStockImagePage.TabIndex = 4;
            this.btnCloseStockImagePage.Text = "Close";
            this.btnCloseStockImagePage.UseVisualStyleBackColor = true;
            this.btnCloseStockImagePage.Click += new System.EventHandler(this.btnCloseStockImagePage_Click);
            // 
            // frmStockImagesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 402);
            this.Controls.Add(this.btnCloseStockImagePage);
            this.Controls.Add(this.btnSaveStockImage);
            this.Controls.Add(this.rtbStockImages);
            this.Controls.Add(this.grbImageSize);
            this.Controls.Add(this.grbImages);
            this.Name = "frmStockImagesPage";
            this.Text = "StockImagesPage";
            this.grbImages.ResumeLayout(false);
            this.grbImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdStockImage;
        private System.Windows.Forms.GroupBox grbImages;
        private System.Windows.Forms.RadioButton rdbTiger;
        private System.Windows.Forms.GroupBox grbImageSize;
        private System.Windows.Forms.RichTextBox rtbStockImages;
        private System.Windows.Forms.Button btnSaveStockImage;
        private System.Windows.Forms.RadioButton rdbCrab;
        private System.Windows.Forms.Button btnCloseStockImagePage;
    }
}