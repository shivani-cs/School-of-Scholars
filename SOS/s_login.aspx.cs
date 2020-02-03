using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class s_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from student1", con);
        SqlDataReader rd = cmd.ExecuteReader();
        int flag = 0;
        while (rd.Read())
        {
            if (rd[1].ToString().Equals(text.Text) && rd[2].ToString().Equals(password.Text))
            {
                Session["id"] = rd[0].ToString();
                Session["name"] = rd[3].ToString();
                Response.Redirect("s_default.aspx");
                //Label1.Text = "Successful" + Session["rollno"].ToString();
                flag = 1;
                break;
            }
        }
        if (flag == 0)
        {
            text.Text = "";
            password.Text = "";
            Label1.Text = "Login Failed";
        }
    }
}