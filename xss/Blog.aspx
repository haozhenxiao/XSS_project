<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Blog.aspx.cs" Inherits="Blog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <asp:Panel ID="Panel2" runat="server" Style="border:groove;background-color:azure;text-align:center;margin-top:50px;">
        <asp:Label ID="Label3" runat="server" Text="You can write your blog here" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        </asp:Panel>

    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Width="500px" Height="600px"  Style="margin-top:2%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-550px">
            <asp:Label ID="Label1" runat="server" Text="Title : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" Height="401px" Width="401px" TextMode="multiline"></asp:TextBox>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Submit" />
    </asp:Panel>

         <asp:Panel ID="Panel3" runat="server" Width="500px" Height="600px"  Style="margin-top:2%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-0px">
            <asp:Label ID="Label2" runat="server" Text="You don't have any blogs"></asp:Label>
    </asp:Panel>

    </form>
</body>
</html>
