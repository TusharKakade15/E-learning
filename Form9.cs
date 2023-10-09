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
    public partial class Form9 : Form
    {
        int counter = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form85 fm = new Form85();
            fm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            switch (counter)
            {
                case 1:
                    label6.Text = "L";
                    label6.ForeColor = Color.Navy;
                    break;

                case 2:
                    label6.Text = "LE";
                    label6.ForeColor = Color.Navy;
                    break;

                case 3:
                    label6.Text = "LEA";
                    label6.ForeColor = Color.Navy;
                    break;

                case 4:
                    label6.Text = "LEAR";
                    label6.ForeColor = Color.Navy;
                    break;

                case 5:
                    label6.Text = "LEARN";
                    label6.ForeColor = Color.Navy;
                    break;

                case 6:
                    label6.Text = "LEARNI";
                    label6.ForeColor = Color.Navy;
                    break;

                case 7:
                    label6.Text = "LEARNIN";
                    label6.ForeColor = Color.Navy;
                    break;

                case 8:
                    label6.Text = "LEARNING";
                    label6.ForeColor = Color.Navy;
                    break;

                default:
                    //timer1.Enabled = false;
                    //Loaginpannel l1 = new Loaginpannel();
                    //l1.Show();
                    //this.Hide();
                    counter = 0;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form182 fm = new Form182();
            fm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form8 fm = new Form8();
            fm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form183 fm = new Form183();
            fm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form184 fm = new Form184();
            fm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form42 fm = new Form42();
            fm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form185 fm = new Form185();
            fm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form186 fm = new Form186();
            fm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
