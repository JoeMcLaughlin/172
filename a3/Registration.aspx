<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>First Name</td>
            <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
         
         <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Fan Name</td>
            <td><asp:TextBox ID="txtFanName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Confirm Password</td>
            <td><asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td>
                <asp:Label ID="lblErrorSuccess" runat="server" Text=""></asp:Label></td>
        </tr>
       
    </table>
        <asp:LinkButton ID="LbLogin" runat="server" 
PostBackUrl="~/Default.aspx">Log in</asp:LinkButton>

        <asp:RequiredFieldValidator ID="EmailValidator" ControlToValidate="txtEmail" runat="server" ErrorMessage="E-Mail is required" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="FanNameValidator" ControlToValidate="txtFanName" runat="server" ErrorMessage="Fan Name is required" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="PasswordValidator" ControlToValidate="txtPassword" runat="server" ErrorMessage="You must enter a Password" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="ConfirmValidator" ControlToValidate="txtConfirm" runat="server" ErrorMessage="You must confirm your Password" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="EmailRegularExpression" ControlToValidate="txtEmail" runat="server" ErrorMessage="Enter a valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:CompareValidator ID="passwordCompare" runat="server" ControlToValidate="txtConfirm" ControlToCompare="txtPassword" ErrorMessage="Passwords don't match" Display="None"></asp:CompareValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        
    </div>
    </form>
</body>
</html>
