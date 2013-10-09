<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="Website.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Home</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <a href="login.aspx">Login</a>
        <asp:Table runat="server" ID="tblAlbums"></asp:Table>
    <asp:Label runat="server" ID="lblCart" EnableViewState="false"></asp:Label>
    <hr/>
    <asp:Label runat="server" ID="lblCartPrice"></asp:Label>
</asp:Content>
