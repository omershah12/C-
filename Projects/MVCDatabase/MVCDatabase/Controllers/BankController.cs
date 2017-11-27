using MVCDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDatabase.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("New");
        }

        public ActionResult AddNew(Data x)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\MVCDatabase\\MVCDatabase\\App_Data\\Database1.mdf';Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO AccountHoloders VALUES('" + x.N + "', '" + x.A + "', '" + x.T + "')";
            cmd.ExecuteNonQuery();
            return View("Index");
        }

        public ActionResult Delete(int PId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\MVCDatabase\\MVCDatabase\\App_Data\\Database1.mdf';Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM AccountHoloders WHERE PId=" + PId;
            cmd.ExecuteNonQuery();
            return View("Index");
        }

        public ActionResult Edit(Data x, int PId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\MVCDatabase\\MVCDatabase\\App_Data\\Database1.mdf';Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader data;
            cmd.CommandText = "SELECT * FROM AccountHoloders WHERE PId=" + PId;
            data = cmd.ExecuteReader();
            if (data.Read())
            {
                x.N = data["Name"].ToString();
                x.A = data["Address"].ToString();
                x.T = data["Telephone"].ToString();
                ViewData["ID"] = PId;
                return View("Edit", x);
            }
            data.Close();
            return View("Index");
        }

        public ActionResult Update(Data x, int PId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\MVCDatabase\\MVCDatabase\\App_Data\\Database1.mdf';Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE AccountHoloders SET Name='" + x.N + "', Address='" + x.A + "', Telephone='" + x.T + "' WHERE PId=" + PId;
            cmd.ExecuteNonQuery();
            return View("Index");
        }
    }
}
