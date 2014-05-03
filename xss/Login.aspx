<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <asp:Panel ID="Panel2" runat="server" Style="border:groove;background-color:azure;text-align:center;margin-top:50px;">
        <asp:Label ID="Label3" runat="server" Text="XSS vulnerable blog" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        </asp:Panel>
    
    <form id="form1" runat="server" vertical-align="middle">
        <asp:Panel ID="Panel1" runat="server" Width="300px" Height="200px"  Style="margin-top:10%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-150px">
            <asp:Label ID="Label1" runat="server" Text="Username: " Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password:  " Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" />
        </asp:Panel>
        
    </form>
</body>
</html>
