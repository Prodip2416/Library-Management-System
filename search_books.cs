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
    public partial class search_books : Form
    {
        public search_books()
        {
            InitializeComponent();
        }
        config o = new config();
        private void search_books_Load(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM BOOKS_DETAILS", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                o.loadgrid("SELECT * FROM BOOKS_DETAILS WHERE BOOK_NAME LIKE '%" + textBox1.Text + "%' OR AUTHOR LIKE '%" + textBox1.Text + "%' OR PUBLICATION LIKE '%" + textBox1.Text + "%' OR BOOK_TYPE LIKE '%" + textBox1.Text + "%' OR ISBN_NO LIKE '%" + textBox1.Text + "%'", dataGridView1);
            }
            else
            {
                o.loadgrid("SELECT * FROM BOOKS_DETAILS", dataGridView1);
            }
        }
    }
}
