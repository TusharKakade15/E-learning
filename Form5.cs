using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
      
        int time = 10;
        
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lineShape6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //label5.Visible = true;
            //generate otp

            con.Open();
            String query = "select * from  Table1 where Email='" + textBox1.Text + "' and Username='"+ textBox2.Text+"'";
            OleDbCommand cm = new OleDbCommand(query, con);
            OleDbDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
               Form4.password = dr["Password"].ToString();
            }

            //mail send
            MailMessage mail = new MailMessage();
            mail.To.Add(textBox1.Text); // use ur email id for demo
            // mail.CC.Add("mrunalimane92001@gmail.com");
            mail.CC.Add("mrunalimane92001@gmail.com");

            mail.From = new MailAddress("application.elearning2019@gmail.com");
            mail.Subject = " Secure Login System!";
            string Body = "Your Password is : " + Form4.password+ "\nDo not Share with Other!";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("application.elearning2019@gmail.com", "learning-e");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("mail sent");

            //// visibility control
            //label3.Visible = true;
            //textBox6.Visible = true;
            //textBox5.Visible = true;
            //textBox4.Visible = true;
            //textBox7.Visible = true;
            //lineShape1.Visible = true;
            //lineShape2.Visible = true;
            //lineShape3.Visible = true;
            //lineShape4.Visible = true;
           
            //button2.Visible = true;


        }
       

        //private void button2_Click(object sender, EventArgs e)
        //{// TIMMER 
        //    timer1.Enabled = false;
        //    groupBox2.Visible = true;
        //    groupBox3.Visible = true;
        //    button4.Visible = true;
        //    button5.Visible = true;

        //}

        //private void textBox7_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox7.Text.Length == 1)
        //    {
        //        button2.Focus();
        //    }
        //}

        //private void textBox6_TextChanged(object sender, EventArgs e)
        //{

        //    label5.Visible = true;

        //    if (textBox6.Text.Length == 1)
        //    {
        //        textBox5.Focus();
        //    }
        //}

        //private void textBox5_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox5.Text.Length == 1)
        //    {
        //        textBox4.Focus();
        //    }
        //}

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox4.Text.Length == 1)
        //    {
        //        textBox7.Focus();
        //    }
        //}

        //private void label4_Click(object sender, EventArgs e)
        //{
        //    Form3 fm = new Form3();
        //    fm.Show();
        //    this.Hide();
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (time == 1)
        //    {
        //        timer1.Enabled = false;
        //        button3.Visible = false;
        //        label5.Visible = false;
        //    }
        //    time--;
        //    label5.Text = "00.0" + time + "";
        //    if (label5.Text == "00.00")
        //    {
        //        button3.Visible = true;

        //    }
        //}

        private void label5_Click(object sender, EventArgs e)
        {
            

        }

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //    label7.Visible = true;
        //    if (textBox3.Text != textBox2.Text)
        //    {
        //        label7.ForeColor = Color.Red;
        //        label7.Text = "password does not match";
        //    }
        //    else
        //    {
        //        label7.ForeColor = Color.Green;
        //        label7.Text = "Password matched";
        //    }

        //}

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form6 fm = new Form6();
                fm.Show();
                this.Hide();
            }
        }
        public int GetPasswordStrength(String password)
        {
            int Marks = 0;
            //here we will check the password strength
            if (password.Length < 8)
            {
                return 1;
            }
            else
            {
                Marks = 1;
            }
            if (Regex.IsMatch(password, "[a-z]"))
            {
                //2
                Marks++;

            }
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                //3
                Marks++;

            }
            if (Regex.IsMatch(password, "[0-9]"))
            {
                //4
                Marks++;
            }
            if (Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},,?,:,;,|,',\\,.,~,`,-,=]"))
            {   //5
                Marks++;
            }
            return Marks;
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    int marks = GetPasswordStrength(textBox2.Text);
        //    string status = "";
        //    switch (marks)
        //    {
        //        case 1:
        //            status = "Bad Password";
        //            label6.ForeColor = Color.Red;
        //            break;
        //        case 2:
        //            status = "fair";
        //            label6.ForeColor = Color.Orange;
        //            break;
        //        case 3:
        //            status = "Medium";
        //            label6.ForeColor = Color.Yellow;
        //            break;
        //        case 4:
        //            status = "Strong";
        //            label6.ForeColor = Color.Green;
        //            break;
        //        case 5:
        //            status = "Perfect!";
        //            label6.ForeColor = Color.GreenYellow;
        //            break;
        //        default:
        //            break;
        //    }
        //    label6.Text = "Status:" + status;
        //    label6.Visible = true;
        //}

        private void button5_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set Password='"+textBox2.Text+"' where Email='" + textBox1.Text+ "'"; 
            cmd.ExecuteNonQuery();
            MessageBox.Show("1 record updated");
            con.Close();

            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}