﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WSF_Labb2WebClientDay
{
    public partial class Days : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DaysClient host = new DaysClient();
            Label1.Text =
                host.Day(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text)).ToString();
        }
    }
}