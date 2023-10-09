using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        //int num = -1;
        public Form7()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            String un = Form3.uname;
            label2.Text = un;
            label7.Text=un;
            if (Convert.ToInt32(DateTime.Now.Hour + "") < 12)
            {
                label1.Text = "Good Morning!";
            }
            else
            {
                if (Convert.ToInt32(DateTime.Now.Hour + "") < 16)
                {
                    label1.Text = "Good Afternoon!";
                }
                else
                {
                    if (Convert.ToInt32(DateTime.Now.Hour + "") < 21)
                    {
                        label1.Text = "Good Evening!";
                    }
                    else
                    {
                        label1.Text = "Good Night!";
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form50 fm = new Form50();
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form58 fm = new Form58();
            fm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ////num = 1;
            if (panel1.Visible == true)
            {
                panel1.Visible = false;

            }
            else
            {
                panel1.Visible = true;
            }


          
         
      
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Form6 g = new Form6();
            g.Show();
            this.Hide();

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
                    }

        private void Form7_MouseClick(object sender, MouseEventArgs e)
        {
            //int flag = 1;
            panel1.Visible = false;
            //if (flag == 1) { pictureBox5.ImageLocation = "C:\\Users\\Admin\\Downloads\\output-onlinepngtools (1).png"; }
            //else { pictureBox5.ImageLocation = "C:\\Users\\Admin\\Downloads\\output-onlinepngtools.png"; }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form15 fm = new Form15();
            fm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form22 fm = new Form22();
            fm.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form39 fm = new Form39();
            fm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form43 fm = new Form43();
            fm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form56 FM = new Form56();
            FM.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form57 FM = new Form57();
            FM.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form18 fm = new Form18();
            fm.Show();
            this.Hide();
        }
    }
}
