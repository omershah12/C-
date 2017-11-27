<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="URLRewrite.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <%
        for (int i = 1; i <= 1000; i++)
        {
            Response.Write("<br> <a href='Second.aspx?T=" + i + "'>" + i + "</a>");
        }
            %>
    </div>
    </form>
</body>
</html>
