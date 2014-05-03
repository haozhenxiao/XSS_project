using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click += new EventHandler(this.Go_Click);
    }

    void Go_Click(Object sender,
                           EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            Response.Redirect("Choices.aspx");
        }
        else { 
        
        }
    }
}