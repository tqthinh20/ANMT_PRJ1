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
    public partial class Form1 : Form
    {
        public Form1()
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

            //B2
            string t = File.ReadAllText("C:\\Users\\tqthinh16\\Downloads\\kprivate.txt");

            textBox5.Text = PRJ1_module.HASH.hashString(PRJ1_module.HASH.HashSHA256(t));    

            
            textBox6.Text = PRJ1_module.RSA.Decrypt(textBox3.Text, t);


            PRJ1_module.AES.FileDecrypt("C:\\Users\\tqthinh16\\Downloads\\Test.txt.metadata", "C:\\Users\\tqthinh16\\Downloads\\Test1.txt", textBox6.Text);
        }
    }
}
