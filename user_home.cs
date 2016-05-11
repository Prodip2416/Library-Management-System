using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class user_home : Form
    {
        public user_home(string uh)
        {
            InitializeComponent();
            label1.Text = "Wellcome " + uh;
            timer1.Start();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             DateTime dt = DateTime.Now;
             this.toolStripTextBox1.Text = dt.ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn lg = new LogIn();
            lg.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_books sb = new search_books();
            sb.Show();
        }

        private void user_home_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forgot_password fg = new forgot_password();
            fg.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_users_profile eup = new edit_users_profile();
            eup.Show();
        }

        private void mnuIssueBooks_Click(object sender, EventArgs e)
        {
            Issue_Books ib = new Issue_Books();
            ib.Show();
        }

        private void mnuReturnBooks_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
        }
    }
}
