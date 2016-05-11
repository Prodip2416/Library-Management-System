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
using System.IO;

namespace Library_Management
{
    public partial class add_users : Form
    {
        public add_users()
        {
            InitializeComponent();
        }
        config o = new config();
        SqlConnection con;
      //  string str;
        private void add_users_Load(object sender, EventArgs e)
        {
            //str= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\My Programming\Code C#\Work\Library_Management\Library_Management\info.mdf;Integrated Security=True";

            con = new SqlConnection(o.str);
            con.Open();

            label9.Text = getroll();

        }
        string getroll()
        {

            string qry = "SELECT COUNT(*)FROM users";
            SqlCommand cmd = new SqlCommand(qry, con);
            int a = 101 + (Int32)cmd.ExecuteScalar();
            string reg = "A" + a.ToString();
            return (reg);
        }

        string img_file =null;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() !=DialogResult.Cancel)
            {
                img_file = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text !="" && textBox4.Text !="" && textBox5.Text != ""&& comboBox1.SelectedIndex !=-1)
           {
          
                if (textBox3.Text == textBox4.Text)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO users(name,password,department,question,answer,roll_no) VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + label9.Text + "')", con);
                  
                    cmd.ExecuteNonQuery();
  
                    label10.ForeColor = Color.Green;
                    label10.Text = "Users added into database."; 
                }
                else
                {
                    label10.ForeColor = Color.Red;
                    label10.Text = "These passwords don't match.";

                }


           }
               else
               {
                        label10.ForeColor = Color.Red;
                label10.Text = "Please Enter All The Details.";
               }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }
        void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}
