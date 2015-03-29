<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addPage.aspx.cs" Inherits="addPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    


        <h1>The Add Page</h1>
        <h3>Add Artist</h3>
        <table>
         <tr>
            <td>Choose an existing Artist or enter your own</td>            
            <td>
                <asp:TextBox ID="txtArtist" runat="server"></asp:TextBox></td>
             <td>
                <asp:DropDownList ID="ddlArtist" runat="server"></asp:DropDownList></td>
        </tr>

        <tr>
            <td>Email</td>            
            <td>
                <asp:TextBox ID="txtAEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Webpage</td>
            <td>
                <asp:TextBox ID="txtAWebpage" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <h3>Add Show</h3>
            </td>
        </tr>
        <tr>
            <td>Choose an existing Show or enter your own</td>            
            <td>
                <asp:TextBox ID="txtSName" runat="server"></asp:TextBox></td>
            <td>
                <asp:DropDownList ID="ddlSName" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Ticket Info</td>
            <td>
                <asp:TextBox ID="txtSTicket" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Time(format- 00:00:00)</td>
            <td>
                <asp:TextBox ID="txtSTime" runat="server"></asp:TextBox></td>
        </tr>
           
       </table>
        <!-- venue
        artists?
        show?
        showdetailartist starttime?           
        Show Details:
        <textarea cols="100" rows="4" name="taAddDetails"></textarea><br />
-->






        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
    
    </form>
</body>
</html>
