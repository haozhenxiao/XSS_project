using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click += new EventHandler(this.Login_Click);
    }

    void Login_Click(Object sender,
                           EventArgs e) {
        
        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["DbConnection"].ToString());       

        string username = TextBox1.Text;
        string password = TextBox2.Text;
        string sql = ("SELECT * FROM User WHERE name='" + username + "' AND password='" + password + "';");
        SqlCommand command = new SqlCommand();
        command.CommandText = "SELECT * FROM User;";
        command.CommandType = CommandType.Text;
        command.Connection = connection;
        
        SqlDataReader reader = null;
        try {
            connection.Open();
           // reader = command.ExecuteReader();
            //if (!reader.Equals(null))
            //{
            //    Response.Redirect("Welcome.aspx");
            //}
            TextBox1.Text = "OK";
        }
        catch (SqlException ex) {
            TextBox1.Text = "NOT OK";
            Console.WriteLine("00000000000 "+ex.Message);
        }
        
        connection.Close();
        
    }
}