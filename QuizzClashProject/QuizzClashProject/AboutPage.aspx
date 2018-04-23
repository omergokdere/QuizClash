<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutPage.aspx.cs" Inherits="QuizzClash.AboutPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        	<link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>

</head>
<body id="about-body">

    <form id="form1" runat="server">
        <div id="menu">
             <ul class="navbar" runat="server">
                 <asp:Button id="btnProfile" runat="server" Text="" style="float:left" OnClick="btnProfile_Click"/>
                 <asp:Button id="btnLogout" runat="server" Text="LOGOUT" style="float:right" OnClick="btnLogout_Click"/>
                 <h1 style="float"><a>Quizz Clash</a></h1>
             </ul>
        </div>

        <div class="cont_about"> 
            <div class="menu_simple">
		
			    <h2>About</h2>

			    <h3>Welcome to our application!</h3>
                    <br />
                    <br />
			    <p>We promise you lots of fun, by answering questions and battle to know how much knowledge you have.</p>
			        <br />
                    <br />
                <p>The Quizz Clash is in pre-Alpha. So it's just a prototype of what this app will be.</p>
			        <br />
                    <br />
                <p>In the pre-Alpha release we offer:</p>
				    <br />
                <p>-login/logout.</p>
				    <br />
                <p>-create account.</p>
				    <br />
                <p>-recover password.</p>
				    <br />
                <p>-menu page.</p>
				    <br />
                <p>-play page.</p>
				    <br />
                <p>-top score page.</p>
				    <br />
                <p>-about page.</p>
				    <br />
                <p>-security features in the account.</p>
                <br />
                <br />

                <p>The objective of the game is to test people knowledge in 7 different areas:
                    <br />
                    <br />
                    <br />
                    <p>-Gastronomy</p>
				    <br />
                    <p>-History</p>
                    <br />
                    <p>-Art</p>
                    <br />
                    <p>-Music</p>
                    <br />
                    <p>-Sports</p>
                    <br />
                    <p>-Entertaintment</p>
                    <br />
                    <p>-Geography</p>
                    <br />
                    <p>-The game has 3 different modes:</p>
                    <br />
                    <p>-Easy- 5 questions of easy difficulty are made.</p>
                    <br />
                    <p>-Medium- 10 questions of medium difficulty are made.</p>
                    <br />
                    <p>-Hard- 15 questions of hard difficulty are made.</p>
                    <br />
                    <br />
                    <p>-In “scores page” the 5 best scores of each difficulty mode are shown.</p>
                    <br />
                    <p>-There is 4 possible answers, only one of them is correct.</p>
                    <br />

                <br />
	        </div>
        </div>
        <div class="form-input">
            <asp:Button ID="btnGoBackToMenu2" runat="server" Text="BACK" CssClass="btn-BACK" Width="250px" OnClick="btnGoBackToMenu_Click"/>
        </div>
    </form>
</body>
</html>
