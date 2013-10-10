using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DataAccessLayer;

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
        // Takes care of [what?]
        protected void Page_PreRender(object sender, EventArgs e)
        {
            
            // Copy shopping cart to view state
            //Session["cart"] = cart;
            Dictionary<Album, int> cart = (Dictionary<Album, int>)Session["cart"];
            decimal price = 0;
            foreach (var album in cart)
            {
                //Label lblCart = Master.FindControl("lblCart") as Label;
                lblCart.Text += string.Format("{0} ({1}) , {2} DKK <br/>", album.Key.AlbumName, album.Value, album.Key.Price);

                //The total price of the shopping cart @TODO
                //Label lblCartPrice = Master.FindControl("lblCartPrice") as Label;
                lblCartPrice.Text = Convert.ToString(price += album.Key.Price) + " DKK";
            }

        }
    }
}