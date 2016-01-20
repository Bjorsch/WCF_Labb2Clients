using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCL_Labb2WebClient1000
{
    public partial class Birthday1000 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BirthdayClient host = new BirthdayClient();
            Label1.Text = "Nästa gång du fyller jämt 1000 dagar är om "  + host.To1000(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text)).ToString() + " dagar";
        }
    }
}