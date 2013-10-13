<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Registration.aspx.cs" Inherits="Website.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Register</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
         <strong>Sign Up for New User Account</strong><br/><br/>
         <span>UserName:</span>
         <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server"/> 
         <asp:RequiredFieldValidator ID="rqfUserName" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"/> 
         <br/>
         <span>Password: </span>
         <asp:TextBox CssClass="form-control" ID="txtPwd" runat="server" TextMode="Password"/> 
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"/> 
         <br/>
         <span>Confirm Password: </span>
         <asp:TextBox CssClass="form-control" ID="txtCnfPwd" runat="server" TextMode="Password"/> 
         <asp:RequiredFieldValidator id="PasswordConfirmRequiredValidator" runat="server" ControlToValidate="txtCnfPwd" ForeColor="red" Display="Dynamic" ErrorMessage="Required" />
         <asp:CompareValidator id="PasswordConfirmCompareValidator" runat="server" ControlToValidate="txtCnfPwd" ForeColor="red" Display="Dynamic" ControlToCompare="txtPwd" ErrorMessage="Confirm password must match password." /> 
         <br/>
         <span>Email: </span>
         <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"/> 
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" Display="Static" ErrorMessage="Required" ForeColor="Red"/> 
         <br/>
         <span>Security Question: </span>
         <asp:TextBox CssClass="form-control" ID="txtQuestion" runat="server"/> 
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtQuestion" Display="Static" ErrorMessage="Required" ForeColor="Red"/> 
         <br/>
         <span>Security Answer: </span>
         <asp:TextBox CssClass="form-control" ID="txtAnswer" runat="server"/> 
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAnswer" Display="Static" ErrorMessage="Required" ForeColor="Red"/> 
         <br/>
         <asp:Button ID="btnSubmit" CssClass="btn btn-primary" runat="server" Text="Register" onclick="CmdSubmit_Click" /> 
         <br/>
         <asp:Label ID="lblResult" runat="server" Font-Bold="true"/>      
     </div>
</asp:Content>