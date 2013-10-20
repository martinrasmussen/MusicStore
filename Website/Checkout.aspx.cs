using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;

namespace Website
{
    public partial class Checkout : System.Web.UI.Page
    {

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
           btnSubmit.Click += btnSubmit_OnClickSubmit_Click;

        }
        
        /// <summary>
        /// Gets the order information.
        /// </summary>
        /// <value>
        /// The order information.
        /// </value>
        public string orderInfo
        {
            get
            {
                // Get personal info from customer
                StringBuilder sb = new StringBuilder();
                sb.Append("<br>Order information for ");
                sb.Append(txtFirstName.Text + " " + txtLastName.Text + ":<br/><br/>");
                sb.Append(txtStreet.Text + "<br/>");
                sb.Append(txtCity.Text + "<br/>");
                sb.Append(txtCountry.Text + "<br/>");
                sb.Append(txtEmail.Text + "<br/><br/>");

                Dictionary<Album, int> cart = (Dictionary<Album, int>)Session["cart"]; // Get cart info

                // Print out orders
                foreach (var i in cart)
                {
                    sb.Append(String.Format("{0} ({1}) - {2} DKK <br/>", i.Key.AlbumName, i.Value, i.Key.Price));
                }
                return sb.ToString();
            }
        }


        /// <summary>
        /// Handles the Click event of the btnSubmit_OnClickSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSubmit_OnClickSubmit_Click(object sender, EventArgs e)
        {
            Server.Transfer("Confirmation.aspx");
        }

       
    }
}