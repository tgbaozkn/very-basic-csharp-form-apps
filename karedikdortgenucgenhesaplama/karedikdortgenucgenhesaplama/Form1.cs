using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace karedikdortgenucgenhesaplama
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

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ucgen.Text;
            yukseklik.Visible = true;
          

        }

        private void Alan_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kare_Click(object sender, EventArgs e)
        {
            label1.Text = kare.Text;
            yukseklik.Visible = false;
        }

        private void daire_Click(object sender, EventArgs e)
        {
            label1.Text = daire.Text;
            yukseklik.Visible = false;
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if (label1.Text == ucgen.Text)
            {
                int taban = Convert.ToInt32(kenar.Text);
                int yuksek = Convert.ToInt32(yukseklik.Text);
                double al = (taban * yuksek) / 2;
                label4.Text = Convert.ToString(al);
                double perimeter = taban * 3;
                label5.Text = Convert.ToString(perimeter);
            }
            else if(label1.Text == kare.Text)
            {
                int taban = Convert.ToInt32(kenar.Text);
                double al = taban * taban;
                label4.Text = Convert.ToString(al);
                double perimeter = taban * 4;
                label5.Text = Convert.ToString(perimeter);
            }
            else if(label1.Text == daire.Text)
            {
                int taban = Convert.ToInt32(kenar.Text);
                double al = taban * (3.14*3.14);
                double perimeter = 2 * taban * 3.14;
                label5.Text = Convert.ToString(perimeter);
                label4.Text = Convert.ToString(al);
            }

        }
    }
}
