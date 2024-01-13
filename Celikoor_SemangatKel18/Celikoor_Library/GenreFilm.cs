using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class GenreFilm
    {
        #region DATAMEMBERS
        private int genres_id;
        private string genres_nama;
        private int films_id;
        private string films_judul;

        #endregion

        #region CONSTRUCTORS
        public GenreFilm()
        {

        }

        public GenreFilm(int genres_id, string genres_nama, int films_id, string films_judul)
        {
            this.Genres_id = genres_id;
            this.Genres_nama = genres_nama;
            this.Films_id = films_id;
            this.Films_judul = films_judul;
        }
        #endregion

        #region PROPERTIES
        public int Genres_id { get => genres_id; set => genres_id = value; }
        public string Genres_nama { get => genres_nama; set => genres_nama = value; }
        public int Films_id { get => films_id; set => films_id = value; }
        public string Films_judul { get => films_judul; set => films_judul = value; }
        #endregion

        #region METHODS
        public static List<GenreFilm> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "SELECT gf.*, g.nama, f.judul FROM genre_film gf INNER JOIN genres g ON gf.genres_id = g.id INNER JOIN films f ON gf.films_id = f.id";
            if (filter == "")
            {
                perintah += ";";
            }
            else
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<GenreFilm> listHasil = new List<GenreFilm>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                GenreFilm tampung = new GenreFilm();
                tampung.Genres_id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Films_id = int.Parse(drHasil.GetValue(1).ToString());
                tampung.Genres_nama = drHasil.GetValue(2).ToString();
                tampung.Films_judul = drHasil.GetValue(3).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(GenreFilm g)
        {

        }
        
        public static void UbahData(int id_studio, int id_film, GenreFilm obj)
        {
        
        }

        public static void HapusData(int id_studio, int id_film)
        {  
            
        }
        #endregion
    }
}
