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

namespace Library_Management
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        config o = new config();
      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(textBox1.Text!="" && textBox2.Text!="" && comboBox1.SelectedIndex!=-1)
          {
              string qry;
              SqlCommand cmd;
              if(comboBox1.Text=="Student")
            {
                qry = "SELECT name,password FROM users WHERE name='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                cmd = new SqlCommand(qry, o.con);
                SqlDataReader dr = cmd.ExecuteReader();
                  if(dr.Read())
                  {
                      dr.Close();
                      this.Dispose(false);
                      user_home uh = new user_home(textBox1.Text);

                      GetUserData(textBox1.Text);

                      uh.Show();
                  }
                  else
                  {
                      label4.ForeColor = Color.Red;
                      label4.Text = "Invalid Id Or Password.";
                      dr.Close();
                  }

            }
            else if(comboBox1.Text=="Admin")
            {
                qry = "SELECT name,password FROM admin WHERE name='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                cmd = new SqlCommand(qry, o.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Dispose(false);
                    admin_home a = new admin_home(textBox1.Text);
                    a.Show();
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Invalid Id Or Password.";
                    dr.Close();
                }
            }

          }
            else
          {
              label4.ForeColor = Color.Red;
              label4.Text = "Invalid Id Or Password.";
          }
        }

       public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "-";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
            add_users au = new add_users();
            au.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            forgot_password fp=new forgot_password();
            fp.Show();
        }

        public void GetUserData(string strUserID)
        {

            string qry;
            SqlCommand cmd;
            qry = "SELECT roll_no FROM users WHERE name='" + strUserID + "' ";
            cmd = new SqlCommand(qry, o.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                clsLogin.UserRoll = (string)dr.GetValue(dr.GetOrdinal("roll_no"));
                dr.Close();              
            }
        }
 }
}
