﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BookReview Login</title>
    <link href="BookReviewAtLargeStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Venue's Login Page</h1>
        <hr />
        <table class="login">
            <tr>
                <td class="login">User Name</td>
                <td class="login">
                    <asp:TextBox ID="txtUserName" runat="server">
</asp:TextBox></td>
            </tr>
                <tr>
                <td class="login">Password</td>
                <td class="login">
                    <asp:TextBox ID="txtPassword" runat="server" 
TextMode="Password">
                   </asp:TextBox></td>
            </tr>
                <tr>
                <td class="login">
                    <asp:Button ID="btnLogin" runat="server" Text="LogIn" OnClick="btnLogin_Click" />
                </td>
                <td class="login">
                    <asp:Label ID="lblMessage" runat="server" Text="">
</asp:Label> </td>
            </tr>
        </table>
        <asp:LinkButton ID="lbRegister" runat="server" 
            PostBackUrl="~/Registration.aspx">Register</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>