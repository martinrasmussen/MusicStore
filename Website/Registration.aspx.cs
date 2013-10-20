using System;
using System.Drawing;
using System.Web.Security;

namespace Website
{
    public partial class Registration : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(Object sender, EventArgs e)
        {
            // Assign the click function to the Register button.
            btnSubmit.Click += CmdSubmit_Click;
        }

        /// <summary>
        /// Handles the Click event of the CmdSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void CmdSubmit_Click(Object sender, EventArgs e)
        {
            // Create variable to hold creation status.
            MembershipCreateStatus createStatus;
            
            // Create user and get createstatus back.
            MembershipUser user = Membership.CreateUser(txtUserName.Text, txtPwd.Text, txtEmail.Text, txtQuestion.Text, txtAnswer.Text, true, out createStatus);
            
            // What createStatus did we got back?!
            switch (createStatus)
            {
                //This Case Occured whenver User Created Successfully in database
                case MembershipCreateStatus.Success:
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "The user account was successfully created";
                    txtUserName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtQuestion.Text = string.Empty;
                    txtAnswer.Text = string.Empty;
                    break;
                // This Case Occured whenver we send duplicate UserName
                case MembershipCreateStatus.DuplicateUserName:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "The user with the same UserName already exists!";
                    break;
                //This Case Occured whenver we give duplicate mail id
                case MembershipCreateStatus.DuplicateEmail:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "The user with the same email address already exists!";
                    break;
                //This Case Occured whenver we send invalid mail format
                case MembershipCreateStatus.InvalidEmail:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "The email address you provided is invalid.";
                    break;
                //This Case Occured whenver we send empty data or Invalid Data
                case MembershipCreateStatus.InvalidAnswer:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "The security answer was invalid.";
                    break;
                // This Case Occured whenver we supplied weak password
                case MembershipCreateStatus.InvalidPassword:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text =
                        "The password you provided is invalid. It must be 7 characters long and have at least 1 special character.";
                    break;
            }
        }
    }
}