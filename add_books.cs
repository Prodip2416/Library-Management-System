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
{    public partial class add_books : Form
    {
        public add_books()
        {
            InitializeComponent();
        }

        config o = new config();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                try
                {
                    string qry = "INSERT INTO BOOKS_DETAILS(BOOK_NAME,ISBN_NO,AUTHOR,PUBLICATION,BOOK_TYPE) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    cmd.ExecuteNonQuery();
                    label7.ForeColor = Color.Green;
                    label7.Text = "Data Stored.";

                }
                catch (Exception x)
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = x.Message;
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Datas.");
            }
        }

      public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label7.Text = "-";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }
    }
}
