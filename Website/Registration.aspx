<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Registration.aspx.cs" Inherits="Website.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Home</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox runat="server" ÍD="username" CssClass="form-control"/>
    <asp:TextBox runat="server" ÍD="password" TextMode="Password"/>
    <asp:Button type="button" runat="server" id="btnRegister" CssClass="btn btn-success" Text="Create"></asp:Button> 
</asp:Content>
