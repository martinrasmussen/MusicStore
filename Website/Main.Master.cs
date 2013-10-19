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

        // Takes care of the rendering of the shopping cart
        protected void Page_PreRender(object sender, EventArgs e)
        {
            // Get shopping cart from Session state.
            Dictionary<Album, int> cart = (Dictionary<Album, int>)Session["cart"];
            
            // Var to hold the total price.
            decimal price = 0;

            // Stores the count of the cart.
            int cartCount = 0;

            // If cart is not empty
            if (cart != null)
            {
                // Loop through each of it's element
                foreach (var album in cart)
                {
                    // Add the albums underneath each onto a list
                    HtmlGenericControl li = new HtmlGenericControl("li");

                    // The album name + the quantity
                    Label albumName = new Label {Text = string.Format("{0} ({1})", album.Key.AlbumName, album.Value)};

                    // The individual price of the albums
                    Label albumPrice = new Label {Text = string.Format("{0} DKK", album.Key.Price)};
                    albumPrice.Attributes["class"] = "pull-right"; // Pulls it to the right

                    // Add the controls into the li tag
                    li.Controls.Add(albumName);
                    li.Controls.Add(albumPrice);

                    // Add the li tag onto the ul list tag
                    ulCart.Controls.Add(li);

                    // Calculate the total price
                    price += album.Key.Price*album.Value;
                    
                    // Increment the counter
                    cartCount += album.Value;
                }
                // Show the total price.
                lblCartPrice.Text = "   " + price.ToString() + " DKK";
            }
            // Update the cart counter.
            lblCartCount.Text = cartCount.ToString();
        }
    }
}