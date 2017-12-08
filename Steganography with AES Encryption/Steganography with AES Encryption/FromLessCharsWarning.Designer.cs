namespace Steganography_with_AES_Encryption
{
    partial class FormLessChars
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShowNextTime = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 155);
            this.label1.TabIndex = 0;
            this.label1.Text = "Using encryption makes your message more secure, but it also limits the length of" +
    " the storable message by a factor of 10, and increases the time needed to encode" +
    " and decode.";
            // 
            // checkBoxShowNextTime
            // 
            this.checkBoxShowNextTime.AutoSize = true;
            this.checkBoxShowNextTime.Checked = true;
            this.checkBoxShowNextTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowNextTime.Location = new System.Drawing.Point(24, 256);
            this.checkBoxShowNextTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShowNextTime.Name = "checkBoxShowNextTime";
            this.checkBoxShowNextTime.Size = new System.Drawing.Size(262, 27);
            this.checkBoxShowNextTime.TabIndex = 1;
            this.checkBoxShowNextTime.Text = "Show This Message Next Time";
            this.checkBoxShowNextTime.UseVisualStyleBackColor = true;
            this.checkBoxShowNextTime.CheckedChanged += new System.EventHandler(this.checkBoxShowNextTime_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(24, 198);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(272, 47);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormLessChars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 334);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxShowNextTime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLessChars";
            this.Text = "Warning!";
            this.Load += new System.EventHandler(this.formLessChars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxShowNextTime;
        private System.Windows.Forms.Button buttonOK;
    }
}