using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;

public partial class register2 : System.Web.UI.Page
{
    string ufinalstring, pfinalstring;
    SqlConnection con = new SqlConnection("server=SHIVANI;initial catalog=bishop_school1;integrated security=true");
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
        TextBox6.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456790_@#";
        var password = new char[8];
        var user1 = new char[8];
        var b = TextBox1.Text + TextBox3.Text;
        var b1 = TextBox2.Text + TextBox3.Text;
        var random = new Random();
        for (int i = 0; i < password.Length; i++)
        {
            password[i] = a[random.Next(a.Length)];
            user1[i] = b[random.Next(b.Length)];
        }
        pfinalstring = new String(password);
        ufinalstring = new String(user1);

        int sal = Convert.ToInt32(TextBox6.Text);
        string sub = ListBox1.SelectedValue.ToString();
        int std = ListBox2.SelectedIndex;
        string email = TextBox3.Text;

        con.Open();
        string s = "insert into teacher1 values('" + ufinalstring + "','" + pfinalstring + "','" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + sal + ",'" + sub + "'," + std + ",'" + TextBox2.Text + "' )";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        con.Close();

        string subm = "Username and password.";
        string msg = "Your username & password is \nusername-" + ufinalstring + "  password-" + pfinalstring + "\nYou can change your username and password after login.";
        int ret = SendEmail(email, subm, msg);
        if (ret == 1)
            Label10.Text = "Email is sent successfully!!!";
        else
        {
            Label10.Text = "Email is not sent.\nClick on retry...";
            Button3.Visible = true;
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string email = TextBox3.Text;
        string subm = "Username and password.";
        string msg = "Your username & password is \nusername-" + ufinalstring + "  password-" + pfinalstring + "\nYou can change your username and password after login.";
        int ret = SendEmail(email, subm, msg);
        if (ret == 1)
            Label10.Text = "Email is sent successfully!!!";
        else
        {
            Label10.Text = "Email is not sent.\nClick on retry...";
            Button3.Visible = true;
        }
    }
}