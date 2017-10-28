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
            this.groupBoxColorChannels = new System.Windows.Forms.GroupBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.groupBoxAESBlock = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxSaving = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBoxColorChannels.SuspendLayout();
            this.groupBoxAESBlock.SuspendLayout();
            this.groupBoxSaving.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColorChannels
            // 
            this.groupBoxColorChannels.Controls.Add(this.checkBoxB);
            this.groupBoxColorChannels.Controls.Add(this.checkBoxG);
            this.groupBoxColorChannels.Controls.Add(this.checkBoxR);
            this.groupBoxColorChannels.Controls.Add(this.checkBoxA);
            this.groupBoxColorChannels.Location = new System.Drawing.Point(12, 12);
            this.groupBoxColorChannels.Name = "groupBoxColorChannels";
            this.groupBoxColorChannels.Size = new System.Drawing.Size(330, 134);
            this.groupBoxColorChannels.TabIndex = 1;
            this.groupBoxColorChannels.TabStop = false;
            this.groupBoxColorChannels.Text = "Color Channels (Bitmap Encoding Only)";
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(20, 21);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(66, 21);
            this.checkBoxA.TabIndex = 0;
            this.checkBoxA.Text = "Alpha";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Location = new System.Drawing.Point(20, 48);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(56, 21);
            this.checkBoxR.TabIndex = 1;
            this.checkBoxR.Text = "Red";
            this.checkBoxR.UseVisualStyleBackColor = true;
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Location = new System.Drawing.Point(20, 75);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(70, 21);
            this.checkBoxG.TabIndex = 2;
            this.checkBoxG.Text = "Green";
            this.checkBoxG.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(20, 102);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(58, 21);
            this.checkBoxB.TabIndex = 3;
            this.checkBoxB.Text = "Blue";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // groupBoxAESBlock
            // 
            this.groupBoxAESBlock.Controls.Add(this.radioButton3);
            this.groupBoxAESBlock.Controls.Add(this.radioButton2);
            this.groupBoxAESBlock.Controls.Add(this.radioButton1);
            this.groupBoxAESBlock.Location = new System.Drawing.Point(12, 152);
            this.groupBoxAESBlock.Name = "groupBoxAESBlock";
            this.groupBoxAESBlock.Size = new System.Drawing.Size(330, 100);
            this.groupBoxAESBlock.TabIndex = 2;
            this.groupBoxAESBlock.TabStop = false;
            this.groupBoxAESBlock.Text = "AES block size";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "128 bits";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "192 bits";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(238, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "256 bits";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restore Defaults";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 403);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remember settings?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBoxSaving
            // 
            this.groupBoxSaving.Controls.Add(this.radioButton6);
            this.groupBoxSaving.Controls.Add(this.radioButton5);
            this.groupBoxSaving.Controls.Add(this.radioButton4);
            this.groupBoxSaving.Location = new System.Drawing.Point(12, 258);
            this.groupBoxSaving.Name = "groupBoxSaving";
            this.groupBoxSaving.Size = new System.Drawing.Size(330, 139);
            this.groupBoxSaving.TabIndex = 7;
            this.groupBoxSaving.TabStop = false;
            this.groupBoxSaving.Text = "Saving";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(290, 21);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Save as the same format as the input file.";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(20, 49);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(161, 21);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Always Save as PNG";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(20, 77);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(158, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Always Save as JPG";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // AdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 485);
            this.Controls.Add(this.groupBoxSaving);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxAESBlock);
            this.Controls.Add(this.groupBoxColorChannels);
            this.Name = "AdvancedOptions";
            this.Text = "Advanced Options";
            this.groupBoxColorChannels.ResumeLayout(false);
            this.groupBoxColorChannels.PerformLayout();
            this.groupBoxAESBlock.ResumeLayout(false);
            this.groupBoxAESBlock.PerformLayout();
            this.groupBoxSaving.ResumeLayout(false);
            this.groupBoxSaving.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxColorChannels;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.GroupBox groupBoxAESBlock;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxSaving;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}