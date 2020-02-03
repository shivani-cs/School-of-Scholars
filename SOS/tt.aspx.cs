using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
public partial class tt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder htmltable = new StringBuilder();

        SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
        con.Open();

        SqlCommand comm = new SqlCommand("select *from timetable1", con);
        SqlDataReader rd = comm.ExecuteReader();

        htmltable.Append("<table border=1>");
        htmltable.Append("<tr>");
        htmltable.Append("<th>Days</th>");
        htmltable.Append("<th>Period1</th>");
        htmltable.Append("<th>Period2</th>");
        htmltable.Append("<th>Period3</th>");
        htmltable.Append("<th>Period4</th>");
        htmltable.Append("<th>Period5</th>");
        htmltable.Append("</tr>");

        if (rd.HasRows)
        {
            while (rd.Read())
            {
                int i;
                htmltable.Append("<tr>");
                for (i = 0; i < 6; i++)
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