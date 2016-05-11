using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Library_Management
{
    public partial class forgot_password : Form
    {
        public forgot_password()
        {
            InitializeComponent();
        }

        config o = new config();

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\My Programming\Code C#\Work\Library_Management\Library_Management\info.mdf;Integrated Security=True");
            SqlConnection con = o.con;
            SqlCommand cmd = con.CreateCommand();
            if (textBox2.Text != "")
            {
                cmd.CommandText = @"UPDATE [dbo].[users] SET [password] = '" + textBox2.Text + "' WHERE name='" + textBox1.Text + "'";
                label3.Text = "Successful";
                label3.ForeColor = Color.Green;

                //LogIn lg = new LogIn();
                //lg.Show();
                //this.Close();
            }
            else
            {
                cmd.CommandText = @"UPDATE [dbo].[users] SET [password] = '" + textBox2.Text + "' WHERE name='" + textBox1.Text + "'";
                label3.Text = "Try Again";
                label3.ForeColor = Color.Red;
            }
            cmd.ExecuteNonQuery();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Close();
        }
    }
}
