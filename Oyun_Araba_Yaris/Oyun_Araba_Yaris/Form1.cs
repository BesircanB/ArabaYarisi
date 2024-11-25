using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun_Araba_Yaris
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        int x, y;

        private void START_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = rand.Next(5,10);
            pictureBox1.Left += x;

            y = rand.Next(5,10);
            pictureBox2.Left += y;






            if ((pictureBox1.Location.X) > (pictureBox2.Location.X))
            {
                label5.Text = "Mavi araba önde";

                if (pictureBox1.Location.X > 590)
                {
                    timer1.Stop();
                    label5.Text = "Mavi Araba yarışı kazandı!";
                }

            }
            else if (pictureBox2.Location.X>pictureBox1.Location.X)
            {
                label5.Text = "Sarı araba önde";

                if (pictureBox2.Location.X>590)
                {
                    timer1.Stop();
                    label5.Text=("Sarı araba yarışı kazandı");
                }

            }
           


               



        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left =-19;
            pictureBox2.Left =-2;

            label5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
