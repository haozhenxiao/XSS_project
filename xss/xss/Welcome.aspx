<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

     <asp:Panel ID="Panel2" runat="server" Style="border:groove;background-color:azure;text-align:center;margin-top:50px;">
        <asp:Label ID="Label3" runat="server" Text="Welcom to the XSS vulnerable blog" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        </asp:Panel>

    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Width="300px" Height="200px"  Style="margin-top:10%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-150px">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Bold="true">
            <asp:ListItem Selected="True">Vulnerable blog</asp:ListItem>
            <asp:ListItem>Safe blog</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="GO" />
        
        &nbsp;
        
    </asp:Panel>
    </form>
</body>
</html>
