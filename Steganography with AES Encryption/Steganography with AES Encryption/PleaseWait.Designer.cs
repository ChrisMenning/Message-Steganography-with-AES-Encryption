namespace Steganography_with_AES_Encryption
{
    partial class PleaseWait
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
            this.labelStaticWait = new System.Windows.Forms.Label();
            this.labelWaitMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStaticWait
            // 
            this.labelStaticWait.Location = new System.Drawing.Point(16, 19);
            this.labelStaticWait.Name = "labelStaticWait";
            this.labelStaticWait.Size = new System.Drawing.Size(304, 23);
            this.labelStaticWait.TabIndex = 0;
            this.labelStaticWait.Text = "Please Wait";
            this.labelStaticWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWaitMessage
            // 
            this.labelWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWaitMessage.Location = new System.Drawing.Point(12, 64);
            this.labelWaitMessage.Name = "labelWaitMessage";
            this.labelWaitMessage.Size = new System.Drawing.Size(308, 98);
            this.labelWaitMessage.TabIndex = 1;
            this.labelWaitMessage.Text = "Message";
            this.labelWaitMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWaitMessage.Click += new System.EventHandler(this.labelWaitMessage_Click);
            // 
            // PleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 171);
            this.ControlBox = false;
            this.Controls.Add(this.labelWaitMessage);
            this.Controls.Add(this.labelStaticWait);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PleaseWait";
            this.Text = "Processing...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStaticWait;
        private System.Windows.Forms.Label labelWaitMessage;
    }
}