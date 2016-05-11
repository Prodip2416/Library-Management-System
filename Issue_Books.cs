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
    public partial class Issue_Books : Form
    {
        public Issue_Books()
        {
            InitializeComponent();
        }

        config o = new config();
        string UserRollNo = clsLogin.UserRoll;

        private void Issue_Books_Load(object sender, EventArgs e)
        {
            loadgridAllBooks("SELECT * FROM BOOKS_DETAILS", dgvAllBooks);
            o.loadgrid("SELECT ID,BookName,IssueDate FROM IssueBooks Where RollNo = '"+UserRollNo+"' ", dgvIssueBooks);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                loadgridAllBooks("SELECT * FROM BOOKS_DETAILS WHERE BOOK_NAME LIKE '%" + textBox1.Text + "%' OR AUTHOR LIKE '%" + textBox1.Text + "%' OR PUBLICATION LIKE '%" + textBox1.Text + "%' OR BOOK_TYPE LIKE '%" + textBox1.Text + "%' OR ISBN_NO LIKE '%" + textBox1.Text + "%'", dgvAllBooks);
            }
            else
            {
                loadgridAllBooks("SELECT * FROM BOOKS_DETAILS", dgvAllBooks);
            }
        }

        public void loadgridAllBooks(string qry, DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(qry, o.con);
            da.SelectCommand = cmd;
            da.Fill(ds);

            grid.DataSource = ds.Tables[0];
            da.Dispose();
            cmd.Dispose();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grid.Columns.Add(btn);
            btn.HeaderText = "Issue Books";
            btn.Text = "Click";
            btn.Name = "btn";           
            btn.UseColumnTextForButtonValue = true;
        }

        private void dgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow dr = dgvAllBooks.Rows[e.RowIndex];
                int BookID = Convert.ToInt32(dr.Cells[0].Value.ToString());
                string BookName = dr.Cells[1].Value.ToString();
                if (BookExist(BookID))
                {
                    MessageBox.Show("You have already issued selected book");
                }
                else
                {
                    string qry;
                    SqlCommand cmd;
                    qry = "Insert into IssueBooks Values('" + UserRollNo + "', " + BookID + ",'"+BookName+"',GetDate()) ";
                    cmd = new SqlCommand(qry, o.con);
                    SqlDataReader dr2 = cmd.ExecuteReader();

                    dr2.Close();
                    MessageBox.Show("Book Issued Successfully");

                    o.loadgrid("SELECT ID,BookName,IssueDate FROM IssueBooks Where RollNo = '" + UserRollNo + "' ", dgvIssueBooks);
                }
            }
        }

        private bool BookExist(int intBookID)
        {
            string qry;
            SqlCommand cmd;
            qry = "SELECT * FROM IssueBooks WHERE RollNo ='" + UserRollNo + "' and ID = "+intBookID+" ";
            cmd = new SqlCommand(qry, o.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else {
                dr.Close();
                return false;
            }
                
        }
    }
}
