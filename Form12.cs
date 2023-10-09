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
    public partial class Form12 : Form
    {
        int rn = 1;
        
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
        public Form12()
        {
            InitializeComponent();
        }
      
        public void display()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from attendence";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            textBox4.Text=rn+"";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0; comboBox3.SelectedIndex = 0; comboBox4.SelectedIndex = 0; comboBox5.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            //insert code
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into attendence values('"+textBox1.Text +"','"+comboBox5.Text +"','"+comboBox1.Text +"','"+ comboBox2.Text+"','"+ comboBox4.Text+"','"+ textBox3.Text+"','"+ dateTimePicker1.Text+"','"+ textBox5.Text+"','"+ textBox4.Text+"','"+ comboBox3.Text+"')";
                  cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("1 record inserted");
          
            display();
            // next roll no
            if (rn< Convert.ToInt32(textBox5.Text))
            {
                rn++;
                textBox4.Text = rn + "";     
            }
            else
            {
                MessageBox.Show("no roll no");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Loaginpannel lg = new Loaginpannel();
            lg.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
