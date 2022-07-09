using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        string result;

        int a;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string sel = "SELECT * from login where unm = '" + comboBox1.Text + "' AND pwd = '" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sel, Class1.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);
            if (a == 1)
            {
                MessageBox.Show("login okk");
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Enter Correct Username or Password");
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = false;
            // TODO: This line of code loads data into the 'tYDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.tYDataSet.login);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Form2 f = new Form2();
                f.Show();
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btnlogin.Enabled = true;
            }
            else {
                btnlogin.Enabled = false;
            }
        }
    
    }
}
