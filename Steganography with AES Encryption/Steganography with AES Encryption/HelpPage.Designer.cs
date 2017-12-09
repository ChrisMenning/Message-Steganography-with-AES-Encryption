namespace Steganography_with_AES_Encryption
{
    partial class frmHelpPage
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
            this.rtbHelpPage = new System.Windows.Forms.RichTextBox();
            this.btnCloseHelpPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbHelpPage
            // 
            this.rtbHelpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.rtbHelpPage.Location = new System.Drawing.Point(93, 37);
            this.rtbHelpPage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbHelpPage.Name = "rtbHelpPage";
            this.rtbHelpPage.ReadOnly = true;
            this.rtbHelpPage.Size = new System.Drawing.Size(513, 389);
            this.rtbHelpPage.TabIndex = 0;
            this.rtbHelpPage.Text = "";
            // 
            // btnCloseHelpPage
            // 
            this.btnCloseHelpPage.Location = new System.Drawing.Point(272, 482);
            this.btnCloseHelpPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseHelpPage.Name = "btnCloseHelpPage";
            this.btnCloseHelpPage.Size = new System.Drawing.Size(100, 28);
            this.btnCloseHelpPage.TabIndex = 1;
            this.btnCloseHelpPage.Text = "Close";
            this.btnCloseHelpPage.UseVisualStyleBackColor = true;
            this.btnCloseHelpPage.Click += new System.EventHandler(this.btnCloseHelpPage_Click);
            // 
            // frmHelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(681, 548);
            this.Controls.Add(this.btnCloseHelpPage);
            this.Controls.Add(this.rtbHelpPage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHelpPage";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelpPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHelpPage;
        private System.Windows.Forms.Button btnCloseHelpPage;
    }
}