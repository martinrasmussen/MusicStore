using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

namespace DataAccessLayer
{
    public class Repository<Album> : IRepository<Album>
    {
        // @"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
        private readonly string strConnection;

        // The actual connection.
        private DbConnection connection;
        public void Insert(Album entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Album entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Album> GetAll()
        {
            throw new NotImplementedException();
        }

        public Album GetById(int id)
        {
             DbConnection connection = new SqlConnection(strConnection);

            using (var cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "Select * From Album Where ID = @id";
                try
                {
                    connection.Open();
                    DbDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string artistName = dr.GetString(0);
                    string albumName = dr.GetString(1);
                    Int16 releaseYear = dr.GetInt16(2);
                    string genre = dr.GetString(3);
                    string albumArtwork = dr.GetString(4);

                    var album = new Album(artistName, albumName, releaseYear, genre, albumArtwork);
                    return album;

                }
                finally
                {
                    connection.Close();
                }

                //use data 

        }
    }
}