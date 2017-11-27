<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Timestable.aspx.cs" Inherits="FirstASP.Timestable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        int table = Int32.Parse(Request.QueryString["T"]);
        int range = Int32.Parse(Request.QueryString["R"]);

        Response.Write("<h1>Timestable of " + table + "</h1>");
        for (int i = 1; i <= range; i++)
        {
            Response.Write("<br>"+table + "x" + i + "= " + (i * table));
        }
         %>
    </div>
    </form>
</body>
</html>
