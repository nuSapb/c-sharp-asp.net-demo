<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Demo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test C# ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Name:
            <asp:TextBox ID="userName_textBox" runat="server"></asp:TextBox>
            <br />
            Password:
            <asp:TextBox ID="password_textBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
        </div>
    </form>
</body>
</html>
