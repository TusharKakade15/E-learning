using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show(); ;
            this.Hide();
        }

        private void Form22_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(textBox3.Text); // use ur email id for demo
            // mail.CC.Add("mrunalimane92001@gmail@gmail.com");
            mail.CC.Add("mrunalimane92001@gmail.com");

            mail.From = new MailAddress("application.elearning2019@gmail.com");
            mail.Subject = "OPT - Secure Login System!";
            string Body = "Hii, we are inviting you to join our application!!";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("application.elearning2019@gmail.com", "learning-e");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Invitation Send");
           
        }
    }
}
