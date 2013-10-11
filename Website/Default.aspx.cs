using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DataAccessLayer;


namespace Website
{
    public partial class Default : System.Web.UI.Page
    {
        private List<Album> albumsList;
        public Dictionary<Album, int> cart;
        private DataAccessLayer.AlbumRepository repo = new AlbumRepository();

        // Constant variables for the cover photo size
        const int COVER_WIDTH = 175;
        const int COVER_HEIGHT = 175;

        // Takes care [of what]?
        protected void Page_Init(object sender, EventArgs e)
        {
            // Query the database for 
            if (!IsPostBack)
            {
                albumsList = repo.GetAll(); // Get all albums from the DB // But it shouldn't do that every time.
            }
        }

        // Takes care of [what?]
        protected void Page_Load(object sender, EventArgs e)
        {
            
                // Create view state item for the shopping cart if it's empty
                if (Session["cart"] == null)
                {
                    Session["cart"] = new Dictionary<Album, int>();
                }

                if (Session["albums"] == null)
                {
                    Session["albums"] = new List<Album>();
                }
                
                cart = (Dictionary<Album, int>)Session["cart"]; ; // Create an empty cart.

                if(IsPostBack)
                    albumsList = (List<Album>) Session["albums"];

            

            // Populate the page with a table full of albums
            foreach (Album album in albumsList)
            {

                // Create cover photo
                ImageButton cover = new ImageButton();
                cover.ImageUrl = string.Format(@"~\Images\{0}", album.AlbumArtwork);
                cover.Width = COVER_WIDTH;
                cover.Height = COVER_HEIGHT;

                // Add listener to image cell
                cover.Command += cmdAdd_Click;
                cover.CommandName = "Add";
                cover.CommandArgument = albumsList.IndexOf(album).ToString();

                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Attributes["class"] = "cover-art";
                div.Controls.Add(cover);
                pnlContent.Controls.Add(div);
                
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {

            // Copy shopping cart to view state
            Session["cart"] = cart;
            Session["albums"] = albumsList;

        }

        // Click listener for the Add function.
        private void cmdAdd_Click(object sender, CommandEventArgs e)
        {
            // Save the album which we clicked on into a local variable.
            var album = albumsList[Convert.ToInt32(e.CommandArgument)];
            
            // Declare a bool to check if we already have the item in the cart. False by default.
            bool hasFound = false;
            
            
            // Loop throught the cart and check if the album which we want to add is already there or not.
            foreach (var cartAlbum in cart.Keys)
            {
                // If it is, set the hasFound to true and override the album var with the one already in the cart.
                if (cartAlbum.ID.Equals(album.ID))
                {
                    hasFound = true; // We found it!
                    album = cartAlbum; // We save it!
                }
            }

            // If we found it in the cart, we increase the quantity, which is the key in the cart dictionary
            if (hasFound)
            {
                cart[album]++;
            }
            // Else we just add it with a quantity of 1.
            else
            {
                cart.Add(album, 1);
            }
        }
    }
}