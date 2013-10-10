using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs e)
        {
            btnRegister.Click += cmdRegisterClick;
        }

        protected void cmdRegisterClick(Object sender, EventArgs e)
        {
            string username = UserName.Value;
            string password = pw.Value;
            string myEmail = email.Value;

            Membership.CreateUser(username, password, myEmail);

            Server.Transfer("Login.aspx");


        }
    }
}