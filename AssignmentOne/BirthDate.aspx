<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BirthDate.aspx.cs" Inherits="BirthDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Please enter your Name:</p>
        <asp:TextBox ID="userName" runat="server" OnTextChanged="userName_TextChanged" />
        <p>Please choose the month you were born</p>
        <asp:DropDownList id="month" AutoPostBack="true" OnSelectedIndexChanged="Selection_Change" runat="server">
            <asp:ListItem Selected="True" Value="1">January</asp:ListItem>
            <asp:ListItem Value="2">February</asp:ListItem>
            <asp:ListItem Value="3">March</asp:ListItem>
            <asp:ListItem Value="4">April</asp:ListItem>
            <asp:ListItem Value="5">May</asp:ListItem>
            <asp:ListItem Value="6">June</asp:ListItem>
            <asp:ListItem Value="7">July</asp:ListItem>
            <asp:ListItem Value="8">August</asp:ListItem>
            <asp:ListItem Value="9">September</asp:ListItem>
            <asp:ListItem Value="10">October</asp:ListItem>
            <asp:ListItem Value="11">November</asp:ListItem>
            <asp:ListItem Value="12">December</asp:ListItem>
        </asp:DropDownList>
         <p>Please enter your Day of birth:</p>
        <asp:TextBox ID="dayBirth" runat="server" OnTextChanged="userName_TextChanged" />
         <p>Please enter your Year of birth:</p>
        <asp:TextBox ID="yearBirth" runat="server" OnTextChanged="userName_TextChanged" />
        
        

        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
        <p><asp:Label ID="lblDays" runat="server" Text=""></asp:Label></p>
    </div>
    </form>
</body>
</html>
