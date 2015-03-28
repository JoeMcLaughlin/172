<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1> Hello World!</h1>
        <img src="http://www.highwayrobbery.net/TrcImgsCartoonStandOnOneLeg.gif" />
        </div>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer2" runat="server" Interval="10000" OnTick="Timer2_Tick">
                    </asp:Timer>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
