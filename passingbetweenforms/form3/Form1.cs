using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form3
{
    public partial class Form1 : Form
    {
        public static string title;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(textBox1.Text == "tugba" && textBox2.Text == "1234")
            {
                form2.Show();
                this.Hide();
                title = textBox1.Text;
               

            }
            else if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanici adi veya Parola girmediniz");
            }
            else if(textBox1.Text != "tugba" || textBox2.Text != "1234")
            {
                MessageBox.Show("Yanlis giris");
            }
        }
    }
}
