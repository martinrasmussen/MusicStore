using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If user is logged in, show login and register 
//            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
//            {
//                // Hide the login and logout links.
//                myLogin.Visible = false;
//                myRegister.Visible = false;
//
//                // Create a label with the currently logged in username.
//                HtmlGenericControl span = new HtmlGenericControl("span");
//
//                span.InnerText = String.Format("Welcome, {0}", System.Web.HttpContext.Current.User.Identity.Name);
//
//                // Create a dynamic list item which will be added to the navigation.
//                HtmlGenericControl li = new HtmlGenericControl("li");
//                li.Controls.Add(span);
//
//                // Add the new controls to the navigation bar.
//                navBar.Controls.Add(li);
//            }
        }
    }
}