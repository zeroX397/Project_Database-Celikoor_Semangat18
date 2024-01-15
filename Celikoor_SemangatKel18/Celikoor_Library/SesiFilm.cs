using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class SesiFilm
    {
        #region DATAMEMBERS
        private int jadwal_films_id;
        private string jadwal_film_tanggal;
        private string jadwal_film_jam;
        private int studios_id;
        private string studios_nama;
        private int films_id;
        private string films_judul;

        #endregion

        #region CONSTRUCTORS

        public SesiFilm()
        {

        }

        public SesiFilm(int jadwal_films_id, string jadwal_film_tanggal, string jadwal_film_jam, int studios_id, string studios_nama, int films_id, string films_judul)
        {
            this.jadwal_films_id = jadwal_films_id;
            this.jadwal_film_tanggal = jadwal_film_tanggal;
            this.jadwal_film_jam = jadwal_film_jam;
            this.studios_id = studios_id;
            this.studios_nama = studios_nama;
            this.films_id = films_id;
            this.films_judul = films_judul;
        }
        #endregion

        #region PROPERTIES
        public int Jadwal_films_id { get => jadwal_films_id; set => jadwal_films_id = value; }
        public string Jadwal_film_tanggal { get => jadwal_film_tanggal; set => jadwal_film_tanggal = value; }
        public string Jadwal_film_jam { get => jadwal_film_jam; set => jadwal_film_jam = value; }
        public int Studios_id { get => studios_id; set => studios_id = value; }
        public string Studios_nama { get => studios_nama; set => studios_nama = value; }
        public int Films_id { get => films_id; set => films_id = value; }
        public string Films_judul { get => films_judul; set => films_judul = value; }
        #endregion

        #region METHODS
        public static List<SesiFilm> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "SELECT sf.*, jf.tanggal, jf.jam_pemutaran, s.nama, f.judul " +
                            "FROM sesi_films sf " +
                            "INNER JOIN jadwal_films jf ON sf.jadwal_film_id = jf.id "+
                            "INNER JOIN studios s ON sf.studios_id = s.id " +
                            "INNER JOIN films f ON sf.films_id = f.id ";

            if (filter == "")
            {
                perintah += ";";
            }
            else
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<SesiFilm> listHasil = new List<SesiFilm>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                SesiFilm tampung = new SesiFilm();
                tampung.jadwal_films_id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.studios_id = int.Parse(drHasil.GetValue(1).ToString());
                tampung.films_id = int.Parse(drHasil.GetValue(2).ToString());
                tampung.Jadwal_film_tanggal = drHasil.GetValue(3).ToString();
                tampung.Jadwal_film_jam= drHasil.GetValue(4).ToString();
                tampung.Studios_nama = drHasil.GetValue(5).ToString();
                tampung.films_judul = drHasil.GetValue(6).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(SesiFilm obj)
        {
            string sql = "INSERT INTO sesi_films " + "(jadwal_film_id, studios_id, films_id) VALUES " + "('" +
                obj.jadwal_films_id + "', '" +
                obj.studios_id + "', '" +
                obj.films_id + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        
        public static void UbahData(int id_studio, int id_film, SesiFilm obj)
        {
        
        }

        public static void HapusData(int id_studio, int id_film)
        {  
            
        }
        #endregion
    }
}
