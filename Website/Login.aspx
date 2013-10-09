<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
    
        User name:
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        Password:&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="cmdLogin" runat="server" Text="Login" OnClick="cmdLogin_Click" />
        <br />
        <br />
        Keep me logged in
        <asp:CheckBox ID="chkKeepMeLoggedIn" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        User name: test<br />
        Password: test-12</div>
    </form>
</body>
</html>
