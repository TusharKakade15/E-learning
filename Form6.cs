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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

       

        //private void label4_Click(object sender, EventArgs e)
        //{
        //    Form3 f3 = new Form3();
        //    f3.Show();
        //    this.Hide();
        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Visible = true;
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form11 fm = new Form11();
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            String un = Form3.uname;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form8 fm = new Form8();
            fm.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form14 fm = new Form14();
            fm.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form77 fm = new Form77();
            fm.Show();
            this.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Form82 fm = new Form82();
            fm.Show();
            this.Hide();
        }
    }   
}
