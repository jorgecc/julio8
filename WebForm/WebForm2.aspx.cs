﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ses = (string)Session["llave"];
            Label1.Text=ses;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["llave"]=TextBox1.Text;
        }
    }
}