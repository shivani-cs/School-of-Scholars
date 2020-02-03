using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;


public partial class sprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder htmltable = new StringBuilder();

        SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
        con.Open();
        int i;
        i = Convert.ToInt32(Session["id"]);

        SqlCommand comm = new SqlCommand("select *from student1 where roll_no=" + i, con);
        SqlDataReader rd = comm.ExecuteReader();

        int tid=0,std=0;
        string user="", pswd="", name="", addr="", gender="",bd="",contact="";
        

        if (rd.HasRows)
        {

            while (rd.Read())
            {
                tid = Convert.ToInt32(rd[0].ToString());
                user = rd[1].ToString();
                pswd = rd[2].ToString();
                name = rd[3].ToString();
                addr = rd[4].ToString();
                gender = rd[5].ToString();
                bd = rd[6].ToString();
                contact = rd[7].ToString();
                std = Convert.ToInt32(rd[8].ToString());

            }
        }

        htmltable.Append("<table border=0 cellpadding=5 style=width:98%>");
        
        htmltable.Append("<tr>");
        htmltable.Append("<td>Roll Number</td>");
        htmltable.Append("<td>" + tid + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Username</td>");
        htmltable.Append("<td>" + user + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Password</td>");
        htmltable.Append("<td>" + pswd + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Name</td>");
        htmltable.Append("<td>" + name + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Address</td>");
        htmltable.Append("<td>" + addr + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Gender</td>");
        htmltable.Append("<td>" + gender + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Birt Date</td>");
        htmltable.Append("<td>" + bd + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Parent Contact Number</td>");
        htmltable.Append("<td>" + contact + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Standard</td>");
        htmltable.Append("<td>" + std + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("</table>");
        PlaceHolder1.Controls.Add(new Literal { Text = htmltable.ToString() });
    }
}