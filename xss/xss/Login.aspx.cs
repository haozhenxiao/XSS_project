using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click += new EventHandler(this.Login_Click);
    }

    void Login_Click(Object sender,
                           EventArgs e) {
        Response.Redirect("Welcome.aspx");
    }
}