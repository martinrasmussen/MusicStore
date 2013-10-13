<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Confirmation.aspx.cs" Inherits="Website.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Confirmation</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label ID="lblFirstName" runat="server" placeholder="First Name"></asp:Label>
    </div>
</asp:Content>