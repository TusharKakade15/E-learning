using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form15 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
       
        public Form15()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Search on Text box
           // con.Open();
            
           
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form3.uname;
            textBox3.Text = Form3.pass;
            textBox2.Text = Form3.email;

        }

        private void Form15_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = Form3.uname;
            textBox3.Text = Form3.pass;
            textBox2.Text = Form3.email;
            pictureBox3.ImageLocation = Form3.img;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e) { }
        //{{
        //    openFileDialog1.ShowDialog();
        //    String imgname = openFileDialog1.FileName;
        //    pictureBox3.ImageLocation = imgname;
        //}

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 fs = new Form6();
            fs.Show();
            this.Hide();
        }
    }
}
