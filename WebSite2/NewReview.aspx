<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewReview.aspx.cs" Inherits="NewReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Review</title>
    <link href="BookReviewAtLargeStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Book Reviews At Large</h1>
        <hr />
        <p>Add Your review</p>
    <table>
        <tr>
            <td>Choose an existing title or enter your own</td>
            <td>
                <asp:DropDownList ID="ddlTitles" runat="server"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
            <td>Choose an existing Author or enter your own</td>
            <td>
                <asp:DropDownList ID="ddlAuthor" runat="server"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
            <td>Choose a category</td>
            <td>
                <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList></td>
            <td>
                 </td>
        </tr>
          <tr>
            <td>Enter a title for your review</td>
            <td>
                <asp:TextBox ID="txtReviewTitle" runat="server"></asp:TextBox>  </td>
            <td>
                </td>
        </tr>
          <tr>
            <td>Rate the book 1 to 5</td>
            <td>
                <asp:DropDownList ID="ddlRating" runat="server">
                   
                </asp:DropDownList></td>
            <td>
                </td>

        </tr>
        
          <tr>
            <td>Enter your review</td>
            <td colspan="2">
                <asp:TextBox ID="txtReview" runat="server" 
                    TextMode="MultiLine" width="100%" Height="300"></asp:TextBox>  

            </td>
     
        </tr>
        
          <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
            <td>
                <asp:Label ID="lbResult" runat="server" Text=""></asp:Label> </td>
            <td>
                </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>