﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<!-- 
    [x] -- Create a new empty website. 
    [x] -- Add a Web Form.
    [ ] -- In this site we are going to allow a fan to register. 
    [ ] -- Once they have registered, they can log in. For now, 
            [ ] -- if they successfully log in, 
            [ ] -- their key will be stored in a Session Variable and 
            [ ] -- they will be redirected  to a welcome page.
    [ ] -- We will want to hash the passwords of the fans for the database. For security we will also 
            [ ] -- create a random integer called a seed to be concatenated with the password. will give you the file to create the hash.
    [ ] -- Use some CSS to modify the appearance of the page.
    [ ] -- Use ADO Entites and the SQL Login FanLogin with the Password "FanP@ssword"
    -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to the Book Review Club</h1>
        <p>Log in or register to leave reviews</p>
        <table>
            <tr>
                <td>User Name</td>
                <td>
                    <asp:TextBox ID="txtuserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" />
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Registration.aspx">Register</asp:LinkButton>
        </p>
    </div>
    </form>
</body>
</html>