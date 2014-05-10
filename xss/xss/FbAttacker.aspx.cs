using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FbAttacker : System.Web.UI.Page

{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TheLogin_Click(object sender, EventArgs e)
    {

        

        Control email = this.Controls.Find("MyEmail", true);

        System.Diagnostics.Debug.Write("+++++++++++++++++++++++++++++++++++++ "+email.Text);


    }
}