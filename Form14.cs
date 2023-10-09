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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            String un = Form3.uname;
            label2.Text = un;
            label7.Text = un;
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

        private void label7_Click(object sender, EventArgs e)
        {
            Form15 fm = new Form15();
            fm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;

            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void Form14_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
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
            Form38 fm = new Form38();
            fm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form45 fm = new Form45();
            fm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form63 fm = new Form63();
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form65 FM = new Form65();
            FM.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form148 FM = new Form148();
            FM.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form203 fm = new Form203();
            fm.Show();
            this.Hide();
        }
    }
}
