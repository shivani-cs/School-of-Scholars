﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class a_logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Homepage.html",true);
        //Response.Write(Session["name"].ToString());
    }
}