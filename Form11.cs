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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            String un = Form3.uname;
            label7.Text = un;
            label2.Text = un;
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

        private void Form11_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Form6 g = new Form6();
            g.Show();
            this.Hide();
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
            Form40 fm = new Form40();
            fm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form44 fm = new Form44();
            fm.Show();
            this.Hide();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            Form40 fm = new Form40();
            fm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form59 fm = new Form59();
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form60 fm = new Form60();
            fm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form61 fm = new Form61();
            fm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form62 fm = new Form62();
            fm.Show();
            this.Hide();
        }
    }
}
