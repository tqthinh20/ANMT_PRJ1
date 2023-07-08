using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ1
{
    public partial class FormDecrypt : Form
    {
        public FormDecrypt()
        {
            InitializeComponent();
        }

        private void btn_Browse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  //Browse file from computer
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;   //Get file name
        }

        private void btn_Browse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  //Browse file from computer
            ofd.ShowDialog();
            textBox2.Text = ofd.FileName;   //Get file name
        }

        private void btn_Browse3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  //Browse file from computer
            ofd.ShowDialog();
            textBox3.Text = ofd.FileName;   //Get file name
        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(textBox1.Text) && File.Exists(textBox2.Text) && File.Exists(textBox3.Text))
                {
                    StreamReader rd = new StreamReader(textBox2.Text);
                    string Kprivate = rd.ReadToEnd();
                    rd.Close();

                    StreamReader rd1 = new StreamReader(textBox3.Text);
                    string Kx = rd1.ReadLine();
                    string HKprivate = rd1.ReadLine();
                    rd1.Close();

                    if (PRJ1_module.HASH.hashString(PRJ1_module.HASH.HashSHA256(Kprivate)) == HKprivate)
                    {
                        string Ks = PRJ1_module.RSA.Decrypt(Kx, Kprivate);

                        FolderBrowserDialog fbd = new FolderBrowserDialog();
                        fbd.ShowDialog();
                        string path = fbd.SelectedPath;
                        path = path + "\\Test1.txt";

                        PRJ1_module.AES.FileDecrypt(textBox1.Text, path, Ks);

                        MessageBox.Show("Decrypt successfully!");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid file input!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu form = new FormMenu();
            form.ShowDialog();
            this.Close();
        }
    }
}
