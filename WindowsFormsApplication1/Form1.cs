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
    public partial class Form1 : Form
    {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        string result;

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            timer1.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBar1.Value = i+1;
            label5.Text = "Loding '" + progressBar1.Value + "' % ";
     
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
               
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // this.Close();
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
