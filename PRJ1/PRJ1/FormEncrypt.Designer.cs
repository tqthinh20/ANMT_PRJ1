namespace PRJ1
{
    partial class FormEncrypt
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
            this.btn_Enc = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Enc
            // 
            this.btn_Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Enc.Location = new System.Drawing.Point(195, 276);
            this.btn_Enc.Name = "btn_Enc";
            this.btn_Enc.Size = new System.Drawing.Size(163, 59);
            this.btn_Enc.TabIndex = 0;
            this.btn_Enc.Text = "Encrypt";
            this.btn_Enc.UseVisualStyleBackColor = true;
            this.btn_Enc.Click += new System.EventHandler(this.btn_Enc_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(518, 327);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 35);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(34, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name";
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_BrowseFile.Location = new System.Drawing.Point(528, 117);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(83, 26);
            this.btn_BrowseFile.TabIndex = 4;
            this.btn_BrowseFile.Text = "Browse";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(179, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENCRYPTION";
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Select.Location = new System.Drawing.Point(528, 201);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(83, 26);
            this.btn_Select.TabIndex = 8;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(34, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Export Path";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 22);
            this.textBox2.TabIndex = 6;
            // 
            // FormEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 374);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_BrowseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Enc);
            this.Name = "FormEncrypt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEncrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enc;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BrowseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}