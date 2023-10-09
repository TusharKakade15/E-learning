using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;  

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public static String uname=" ";
        public static String pass = " ";
        public static String img = " ";
        public static String email = "";
        public static String sts = "";

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\e learning application\Database5.mdb");
        int counter = 0;
        int hide = 0;
       
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            
            //checkBox1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label7.Text=="")
            {
                label7.Text = textBox2.Text;
                button3.Text = "Hide";
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                button3.Text = "Show";
                label7.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int GetPasswordStrength(String password)
        {
            int Marks=0;
            //here we will check the password strength
            if(password.Length <8)
            {
                return 1;
            }
                else{
                    Marks=1;
                }
                if(Regex.IsMatch(password, "[a-z]"))
                {
                    //2
                    Marks++;

                }
                if(Regex.IsMatch(password, "[A-Z]"))
                {
                    //3
                    Marks++;

                }
                if(Regex.IsMatch(password, "[0-9]"))
                {
                    //4
                    Marks++;
                }
                if(Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},,?,:,;,|,',\\,.,~,`,-,=]"))
                {   //5
                    Marks++;
                }
                return Marks;
            }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int marks = GetPasswordStrength(textBox2.Text);
            //    string status="";
            //switch(marks)
            //{
            //    case 1:
            //        status="Bad Password";
            //Label8.ForeColor    =Color.Red;
            //        break;
            //    case 2:
            //        status="fair";
            //        Label8.ForeColor=Color.Orange;
            //        break;
            //    case 3:
            //        status="Medium";
            //        Label8.ForeColor=Color.Yellow;
            //        break;
            //    case 4:
            //        status="Strong";
            //        Label8.ForeColor=Color.Green;
            //        break;
            //    case 5:
            //        status="Perfect!";
            //        Label8.ForeColor=Color.GreenYellow;
            //        break;
            //    default:
            //        break;
            //}
            //Label8.Text="Status:"+status;



        }


       

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 ff = new Form5();
            ff.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loaginpannel f = new Loaginpannel();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hide==1)
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\close eye image 1.png";
                hide = 0;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\major project images\\open eye image.png";
                hide = 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
        //    if (textBox1.Text != "mrunali")
        //    {
        //        MessageBox.Show("username not valid");
        //    }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "mrunali" && textBox2.Text == "mane")
            //{
            //    MessageBox.Show("valid username and password");
            //    Form6 f6 = new Form6();
            //    f6.Show();
            //    this.Hide();


            //}
            //else
            //{

            //    MessageBox.Show("invalid username or password");
            //}


            //id pass fetch from database String pass, uname.
            
            
            pass = "";
            uname = "";
            
            con.Open();
            String query="select * from  Table1 where Username='"+textBox1.Text+"'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pass = dr["Password"].ToString();
                uname = dr["Username"].ToString();
                email = dr["Email"].ToString();
                img = dr["profile"].ToString();
                sts = dr["status"].ToString();

                   
              }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                
                MessageBox.Show("No record Found");
                
            }
            con.Close();
        //check pass
            if (textBox2.Text == pass && sts == "Active")
            {
                MessageBox.Show("welcome " +uname);
                Form6 fm = new Form6();
                fm.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("wrong password");

              
            }
           

            
        }


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Form6 fm = new Form6();
            fm.Show();
            this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Loaginpannel lg = new Loaginpannel();
            lg.Show();
            this.Hide();
        }

       

    }
}
