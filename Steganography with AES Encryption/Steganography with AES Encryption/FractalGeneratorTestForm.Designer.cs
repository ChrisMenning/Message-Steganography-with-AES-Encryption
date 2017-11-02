namespace Steganography_with_AES_Encryption
{
    partial class frmFractalGeneratorTestForm
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
            this.ptbTest = new System.Windows.Forms.PictureBox();
            this.btnGenerateFractal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbTest
            // 
            this.ptbTest.Location = new System.Drawing.Point(93, 12);
            this.ptbTest.Name = "ptbTest";
            this.ptbTest.Size = new System.Drawing.Size(358, 299);
            this.ptbTest.TabIndex = 0;
            this.ptbTest.TabStop = false;
            // 
            // btnGenerateFractal
            // 
            this.btnGenerateFractal.Location = new System.Drawing.Point(190, 343);
            this.btnGenerateFractal.Name = "btnGenerateFractal";
            this.btnGenerateFractal.Size = new System.Drawing.Size(137, 29);
            this.btnGenerateFractal.TabIndex = 1;
            this.btnGenerateFractal.Text = "Generate Fractal";
            this.btnGenerateFractal.UseVisualStyleBackColor = true;
            this.btnGenerateFractal.Click += new System.EventHandler(this.btnGenerateFractal_Click);
            // 
            // frmFractalGeneratorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 400);
            this.Controls.Add(this.btnGenerateFractal);
            this.Controls.Add(this.ptbTest);
            this.Name = "frmFractalGeneratorTestForm";
            this.Text = "FractalGeneratorTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTest;
        private System.Windows.Forms.Button btnGenerateFractal;
    }
}