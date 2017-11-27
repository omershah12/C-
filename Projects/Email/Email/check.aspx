<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="check.aspx.cs" Inherits="Email.check" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Check
    </div>
    </form>
    <%
        String user = Request.Form["user"];
        String pass = Request.Form["pass"];
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Email\\Email\\App_Data\\Database1.mdf';Integrated Security=True";
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = "SELECT * FROM Users WHERE username='" + user + "' AND password= '" + pass + "'";
        SqlDataReader data = cmd.ExecuteReader();

        if (data.Read())
        {
            Session["date"] = DateTime.Now.ToString("d/M/yyyy");
            Session["user"] = data["username"].ToString();
            Response.Redirect("inbox.aspx");
        }else
        {
            Response.Redirect("Invalid.aspx");
        }
        data.Close();
         %>
</body>
</html>
