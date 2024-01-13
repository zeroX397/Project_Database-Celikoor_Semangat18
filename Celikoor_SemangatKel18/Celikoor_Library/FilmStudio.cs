using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class FilmStudio
    {
        #region DATAMEMBERS
        private int studios_id;
        private string studios_nama;
        private int films_id;
        private string films_judul;

        #endregion

        #region CONSTRUCTORS
        public FilmStudio()
        {

        }

        public FilmStudio(int studios_id, string studios_nama, int films_id, string films_judul)
        {
            this.Studios_id = studios_id;
            this.Studios_nama = studios_nama;
            this.Films_id = films_id;
            this.Films_judul = films_judul;
        }
        #endregion

        #region PROPERTIES
        public int Studios_id { get => studios_id; set => studios_id = value; }
        public string Studios_nama { get => studios_nama; set => studios_nama = value; }
        public int Films_id { get => films_id; set => films_id = value; }
        public string Films_judul { get => films_judul; set => films_judul = value; }
        #endregion

        #region METHODS
        public static List<FilmStudio> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "SELECT fs.*, s.nama, f.judul FROM film_studio fs INNER JOIN studios s ON fs.studios_id = s.id INNER JOIN films f ON fs.films_id = f.id";
            if (filter == "")
            {
                perintah += ";";
            }
            else
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<FilmStudio> listHasil = new List<FilmStudio>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                FilmStudio tampung = new FilmStudio();
                tampung.Studios_id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Films_id = int.Parse(drHasil.GetValue(1).ToString());
                tampung.Studios_nama = drHasil.GetValue(2).ToString();
                tampung.Films_judul = drHasil.GetValue(3).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(FilmStudio g)
        {

        }
        
        public static void UbahData(int id_studio, int id_film, FilmStudio obj)
        {
        
        }

        public static void HapusData(int id_studio, int id_film)
        {  
            
        }
        #endregion
    }
}
