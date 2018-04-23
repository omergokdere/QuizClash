<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DifficultyPage.aspx.cs" Inherits="QuizzClash.DifficultyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>

</head>
<body id="difficult-body">
    <form id="form1" runat="server">
        <div class="container">
            <img src="http://www.emoji.co.uk/files/google-emojis/smileys-people-android/7322-man-with-gua-pi-mao.png"; />
            <div class="form-input">
            <asp:Button ID="btnEasyID" runat="server" Text="EASY" CssClass="btn-login" OnClick="btnEasyID_Click"  Width="250px"/>
            </div>
            <br />
            <div class="form-input">
            <asp:Button ID="btnMediumID" runat="server" Text="MEDIUM" CssClass="btn-login" Width="250px" OnClick="btnMediumID_Click"/>
            </div>
            <br />
            <div class="form-input">
            <asp:Button ID="btnHardID" runat="server" Text="HARD" CssClass="btn-login" Width="250px" OnClick="btnHardID_Click"/>
            </div>
            <br />
            <div class="form-input">
            <asp:Button ID="btnGoBackToMenu" runat="server" Text="BACK" CssClass="btn-BACK" Width="250px" OnClick="btnGoBackToMenu_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
