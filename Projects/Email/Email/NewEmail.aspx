<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewEmail.aspx.cs" Inherits="Email.NewEmail" %>

<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="SendEmail.aspx">
        To:
            <input type="text" name="to" />
        <br />
        Subject:
            <input type="text" name="subject" />
        <br />
        Body:
        <br />
        <input type="text" name="body" />
        <input type="submit" value="Send" />
        <div>
            <%
                if (Session["user"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("Welcome " + Session["user"] + " " + Session["date"] + "<br>");
                }
            %>
        </div>
    </form>
</body>
</html>
