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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRJ1
{
    public partial class FormEncrypt : Form
    {
        public FormEncrypt()
        {
            InitializeComponent();
        }

        private void FormEncrypt_Load(object sender, EventArgs e)
        {

        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  //Browse file from computer
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;   //Get file name
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox2.Text = fbd.SelectedPath;
        }

        private void btn_Enc_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(textBox1.Text) && Directory.Exists(textBox2.Text)) 
                {
                    string Ks = PRJ1_module.AES.GenerateKey();  //Generate AES key (Ks)
                    PRJ1_module.AES.FileEncrypt(textBox1.Text, Ks);  //Encrypt chosen file with Ks

                    Tuple<string, string> kp = PRJ1_module.RSA.GenerateKey();   //Generate a pair of private key (Kprivate) and public key (Kpublic) of RSA
                    string Kpublic = kp.Item1;   //Get Kpublic
                    string Kprivate = kp.Item2;   //Get Kprivate


                    string Kx = PRJ1_module.RSA.Encrypt(Ks, Kpublic);   //Encrypt Ks by RSA using Kpublic (output Kx)


                    PRJ1_module.RSA.exportKey(textBox2.Text, Kprivate);    //Write Kprivate into file

                    //Hash Kprivate by SHA256
                    string HKprivate = PRJ1_module.HASH.hashString(PRJ1_module.HASH.HashSHA1(Kprivate));

                    //Write Kx and HKprivate into file
                    StreamWriter wr = new StreamWriter(textBox2.Text + "\\Kx_HKpr.metadata");
                    wr.WriteLine(Kx);
                    wr.WriteLine(HKprivate);
                    wr.Write(Path.GetExtension(textBox1.Text));
                    wr.Close();

                    MessageBox.Show("Encrypt successfully!");
                }
                
                else {
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
