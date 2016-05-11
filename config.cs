using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Library_Management
{
    class config
    {
        public SqlConnection con;
        public string str;

       public config()
        {
            try
            {
                str = @"Data Source=.;Initial Catalog= info;Integrated Security=true";
                //str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\My Programming\Code C#\Work\Library_Management\Library_Management\info.mdf;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
            }
            catch (SqlException x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);

            }
            finally
            {
                //con.Close();
            }

        }
    public void loadgrid(string qry, DataGridView grid)
       {
           SqlDataAdapter da = new SqlDataAdapter();
           DataSet ds = new DataSet();
           SqlCommand cmd = new SqlCommand(qry, con);
           da.SelectCommand = cmd;
           da.Fill(ds);
           grid.DataSource = ds.Tables[0];
           da.Dispose();
           cmd.Dispose();
       }
    }
}
