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
    public partial class Library_Management : Form
    {
        public Library_Management()
        {
            InitializeComponent();
        }
  
      
        private void timer1_Tick(object sender, EventArgs e)
        {
      
        }

        private void Library_Management_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);
        }

        public static int i = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            i++;
            if(i==15)
            {
                this.Dispose(false);
                LogIn lg = new LogIn();
                lg.Show();
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
