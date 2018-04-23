<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPage.aspx.cs" Inherits="QuizzClash.MenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>

</head>
<body id="menu-body">

    <form id="form1" runat="server">
        <div id="menu">
             <ul class="navbar" runat="server">
                 <asp:Button id="btnProfile" runat="server" Text="" style="float:left" OnClick="btnProfile_Click"/>
                 <asp:Button id="btnLogout" runat="server" Text="LOGOUT" style="float:right" OnClick="btnLogout_Click"/>
                 <h1 style="float"><a>Quizz Clash</a></h1>
             </ul>
        </div>
        

        <div class="container">
           <img src="http://www.emoji.co.uk/files/google-emojis/smileys-people-android/7322-man-with-gua-pi-mao.png"; />

            <div class="form-input">
            <asp:Button ID="btnPlayID" runat="server" Text="PLAY" CssClass="btn-login" OnClick="btnPlayID_Click"/>
            </div>
                <br />
            <div class="form-input">
            <asp:Button ID="btnTopScoresID" runat="server" Text="TOP SCORES" CssClass="btn-score" OnClick="btnTopScoresID_Click"/>
            </div>
                <br />
            <div class="form-input">
            <asp:Button ID="btnAboutID" runat="server" Text="ABOUT" CssClass="btn-about" OnClick="btnAboutID_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
