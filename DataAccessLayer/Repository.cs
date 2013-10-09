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
    public class Repository : IRepository<Album>
    {
        // ;
        private readonly string strConnection =
            @"Data Source=.\sqlexpress;Initial Catalog=MusicStore;Integrated Security=True";

        
        public void Insert(Album entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Album entity)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAll()
        {
            DbConnection connection = new SqlConnection(strConnection);
            List<Album> albumList = new List<Album>();


            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select * From Album";
            connection.Open();

            DbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
//                string artistName = dr.GetString(1);
                string albumName = dr.GetString(1);
//                Int16 releaseYear = dr.GetInt16(3);
//                string genre = dr.GetString(4);
                string albumArtwork = dr.GetString(5);

                albumList.Add(new Album(albumName, albumArtwork));
            }
            connection.Close();
            return albumList;
        }


        public Album GetById(int id) {
            throw new NotImplementedException();
        }
    }
}