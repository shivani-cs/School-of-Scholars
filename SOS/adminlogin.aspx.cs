using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (text.Text.Equals("admin") && password.Text.Equals("admin"))
        {
            Session["name"] = "admin";
            Response.Redirect("a_default.aspx");
         }
        else
        {
            Label1.Text = "Login failed.";
            password.Text = "";
        }
    }
}