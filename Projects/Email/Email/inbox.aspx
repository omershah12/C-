<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="Email.inbox" %>

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
                    Response.Write("<ul> <li>Welcome "+Session["user"].ToString()+" </li> <li>     </li> <li> "+Session["date"].ToString()+"</li> </ul>");
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Email\\Email\\App_Data\\Database1.mdf';Integrated Security=True";
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Email2 WHERE username='" + Session["user"].ToString() + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        if (data["status"].ToString() == "n")
                        {
                            Response.Write("<br><b><a href='ViewEmail.aspx?id="+data["subject"].ToString()+"'>" + data["sender"].ToString() + " " + data["subject"].ToString() + " " + data["body"].ToString() + " " + data["date"].ToString() + "</b></a>");
                        }else
                        {
                            Response.Write("<br><a href='ViewEmail.aspx?id="+data["subject"].ToString()+"'>" + data["sender"].ToString() + " " + data["subject"].ToString() + " " + data["body"].ToString() + " " + data["date"].ToString() + "</a>");
                        }
                    }
                    data.Close();
                }
            %>
            <br />
            <a href="NewEmail.aspx"> New email</a>
            <br />
            <a href="logout.aspx">Logout</a>
        </div>
    </form>
</body>
</html>
