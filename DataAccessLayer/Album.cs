using System;
using System.Web.UI.WebControls;

namespace DataAccessLayer
{
    public class Album : IEntity
    {
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public Int16 ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string AlbumArtwork { get; set; }
        public decimal Price { get; set; }

        public Album(string artistName, string albumName, Int16 releaseYear, string genre, string albumArtwork)
        {
            this.ArtistName = artistName;
            this.AlbumName = albumName;
            this.ReleaseYear = releaseYear;
            this.Genre = genre;
            this.AlbumArtwork = albumArtwork;
        }
    }
}
