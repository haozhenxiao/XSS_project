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

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "DbConnection";
        builder.InitialCatalog = "LocalDB";
        builder.InitialCatalog = "DbConnection";
        builder.UserID = "";
        builder.Password = "";
        builder.ConnectTimeout = 0;
        builder.IntegratedSecurity = false;
        
        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["DbConnection"].ToString()); 
        //SqlConnection connection = new SqlConnection(builder.ConnectionString);

        string username = TextBox1.Text;
        string password = TextBox2.Text;
        string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "';";
        SqlCommand command = new SqlCommand();
        command.CommandText = sql;
        command.CommandType = CommandType.Text;
        command.Connection = connection;
        
        SqlDataReader reader = null;
        try {
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                HttpCookie cookie = new HttpCookie(username,password);
                Response.Cookies.Add(cookie);
                Response.Redirect("Welcome.aspx");
            }

        }
        catch (SqlException ex) {
            TextBox1.Text = "NOT OK";
        }
        
        connection.Close();
        
    }

}