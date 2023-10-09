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
    public partial class Form13 : Form
    {
        int counter = 0;
        public static String Teacher_uname = " ";
        public static String Teacher_password = " ";
  
        public static String Teacher_email = "";
        public static String Teacher_sts = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
       
        public Form13()
        {
            InitializeComponent();
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
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_password = "";
            Teacher_uname = "";

            con.Open();
            String query = "select * from  Teacher_login where Teacher_Uname='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Teacher_password = dr["Teacher_Pass"].ToString();
                Teacher_uname = dr["Teacher_Uname"].ToString();
                Teacher_email = dr["Teacher_Email"].ToString();
                Teacher_sts = dr["Teacher_status"].ToString();

                if (textBox2.Text == Form13.Teacher_password && Teacher_sts == "Active")
                {
                    MessageBox.Show("welcome " + Form13.Teacher_uname);
                    Form25 fm = new Form25();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong password");


                }


            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("No record Found");

            }
            con.Close();


            ////check pass
            



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
