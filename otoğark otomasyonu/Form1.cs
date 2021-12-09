using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoğark_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            admin admin = new admin();
            kullanıcıform kullanıcı = new kullanıcıform();
            if (textBox1.Text== "admin" && textBox2.Text=="123")
            {
                admin.ShowDialog();
            }

            else if ( textBox1.Text=="kullanıcı" && textBox2.Text=="456")
            {
                kullanıcı.ShowDialog();
            }
            else
            {
                MessageBox.Show("lutfen dogru bır bılgi giriniz");
            }

        }
    }
}
