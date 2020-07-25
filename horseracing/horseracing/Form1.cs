using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horseracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int firsthorsedistance, secondhorsedis, thirdhorsedis;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            firsthorsedistance = pictureBox1.Left;
            secondhorsedis = pictureBox2.Left;
            thirdhorsedis = pictureBox3.Left;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label9.Text);
            time = time + 1;

            label9.Text = time.ToString();
            pictureBox1.Left += random.Next(18, 31);
            pictureBox2.Left += random.Next(18, 31);
            pictureBox3.Left += random.Next(18, 31);

            int finishline = label6.Left;
            int firsthorse = (pictureBox1.Right - finishline);
            int secondhorse = (pictureBox2.Right - finishline);
            int thirdhorse = (pictureBox3.Right - finishline);
         
         
            if (firsthorse ==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner :First Horse!");
                Application.Exit();
            }
            if (secondhorse == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner : Second Horse!");
                Application.Exit();
            }
            if (thirdhorse == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner : Third Horse!");
                Application.Exit();
            }
            if(secondhorse < firsthorse || secondhorse< thirdhorse)
            {
                label8.Text = "Second horse is taking the lead!";
            }
            if (firsthorse < secondhorse || firsthorse < thirdhorse)
            {
                label8.Text = "First horse is taking the lead!";
            }
            if (thirdhorse < secondhorse || thirdhorse < firsthorse)
            {
                label8.Text = "Third horse is taking the lead!";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
