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
    public partial class loadingpage : Form
    {
        int counter = 0;
        public loadingpage()
        {
            InitializeComponent();

        }

        private void loadingpage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            counter++;
            switch (counter)
            {
                case 1:
                    label1.Text = "L";
                    label1.ForeColor = Color.Navy;
                    break;

                case 2:
                    label1.Text = "LE";
                    label1.ForeColor = Color.Navy;
                    break;

                case 3:
                    label1.Text = "LEA";
                    label1.ForeColor = Color.Navy;
                    break;

                case 4:
                    label1.Text = "LEAR";
                    label1.ForeColor = Color.Navy;
                    break;

                case 5:
                    label1.Text = "LEARN";
                    label1.ForeColor = Color.Navy;
                    break;

                case 6:
                    label1.Text = "LEARNI";
                    label1.ForeColor = Color.Navy;
                    break;

                case 7:
                    label1.Text = "LEARNIN";
                    label1.ForeColor = Color.Navy;
                    break;

                case 8:
                    label1.Text = "LEARNING";
                    label1.ForeColor = Color.Navy;
                    break;

                default:
                      timer1.Enabled = false;
                      Loaginpannel l1 = new Loaginpannel();
                      l1.Show();
                      this.Hide();
                    break;
            }
            //if (counter == 5)
            //{
            //    timer1.Enabled = false;
            //    Loaginpannel l1 = new Loaginpannel();
            //    l1.Show();
            //    this.Hide();
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Loaginpannel l1 = new Loaginpannel();
            l1.Show();
            this.Hide();
        }
    }
}

