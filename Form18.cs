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
    public partial class Form18 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
        int rate = 0;
        public Form18()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project imagess\\gold star.PNG";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";

        
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox4.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox4.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox5.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            rate = 2;
        }

       

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (rate != 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\black star.PNG";
            }
        
        
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (rate != 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\black star.PNG";
            }

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (rate != 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\black star.PNG";
            }
        
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (rate != 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.png";
            }
        
        
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (rate != 5)
            {
                pictureBox5.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\black star.PNG";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            rate = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            rate = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG ";
            pictureBox4.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.PNG";
            rate = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.png";
            pictureBox2.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.png";
            pictureBox3.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.png";
            pictureBox4.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.png";
            pictureBox5.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\gold star.png";
            rate = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert code
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into rate_us values('"
                + label2.Text + "','"
                 + rate + "')";
            cmd.ExecuteNonQuery();

            //DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //da.Fill(dt);
            //DataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("THANK YOU");
           
          
        }

        private void Form18_Load(object sender, EventArgs e)
        {

            String un = Form3.uname;
            label2.Text = un;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }
    }
}
