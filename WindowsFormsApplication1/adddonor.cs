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
    public partial class adddonor : Form
    {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        string result;
        string email = txtemail.Text();

        public adddonor()
        {
            InitializeComponent();
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
                // Do something  
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtdnm.Text = "";
            txtfnm.Text = "";
            txtmnm.Text = "";
            dateTimePicker1.Text = "";
            txtmobileno.Text = "";
            combogen.Text = "";
            txtemail.Text = "";
            combobg.Text = "";
            txtcity.Text = "";
            txtadd.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insert = "insert into reg values('"+txtdnm.Text+"','"+txtfnm.Text+"','"+txtmnm.Text+"','"+dateTimePicker1.Text+"','"+txtmobileno.Text+"','"+combogen.Text+"','"+txtemail.Text+"','"+combobg.Text+"','"+txtcity.Text+"','"+txtadd.Text+"')";

            SqlDataAdapter d1 = new SqlDataAdapter(insert,Class1.cn);
            DataTable dt1 = new DataTable();
           int ab =  d1.Fill(dt1);
           if (ab == 0)
           {
               MessageBox.Show("Donor Register successfully");
               clear();
           }
           else
           {
               MessageBox.Show("Plese Fill Up All Details");
           }
        }

        private void lbldoid_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (email.lastindexof("@") > -1)
            {
                //valid
            }
            else
            {

            }
        }

       

       
    }
}
