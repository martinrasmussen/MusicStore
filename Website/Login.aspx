<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Login</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <span>User name:</span>
        <asp:TextBox ID="txtUser" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <span>Password:</span>
        <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="cmdLogin" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="cmdLogin_Click" />
        <br />
        <br />
        <span>Keep me logged in</span>
        <asp:CheckBox ID="chkKeepMeLoggedIn" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>