using System;
using System.Web.UI.WebControls;

namespace DataAccessLayer
{
    [Serializable] // It's serializable so we can save it to session state.
    public class Album
    {
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public Int16 ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string AlbumArtwork { get; set; }
        public decimal Price { get; set; }

        public Album(string albumName, string albumArtwork)
        {
//            this.ArtistName = artistName;
            this.AlbumName = albumName;
//            this.ReleaseYear = releaseYear;
//            this.Genre = genre;
            this.AlbumArtwork = albumArtwork;
        }
    }
}
