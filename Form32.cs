using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form32 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
    
        public Form32()
        {
            InitializeComponent();
        }

        //public void clr()
        //{
        //    textBox1.Text = "";
        //    textBox2.Text = "";
           
        //}
        //public void display()
        //{
        //    con.Open();
        //    OleDbCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from Table1";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.Fill(dt);
        //    con.Close();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set status='Deactive' where Username='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            
            con.Close();


            MailMessage mail = new MailMessage();
            mail.To.Add(textBox2.Text); // use ur email id for demo
            // mail.CC.Add("mrunalimane92001@gmail@gmail.com");
            mail.CC.Add("mrunalimane92001@gmail.com");

            mail.From = new MailAddress("application.elearning2019@gmail.com");
            mail.Subject = "OPT - Secure Login System!";
            string Body = "Your OTP is : " +  "\nDo not Share with Other!";
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
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form27 fm = new Form27();
            fm.Show();
            this.Hide();
        }
    }
}
