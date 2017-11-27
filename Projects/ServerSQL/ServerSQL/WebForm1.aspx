<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServerSQL.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="myTable" runat="server" Width="100%"> 
    <asp:TableRow>
        <asp:TableCell>Name</asp:TableCell>
        <asp:TableCell>Address</asp:TableCell>
    </asp:TableRow>
</asp:Table>  
</asp:Content>
