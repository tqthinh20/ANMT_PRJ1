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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_encForm_Click(object sender, EventArgs e)
        {
            FormEncrypt f = new FormEncrypt();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_decForm_Click(object sender, EventArgs e)
        {
            FormDecrypt f = new FormDecrypt();
            this.Hide();
            f.ShowDialog();
        }
    }
}
