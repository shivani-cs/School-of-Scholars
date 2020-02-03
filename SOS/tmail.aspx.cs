using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;

public partial class tmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
    protected void Button1_Click(object sender, EventArgs e)
    {
        int ret = SendEmail(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        if (ret == 1)
            Label4.Text = "Email is sent successfully!!!";
        else
            Label4.Text = "Email is not sent.\nClick on send again.";
    }
}