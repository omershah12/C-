﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="/" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="*" />
          
        </div>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
