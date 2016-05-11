using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class view_books : Form
    {
        public view_books()
        {
            InitializeComponent();
        }
        config o = new config();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_books_Load(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM BOOKS_DETAILS", dataGridView1);
        }
    }
}
