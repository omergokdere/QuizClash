<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUserPage.aspx.cs" Inherits="QuizzClash.CreateUserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QUIZZCLASH</title>
	<link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>
</head>
<body id="create-body">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <br />
                    <div class="form-input">
                    <asp:TextBox ID="UserName" runat="server" placeholder="Username"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                        ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </div>
                    <div class="form-input">
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                        ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </div>
                    <div class="form-input">
                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword"
                        ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                    </div>
                <div class="form-input">
                    <asp:TextBox ID="Email" runat="server" placeholder="Email" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </div>
                    <asp:TextBox ID="Question" runat="server" placeholder="Secret Question" hidden="true"></asp:TextBox>
                    <asp:TextBox ID="Answer" runat="server" hidden="true"></asp:TextBox>
                <div class="form-input">
                    <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                        ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match."
                        ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                </div>
            <div class="btn-create-user">
                <asp:Button ID="CreateUserButtonID" runat="server" Text="CREATE" ValidationGroup="CreateUserWizard1" class="btn-create" OnClick="CreateUserButtonID_Click"/>
            </div>

        </div>
    </form>
</body>
</html>
