using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<String> albumsList = new List<string>();
        albumsList.Add("Hello Kitty");
        albumsList.Add("GoGoGo");
        albumsList.Add("One Direction");
        albumsList.Add("Big Fat Snake");

        //Image image = new Image();
        //image.ImageUrl = 
        foreach (string album in albumsList)
        {
            //Initialize a row for the table
            TableRow tblRow = new TableRow();

            //Creates a cell to be put in to the table
            TableCell tblCell1 = new TableCell();
            TableCell tblCell2 = new TableCell();
            TableCell tblCell3 = new TableCell();

            //Add data to the cell here
            tblCell1.Text = album.ToString();
            tblCell2.Text = album.ToString();
           // tblCell3.Controls.Add(image);
            

            //Add the cell to the row
            tblRow.Cells.Add(tblCell1);
            tblRow.Cells.Add(tblCell2);
           // tblRow.Cells.Add(tblCell3);

            //Add the row to the table
            tblAlbums.Rows.Add(tblRow);

        }
        
        
        

        

        




    }
}