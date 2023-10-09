using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form31 : Form
    {
        int time = 10;
        public static String email = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
        int counter = 0;
        static String MyOtp = "";
        public Form31()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //generate otp
            MyOtp = RandomString(4);


            //mail send
            MailMessage mail = new MailMessage();
            mail.To.Add(textBox10.Text); // use ur email id for demo
            // mail.CC.Add("mrunalimane92001@gmail@gmail.com");
            mail.CC.Add("mrunalimane92001@gmail.com");

            mail.From = new MailAddress("application.elearning2019@gmail.com");
            mail.Subject = "OPT - Secure Login System!";
            string Body = "Your OTP is : " + MyOtp + "\nDo not Share with Other!";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("application.elearning2019@gmail.com", "learning-e");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);

            // visibility controls
            label8.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            // button3.Visible = true;
            lineShape1.Visible = true;
            lineShape2.Visible = true;
            lineShape6.Visible = true;
            lineShape8.Visible = true;
       
    
        
      }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = true;


            if (!(isEmail(textBox10.Text)))
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

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label12.Visible = true;
            textBox9.Visible = true;
            lineShape5.Visible = true;
            textBox8.Visible = true;
            lineShape4.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            lineShape3.Visible = true;
            button1.Visible = true;
            label9.Visible = true;
            button3.Visible = false;
            button5.Visible = true;
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label13.Visible = true;
            if (textBox1.Text.Length == 1)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text.Length == 1)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length == 1)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                button2.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 1)
            {
                timer1.Enabled = false;
                button3.Visible = false;
                label5.Visible = false;
            }
            time--;
            label5.Text = "00.0" + time + "";
            if (label13.Text == "00.00")
            {
                button3.Visible = true;

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = true;


            //CHECKING FOR NAME
            if (textBox9.Text == "")
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Username is compulsory";
            }
            else
            {
                label2.ForeColor = Color.Green;
                label2.Text = "Done";
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
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int marks = GetPasswordStrength(textBox8.Text);
            string status = "";
            switch (marks)
            {
                case 1:
                    status = "Bad Password";
                    label1.ForeColor = Color.Red;
                    break;
                case 2:
                    status = "fair";
                    label1.ForeColor = Color.Orange;
                    break;
                case 3:
                    status = "Medium";
                    label1.ForeColor = Color.Yellow;
                    break;
                case 4:
                    status = "Strong";
                    label1.ForeColor = Color.Green;
                    break;
                case 5:
                    status = "Perfect!";
                    label1.ForeColor = Color.GreenYellow;
                    break;
                default:
                    break;
            }
            label1.Text = "Status:" + status;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            label5.Visible = true;

            if (textBox8.Text != textBox6.Text)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "password does not match";
            }
            else
            {
                label5.ForeColor = Color.Green;
                label5.Text = "Password matched";
            }

        }
        public void clr()
        {
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox6.Text = "";
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
            con.Close();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //insert code
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Table1 values('"
                + textBox10.Text + "','"
                 + textBox9.Text + "','" + textBox8.Text + "','" + textBox6.Text + "','" + pictureBox3.ImageLocation + "','Active')";
            cmd.ExecuteNonQuery();

            //DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //da.Fill(dt);
            //DataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("1 record inserted");
            clr();
            display();

            Form27 FM = new Form27();
            FM.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form27 f1 = new Form27();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //generate otp
            MyOtp = RandomString(4);


            //mail send
            MailMessage mail = new MailMessage();
            mail.To.Add(textBox10.Text); // use ur email id for demo
            // mail.CC.Add("mrunalimane92001@gmail@gmail.com");
            mail.CC.Add("mrunalimane92001@gmail.com");

            mail.From = new MailAddress("application.elearning2019@gmail.com");
            mail.Subject = "OPT - Secure Login System!";
            string Body = "Your OTP is : " + MyOtp + "\nDo not Share with Other!";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("application.elearning2019@gmail.com", "learning-e");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form27 fm = new Form27();
            fm.Show();
            this.Hide();
        }
    }

}
