namespace Steganography_with_AES_Encryption
{
    partial class FormAdvancedOptions
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
            this.groupBoxAESKey = new System.Windows.Forms.GroupBox();
            this.radioButton256 = new System.Windows.Forms.RadioButton();
            this.radioButton192 = new System.Windows.Forms.RadioButton();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.buttonRestoreDefaults = new System.Windows.Forms.Button();
            this.checkBoxRememberSettings = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAESKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAESKey
            // 
            this.groupBoxAESKey.Controls.Add(this.radioButton256);
            this.groupBoxAESKey.Controls.Add(this.radioButton192);
            this.groupBoxAESKey.Controls.Add(this.radioButton128);
            this.groupBoxAESKey.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAESKey.Name = "groupBoxAESKey";
            this.groupBoxAESKey.Size = new System.Drawing.Size(330, 100);
            this.groupBoxAESKey.TabIndex = 2;
            this.groupBoxAESKey.TabStop = false;
            this.groupBoxAESKey.Text = "AES key size";
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
            // buttonRestoreDefaults
            // 
            this.buttonRestoreDefaults.Location = new System.Drawing.Point(12, 151);
            this.buttonRestoreDefaults.Name = "buttonRestoreDefaults";
            this.buttonRestoreDefaults.Size = new System.Drawing.Size(99, 42);
            this.buttonRestoreDefaults.TabIndex = 3;
            this.buttonRestoreDefaults.Text = "Restore Defaults";
            this.buttonRestoreDefaults.UseVisualStyleBackColor = true;
            this.buttonRestoreDefaults.Click += new System.EventHandler(this.ButtonRestoreDefaults_Click);
            // 
            // checkBoxRememberSettings
            // 
            this.checkBoxRememberSettings.AutoSize = true;
            this.checkBoxRememberSettings.Checked = true;
            this.checkBoxRememberSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRememberSettings.Location = new System.Drawing.Point(12, 124);
            this.checkBoxRememberSettings.Name = "checkBoxRememberSettings";
            this.checkBoxRememberSettings.Size = new System.Drawing.Size(160, 21);
            this.checkBoxRememberSettings.TabIndex = 4;
            this.checkBoxRememberSettings.Text = "Remember settings?";
            this.checkBoxRememberSettings.UseVisualStyleBackColor = true;
            this.checkBoxRememberSettings.CheckedChanged += new System.EventHandler(this.CheckBoxRememberSettings_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(129, 151);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 42);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(243, 151);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 42);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormAdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 210);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxRememberSettings);
            this.Controls.Add(this.buttonRestoreDefaults);
            this.Controls.Add(this.groupBoxAESKey);
            this.Name = "FormAdvancedOptions";
            this.Text = "Advanced Options";
            this.groupBoxAESKey.ResumeLayout(false);
            this.groupBoxAESKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAESKey;
        private System.Windows.Forms.RadioButton radioButton256;
        private System.Windows.Forms.RadioButton radioButton192;
        private System.Windows.Forms.RadioButton radioButton128;
        private System.Windows.Forms.Button buttonRestoreDefaults;
        private System.Windows.Forms.CheckBox checkBoxRememberSettings;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}