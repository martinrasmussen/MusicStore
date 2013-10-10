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
    public class GenreRepository : IRepository<string>
    {
        // Connection string to the database. It has to be changed if yours is different!;
        private const string DB_INSTANCE_NAME = @".\SQLEXPRESS";
        private const string DB_NAME = @"MusicStore";
        private const bool SECURITY = true;

        private string _strConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumRepository"/> class.
        /// </summary>
        public GenreRepository()
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
        public GenreRepository(string dbInstanceName, string dbName, bool enableSecurity)
        {
            this._strConnection = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2}",
            dbInstanceName, dbName, enableSecurity.ToString());
        }

        /// <summary>
        /// Inserts the specified entity to the database.
        /// </summary>
        /// <param name="genre">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Insert(string genre)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified entity from the database.
        /// </summary>
        /// <param name="genre">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(string genre)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets all albums from the database.
        /// </summary>
        /// <returns>genreList</returns>
        public List<string> GetAll()
        {
            // Create a connection.
            DbConnection connection = new SqlConnection(_strConnection);

            // Create an empty list that will be used to store the albums from the database.
            List<string> genreList = new List<string>();

            // Create a command.
            DbCommand cmd = connection.CreateCommand();
            
            // Here we set the command to be our sql query.
            cmd.CommandText = "Select Genre.genreName FROM Genre";
            
            // Open the connection.
            connection.Open();

            // Initiate a data reader which we'll use to go throuth our output from the database.
            DbDataReader dr = cmd.ExecuteReader();

            // While there are rows in our output.
            while (dr.Read())
            {
                // Set the genre.
                string genre = dr.GetString(dr.GetOrdinal("genreName"));

                // Add the genre to our list
                genreList.Add(genre);
            }

            // Close the connection.
            connection.Close();

            // Return the album list.
            return genreList;
        }


        /// <summary>
        /// Gets one album by an identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>genre</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetById(int id) {
            // Create a connection.
            DbConnection connection = new SqlConnection(_strConnection);

            // This variable will store the genre.
            string genre = null;

            // Create a command.
            DbCommand cmd = connection.CreateCommand();

            // Here we set the command to be our sql query.
            cmd.CommandText = String.Format("Select Genre.genreName WHERE Genre.ID = {0};", id);

            // Open the connection.
            connection.Open();

            // Initiate a data reader which we'll use to read the output from the database.
            DbDataReader dr = cmd.ExecuteReader();

            // If there is a row in our result, read it.
            if (dr.Read())
            {
                genre = dr.GetString(dr.GetOrdinal("genreName"));
            }

            // Close the connection.
            connection.Close();

            // Return the genre string.
            return genre;
        }
    }
}