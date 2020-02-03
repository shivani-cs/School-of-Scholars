using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
public partial class register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
    string pfinalstring, pfinalstring1, ufinalstring, ufinalstring1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Button3.Visible = false;
        }
    }

    protected int SendEmail(string toAddress, string subject, string body)
    {
        int result = 1;
        string senderID = "akshaydeshpande005@gmail.com";// use sender’s email id here..
        const string senderPassword = "shriswam"; // sender password here…
        //System.Net.Mail.Attachment att;
        try
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com", // smtp server address here…
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                Timeout = 30000,
            };
            MailMessage message = new MailMessage(senderID, toAddress, subject, body);
            smtp.Send(message);
        }
        catch (Exception e)
        {
            result = 0;
        }
        return (result);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456790_@#";
        var password = new char[8];
        var password1 = new char[8];
        var user1 = new char[8];
        var user2 = new char[8];
        var b = TextBox1.Text + TextBox3.Text;
        var b1 = TextBox2.Text + TextBox3.Text;
        var random = new Random();
        for (int i = 0; i < password.Length; i++)
        {
            password[i] = a[random.Next(a.Length)];
            user1[i] = b[random.Next(b.Length)];
        }
        for (int i = 0; i < password1.Length; i++)
        {
            password1[i] = a[random.Next(a.Length)];
            user2[i] = b1[random.Next(b1.Length)];
        }

        pfinalstring = new String(password);
        pfinalstring1 = new String(password1);
        ufinalstring = new String(user1);
        ufinalstring1 = new String(user2);

        string name = TextBox1.Text;
        name += " ";
        name += TextBox2.Text;
        name += " ";
        name += TextBox3.Text;
        string mname = TextBox4.Text;
        string fname = TextBox5.Text;
        string gender;
        if (RadioButton1.Checked == true)
            gender = "Male";
        else
            gender = "Female";
        string bday = TextBox7.Text;
        string addr = TextBox8.Text;
        string email = TextBox10.Text;
        string contact = TextBox9.Text;
        int std = Convert.ToInt32(ListBox1.SelectedIndex);


        con.Open();
        string s = "insert into student1 values('" + ufinalstring + "','" + pfinalstring + "','" + name + "','" + addr + "','" + gender + "','" + bday + "','" + contact + "'," + std + " )";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();

        SqlCommand s1 = new SqlCommand("select *from student1", con);
        SqlDataReader rd1 = s1.ExecuteReader();
        int k = 0;
        while (rd1.Read())
        {
            k++;
        }
        rd1.Close();
        string p = "insert into parent1 values(" + k + ",'" + ufinalstring1 + "','" + pfinalstring1 + "','" + fname + "','" + mname + "','" + email + "' )";
        SqlCommand cmd1 = new SqlCommand(p, con);
        cmd1.ExecuteNonQuery();
        string sub = "Username and password of student.";
        string msg = "PARENT \nusername-" + ufinalstring1 + "  password-" + pfinalstring1 + "\nStudent \nusername" + ufinalstring + "  password" + pfinalstring + "\nYou can change your username and password after login.";
        int ret = SendEmail(email, sub, msg);
        if (ret == 1)
        {
            Label10.Text = "Email is sent successfully!!!";
            Button3.Visible = false;
        }
        else
        {
            Label10.Text = "Email is not sent.\nClick on retry...";
            Button3.Visible = true;
        }
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string email = TextBox10.Text;
        string sub = "Username and password of student.";
        string msg = "PARENT \nusername-" + ufinalstring1 + "  password-" + pfinalstring1 + "\nStudent \nusername" + ufinalstring + "  password" + pfinalstring + "\nYou can change your username and password after login.";
        int ret = SendEmail(email, sub, msg);
        if (ret == 1)
            Label10.Text = "Email is sent successfully!!!";
        else
            Label10.Text = "Email is not sent.\nClick on retry...";
    }
}