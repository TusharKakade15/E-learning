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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;//label7.Visible = true;
            //label8.Visible = true;

            //label11.Visible = false;
            //label10.Visible = false;

            //label9.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //label10.Visible = true;
            //panel2.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
                panel1.Visible=false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form9 fm = new Form9();
            fm.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
