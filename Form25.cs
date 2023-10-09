using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form24 fm = new Form24();
                fm.Show();
                this.Hide();
         
            
            }

            if (radioButton2.Checked)
            {
                Form12 fs = new Form12();
                fs.Show();
                this.Hide();
            
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
            this.Hide();
        }
    }
}
