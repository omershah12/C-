<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Email.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
 
<body>
    <form id="form1" runat="server" method="post" action="check.aspx">
        <div>
            Username:
            <input type="text" name="user" />
            <br />
            Password
            <input type="password" name="pass" />
            <br />
            <input type="submit" value="Login" />
        </div>

    </form>
</body>
</html>
