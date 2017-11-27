using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ServerSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        private DataTable dataTable = new DataTable();

        public WebForm1()
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\ServerSQL\\ServerSQL\\App_Data\\Database1.mdf';Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Personal";
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read())
            {
                string name = data["Name"].ToString();
                string address = data["Address"].ToString();

                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = "blah blah";
                row.Cells.Add(cell1);
                TableCell cell2 = new TableCell();
                cell2.Text = "blah blah";
                row.Cells.Add(cell2);
                myTable.Rows.Add(row);


                data.Close();
            }
        }
    }
}