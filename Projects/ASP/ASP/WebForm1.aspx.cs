using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    TextBox1.Text = "Hello My Friends";
            //}
            HttpCookie myCookie = Request.Cookies["User"];
            if (myCookie != null)
            {
                Response.Redirect("WebForm2.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("User");
            myCookie["name"] = TextBox1.Text;
            myCookie.Expires = DateTime.Now.AddDays(1d);
            Response.Cookies.Add(myCookie);

            Response.Redirect("WebForm2.aspx");
        }
    }
}