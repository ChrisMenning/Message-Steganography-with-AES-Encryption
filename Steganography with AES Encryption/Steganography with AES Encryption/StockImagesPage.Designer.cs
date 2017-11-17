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
            this.grbImages = new System.Windows.Forms.GroupBox();
            this.rdbTiger = new System.Windows.Forms.RadioButton();
            this.rdbRocks = new System.Windows.Forms.RadioButton();
            this.rdbPenguin = new System.Windows.Forms.RadioButton();
            this.rdbDog = new System.Windows.Forms.RadioButton();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rtbStockImage = new System.Windows.Forms.RichTextBox();
            this.sfdStockImages = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenStockImage = new System.Windows.Forms.Button();
            this.btnStockImagesClose = new System.Windows.Forms.Button();
            this.ptbStockImage = new System.Windows.Forms.PictureBox();
            this.grbImages.SuspendLayout();
            this.grbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStockImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbImages
            // 
            this.grbImages.Controls.Add(this.rdbTiger);
            this.grbImages.Controls.Add(this.rdbRocks);
            this.grbImages.Controls.Add(this.rdbPenguin);
            this.grbImages.Controls.Add(this.rdbDog);
            this.grbImages.Location = new System.Drawing.Point(34, 49);
            this.grbImages.Name = "grbImages";
            this.grbImages.Size = new System.Drawing.Size(102, 120);
            this.grbImages.TabIndex = 0;
            this.grbImages.TabStop = false;
            this.grbImages.Text = "Images";
            // 
            // rdbTiger
            // 
            this.rdbTiger.AutoSize = true;
            this.rdbTiger.Location = new System.Drawing.Point(6, 89);
            this.rdbTiger.Name = "rdbTiger";
            this.rdbTiger.Size = new System.Drawing.Size(49, 17);
            this.rdbTiger.TabIndex = 3;
            this.rdbTiger.TabStop = true;
            this.rdbTiger.Text = "Tiger";
            this.rdbTiger.UseVisualStyleBackColor = true;
            this.rdbTiger.CheckedChanged += new System.EventHandler(this.rdbTiger_CheckedChanged);
            // 
            // rdbRocks
            // 
            this.rdbRocks.AutoSize = true;
            this.rdbRocks.Location = new System.Drawing.Point(6, 65);
            this.rdbRocks.Name = "rdbRocks";
            this.rdbRocks.Size = new System.Drawing.Size(56, 17);
            this.rdbRocks.TabIndex = 2;
            this.rdbRocks.TabStop = true;
            this.rdbRocks.Text = "Rocks";
            this.rdbRocks.UseVisualStyleBackColor = true;
            this.rdbRocks.CheckedChanged += new System.EventHandler(this.rdbRocks_CheckedChanged);
            // 
            // rdbPenguin
            // 
            this.rdbPenguin.AutoSize = true;
            this.rdbPenguin.Location = new System.Drawing.Point(6, 42);
            this.rdbPenguin.Name = "rdbPenguin";
            this.rdbPenguin.Size = new System.Drawing.Size(64, 17);
            this.rdbPenguin.TabIndex = 1;
            this.rdbPenguin.TabStop = true;
            this.rdbPenguin.Text = "Penguin";
            this.rdbPenguin.UseVisualStyleBackColor = true;
            this.rdbPenguin.CheckedChanged += new System.EventHandler(this.rdbPenguin_CheckedChanged);
            // 
            // rdbDog
            // 
            this.rdbDog.AutoSize = true;
            this.rdbDog.Checked = true;
            this.rdbDog.Location = new System.Drawing.Point(6, 19);
            this.rdbDog.Name = "rdbDog";
            this.rdbDog.Size = new System.Drawing.Size(45, 17);
            this.rdbDog.TabIndex = 0;
            this.rdbDog.TabStop = true;
            this.rdbDog.Text = "Dog";
            this.rdbDog.UseVisualStyleBackColor = true;
            this.rdbDog.CheckedChanged += new System.EventHandler(this.rdbDog_CheckedChanged);
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.rdbSmall);
            this.grbSize.Controls.Add(this.rdbMedium);
            this.grbSize.Controls.Add(this.rdbLarge);
            this.grbSize.Location = new System.Drawing.Point(142, 49);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(97, 120);
            this.grbSize.TabIndex = 1;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Sizes";
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(6, 78);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(50, 17);
            this.rdbSmall.TabIndex = 2;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(6, 54);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(62, 17);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(6, 31);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(52, 17);
            this.rdbLarge.TabIndex = 0;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rtbStockImage
            // 
            this.rtbStockImage.Location = new System.Drawing.Point(34, 175);
            this.rtbStockImage.Name = "rtbStockImage";
            this.rtbStockImage.Size = new System.Drawing.Size(205, 214);
            this.rtbStockImage.TabIndex = 3;
            this.rtbStockImage.Text = "";
            // 
            // btnOpenStockImage
            // 
            this.btnOpenStockImage.Location = new System.Drawing.Point(34, 408);
            this.btnOpenStockImage.Name = "btnOpenStockImage";
            this.btnOpenStockImage.Size = new System.Drawing.Size(91, 23);
            this.btnOpenStockImage.TabIndex = 4;
            this.btnOpenStockImage.Text = "Open Image";
            this.btnOpenStockImage.UseVisualStyleBackColor = true;
            this.btnOpenStockImage.Click += new System.EventHandler(this.btnSaveStockImage_Click);
            // 
            // btnStockImagesClose
            // 
            this.btnStockImagesClose.Location = new System.Drawing.Point(148, 408);
            this.btnStockImagesClose.Name = "btnStockImagesClose";
            this.btnStockImagesClose.Size = new System.Drawing.Size(91, 23);
            this.btnStockImagesClose.TabIndex = 5;
            this.btnStockImagesClose.Text = "Close";
            this.btnStockImagesClose.UseVisualStyleBackColor = true;
            this.btnStockImagesClose.Click += new System.EventHandler(this.btnStockImagesClose_Click);
            // 
            // ptbStockImage
            // 
            this.ptbStockImage.Location = new System.Drawing.Point(278, 49);
            this.ptbStockImage.Name = "ptbStockImage";
            this.ptbStockImage.Size = new System.Drawing.Size(558, 382);
            this.ptbStockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbStockImage.TabIndex = 2;
            this.ptbStockImage.TabStop = false;
            // 
            // frmStockImagesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 459);
            this.Controls.Add(this.btnStockImagesClose);
            this.Controls.Add(this.btnOpenStockImage);
            this.Controls.Add(this.rtbStockImage);
            this.Controls.Add(this.ptbStockImage);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.grbImages);
            this.Name = "frmStockImagesPage";
            this.Text = "StockImagesPage";
            this.Load += new System.EventHandler(this.frmStockImagesPage_Load);
            this.grbImages.ResumeLayout(false);
            this.grbImages.PerformLayout();
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStockImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbImages;
        private System.Windows.Forms.RadioButton rdbTiger;
        private System.Windows.Forms.RadioButton rdbRocks;
        private System.Windows.Forms.RadioButton rdbPenguin;
        private System.Windows.Forms.RadioButton rdbDog;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.PictureBox ptbStockImage;
        private System.Windows.Forms.RichTextBox rtbStockImage;
        private System.Windows.Forms.SaveFileDialog sfdStockImages;
        private System.Windows.Forms.Button btnOpenStockImage;
        private System.Windows.Forms.Button btnStockImagesClose;
    }
}