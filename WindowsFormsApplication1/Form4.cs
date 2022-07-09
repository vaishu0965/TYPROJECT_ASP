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
    public partial class Form4 : Form
    {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        string result;

        public Form4()
        {
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout log = new logout();
            log.Show();
           
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adddonor ad = new adddonor();
            ad.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedonor ud = new updatedonor();
            ud.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alldonordet add = new alldonordet();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("sadasd");
        }

        


        
    }
}
