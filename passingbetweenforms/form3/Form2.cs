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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        public void label2_Click(object sender, EventArgs e)
        {
           
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text =="Blue")
            {
                button2.BackColor = Color.Blue;
                MessageBox.Show("Hello   " + " "  + Form1.title + " ,You chose this color ::"+ comboBox1.Text + "This mean is depth and freedom ." );
            }
            if (comboBox1.Text == "Red")
            {
                button2.BackColor = Color.Red;
                MessageBox.Show("Hello   " + " "  + Form1.title + " ,You chose this color ::" + comboBox1.Text + "This mean is the life .");
            }
            if (comboBox1.Text == "Yellow")
            {
                button2.BackColor = Color.Yellow;
                MessageBox.Show("Hello   " + " "  + Form1.title + " ,You chose this color ::" + comboBox1.Text + "This mean is none.");
            }
            if (comboBox1.Text == "Black")
            {
                button2.BackColor = Color.Black;
                MessageBox.Show("Hello   " + " "  + Form1.title + " ,You chose this color ::" + comboBox1.Text + "This mean is pessimism .");
            }
            if (comboBox1.Text == "Orange")
            {
                button2.BackColor = Color.Orange;
                MessageBox.Show("Hello   " + " "  + Form1.title + " ,You chose this color ::" + comboBox1.Text + "This mean is action .");
            }
            if (comboBox1.Text == "White")
            {
                button2.BackColor = Color.White;
                MessageBox.Show("Hello   " + " "  + Form1.title + " ,You chose this color ::" + comboBox1.Text + "This mean is innocence .");
            }
            else
            {
                MessageBox.Show("You didn't choose any color!"+ " "  + Form1.title);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
