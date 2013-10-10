using System;
using System.Web.UI.WebControls;

namespace DataAccessLayer
{
    [Serializable] // It's serializable so we can save it to session state.
    public class Album
    {
        private string _artistName,
            _albumName,
            _genre,
            _albumArtwork;

        private Int16 _releaseYear;

        private Int32 _id;

        private decimal _price;

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID
        {
            get
            {
                return this._id;
            }
            internal set
            {
                this._id = value;
            }
        }

        /// <summary>
        /// Gets the name of the artist.
        /// </summary>
        /// <value>
        /// The name of the artist.
        /// </value>
        public string ArtistName
        {
            get
            {
                return this._artistName;
            }
            internal set
            {
                this._artistName = value;
            }
        }

        /// <summary>
        /// Gets the name of the album.
        /// </summary>
        /// <value>
        /// The name of the album.
        /// </value>
        public string AlbumName
        {
            get
            {
                return this._albumName;
            }
            internal set
            {
                this._albumName = value;
            }
        }

        /// <summary>
        /// Gets the release year.
        /// </summary>
        /// <value>
        /// The release year.
        /// </value>
        public Int16 ReleaseYear
        {
            get
            {
                return this._releaseYear;
            }
            internal set
            {
                this._releaseYear = value;
            }
        }

        /// <summary>
        /// Gets the genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        public string Genre
        {
            get
            {
                return this._genre;
            }
            internal set
            {
                this._genre = value;
            }
        }

        /// <summary>
        /// Gets the album artwork.
        /// </summary>
        /// <value>
        /// The album artwork.
        /// </value>
        public string AlbumArtwork
        {
            get
            {
                return this._albumArtwork;
            }
            internal set
            {
                this._albumArtwork = value;
            }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price
        {
            get
            {
                return this._price;
            }
            internal set
            {
                this._price = value;
            }
        }
    }
}
