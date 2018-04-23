<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EasyQuizPage.aspx.cs" Inherits="QuizzClash.EasyQuizPage_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="UTF-8"/>
    <title>Quizz</title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
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
<body id="easy-body" onload="changeHashOnLoad();"> 
    <form id="myform1" runat="server">
    <div class="grid" runat="server">
        <div id="quiz" runat="server">
            <h4>QuizzClash</h4>
            <div id="categoryDiv" runat="server">
                <p id="category" runat="server">Category of Question</p>
                <asp:Label ID="lblCategoryQuestion" runat="server" Text=""></asp:Label>
            </div>
            <hr style="margin-bottom: 10px"/>
            <span word-wrap="break-word" runat="server" color="transparent">
                <asp:TextBox id="txtQuestion" word-wrap="break-word" runat="server" color="transparent" BackColor="Transparent" BorderColor="Transparent" BorderStyle="None" BorderWidth="0px" Height="74px" TextMode="MultiLine" Width="991px"></asp:TextBox>
            </span>
            <div class="buttons" runat="server">
                <asp:Button ID="btnAnswer1" runat="server" OnClick="btnAnswer1_Click"></asp:Button>
                <asp:Button ID="btnAnswer2" runat="server" OnClick="btnAnswer2_Click"></asp:Button>
                <asp:Button ID="btnAnswer3" runat="server" OnClick="btnAnswer3_Click"></asp:Button>
                <asp:Button ID="btnAnswer4" runat="server" OnClick="btnAnswer4_Click"></asp:Button>
            </div>
            
            <hr style="margin-top: 50px" />
        </div>
        <asp:Button ID="btnStartGame" runat="server" OnClick="btnStartGame_Click" Text="START GAME" />
        <asp:Button ID="btnGoBackToMenu1" runat="server" OnClick="btnGoBackToMenu1_Click" Text="GO BACK TO MENU PAGE" />
    </div>
    </form>
</body>
</html>
