<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="URLRewrite.Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        String t = Request.QueryString["T"];
        for(int i=10; i <= 100; i += 10)
        {
            Response.Write("<br> <a href='Third.aspx?T=" + t + "&R=" + i + "'>" + i + "</a>");
        }
         %>
    </div>
    </form>
</body>
</html>
