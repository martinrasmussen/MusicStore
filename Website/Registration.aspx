<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Registration.aspx.cs" Inherits="Website.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Home</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:createuserwizard ID="CreateUserWizard1" runat="server"> <WizardSteps> <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server"/> <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server"/> </WizardSteps> </asp:createuserwizard>

    </div>
</asp:Content>
