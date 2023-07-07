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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //B1
            textBox1.Text = PRJ1_module.AES.GenerateKey();

            PRJ1_module.AES.FileEncrypt("C:\\Users\\tqthinh16\\Downloads\\Test.txt", textBox1.Text);

            Tuple <string, string> kp = PRJ1_module.RSA.GenerateKey();

            textBox2.Text = kp.Item2;
            

            textBox3.Text = PRJ1_module.RSA.Encrypt(textBox1.Text, kp.Item1);            

            
            PRJ1_module.RSA.exportKey(kp.Item2);            
            

            textBox4.Text = PRJ1_module.HASH.hashString(PRJ1_module.HASH.HashSHA256(kp.Item2));

            StreamWriter wr = new StreamWriter("C:\\Users\\tqthinh16\\Downloads\\KSSS.txt");
            wr.WriteLine(textBox3.Text);
            wr.Write(textBox4.Text);
            wr.Close();


            //B2
            StreamReader rd = new StreamReader("C:\\Users\\tqthinh16\\Downloads\\kprivate.txt");
            string t = rd.ReadToEnd();

            StreamReader rd1 = new StreamReader("C:\\Users\\tqthinh16\\Downloads\\KSSS.txt");
            string k1 = rd1.ReadLine();
            string h = rd1.ReadLine();

            textBox5.Text = PRJ1_module.HASH.hashString(PRJ1_module.HASH.HashSHA256(t));
            
            if (textBox5.Text == h)
            {
                textBox6.Text = PRJ1_module.RSA.Decrypt(k1, t);


                PRJ1_module.AES.FileDecrypt("C:\\Users\\tqthinh16\\Downloads\\Test.txt.metadata", "C:\\Users\\tqthinh16\\Downloads\\Test1.txt", textBox6.Text);
            }            
        }

		private void btn_encFile_Click(object sender, EventArgs e)
		{
            try
            {                
                OpenFileDialog ofd = new OpenFileDialog();  //Browse file from computer
				ofd.ShowDialog();
                textBox1.Text = ofd.FileName;   //Get file name
                textBox2.Text = PRJ1_module.AES.GenerateKey();  //Generate AES key (Ks)
				PRJ1_module.AES.FileEncrypt(textBox1.Text, textBox1.Text);  //Encrypt chosen file with Ks

				Tuple<string, string> kp = PRJ1_module.RSA.GenerateKey();   //Generate a pair of private key (Kprivate) and public key (Kpublic) of RSA
				textBox3.Text = kp.Item2;   //Get Kprivate
                textBox4.Text = kp.Item1;   //Get Kpublic

				textBox5.Text = PRJ1_module.RSA.Encrypt(textBox2.Text, kp.Item1);   //Encrypt Ks by RSA using Kpublic (output Kx)


				PRJ1_module.RSA.exportKey(kp.Item2);    //Write Kprivate into file

                //Hash Kprivate by SHA256
				textBox6.Text = PRJ1_module.HASH.hashString(PRJ1_module.HASH.HashSHA256(kp.Item2));

                //Write Kx and Hashed string of Kprivate into file
				StreamWriter wr = new StreamWriter("~/myKey/KSSS.txt");
				wr.WriteLine(textBox5.Text);
				wr.Write(textBox6.Text);
				wr.Close();
			}

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void btn_decFile_Click(object sender, EventArgs e)
		{

		}
	}
}
