using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace mediaplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> resimler = new List<string>();
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            string a = "C:\\Users\\Toshiba\\Desktop\\vegetables.png";
            string b = "C:\\Users\\Toshiba\\Desktop\\fruits.png";
            string c = "C:\\Users\\Toshiba\\Desktop\\vitamins.png";
            resimler.Add(a);
            resimler.Add(b);
            resimler.Add(c);
            axWindowsMediaPlayer1.URL = "C:\\Users\\Toshiba\\Desktop\\1.mkv";
       


        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible =! axWindowsMediaPlayer1.Visible;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int i = 3;
        private void button2_Click(object sender, EventArgs e)

        {
            
                i = i - 1;
                Thread.Sleep(400);
                pictureBox1.ImageLocation = resimler[i];
            
        }
        int j = 0;
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Timer timer = new Timer(2000);
            j = j + 1;
            //var pow= Math.Pow(j, 3);
           // label1.Text = pow.ToString();
            
            pictureBox1.ImageLocation = resimler[j];
              if(j==2)
            {
                pictureBox1.ImageLocation = resimler[2];
            }
            
            //for (int i = 0; i < 3;)

            //{
            //   pictureBox1.ImageLocation = resimler[i];
            //    pictureBox1.Image = Image.FromFile(@resimler[i]);

            //}
            /* 
             
            foreach (var i in resimler)
            {
               pictureBox1.ImageLocation = i;
             
            }
             */
        }

        private void label1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.116:80";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void inceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
