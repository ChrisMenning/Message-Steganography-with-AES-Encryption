namespace Steganography_with_AES_Encryption
{
    partial class AdvancedOptions
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
            this.groupBoxAESBlock = new System.Windows.Forms.GroupBox();
            this.radioButton256 = new System.Windows.Forms.RadioButton();
            this.radioButton192 = new System.Windows.Forms.RadioButton();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxAESBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAESBlock
            // 
            this.groupBoxAESBlock.Controls.Add(this.radioButton256);
            this.groupBoxAESBlock.Controls.Add(this.radioButton192);
            this.groupBoxAESBlock.Controls.Add(this.radioButton128);
            this.groupBoxAESBlock.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAESBlock.Name = "groupBoxAESBlock";
            this.groupBoxAESBlock.Size = new System.Drawing.Size(330, 100);
            this.groupBoxAESBlock.TabIndex = 2;
            this.groupBoxAESBlock.TabStop = false;
            this.groupBoxAESBlock.Text = "AES block size";
            // 
            // radioButton256
            // 
            this.radioButton256.AutoSize = true;
            this.radioButton256.Location = new System.Drawing.Point(238, 48);
            this.radioButton256.Name = "radioButton256";
            this.radioButton256.Size = new System.Drawing.Size(79, 21);
            this.radioButton256.TabIndex = 2;
            this.radioButton256.TabStop = true;
            this.radioButton256.Text = "256 bits";
            this.radioButton256.UseVisualStyleBackColor = true;
            // 
            // radioButton192
            // 
            this.radioButton192.AutoSize = true;
            this.radioButton192.Location = new System.Drawing.Point(128, 48);
            this.radioButton192.Name = "radioButton192";
            this.radioButton192.Size = new System.Drawing.Size(79, 21);
            this.radioButton192.TabIndex = 1;
            this.radioButton192.TabStop = true;
            this.radioButton192.Text = "192 bits";
            this.radioButton192.UseVisualStyleBackColor = true;
            // 
            // radioButton128
            // 
            this.radioButton128.AutoSize = true;
            this.radioButton128.Location = new System.Drawing.Point(20, 48);
            this.radioButton128.Name = "radioButton128";
            this.radioButton128.Size = new System.Drawing.Size(79, 21);
            this.radioButton128.TabIndex = 0;
            this.radioButton128.TabStop = true;
            this.radioButton128.Text = "128 bits";
            this.radioButton128.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restore Defaults";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remember settings?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 210);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxAESBlock);
            this.Name = "AdvancedOptions";
            this.Text = "Advanced Options";
            this.groupBoxAESBlock.ResumeLayout(false);
            this.groupBoxAESBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAESBlock;
        private System.Windows.Forms.RadioButton radioButton256;
        private System.Windows.Forms.RadioButton radioButton192;
        private System.Windows.Forms.RadioButton radioButton128;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}