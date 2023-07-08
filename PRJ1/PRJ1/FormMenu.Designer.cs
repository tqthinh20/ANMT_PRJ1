namespace PRJ1
{
    partial class FormMenu
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
            this.btn_encForm = new System.Windows.Forms.Button();
            this.btn_decForm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_encForm
            // 
            this.btn_encForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_encForm.Location = new System.Drawing.Point(118, 128);
            this.btn_encForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_encForm.Name = "btn_encForm";
            this.btn_encForm.Size = new System.Drawing.Size(171, 54);
            this.btn_encForm.TabIndex = 6;
            this.btn_encForm.Text = "Encrypt File";
            this.btn_encForm.UseVisualStyleBackColor = true;
            this.btn_encForm.Click += new System.EventHandler(this.btn_encForm_Click);
            // 
            // btn_decForm
            // 
            this.btn_decForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_decForm.Location = new System.Drawing.Point(118, 261);
            this.btn_decForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_decForm.Name = "btn_decForm";
            this.btn_decForm.Size = new System.Drawing.Size(171, 54);
            this.btn_decForm.TabIndex = 7;
            this.btn_decForm.Text = "Decrypt File";
            this.btn_decForm.UseVisualStyleBackColor = true;
            this.btn_decForm.Click += new System.EventHandler(this.btn_decForm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(45, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "File Encryption/Decryption";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_decForm);
            this.Controls.Add(this.btn_encForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(432, 448);
            this.MinimumSize = new System.Drawing.Size(432, 448);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Button btn_encForm;
		private System.Windows.Forms.Button btn_decForm;
		private System.Windows.Forms.Label label7;
    }
}

