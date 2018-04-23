<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="QuizzClash.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" IE="Edge">
    
    <title>QUIZZCLASH</title>
	<link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>
    <script type = "text/javascript" >
        
            function changeHashOnLoad() {
                window.location.href += "#";
                setTimeout("changeHashAgain()", "50");
            }

            function changeHashAgain() {
                window.location.href += "1";
            }

            var storedHash = window.location.hash;
            window.setInterval(function () {
                if (window.location.hash != storedHash) {
                    window.location.hash = storedHash;
                }
            }, 50);

        
</script>
</head>
<body id="loginBody" onload="changeHashOnLoad();">
    <div class="container">
        <img src="http://www.emoji.co.uk/files/google-emojis/smileys-people-android/7322-man-with-gua-pi-mao.png"; />
        <form id="form1" runat="server">
            <div class="form-input">
                <asp:TextBox ID="UserName" runat="server" placeholder="Username"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="loginID">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-input">
                <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="loginID">*</asp:RequiredFieldValidator>
            </div>
            <asp:Button ID="LoginButtonID" runat="server" Text="LOGIN" ValidationGroup="loginID" OnClick="LoginButtonClicked" class="btn-login" />
            <br />
            <a href="CreateUserPage.aspx" id="createUserID" runat="server">Create account </a>
            <br />
            <a href="PasswordRecoveryPage.aspx" id="passwordRecoveryID" runat="server">Forget password ?</a>
        </form>
    </div>
</body>
</html>
