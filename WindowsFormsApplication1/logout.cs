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
    public partial class logout : Form
    {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        string result;

        public logout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f22 = new Form2();
            f22.Show();
            this.Hide();
           // MessageBox.Show("Thanks for visiting..!!");
            
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
