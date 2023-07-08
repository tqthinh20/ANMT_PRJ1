namespace PRJ1
{
    partial class FormDecrypt
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
            this.btn_Browse1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Browse2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Browse3 = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Browse1
            // 
            this.btn_Browse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Browse1.Location = new System.Drawing.Point(578, 122);
            this.btn_Browse1.Name = "btn_Browse1";
            this.btn_Browse1.Size = new System.Drawing.Size(83, 26);
            this.btn_Browse1.TabIndex = 7;
            this.btn_Browse1.Text = "Browse";
            this.btn_Browse1.UseVisualStyleBackColor = true;
            this.btn_Browse1.Click += new System.EventHandler(this.btn_Browse1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "File to Decrypt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(210, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "DECRYPTION";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(387, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Private key";
            // 
            // btn_Browse2
            // 
            this.btn_Browse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Browse2.Location = new System.Drawing.Point(578, 191);
            this.btn_Browse2.Name = "btn_Browse2";
            this.btn_Browse2.Size = new System.Drawing.Size(83, 26);
            this.btn_Browse2.TabIndex = 7;
            this.btn_Browse2.Text = "Browse";
            this.btn_Browse2.UseVisualStyleBackColor = true;
            this.btn_Browse2.Click += new System.EventHandler(this.btn_Browse2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 260);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(387, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(30, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "KSSS";
            // 
            // btn_Browse3
            // 
            this.btn_Browse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Browse3.Location = new System.Drawing.Point(578, 260);
            this.btn_Browse3.Name = "btn_Browse3";
            this.btn_Browse3.Size = new System.Drawing.Size(83, 26);
            this.btn_Browse3.TabIndex = 7;
            this.btn_Browse3.Text = "Browse";
            this.btn_Browse3.UseVisualStyleBackColor = true;
            this.btn_Browse3.Click += new System.EventHandler(this.btn_Browse3_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(575, 373);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 35);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Dec
            // 
            this.btn_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Dec.Location = new System.Drawing.Point(190, 323);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(163, 59);
            this.btn_Dec.TabIndex = 9;
            this.btn_Dec.Text = "Decrypt";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.btn_Dec_Click);
            // 
            // FormDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 420);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Browse3);
            this.Controls.Add(this.btn_Browse2);
            this.Controls.Add(this.btn_Browse1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDecrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Browse2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Browse3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Dec;
    }
}