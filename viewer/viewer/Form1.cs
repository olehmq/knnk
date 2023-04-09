using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace viewer
{
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();
        }
        
        Observer ob = new Observer();

        private int imageIndex = 0;

        void Send()
        {
            ob.SendNotify();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ob.IsIn((Button)sender))
            { ob.RemSubscriber((Button)sender);
                timer1.Stop();
                MessageBox.Show("Stop");

            }  
            else
            ob.AddSubscriber((Button)sender);
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            timer1.Start();
            MessageBox.Show("Start");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ob.RemSubscriber((Button)sender);
            timer1.Stop();
            button1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            Send();
            switch(button1.Text)
            {
                case "1":
                    pictureBox1.Image = Properties.Resources.image1;
                    break;
                    case "11":
                    pictureBox3.Image = Properties.Resources.image2;
                    break;
                case "111":
                    pictureBox4.Image = Properties.Resources.image3;
                    break;
                case "1111":
                    pictureBox5.Image = Properties.Resources.image4;
                    break;
                default:
                    
                    timer1.Stop();
                    button1.Text = "";
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    MessageBox.Show("Будівництво завершено");
                    break;
            }

         

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
