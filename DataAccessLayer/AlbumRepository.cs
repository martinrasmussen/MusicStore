using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web.UI.WebControls;

namespace DataAccessLayer
{
    public class AlbumRepository : IRepository<Album>
    {
        // Connection string to the database. It has to be changed if yours is different!;
        private const string DB_INSTANCE_NAME = @"ASPIRE-5741";
        private const string DB_NAME = @"MusicStore";
        private const bool SECURITY = true;

        private string _strConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumRepository"/> class.
        /// </summary>
        public AlbumRepository()
        {
            this._strConnection = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2}",
            DB_INSTANCE_NAME, DB_NAME, SECURITY.ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumRepository"/> class.
        /// </summary>
        /// <param name="dbInstanceName">Name of the database instance.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="enableSecurity">if set to <c>true</c> [enable security].</param>
        public AlbumRepository(string dbInstanceName, string dbName, bool enableSecurity)
        {
            this._strConnection = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2}",
            dbInstanceName, dbName, enableSecurity.ToString());
        }

        /// <summary>
        /// Inserts the specified entity to the database.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Insert(Album entity)
        {
            // Create a connection.
            DbConnection connection = new SqlConnection(_strConnection);

            // Create a command.
            DbCommand cmd = connection.CreateCommand();

            // Here we set the command to be our sql query.
            cmd.CommandText = String.Format("Insert into Album (Album.albumName, Album.releaseYear, Album.genre, Album.artistName, Album.albumArtwork, Album.price) values ({0}, {1}, {2}, {3}, {4}, {5}, {6});", entity.AlbumName, entity.ArtistName, entity.Genre, entity.ReleaseYear, entity.Price, entity.AlbumArtwork);

            // Open the connection.
            connection.Open();

            // Execute the sql command.
            cmd.ExecuteNonQuery();

            // Close the connection.
            connection.Close();
        }

        /// <summary>
        /// Deletes the specified entity from the database.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(Album entity)
        {
            // Create a connection.
            DbConnection connection = new SqlConnection(_strConnection);

            // Create a command.
            DbCommand cmd = connection.CreateCommand();

            // Here we set the command to be our sql query.
            cmd.CommandText = String.Format("Delete from Album where Album.ID = {0};",entity.ID);

            // Open the connection.
            connection.Open();
        
            // Execute the sql command.
            cmd.ExecuteNonQuery();

            // Close the connection.
            connection.Close();
        }


        /// <summary>
        /// Gets all albums from the database.
        /// </summary>
        /// <returns>albumList</returns>
        public List<Album> GetAll()
        {
            // Create a connection.
            DbConnection connection = new SqlConnection(_strConnection);

            // Create an empty list that will be used to store the albums from the database.
            List<Album> albumList = new List<Album>();

            // Create a command.
            DbCommand cmd = connection.CreateCommand();
            
            // Here we set the command to be our sql query.
            cmd.CommandText = "Select Album.ID, Album.artistName, Album.albumTitle, Album.albumArtwork, Album.genre, Album.releaseYear, Album.price From Album;";
            
            // Open the connection.
            connection.Open();

            // Initiate a data reader which we'll use to go throuth our output from the database.
            DbDataReader dr = cmd.ExecuteReader();

            // While there are rows in our output.
            while (dr.Read())
            {
                // Create an album with the information from the database.
                Album album = new Album
                {
                    ID = dr.GetInt32(dr.GetOrdinal("ID")),
                    ArtistName = dr.GetString(dr.GetOrdinal("artistName")),
                    AlbumName = dr.GetString(dr.GetOrdinal("albumTitle")),
                    ReleaseYear = dr.GetInt16(dr.GetOrdinal("releaseYear")),
                    Genre = dr.GetString(dr.GetOrdinal("genre")),
                    AlbumArtwork = dr.GetString(dr.GetOrdinal("albumArtwork")),
                    Price = dr.GetDecimal(dr.GetOrdinal("price"))
                };

                // Set the album's properties.

                // Add the album to our list
                albumList.Add(album);
            }

            // Close the connection.
            connection.Close();

            // Return the album list.
            return albumList;
        }


        /// <summary>
        /// Gets one album by an identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Album GetById(int id) {
            // Create a connection.
            DbConnection connection = new SqlConnection(_strConnection);

            // Create an empty album that will be used to store the album from the database.
            Album album = new Album();

            // Create a command.
            DbCommand cmd = connection.CreateCommand();

            // Here we set the command to be our sql query.
            cmd.CommandText = String.Format("Select Album.ID, Album.artistName, Album.albumTitle, Album.albumArtwork, Album.genre, Album.releaseYear, Album.price From Album WHERE Album.ID = {0};", id);

            // Open the connection.
            connection.Open();

            // Initiate a data reader which we'll use to read the output from the database.
            DbDataReader dr = cmd.ExecuteReader();

            // If there is a row in our result, read it.
            if (dr.Read())
            {
                // Set the album's properties.
                album.ID = dr.GetInt32(dr.GetOrdinal("ID"));
                album.ArtistName = dr.GetString(dr.GetOrdinal("artistName"));
                album.AlbumName = dr.GetString(dr.GetOrdinal("albumTitle"));
                album.ReleaseYear = dr.GetInt16(dr.GetOrdinal("releaseYear"));
                album.Genre = dr.GetString(dr.GetOrdinal("genreName"));
                album.AlbumArtwork = dr.GetString(dr.GetOrdinal("albumArtwork"));
                album.Price = dr.GetDecimal(dr.GetOrdinal("price"));
            }
            // Otherwise don't.
            else
            {
                return null;
            }

            // Close the connection.
            connection.Close();

            // Return the album.
            return album;
        }
    }
}