using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Blog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void BlogSubmit_Click(object sender, EventArgs e)
    {
        string blogTitle = BlogTitle.Text;
        string blogContent = BlogContent.Text;
        //string blogContent = TextArea1.InnerText;
        //Request.Form("txtImagename1");
        //Request.
        //Request.Form
        //HtmlTextArea txt = (HtmlTextArea)(form1.FindControl("TextArea1"));
        //HtmlTextArea txt = (HtmlTextArea)Request.Form["txtImagename1"];
       // var txt = Request.Form["txtImagename1"];

       // string blogContent = Request.Form["txtImagename1"];
        //string blogContent = "<script>alert(\"hello\");</script>";
       // ShowBlog.Text = blogContent;
        
        if (blogTitle.Length > 0 && blogContent.Length > 0) {
            Insert_Blog(blogTitle,blogContent);
        
        }
    }


    protected void Insert_Blog(string title, string content) {

        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["DbConnection"].ToString());
        string sql = "INSERT INTO Blogs (Title,Content) VALUES (@title,@content)";

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@title", title);
            command.Parameters.Add("@content", content);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            TitleDropDown.Items.Add(title);
        }
        catch (SqlException ex)
        {
            //ShowBlog.Text = ex.ToString();

        }
        finally
        {
            connection.Close();
        }

    }


    protected void TitleDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedTitle = TitleDropDown.SelectedIndex+1;
        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["DbConnection"].ToString());
        string sql = "SELECT Content FROM Blogs WHERE Id=" + selectedTitle+";";
        try {

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) {

                if (reader.Read())
                {

                    string content = reader.GetString(0);
                    //ShowBlog.Text = content;
                   // show.InnerText = content;
                    //show.InnerHtml = "<div>"+content+"</div>";
                    HtmlTable table = (HtmlTable)(form1.FindControl("show"));
                    
                    //table.InnerHtml = "<tr><td></td></tr>";
                    HtmlTableRow row = table.Rows[0];
                    HtmlTableCell cell = row.Cells[0];
                    //cell.InnerHtml = "How are you";
                    cell.InnerHtml = content;
                }
            
            }
            
        
        }catch(SqlException ex){
            //ShowBlog.Text = ex.ToString();
        
        }finally{
            connection.Close();
        
        }
    }
}