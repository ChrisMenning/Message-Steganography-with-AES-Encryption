//----------------------------------------------------------------------------------
// <copyright file="HelpPage.Designer.cs" company="Legendary Lichens">
//    © Legendary Lichens. All rights reserved. 
//    2017 - Nathan Beyer / Chris Hoegger / Chris Menning / Leilani Ray
// </copyright>
//---------------------------------------------------------------------------------- 

namespace Steganography_with_AES_Encryption
{
    /// <summary>
    /// Designer Code for the Help Page Form.
    /// </summary>
    public partial class FrmHelpPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Rich Text Box on Help Page; Displays Help information.
        /// </summary>
        private System.Windows.Forms.RichTextBox rtbHelpPage;

        /// <summary>
        /// Close Button on Help Page; Closes Form.
        /// </summary>
        private System.Windows.Forms.Button btnCloseHelpPage;

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
            this.rtbHelpPage = new System.Windows.Forms.RichTextBox();
            this.btnCloseHelpPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbHelpPage
            // 
            this.rtbHelpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.rtbHelpPage.Location = new System.Drawing.Point(70, 30);
            this.rtbHelpPage.Name = "rtbHelpPage";
            this.rtbHelpPage.ReadOnly = true;
            this.rtbHelpPage.Size = new System.Drawing.Size(386, 317);
            this.rtbHelpPage.TabIndex = 0;
            this.rtbHelpPage.Text = string.Empty;
            // 
            // BtnCloseHelpPage
            // 
            this.btnCloseHelpPage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCloseHelpPage.Location = new System.Drawing.Point(204, 392);
            this.btnCloseHelpPage.Name = "BtnCloseHelpPage";
            this.btnCloseHelpPage.Size = new System.Drawing.Size(75, 23);
            this.btnCloseHelpPage.TabIndex = 1;
            this.btnCloseHelpPage.Text = "Close";
            this.btnCloseHelpPage.UseVisualStyleBackColor = true;
            this.btnCloseHelpPage.Click += new System.EventHandler(this.BtnCloseHelpPage_Click);
            // 
            // FrmHelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(511, 445);
            this.Controls.Add(this.btnCloseHelpPage);
            this.Controls.Add(this.rtbHelpPage);
            this.Name = "FrmHelpPage";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.FrmHelpPage_Load);
            this.ResumeLayout(false);

        }
        #endregion
    }
}