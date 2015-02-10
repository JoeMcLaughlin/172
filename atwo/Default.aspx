<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<!--
    [x]Start with an empty web site.
    [x]Add a web form. 
    [x]Add the ADO Entites.
    [x]Use the Sql Server Login BasicShowTimeLogin with the password="P@ssw0rd1". 
    [x]Make sure to include the tables Artist, Show, and ShowDetails. 
    [x]You should also include Venue.
    [x]Add a drop down list that shows all the artists in the database. 
    [x]You will also need the artistkey assigned to the list as a DataValue. 
    You will need it to link the show to the artist.
    When the user select an artist the page should show all the shows and show details for that artist.
  -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
