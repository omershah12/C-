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

namespace BankSystem
{
    public partial class newAcc : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader r;
        String accType = "";
        String gender = "";

        public newAcc()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\BankSystem\\BankSystem\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            accType = currentBtn.Checked ? "C" : "S";
            gender = maleBtn.Checked ? "M" : "F";

            cmd.CommandText = "SELECT CONCAT('" + accType + "', '" + gender + "', RIGHT(CONCAT(REPLICATE('0',3) , ISNULL(MAX(SUBSTRING(AccNo,3,3))+1, '001')), 3)) AS NewAccNo FROM Account WHERE SUBSTRING(AccNo,1,1)='"+accType+"'";
            Console.Write(cmd.CommandText);
            r = cmd.ExecuteReader();
            r.Read();
            String newAccNumber = r["NewAccNo"].ToString();
            r.Close();
            cmd.CommandText = "INSERT INTO Account VALUES('" + newAccNumber + "', '"+txtName.Text+"', '"+txtAddress.Text+"', 'A')";
            cmd.ExecuteNonQuery();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deposit d = new deposit();
            d.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.Show();
        }
    }
}
