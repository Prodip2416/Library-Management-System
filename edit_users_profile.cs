using Library_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class edit_users_profile : Form
    {
        private string UserRollNo = clsLogin.UserRoll;
        private int valueExist = 0;
        config o = new config();
        public edit_users_profile()
        {   
            InitializeComponent();
            loadInitialData();
        }

        private void loadInitialData()
        {
            string qry;
            SqlCommand cmd;
            qry = "SELECT * FROM UserProfile WHERE RollNo ='" + UserRollNo + "' ";
            cmd = new SqlCommand(qry, o.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                valueExist = 1;
                UserProfile up = new UserProfile();
                up.RollNo = (string)dr.GetValue(dr.GetOrdinal("RollNo"));
                up.FName = (string)dr.GetValue(dr.GetOrdinal("FName"));
                up.LName = (string)dr.GetValue(dr.GetOrdinal("LName"));
                up.NickName = (string)dr.GetValue(dr.GetOrdinal("NickName"));                
                up.Country = (string)dr.GetValue(dr.GetOrdinal("Country"));
                up.District = (string)dr.GetValue(dr.GetOrdinal("District"));
                up.Email = (string)dr.GetValue(dr.GetOrdinal("Email"));
                up.BloodGroup = (string)dr.GetValue(dr.GetOrdinal("BloodGroup"));
                up.MobileNo = (string)dr.GetValue(dr.GetOrdinal("MobileNo"));
                up.PostOffice = (string)dr.GetValue(dr.GetOrdinal("Postoffice"));
                up.Gender = (string)dr.GetValue(dr.GetOrdinal("Gender"));

                textBox1.Text = up.FName;
                textBox2.Text = up.LName;
                textBox3.Text = up.NickName;
                cboGender.Text = up.Gender;
                textBox5.Text = up.BloodGroup;
                textBox6.Text = up.MobileNo;
                textBox7.Text = up.Email;
                textBox8.Text = up.PostOffice;
                textBox9.Text = up.District;
                textBox10.Text = up.Country;

                dr.Close();
            }
            else
            {
                dr.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    
                    string qry;
                    SqlCommand cmd;
                    if (valueExist == 1)
                    {
                        qry = "Update UserProfile set FName = '"+textBox1.Text+ "',LName = '"+ textBox2.Text + "',NickName = '" + textBox3.Text + "',Gender = '" + cboGender.Text + "',";
                        qry += " BloodGroup = '"+ textBox5.Text + "', MobileNo = '"+ textBox6.Text + "', Email = '" + textBox7.Text + "', PostOffice = '" + textBox8.Text + "', ";
                        qry += " District = '" + textBox9.Text + "', Country = '" + textBox10.Text + "' ";                        
                        qry += " where RollNo = '"+ UserRollNo + "'";
                    }
                    else
                    {
                        qry = "Insert into UserProfile values ('" + UserRollNo + "','" + textBox1.Text+"','"+ textBox2.Text + "','"+ textBox3.Text + "','"+cboGender.Text+"','"+ textBox5.Text + "','"+ textBox6.Text + "','"+ textBox7.Text + "','"+ textBox8.Text + "','"+ textBox9.Text + "','"+ textBox10.Text + "') ";
                    }
                       
                    cmd = new SqlCommand(qry, o.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                }

                catch (Exception ex)
                {

                }

                MessageBox.Show("Save successfully...");
                this.Close();
            }
        }

        private bool Validate()
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox2.Focus();
                return false;
            }
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox3.Focus();
                return false;
            }
            if (cboGender.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                cboGender.Focus();
                return false;
            }
            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox5.Focus();
                return false;
            }
            if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox6.Focus();
                return false;
            }
            if (textBox7.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox7.Focus();
                return false;
            }
            if (textBox8.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox8.Focus();
                return false;
            }
            if (textBox9.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox9.Focus();
                return false;
            }
            if (textBox10.Text.Equals(""))
            {
                MessageBox.Show("Please fill the data..");
                textBox10.Focus();
                return false;
            }
            return true;
        }
    }
}
