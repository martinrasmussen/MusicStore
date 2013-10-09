using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CreateUserWizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Label lbl = (Label)CreateUserWizard1.CompleteStep.Controls[0].FindControl("lblSubscriptionList");
            CheckBoxList chk = (CheckBoxList)CreateUserWizard1.FindControl("chkSubscription");

            string selection = "";
            foreach (ListItem item in chk.Items)
            {
                if (item.Selected) selection += "<br />&nbsp;&nbsp;" + item.Text;
            }
            lbl.Text = selection;
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            Roles.AddUserToRole(CreateUserWizard1.UserName, "User");
        }
    }
}