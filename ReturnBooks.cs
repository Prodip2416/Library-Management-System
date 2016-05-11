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
    public partial class ReturnBooks : Form
    {

        config o = new config();
        string UserRollNo = clsLogin.UserRoll;
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            loadgridReturnAllBooks("SELECT ID,BookName,IssueDate FROM IssueBooks Where RollNo = '" + UserRollNo + "' ", dgvReturnBooks);
        }


        public void loadgridReturnAllBooks(string qry, DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(qry, o.con);
            da.SelectCommand = cmd;
            da.Fill(ds);


            grid.DataSource = ds.Tables[0];
            da.Dispose();
            cmd.Dispose();

            if (grid.Columns.Contains("btn"))
            {
                grid.Columns.Remove("btn");
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grid.Columns.Add(btn);
            btn.HeaderText = "Return Books";
            btn.Text = "Click";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                loadgridReturnAllBooks("SELECT ID,BookName,IssueDate FROM IssueBooks Where RollNo = '" + UserRollNo + "' and BOOKNAME LIKE '%" + textBox1.Text + "%' ", dgvReturnBooks);
            }
            else
            {
                loadgridReturnAllBooks("SELECT ID,BookName,IssueDate FROM IssueBooks Where RollNo = '" + UserRollNo + "' ", dgvReturnBooks);
            }
        }

        private void dgvReturnBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow dr = dgvReturnBooks.Rows[e.RowIndex];
                int BookID = Convert.ToInt32(dr.Cells[0].Value.ToString());
                string BookName = dr.Cells[1].Value.ToString();

                string qry;
                SqlCommand cmd;
                qry = "Delete from IssueBooks Where RollNo = '" + UserRollNo + "' and ID = " + BookID + " ";
                cmd = new SqlCommand(qry, o.con);
                SqlDataReader dr2 = cmd.ExecuteReader();

                dr2.Close();
                MessageBox.Show("Book Returned Successfully");

                loadgridReturnAllBooks("SELECT ID,BookName,IssueDate FROM IssueBooks Where RollNo = '" + UserRollNo + "' ", dgvReturnBooks);

            }
        }
    }
}
