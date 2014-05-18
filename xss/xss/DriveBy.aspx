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

            var xmlHttp = new XMLHttpRequest;
            xmlHttp.onreadystatechange = function () {
                if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                    
                }


            }

            xmlHttp.open("GET", "~/images/SecurityPatch.exe.txt", true);
            xmlHttp.send();
        </script>
        
    
    </div>
    </form>
</body>
</html>
