<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ALotOfLinks.aspx.cs" Inherits="FirstASP.ALotOfLinks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        for(int i = 1; i <= 20000; i++)
        {
            Response.Write("<br> <a href='Timestable.aspx?T=" + i + "&R=10'>" + i + "</a>");
        }
         %>
    </div>
    </form>
</body>
</html>
