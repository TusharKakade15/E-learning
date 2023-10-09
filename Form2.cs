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
    public partial class Loaginpannel : Form
    {
        int counter = 0;
        public Loaginpannel()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            switch (counter)
            {
                case 1:
                    label4.Text = "L";
                    label4.ForeColor = Color.Navy;
                    break;

                case 2:
                    label4.Text = "LE";
                    label4.ForeColor = Color.Navy;
                    break;

                case 3:
                    label4.Text = "LEA";
                    label4.ForeColor = Color.Navy;
                    break;

                case 4:
                    label4.Text = "LEAR";
                    label4.ForeColor = Color.Navy;
                    break;

                case 5:
                    label4.Text = "LEARN";
                    label4.ForeColor = Color.Navy;
                    break;

                case 6:
                    label4.Text = "LEARNI";
                    label4.ForeColor = Color.Navy;
                    break;

                case 7:
                    label4.Text = "LEARNIN";
                    label4.ForeColor = Color.Navy;
                    break;

                case 8:
                    label4.Text = "LEARNING";
                    label4.ForeColor = Color.Navy;
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

        private void Loaginpannel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
       
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 s1 = new Form3();
            s1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form26 fm = new Form26();
            fm.Show();
            this.Hide();
        }

        
    }
}
