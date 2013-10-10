using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace Website
{
    public partial class Default : System.Web.UI.Page
    {
        private List<Album> albumsList;
        public Dictionary<Album, int> cart;
        private DataAccessLayer.Repository repo;

        // Constant variables for the cover photo size
        const int COVER_WIDTH = 100;
        const int COVER_HEIGHT = 100;

        // Takes care [of what]?
        protected void Page_Init(object sender, EventArgs e)
        {
                // Initialize the ...
            if (!IsPostBack)
            {
                repo = new Repository(); // Data access layer // But it shouldn't do that every time.
                albumsList = repo.GetAll(); // Get all albums from the DB // But it shouldn't do that every time.
            }

        }

        // Takes care of [what?]
        protected void Page_Load(object sender, EventArgs e)
        {
            
                // Create view state item for the shopping cart if it's empty
                if (ViewState["cart"] == null)
                {
                    ViewState["cart"] = new Dictionary<Album, int>();
                }

                if (ViewState["albums"] == null)
                {
                    ViewState["albums"] = new List<Album>();
                }
                
                cart = (Dictionary<Album, int>)ViewState["cart"]; ; // Create an empty cart.

                if(IsPostBack)
                    albumsList = (List<Album>) ViewState["albums"];

            

            // Populate the page with a table full of albums
            foreach (Album album in albumsList)
            {
                // Create an 'add' button
                Button btnAdd = new Button();
                btnAdd.Text = "Add to cart";

                // Initialize a row for the table
                TableRow tblRow = new TableRow();

                // Creates a cell to be put in to the table
                TableCell tblCell1 = new TableCell();
                TableCell tblCell2 = new TableCell();
                TableCell tblCell3 = new TableCell();

                // Create cover photo
                Image cover = new Image();
                cover.ImageUrl = string.Format(@"~\Images\{0}", album.AlbumArtwork);
                cover.Width = COVER_WIDTH;
                cover.Height = COVER_HEIGHT;

                // Add listener to image cell
                btnAdd.Command += cmdAdd_Click;
                btnAdd.CommandName = "Add";
                btnAdd.CommandArgument = albumsList.IndexOf(album).ToString();

                // Add data to the cell here
                tblCell1.Controls.Add(cover);
                tblCell2.Text = album.AlbumName;
                tblCell3.Controls.Add(btnAdd);

                // Add the cell to the row
                tblRow.Cells.Add(tblCell1);
                tblRow.Cells.Add(tblCell2);
                tblRow.Cells.Add(tblCell3);

                // Add the row to the table
                tblAlbums.Rows.Add(tblRow);
            }
        }

        // Takes care of [what?]
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["albums"] = albumsList;
            // Copy shopping cart to view state
            ViewState["cart"] = cart;
            decimal price = 0;
            foreach (var album in cart)
            {
                lblCart.Text += album.Key.AlbumName + " " + album.Value + "<br/>";

                //The total price of the shopping cart @TODO
                lblCartPrice.Text = Convert.ToString(price += 50);
            }
            
        }

        // Click listener for the Add function
        protected void cmdAdd_Click(object sender, CommandEventArgs e)
        {
            
            // Add selected movie to shopping cart
            var album = albumsList[Convert.ToInt32(e.CommandArgument)];
            bool hasFound = false;
            
            
                foreach (var cartAlbum in cart.Keys)
                {
                    if (cartAlbum.AlbumName.Equals(album.AlbumName))
                    {
                        hasFound = true;
                        album = cartAlbum;
                    }
                }
            if (hasFound)
            {
                cart[album]++;
            }
            else
            {
                cart.Add(album, 1);
            }



        }
    }
}