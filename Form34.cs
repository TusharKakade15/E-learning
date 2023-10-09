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
    public partial class Form34 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
        public Form34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //where Teacher_name='" + textBox1.Text + "' and Subject='" + comboBox5.SelectedItem + "'
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from attendence where Teacher_name='" + textBox1.Text + "' and Subject='" + comboBox5.Text + "'and Lacture_or_Practical='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form27 gm = new Form27();
            gm.Show();
            this.Hide();
        }
    }
}
