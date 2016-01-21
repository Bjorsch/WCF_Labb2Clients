using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF_Labb2WebClientHobby
{
    public partial class AllMovieYear : System.Web.UI.Page
    {
        private HobbyClient host;
        public AllMovieYear()
        {
            host = new HobbyClient();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            TextBox1.Text = host.ButtonFromYear("2012");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {           
            TextBox1.Text = host.ButtonFromYear("2013");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {           
            TextBox1.Text = host.ButtonFromYear("2014");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {          
            TextBox1.Text = host.ButtonFromYear("2015");
        }
    }
}