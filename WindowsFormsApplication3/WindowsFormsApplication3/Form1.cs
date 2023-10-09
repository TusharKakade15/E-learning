using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Sample_db.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
        }

        public void clr()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        public void display()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Table1 values('"
                                + textBox3.Text + "','"
                                + textBox2.Text + "','"
                                + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("1 record inserted");
            clr();
            display();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set Sname = '"
                                + textBox2.Text
                                + "', Address = '"
                                + textBox1.Text + "' where RollNo = '"
                                + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("1 record updated");
            clr();
            display();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table1 where RollNo = '"
                                + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("1 record deleted");
            clr();
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
OleDbCommand cmd = con.CreateCommand();
cmd.CommandType = CommandType.Text;
cmd.CommandText = "select * from Table1 where RollNo = '" 
					+ textBox3.Text + "'";
cmd.ExecuteNonQuery();
DataTable dt = new DataTable();
OleDbDataAdapter da = new OleDbDataAdapter(cmd);
da.Fill(dt);
dataGridView1.DataSource = dt;

con.Close();            }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from Table1 where RollNo = '"
                                + textBox3.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["Sname"].ToString();
                textBox1.Text = dr["Address"].ToString();
            }
            else
            {
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                MessageBox.Show("No Record Found !");
            }
            con.Close();


        }


        }
    }

