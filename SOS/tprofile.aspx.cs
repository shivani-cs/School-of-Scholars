using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

public partial class tprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder htmltable = new StringBuilder();

        SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
        con.Open();
        int i;
        i = Convert.ToInt32(Session["id"]);

        SqlCommand comm = new SqlCommand("select *from teacher1 where id=" + i, con);
        SqlDataReader rd = comm.ExecuteReader();

        int tid,ct=0;
        string us="", pswd="", name="", qual="", sal="", email="", contact="",sub="",bd="";

        if (rd.HasRows)
        {

            while (rd.Read())
            {
                tid = Convert.ToInt32(rd[0].ToString());
                us = rd[1].ToString();
                pswd = rd[2].ToString();
                name = rd[3].ToString();
                email = rd[4].ToString();
                contact = rd[5].ToString();
                qual = rd[6].ToString();
                sal = rd[7].ToString();
                sub = rd[8].ToString();
                ct = Convert.ToInt32(rd[9].ToString());
                bd = rd[10].ToString();

            }
        }

        htmltable.Append("<table border=0 cellpadding=5 style=width:98%>");
       
        //htmltable.Append("<tr>");
        //htmltable.Append("<td>Roll Number</td>");
        //htmltable.Append("<td>" + tid + "</td>");
        //htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Username</td>");
        htmltable.Append("<td>" + us + "</td>");
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
        htmltable.Append("<td>Email</td>");
        htmltable.Append("<td>" + email + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Monile Number</td>");
        htmltable.Append("<td>" + contact + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Qualification</td>");
        htmltable.Append("<td>" + qual + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Salary</td>");
        htmltable.Append("<td>" + sal + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Subject</td>");
        htmltable.Append("<td>" + sub + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Classteacher</td>");
        htmltable.Append("<td>" + ct + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("<tr>");
        htmltable.Append("<td>Birth Date</td>");
        htmltable.Append("<td>" + bd + "</td>");
        htmltable.Append("</tr>");

        htmltable.Append("</table>");
        PlaceHolder1.Controls.Add(new Literal { Text = htmltable.ToString() });
    }
}