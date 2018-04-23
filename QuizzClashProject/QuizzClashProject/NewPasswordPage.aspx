<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPasswordPage.aspx.cs" Inherits="QuizzClash.NewPasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>

</head>
<body id="newPassword-body">
    <form id="form1" runat="server">
        <div class="container">
            <img src="http://www.emoji.co.uk/files/google-emojis/smileys-people-android/7322-man-with-gua-pi-mao.png"; />
            <div class="form-input">
                <asp:TextBox ID="NewPassword" runat="server" TextMode="Password" placeholder="New Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="NewPassword" >*</asp:RequiredFieldValidator>
            </div>
            <br />
            <div class="form-input">
                <asp:TextBox ID="ConfirmNewPassword" runat="server" TextMode="Password" placeholder="Confirm New Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired1" runat="server" ControlToValidate="ConfirmNewPassword">*</asp:RequiredFieldValidator>
            </div>
            <br />
            <div class="form-input">
                <asp:Button ID="SavePasswordButton" runat="server" Text="SUBMIT" OnClick="SavePasswordButton_Click" class="btn-newPass" />
            </div>
        </div>
    </form>
</body>
</html>
