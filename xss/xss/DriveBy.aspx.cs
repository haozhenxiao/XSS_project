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
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment; filename=scripts.txt");
        Response.TransmitFile(Server.MapPath("~/images/scripts.txt"));
        Response.End();
    }
}