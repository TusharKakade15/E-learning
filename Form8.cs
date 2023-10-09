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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            String un = Form3.uname;
            label2.Text = un;
            label8.Text = un;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form9 fm=new Form9();
            fm.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form15 fm = new Form15();
            fm.Show();
            this.Hide();
        }

        private void Form8_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form18 fm = new Form18();
            fm.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form47 f1 = new Form47();
            f1.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form22 fm = new Form22();
            fm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form19 fm = new Form19();
            fm.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form37 fh = new Form37();
            fh.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form46 fm = new Form46();
            fm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form41 fm = new Form41();
            fm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form48 fm = new Form48();
            fm.Show();
            this.Hide();
        }

        //private void pictureBox6_Click_1(object sender, EventArgs e)
        //{
        //    panel1
        //}

        //private void pictureBox6_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void pictureBox6_Click_1(object sender, EventArgs e)
        //{
        //    panel1.Visible = false;
        //}
    }
}
