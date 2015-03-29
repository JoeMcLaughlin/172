<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>

    <h1>Search for Shows!</h1>
    <p> Choose how you would like to search.</p>
    <form runat="server">
        Search By:<br />
    <asp:RadioButton GroupName="options" ID="artist" runat="server" AutoPostBack="true"/>Artists
       <span class="invisible" ID="artists" runat="server" >
           (List of Artists)
            <asp:DropDownList  ID="ddlArtist" runat="server" AutoPostBack="true"></asp:DropDownList>
       </span>
        <br />
    <asp:RadioButton GroupName="options" ID="genre" runat="server" AutoPostBack="true"/>Genre
        <span class ="invisible" ID="genres" runat="server">
            (List of Genres)
            <asp:DropDownList ID="ddlGenre" runat="server" AutoPostBack="true"></asp:DropDownList>
        </span>
    <br />
    <asp:RadioButton GroupName="options" ID="venue" runat="server" AutoPostBack="true"/>Venue
        <span class ="invisible" ID="venues" runat="server">
            (List of Venues)
            <asp:DropDownList ID="ddlVenue" runat="server" AutoPostBack="true"></asp:DropDownList>
        </span>
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Save" />
        <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
        </form>

</body>
</html>
