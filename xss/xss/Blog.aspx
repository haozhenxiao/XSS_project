<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Blog.aspx.cs" Inherits="Blog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 294px;
        }
        #txtImagename1 {
            width: 413px;
        }
    </style>
</head>
<body>

    <asp:Panel ID="Panel2" runat="server" Style="border:groove;background-color:azure;text-align:center;margin-top:50px;">
        <asp:Label ID="Label3" runat="server" Text="You can write your blog here" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        </asp:Panel>

    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Width="500px" Height="600px"  Style="margin-top:2%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-550px">
            <asp:Label ID="Label1" runat="server" Text="Title : "></asp:Label>
            <asp:TextBox ID="BlogTitle" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:TextBox ID="BlogContent" runat="server" Height="401px" Width="401px" TextMode="multiline" ValidateRequestMode="Disabled"></asp:TextBox>
            <br/>
            <asp:Button ID="BlogSubmit" runat="server" Text="Submit" OnClick="BlogSubmit_Click"/>
            <br />
            <br /></asp:Panel>

    <asp:Panel ID="Panel3" runat="server" Width="500px" Height="600px"  Style="margin-top:2%;border:groove;background-color:azure;left:50%;position:absolute;margin-left:-0px">
        <asp:Label ID="Label2" runat="server" Text="Select blog : "></asp:Label>
        <asp:DropDownList ID="TitleDropDown" runat="server" DataSourceID="SqlDataSource1" DataTextField="Title" DataValueField="Title" OnSelectedIndexChanged="TitleDropDown_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DbConnection %>" SelectCommand="SELECT [Title] FROM [Blogs]"></asp:SqlDataSource>
        <br />
        <br />
        <!--<asp:TextBox ID="ShowBlog" runat="server" Height="401px" Width="401px" TextMode="multiline" ReadOnly="true" ValidateRequestMode="Disabled"></asp:TextBox>-->
        <table id="show" style="width: 100%;" runat="server">
            <tr>
                <td>

                </td>

            </tr>
        </table>
            
        <br />
        <br />
            
    </asp:Panel>

    </form>
</body>
</html>
