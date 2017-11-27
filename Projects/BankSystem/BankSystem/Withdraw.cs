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
    public partial class Withdraw : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader r;
        String RegNo;
        String cBalance;
        public Withdraw()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\BankSystem\\BankSystem\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
        }

        private void SearchAcc_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM Account WHERE AccNo='" + search.Text + "'";
            r = cmd.ExecuteReader();
            if (!r.Read())
            {
                MessageBox.Show("Invalid Account Number");
            }
            else
            {
                if (r["Active"].ToString().Equals("D"))
                {
                    MessageBox.Show("Deactivated Account");
                }
                else
                {
                    RegNo = r["AccNo"].ToString();
                    String name = r["Name"].ToString();
                    String address = r["Address"].ToString();

                    String accType = RegNo.Substring(0, 1);
                    String genderType = RegNo.Substring(1, 1);
                    nameTxt.Text = name;
                    addressTxt.Text = address;
                    if (accType == "C")
                    {
                        accTxt.Text = "Current";
                    }
                    else
                    {
                        accTxt.Text = "Savings";
                    }

                    if (genderType == "M")
                    {
                        genderTxt.Text = "Male";
                    }
                    else
                    {
                        genderTxt.Text = "Female";
                    }
                    r.Close();

                    SqlDataReader balance;
                    cmd.CommandText = "SELECT SUM(Amount) AS NewBalance FROM Deposits WHERE AccNo = '" + RegNo + "'";
                    balance = cmd.ExecuteReader();
                    balance.Read();
                    cBalance = balance["NewBalance"].ToString();
                    currentBalance.Text = cBalance;
                    balance.Close();
                    infoPanel.Show();
                }
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            SqlDataReader data;
            cmd.CommandText = "INSERT INTO Withdraw VALUES('" + RegNo + "', " + amtTxt.Text + ", '" + DateTime.Now.ToString("M/d/yyyy") + "')";
            data = cmd.ExecuteReader();
            MessageBox.Show("You have successfully withdrawn £" + amtTxt.Text);

            amtTxt.Clear();
            data.Close();
        }
    }
}

