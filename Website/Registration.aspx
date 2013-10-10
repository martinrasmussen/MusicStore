<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Website.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:createuserwizard ID="CreateUserWizard1" runat="server"> <WizardSteps> <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server"/> <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server"/> </WizardSteps> </asp:createuserwizard>

    </div>
    </form>
</body>
</html>
