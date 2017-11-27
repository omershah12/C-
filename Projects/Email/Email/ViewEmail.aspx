<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEmail.aspx.cs" Inherits="Email.ViewEmail" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #333;
}

li {
    float: left;
    color: white;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <%
         if (Session["user"] == null)
         {
             Response.Redirect("login.aspx");
         }
         else
         {
             String sub = Request.QueryString["id"];
             Response.Write("<ul> <li>Welcome "+Session["user"].ToString()+" </li> <li>     </li> <li> "+Session["date"].ToString()+"</li> </ul>");
             SqlConnection con = new SqlConnection();
             con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Email\\Email\\App_Data\\Database1.mdf';Integrated Security=True";
             con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandText = "SELECT * FROM Email2 WHERE subject='" + sub + "'";
             SqlDataReader data = cmd.ExecuteReader();
             if (data.Read())
             {
                 Response.Write("From: " + data["sender"].ToString() + "<br>");
                 Response.Write("Subject: " + data["subject"].ToString() + "<br>");
                 Response.Write("Body: " + data["body"].ToString() + "<br>");
             }
             if (data["status"].ToString() == "n")
             {
                 data.Close();
                 SqlConnection con1 = new SqlConnection();
                 con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Email\\Email\\App_Data\\Database1.mdf';Integrated Security=True";
                 con1.Open();
                 SqlCommand cmd1 = con1.CreateCommand();
                 SqlDataReader data1;
                 cmd1.CommandText = "UPDATE Email2 SET status='v' WHERE subject='" + sub + "'";
                 data1 = cmd1.ExecuteReader();
             }
         }
            %>
        <br />
        <a href="inbox.aspx">Inbox</a>
    </div>
    </form>
</body>
</html>
