using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class chat : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        con.Open();
        string s1 = "Online";
        string s = "update lastseen set status='" + s1 + "'where username='" + Session["name"] + "'";
        SqlCommand comm = new SqlCommand(s, con);
        comm.ExecuteNonQuery();
        con.Close();
        Response.Redirect("broad.aspx");
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        con.Open();
        string s1="Online";
        string s = "update lastseen set status='" + s1 + "'where username='" + Session["name"] + "'";
        SqlCommand comm = new SqlCommand(s, con);
        comm.ExecuteNonQuery();
        con.Close();
        Response.Redirect("chatting.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
     
    }
}