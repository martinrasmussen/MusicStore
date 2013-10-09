using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Login : System.Web.UI.Page
    {
        bool persistentCookie = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (chkKeepMeLoggedIn.Checked == true)
                persistentCookie = true;
        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(txtUser.Text, txtPassword.Text))
                FormsAuthentication.RedirectFromLoginPage(txtUser.Text, persistentCookie);
            else
                lblStatus.Text = "Authentication failed";
        }
    }
}