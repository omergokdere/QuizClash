<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordRecoveryPage.aspx.cs" Inherits="QuizzClash.PasswordRecoveryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>

</head>
<body id="passwordRecovery-body">
    <form id="form1" runat="server">
        <div class="container">
            <img src="http://www.emoji.co.uk/files/google-emojis/smileys-people-android/7322-man-with-gua-pi-mao.png"; />
            <h3>Enter Username and Email to Recover Your Password</h3>
            <br />
            <div class="form-input">
                <asp:TextBox ID="UserName" runat="server" placeholder="Username"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ValidationGroup="PasswordRecoveryID">*</asp:RequiredFieldValidator>
            <br />
            </div>
            <div class="form-input">
                <asp:TextBox ID="Email" runat="server" placeholder="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ValidationGroup="PasswordRecoveryID">*</asp:RequiredFieldValidator>
            <br />
            </div>
            <div class="form-input">
                <asp:Button ID="SubmitButton" runat="server" CommandName="Submit" class="btn-password" Text="SUBMIT" ValidationGroup="PasswordRecoveryID" OnClick="SubmitButton_Click" />
            </div>
        </div>
    </form>
</body>
</html>
