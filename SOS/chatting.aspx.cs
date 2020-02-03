using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class chatting : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
    SqlConnection con1 = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
       TextBox4.Text = "";
        //if(!IsPostBack)
        {
           // Session["name"] = "shivani shivanand suryawanshi";
        }
      //  string msg = Application["msg"].ToString();
        con.Open();
        con1.Open();
        SqlCommand comm = new SqlCommand("select sendername from chat where receivername='"+Session["name"]+"'",con);
        SqlDataReader rd = comm.ExecuteReader();
     
        if (!IsPostBack)
        {
            while (rd.Read())
            {

                Class1.name[Class1.counter] = rd[0].ToString();

            }
           
            for (int i = 0; i < Class1.name.Length; i++)
            {
                string temp = Class1.name[i];
                for (int j = i + 1; j < Class1.name.Length; j++)
                {
                    string temp1 = Class1.name[j];
                    if (temp == temp1)
                    {
                        Class1.name[i] = Class1.name[j];
                        Class1.name[j] = "";

                    }

                }
            }
            for (int i = 0; i < Class1.name.Length; i++)
            {
                string temp = Class1.name[i];
                if (temp != "")
                    ListBox1.Items.Add(Class1.name[i]);
            }
        }
        rd.Close();
       
     //  TextBox5.Text = rd2[0].ToString();
        if (!IsPostBack)
        {
            
            // rd.Close();
            SqlCommand comm1 = new SqlCommand("select name from student1 where name!='" + Session["name"] + "'", con);
            SqlDataReader rd1 = comm1.ExecuteReader();
            
            while (rd1.Read())
            {
                ListBox2.Items.Add(rd1[0].ToString());
            }
            rd1.Close();
            SqlCommand comm2 = new SqlCommand("select name from teacher1 where name!='" + Session["name"] + "'", con);
            SqlDataReader rd2 = comm1.ExecuteReader();

            while (rd2.Read())
            {
                ListBox2.Items.Add(rd2[0].ToString());
            }

            for (int i = 0; i < Class1.name1.Length; i++)
            {
                string temp = Class1.name1[i];
                for (int j = i + 1; j < Class1.name1.Length; j++)
                {
                    string temp1 = Class1.name1[j];
                    if (temp == temp1)
                    {
                        Class1.name1[i] = Class1.name1[j];
                        Class1.name1[j] = "";

                    }

                }
            }



        }
        
       // ListBox1.Items.Add("");
        con.Close();
        con1.Close();
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
         
        string name = Session["name"].ToString();
        string message = TextBox3.Text;
        string my = name + "::" + message;
        my = my + "\n";
        if (ListBox1.SelectedIndex==-1)
        {
            SqlCommand comm = new SqlCommand("insert into chat values('" + name + "','" + ListBox2.Text + "','" + message + "')", con);
            comm.ExecuteNonQuery();
            string sl = ListBox2.Text;
            string s = "select *from chat where((sendername='" + sl + "'and receivername='" + Session["name"] + "') or (sendername='" + Session["name"] + "' and receivername='" + sl + "'))";
            SqlCommand comm2 = new SqlCommand(s, con);
            SqlDataReader rd = comm2.ExecuteReader();
            //SqlCommand comm2 = new SqlCommand("select *from chat where receivername='" + sl + "' and sendername='" + Session["name"] + "' ", con1);
            //SqlDataReader rd1 = comm2.ExecuteReader();
            while (rd.HasRows)
            {
                while (rd.Read())
                {


                    TextBox4.Text = TextBox4.Text + rd[0].ToString() + "\n";
                    TextBox4.Text = TextBox4.Text + rd[2].ToString() + "\n";

                }


                rd.NextResult();



            }
        }
        else
        {
            SqlCommand comm = new SqlCommand("insert into chat values('" + name + "','" + ListBox1.Text + "','" + message + "')", con);
           comm.ExecuteNonQuery();
           string sl = ListBox1.Text;
           string s = "select *from chat where((sendername='" + sl + "'and receivername='" + Session["name"] + "') or (sendername='" + Session["name"] + "' and receivername='" + sl + "'))";
           SqlCommand comm2 = new SqlCommand(s, con);
           SqlDataReader rd = comm2.ExecuteReader();
           //SqlCommand comm2 = new SqlCommand("select *from chat where receivername='" + sl + "' and sendername='" + Session["name"] + "' ", con1);
           //SqlDataReader rd1 = comm2.ExecuteReader();
           while (rd.HasRows)
           {
               while (rd.Read())
               {


                   TextBox4.Text = TextBox4.Text + rd[0].ToString() + "\n";
                   TextBox4.Text = TextBox4.Text + rd[2].ToString() + "\n";

               }


               rd.NextResult();



           }
        }
        
        con.Close();
        

        

        Application["msg"] = Application["msg"] + my + Environment.NewLine;

     //   Label1.Text = Application["msg"].ToString();

        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       // Session["name"] = TextBox4.Text;
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
        string s1 = "select status from lastseen where username='" + ListBox1.Text + "'";
        SqlCommand comm3 = new SqlCommand(s1, con);
        SqlDataReader rd3 = comm3.ExecuteReader();
        while (rd3.Read())
        {
            Label5.Text = rd3[0].ToString();
        }
        con.Close();
        con.Open();
        int i = 0;
        con1.Open();
        string sl = ListBox1.Text;
        string s = "select *from chat where((sendername='" + sl + "'and receivername='" + Session["name"] + "') or (sendername='" + Session["name"] + "' and receivername='" + sl + "'))";
        SqlCommand comm = new SqlCommand(s,con);
        SqlDataReader rd = comm.ExecuteReader();
        //SqlCommand comm2 = new SqlCommand("select *from chat where receivername='" + sl + "' and sendername='" + Session["name"] + "' ", con1);
        //SqlDataReader rd1 = comm2.ExecuteReader();
        while (rd.HasRows)
        {
            while (rd.Read())
            {

              
                    TextBox4.Text = TextBox4.Text + rd[0].ToString() + "\n";
                    TextBox4.Text = TextBox4.Text + rd[2].ToString() + "\n";
                
            }
          
           
                rd.NextResult();
            
           
            
        }
        rd.Close();
        //SqlCommand comm1 = new SqlCommand("update chat set seen=" + 1 + "", con);
        //comm1.ExecuteNonQuery();

        con.Close();
        TextBox3.Text = "";
    }

    protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //TextBox4.Text = "";
        con.Open();
        string s="select status from lastseen where username='"+ListBox2.Text+"'";
        SqlCommand comm = new SqlCommand(s, con);
        SqlDataReader rd = comm.ExecuteReader();
        while(rd.Read())
        {
            Label5.Text = rd[0].ToString();
        }
        con.Close();

    }
    protected void Button2_Click1(object sender, EventArgs e)
    {

    }
    protected void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
     //   int i = 0;
     //   con1.Open();
        string sl = ListBox1.Text;
        string s = "select *from chat where((sendername='" + sl + "'and receivername='" + Session["name"] + "') or (sendername='" + Session["name"] + "' and receivername='" + sl + "')) and seen=1";
        SqlCommand comm = new SqlCommand(s, con);
        SqlDataReader rd = comm.ExecuteReader();
        //SqlCommand comm2 = new SqlCommand("select *from chat where receivername='" + sl + "' and sendername='" + Session["name"] + "' ", con1);
        //SqlDataReader rd1 = comm2.ExecuteReader();
        while (rd.HasRows)
        {
            while (rd.Read())
            {


                TextBox4.Text = TextBox4.Text + rd[0].ToString() + "\n";
                TextBox4.Text = TextBox4.Text + rd[2].ToString() + "\n";

            }


            rd.NextResult();



        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        string s1 = DateTime.Now.ToShortDateString() +"  "+ DateTime.Now.ToShortTimeString();
        string s = "update lastseen set status='" + s1 + "'where username='" + Session["name"] + "'";
        SqlCommand comm = new SqlCommand(s, con);
        comm.ExecuteNonQuery();
        con.Close();
        //Session.Clear();
        //Session.Abandon();
      //  con.Open();
        
        Response.Redirect("chat.aspx");
    }
    protected void ListBox3_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {

    }
}