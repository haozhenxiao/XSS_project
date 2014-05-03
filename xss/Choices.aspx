<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Choices.aspx.cs" Inherits="Choices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Panel ID="Panel2" runat="server" Style="border:groove;background-color:azure;text-align:center;margin-top:50px;">
        <asp:Label ID="Label3" runat="server" Text="Choose what you want to do" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        </asp:Panel>
    <form id="form1" runat="server">

    <asp:Panel ID="Panel1" runat="server" Width="300px" Height="200px"  Style="margin-top:10%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-150px">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Selected="True">Add to your blog</asp:ListItem>
            <asp:ListItem>View others blogs</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="GO" />
    </asp:Panel>
    </form>
</body>
</html>
