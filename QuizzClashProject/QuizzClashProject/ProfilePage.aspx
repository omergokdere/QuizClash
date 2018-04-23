<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="QuizzClashProject.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile Page</title>
    <link rel="stylesheet" type="text/css" href="style.css" title="CSS file"/>
</head>
<body id="profileBody" runat="server">
    <form id="form2" runat="server">
        <div class="row" runat="server">
            <div class="pic_base" runat="server">
                <img src="https://img.clipartfest.com/fb4d67406489970c2b94f8b229f26c3d_profile-man-user-home-professional-profile-icon-clipart-png_775-720.png" width="200" id="profile_pic" alt=""/>
                <div class="icon_base" runat="server">
                    <a href="PasswordRecoveryPage.aspx" id="edit" runat="server">Edit</a>
                </div>
            </div>
            <div class="content_base" runat="server">
                <p id="lblUserName1" runat="server">Username: <asp:Label ID="lblUserName" runat="server"></asp:Label></p>
                <br />
                <p id="lblEmail1" runat="server">Email: <asp:Label ID="lblEmail" runat="server"></asp:Label></p>
                <br />
                <ul class="social" runat="server">
                    <li><a href="MenuPage.aspx" id="menu" runat="server">Menu</a></li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
