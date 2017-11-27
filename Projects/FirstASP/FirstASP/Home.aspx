<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FirstASP.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Manchester.aspx">QA Consulting</a>
            <a href="Timestable.aspx?T=2&R=10">2</a>
            <a href="Timestable.aspx?T=3&R=20">3</a>
            <a href="ALotOfLinks.aspx">Links</a>
        </div>
        <%
            for (int a = 0; a <= 10; a++)
                Response.Write(a);
        %>
    </form>
</body>
</html>
