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

namespace FirstSQL
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\FirstSQL\\FirstSQL\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT ISNULL(MAX(Id),0) + 1 AS newR FROM school";
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                string newId = r["newR"].ToString();
                r.Close();
                cmd.CommandText = "INSERT INTO school VALUES("+ newId +", '"+ txt2.Text +"', "+ txt3.Text +")";
                cmd.ExecuteNonQuery();
                txt1.Text = newId;
               
            }
           // r.Close();
            //String query = "INSERT INTO school VALUES("+txt1.Text+", '"+txt2.Text+"', "+txt3.Text+")";
            //cmd.CommandText = query;
            //cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM school";
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read())
            {
                txt1.Text = data["Id"].ToString();
                txt2.Text = data["name"].ToString();
                txt3.Text = data["marks"].ToString();
            }
            data.Close();
        }
    }
}
