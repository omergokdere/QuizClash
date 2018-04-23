<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="QuizzClash.ResultPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result Page</title>
    <link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>
</head>
<body id="results-body">
    <form id="form7" runat="server">
        <div id="cont-result">
            <p id="lbl1" runat="server">You have<asp:Label ID="lblResult" runat="server" Text=""></asp:Label> correct answer out of<asp:Label ID="lblResult2" runat="server" Text=""></asp:Label> questions ! </p>
            <asp:Button ID="btnPlayAgain" runat="server" Text="PLAY AGAIN" OnClick="btnPlayAgain_Click"/>
            <asp:Button ID="btnGoBackToMenu" runat="server" Text="RETURN TO MENU" OnClick="btnGoBackToMenu_Click"/>
        </div>
    </form>
</body>
</html>
