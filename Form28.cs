using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class Form28 : Form
    {
        public static String MyOtp = "";
        static String MyOtp1 = "";
        public static String username = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
        public Form28()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = true;


            if (!(isEmail(textBox2.Text)))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Invalid emil id";
            }
            else
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Valid email Id But neededd Verification";

            }
        }
        public static bool isEmail(string inputEmail)
        {
            if (inputEmail != "")
            {
                String strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3\.)|(([a-zA-Z0-9\-]+\" + @".))([a-zA-Z]|){2,4}|)(\}?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(inputEmail))
                    return (true);
                else
                    return (false);
            }
            return (true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyOtp = RandomString(8);
            MyOtp1 = RandomString(4);
            username = textBox1.Text+" s"+MyOtp1;

            MailMessage mail = new MailMessage();
            mail.To.Add(textBox2.Text); // use ur email id for demo
            // mail.CC.Add("mrunalimane92001@gmail@gmail.com");
            mail.CC.Add("mrunalimane92001@gmail.com");

            mail.From = new MailAddress("application.elearning2019@gmail.com");
            mail.Subject = "OPT - Secure Login System!";
            string Body = "Dear" + Form13.Teacher_uname + "you were added by ADMIN"    +"your password is"+" "+MyOtp+" &"+" username is  "+username+"  Kindly login in system using the given password and username "+"  "+"Thanks and Regards...";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("application.elearning2019@gmail.com", "learning-e");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);



            MessageBox.Show("mail sent to Teacher");
        
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Teacher_login values('" + username + "','" + MyOtp + "','" + textBox1.Text + "','" + textBox2.Text + "','Active')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            Form27 fs = new Form27();
            fs.Show();
            this.Hide();

        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@$+abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form27 fm = new Form27();
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
