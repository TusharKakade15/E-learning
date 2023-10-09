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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form26 lp = new Form26();
            lp.Show();
            this.Hide();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (radioButton1.Checked)
        //    {
        //        Form28 fm = new Form28();
        //        fm.Show();
        //        this.Hide();
        //    }
        //    if (radioButton2.Checked)
        //    {

        //        if (radioButton3.Checked)
        //        {
        //            if (radioButton1.Checked)
        //            {
        //                Form32 fm = new Form32();
        //                fm.Show();
        //            }
        //            this.Hide();
        //        }
        //    }
        //    if (radioButton4.Checked) { }
        //}

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form32 fm = new Form32();
            fm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                Form28 fm = new Form28();
                fm.Show();
                this.Hide();
            }
            else if (radioButton2.Checked==true)
            {
                Form31 fm = new Form31();
                fm.Show();
                this.Hide();
            }
            else if (radioButton3.Checked==true)
            {
                Form32 fm = new Form32();
                fm.Show();
                this.Hide();
            }
            else if(radioButton4.Checked==true)
            {
                Form33 fm = new Form33();
                fm.Show();
                this.Hide();
            }
            else if (radioButton5.Checked == true)
            {Form35 fm=new Form35();
            fm.Show();
            this.Hide();}
               
            else{ Form34 fm = new Form34();
            fm.Show(); this.Hide();}}

        //private void radioButton6_CheckedChanged(object sender, EventArgs e)
        //{

        //}


        }

        //private void radioButton6_CheckedChanged(object sender, EventArgs e)
        //{
        //    Form10 fm = new Form10();
        //    fm.Show();
        //    this.Hide();
        //}
    }
