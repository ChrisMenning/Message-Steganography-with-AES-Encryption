﻿namespace Steganography_with_AES_Encryption
{
    partial class frmAboutPage
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
            this.rtbAboutSection = new System.Windows.Forms.RichTextBox();
            this.btnCloseAboutPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAboutSection
            // 
            this.rtbAboutSection.Enabled = false;
            this.rtbAboutSection.Location = new System.Drawing.Point(30, 23);
            this.rtbAboutSection.Name = "rtbAboutSection";
            this.rtbAboutSection.Size = new System.Drawing.Size(369, 345);
            this.rtbAboutSection.TabIndex = 0;
            this.rtbAboutSection.Text = "";
            // 
            // btnCloseAboutPage
            // 
            this.btnCloseAboutPage.Location = new System.Drawing.Point(167, 393);
            this.btnCloseAboutPage.Name = "btnCloseAboutPage";
            this.btnCloseAboutPage.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAboutPage.TabIndex = 1;
            this.btnCloseAboutPage.Text = "Close";
            this.btnCloseAboutPage.UseVisualStyleBackColor = true;
            this.btnCloseAboutPage.Click += new System.EventHandler(this.btnCloseAboutPage_Click);
            // 
            // frmAboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 428);
            this.Controls.Add(this.btnCloseAboutPage);
            this.Controls.Add(this.rtbAboutSection);
            this.Name = "frmAboutPage";
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAboutPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAboutSection;
        private System.Windows.Forms.Button btnCloseAboutPage;
    }
}