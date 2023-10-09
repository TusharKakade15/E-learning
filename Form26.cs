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
    public partial class Form26 : Form
    {
        int counter = 0;
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mrunali" && textBox2.Text == "mane")
            {
                Form27 fm = new Form27();
                fm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loaginpannel lg = new Loaginpannel();
            lg.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Loaginpannel lg = new Loaginpannel();
            lg.Show();
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
    }
}

