using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Genre
    {
        #region DATAMEMBERS
        private int id_genre;
        private string nama_genre;
        private string deskripsi_genre;
        #endregion

        #region CONSTRUCTORS
        public Genre()
        {
            Id_genre = 0;
            Nama_genre = "";
            Deskripsi_genre = "";
        }
        #endregion

        #region PROPERTIES
        public int Id_genre { get => id_genre; set => id_genre = value; }
        public string Nama_genre { get => nama_genre; set => nama_genre = value; }
        public string Deskripsi_genre { get => deskripsi_genre; set => deskripsi_genre = value; }
        #endregion

        #region METHODS
        public static List<Genre> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT * from genres";
            }
            else
            {
                perintah = "SELECT * from genres " +
                    "where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Genre> listHasil = new List<Genre>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                Genre tampung = new Genre();
                tampung.Id_genre = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama_genre = drHasil.GetValue(1).ToString();
                tampung.Deskripsi_genre = drHasil.GetValue(2).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(Genre g)
        {
            string perintah;
            if (g.Deskripsi_genre != null)
            {
                perintah = "INSERT INTO genres" + "(id, nama, deskripsi) VALUES " + "('" + g.Id_genre + "', '" + g.Nama_genre + "', '" + g.Deskripsi_genre + "');";
            }
            else 
            {
                perintah = "INSERT INTO genres" + "(id, nama) VALUES " + "('" + g.Id_genre + "', '" + g.Nama_genre + "');";
            }
            
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        #endregion
    }
}
