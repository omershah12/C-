<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="Email.SendEmail" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <%
         String to = Request.Form["to"];
         String subject = Request.Form["subject"];
         String body = Request.Form["body"];
         SqlConnection con = new SqlConnection();
         con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Email\\Email\\App_Data\\Database1.mdf';Integrated Security=True";
         con.Open();
         SqlCommand cmd = con.CreateCommand();
         SqlDataReader data;
         cmd.CommandText = "INSERT INTO Email2 VALUES('"+to+"', '"+Session["user"].ToString()+"', '"+subject+"', '"+body+"','"+Session["date"].ToString()+"', 'n', 'n')";
         data = cmd.ExecuteReader();
         Response.Redirect("inbox.aspx");
         %>
    </div>
    </form>
</body>
</html>
