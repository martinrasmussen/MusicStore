using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace Website
{
    public partial class Checkout : System.Web.UI.Page
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
           btnSubmit.Click += btnSubmit_OnClickSubmit_Click;

        }
        public string orderInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<br>Order information for ");
                sb.Append(txtFirstName.Text + " " + txtLastName.Text + ":<br/><br/>");
                sb.Append(txtStreet.Text + "<br/>");
                sb.Append(txtCity.Text + "<br/>");
                sb.Append(txtCountry.Text + "<br/>");
                sb.Append(txtEmail.Text + "<br/><br/>");

                Dictionary<Album, int> cart = (Dictionary<Album, int>)Session["cart"];

                foreach (var i in cart)
                {
                    sb.Append(String.Format("{0} ({1}) - {2} DKK <br/>", i.Key.AlbumName, i.Value, i.Key.Price));
                }
                return sb.ToString();
            }
        }


        protected void btnSubmit_OnClickSubmit_Click(object sender, EventArgs e)
        {
     
            Server.Transfer("Confirmation.aspx");
        }

       
    }
}