using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class broad : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox4.Text = "";
        if(!IsPostBack)
        {
            //Session["name"] = "vibhesh shivanand suryawanshi";
        con.Open();
        SqlCommand com1 = new SqlCommand("select * from bchat", con);
        SqlDataReader rd = com1.ExecuteReader();
        while (rd.Read())
        {
            TextBox4.Text = TextBox4.Text +"\n"+ rd[0].ToString();
            TextBox4.Text = TextBox4.Text + "\n" + rd[1].ToString();

            
            
        }
        con.Close();
    }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("insert into bchat values('"+Session["name"]+"','"+TextBox3.Text+"')",con);
        comm.ExecuteNonQuery();
        SqlCommand com1 = new SqlCommand("select * from bchat",con);
        SqlDataReader rd=com1.ExecuteReader();
        while (rd.Read())
        {
            TextBox4.Text = TextBox4.Text + "\n" + rd[0].ToString();
            TextBox4.Text = TextBox4.Text + "\n" + rd[1].ToString();

        }

    }
    protected void listboxC_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        string s1 = DateTime.Now.ToShortDateString() +"  "+ DateTime.Now.ToShortTimeString();
        string s = "update lastseen set status='" + s1 + "'where username='" + Session["name"] + "'";
        SqlCommand comm = new SqlCommand(s, con);
        comm.ExecuteNonQuery();
        con.Close();
       // Session.Clear();
        //Session.Abandon();
        //  con.Open();

        Response.Redirect("chat.aspx");
    }
}