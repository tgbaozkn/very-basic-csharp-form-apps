using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstgame
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = random.NextDouble()*10;
            //free example : double c = random.Next(0, 5);
            a = Convert.ToInt32(a);
            string b = Convert.ToString(a);
            listBox1.Items.Add(c);
            if (textBox1.Text == b)
            {
                listBox1.Items.Insert(0, "True guess! " + b);
            }
            else
            {
                MessageBox.Show(" Wrong guess! ,the number is :" + " " + b);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
