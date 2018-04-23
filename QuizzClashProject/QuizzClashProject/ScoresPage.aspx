<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoresPage.aspx.cs" Inherits="QuizzClash.ScoresPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>
</head>
<body id="scores-body">
    
    <form id="form1" runat="server">
        <div id="menu">
             <ul class="navbar" runat="server">
                 <asp:Button id="btnProfile" runat="server" Text="" style="float:left" OnClick="btnProfile_Click"/>
                 <asp:Button id="btnLogout" runat="server" Text="LOGOUT" style="float:right" OnClick="btnLogout_Click"/>
                 <h1 style="float"><a>Quizz Clash</a></h1>
             </ul>
        </div>

        <div class="container">
        <asp:GridView 
                    ID="gvTopScoresID" 
                    runat="server" 
                    BackColor="White" 
                    BorderColor="#CCCCCC" 
                    BorderStyle="None" 
                    BorderWidth="1px" 
                    CellPadding="4" 
                    GridLines="Horizontal" 
                    CssClass = "Grid"
                    AlternatingRowStyle-CssClass = "alt" ForeColor="Black" Height="359px" Width="403px">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#34495e" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        </div>

        <div class="form-input">
        <asp:Button ID="btnGoBackToMenu3" runat="server" Text="BACK" CssClass="btn-BACK" Width="250px" OnClick="btnGoBackToMenu_Click"/>
        </div>

    </form>
</body>
</html>
