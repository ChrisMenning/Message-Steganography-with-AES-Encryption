//----------------------------------------------------------------------------------
// <copyright file="AboutPage.Designer.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    /// <summary>
    /// Code for the About Page Form.
    /// </summary>
    public partial class FrmAboutPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Rich Text Box Object; Stores About Information.
        /// </summary>
        private System.Windows.Forms.RichTextBox rtbAboutSection;

        /// <summary>
        /// Close Button Object; Closes Form.
        /// </summary>
        private System.Windows.Forms.Button btnCloseAboutPage;

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
            this.rtbAboutSection = new System.Windows.Forms.RichTextBox();
            this.btnCloseAboutPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAboutSection
            // 
            this.rtbAboutSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.rtbAboutSection.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAboutSection.Location = new System.Drawing.Point(30, 23);
            this.rtbAboutSection.Name = "rtbAboutSection";
            this.rtbAboutSection.ReadOnly = true;
            this.rtbAboutSection.Size = new System.Drawing.Size(818, 462);
            this.rtbAboutSection.TabIndex = 0;
            this.rtbAboutSection.Text = string.Empty;
            // 
            // BtnCloseAboutPage
            // 
            this.btnCloseAboutPage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCloseAboutPage.Location = new System.Drawing.Point(386, 508);
            this.btnCloseAboutPage.Name = "BtnCloseAboutPage";
            this.btnCloseAboutPage.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAboutPage.TabIndex = 1;
            this.btnCloseAboutPage.Text = "Close";
            this.btnCloseAboutPage.UseVisualStyleBackColor = true;
            this.btnCloseAboutPage.Click += new System.EventHandler(this.BtnCloseAboutPage_Click);
            // 
            // FrmAboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(879, 560);
            this.Controls.Add(this.btnCloseAboutPage);
            this.Controls.Add(this.rtbAboutSection);
            this.Name = "FrmAboutPage";
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAboutPage_Load);
            this.ResumeLayout(false);

        }
        #endregion
    }
}