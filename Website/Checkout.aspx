<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Checkout.aspx.cs" Inherits="Website.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Checkout</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h3>Enter the following credentials </h3>
        <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server" placeholder="First Name"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server" placeholder="Last Name"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtStreet" CssClass="form-control" runat="server" placeholder="Street"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" placeholder="City"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtCountry" CssClass="form-control" runat="server" placeholder="Country"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Checkout" OnClick="btnSubmit_OnClickSubmit_Click" CssClass="btn btn-primary"/>
    </div>
</asp:Content>