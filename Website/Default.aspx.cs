using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DataAccessLayer;


namespace Website
{
    public partial class Default : System.Web.UI.Page
    {
        // Different variables to hold the stuff we need
        private List<Album> albumsList;
        public Dictionary<Album, int> cart;
        private DataAccessLayer.AlbumRepository repo = new AlbumRepository(); // Access the DAL

        // Constant variables for the cover photo size
        const int COVER_WIDTH = 215;
        const int COVER_HEIGHT = 215;

        // Takes care initialize controls and other parts of the page.
        protected void Page_Init(object sender, EventArgs e)
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

            // Query the database for the info need or just get it from session state
            if (!IsPostBack)
            {
                albumsList = repo.GetAll(); // Get all albums from the DB // But it shouldn't do that every time.
            }
            else
            {
                albumsList = (List<Album>)Session["albums"];
            }
                
        }

        // Load and set controls
        protected void Page_Load(object sender, EventArgs e)
        {
            // Populate the page with a table full of albums
            foreach (Album album in albumsList)
            {

                // Create cover photo
                Image cover = new Image();
                cover.ImageUrl = string.Format(@"~\Images\{0}", album.AlbumArtwork);
                cover.Width = COVER_WIDTH;
                cover.Height = COVER_HEIGHT;

                // Create labels with album info
                Label albumName = new Label();
                albumName.Text = album.AlbumName;

                Label artistName = new Label();
                artistName.Text = album.ArtistName;

                Label price = new Label();
                price.Text = "Price: "+ Convert.ToString(album.Price) + " DKK";

                Label genre = new Label();
                genre.Text = album.Genre;

                // Create add to cart button
                Button add = new Button();
                add.Command += cmdAdd_Click;
                add.CommandName = "Add";
                add.CommandArgument = albumsList.IndexOf(album).ToString();
                add.Text = "Add to cart";
                add.Attributes["class"] = "btn btn-primary";

                // Create div to store the image and the rest of the info
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Attributes["class"] = "col-md-4 cover-art"; // Makes it into a fluid grid system 3*4=12


                // Create another div to store album name, and so on.
                HtmlGenericControl div2 = new HtmlGenericControl("div");
                div2.Attributes["class"] = "hover";
                div2.Controls.Add(albumName);
                div2.Controls.Add(artistName);
                div2.Controls.Add(genre);
                div2.Controls.Add(price);
                div2.Controls.Add(new HtmlGenericControl("br"));
                div2.Controls.Add(add);
                
                div.Controls.Add(div2);
                div.Controls.Add(cover);

                // Place the div to the panel and display it.
                pnlContent.Controls.Add(div);
                
            }
        }

        // Just before showing the page to the user, save the cart and album into the session state. 
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