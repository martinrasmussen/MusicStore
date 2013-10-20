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
        /// <summary>
        /// The persistent cookie
        /// </summary>
        bool persistentCookie = false;

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (chkKeepMeLoggedIn.Checked)
                persistentCookie = true;
        }

        /// <summary>
        /// Handles the Click event of the cmdLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(txtUser.Text, txtPassword.Text))
                FormsAuthentication.RedirectFromLoginPage(txtUser.Text, persistentCookie);
            else
                lblStatus.Text = "Authentication failed";
        }
    }
}