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
    public partial class Form3 : Form
    {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        string result;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string up = "update login set pwd='"+textBox2.Text+"' where unm='"+textBox1.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(up,Class1.cn);
            DataTable dt = new DataTable();
            int b = da.Fill(dt);
            MessageBox.Show(b.ToString());
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
           
                       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                // Do something  
            } 
        }

       

       
        

        


    
        
        
    }
}
