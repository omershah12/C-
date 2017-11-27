using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["User"];
            if (myCookie != null)
                Response.Write("<p> Welcome " + myCookie["name"]);
            else
                Response.Write("not found");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(TextBox1.Text);
            int num2 = Int32.Parse(TextBox1.Text);
            int result = num1 + num2;
            TextBox3.Text = result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(TextBox1.Text);
            int num2 = Int32.Parse(TextBox1.Text);
            int result = num1 / num2;
            TextBox3.Text = result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(TextBox1.Text);
            int num2 = Int32.Parse(TextBox1.Text);
            int result = num1 - num2;
            TextBox3.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(TextBox1.Text);
            int num2 = Int32.Parse(TextBox1.Text);
            int result = num1 * num2;
            TextBox3.Text = result.ToString();
        }
    }
}