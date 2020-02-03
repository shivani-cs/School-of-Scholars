using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;

public partial class std_info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder htmltable = new StringBuilder();

        SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
        con.Open();

        SqlCommand comm = new SqlCommand("select *from student1", con);
        SqlDataReader rd = comm.ExecuteReader();

        htmltable.Append("<table border=1 cellpadding=5 style=width:98%>");
        htmltable.Append("<tr>");
        htmltable.Append("<th>Id</th>");
        htmltable.Append("<th>Username</th>");
        htmltable.Append("<th>Password</th>");
        htmltable.Append("<th>Name</th>");
        htmltable.Append("<th>Address</th>");
        htmltable.Append("<th>Gender</th>");
        htmltable.Append("<th>Birth Date</th>");
        htmltable.Append("<th>Parent Contact Number</th>");
         htmltable.Append("<th>Standard</th>");
        htmltable.Append("</tr>");

        if (rd.HasRows)
        {
            while (rd.Read())
            {
                int i;
                htmltable.Append("<tr>");
                for (i = 0; i < 9; i++)
                {

                    htmltable.Append("<td>" + rd[i] + "</td>");

                }
                htmltable.Append("</tr>");

            }
        }
        htmltable.Append("</table>");
        PlaceHolder1.Controls.Add(new Literal { Text = htmltable.ToString() });
    }
}