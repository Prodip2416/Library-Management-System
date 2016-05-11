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
    public partial class admin_home : Form
    {
        public admin_home(string a)
        {
            InitializeComponent();
            label1.Text = "Welcome " + a;
            timer1.Start();

        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn lg = new LogIn();
            lg.Show();
        }

        private void validityBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_books ad = new add_books();
            ad.MdiParent = this;
            ad.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_books ad = new view_books();
            ad.MdiParent = this;
            ad.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.toolStripTextBox1.Text = dt.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      //  private void updateBooksToolStripMenuItem_Click(object sender, EventArgs e)
      //  {
      ///     update_book up = new update_book();
       //     up.Show();
      //  }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_books ab = new search_books();
            ab.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_users au = new add_users();
            au.Show();
        }

        private void admin_home_Load(object sender, EventArgs e)
        {

        }
    }
}
