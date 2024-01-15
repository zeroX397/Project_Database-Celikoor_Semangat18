using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class JadwalPemutaranFilm
    {
        #region DATAMEMBERS
        private string judul_film;
        private string cinema;
        private string studio;
        private DateTime tanggal;
        private string jam_pemutaran;
        #endregion

        public JadwalPemutaranFilm()
        {

        }

        public JadwalPemutaranFilm(string judul_film, string cinema, string studio, DateTime tanggal, string jam_pemutaran)
        {
            this.Judul_film = judul_film;
            this.Cinema = cinema;
            this.Studio = studio;
            this.Tanggal = tanggal;
            this.Jam_pemutaran = jam_pemutaran;
        }

        public string Judul_film { get => judul_film; set => judul_film = value; }
        public string Cinema { get => cinema; set => cinema = value; }
        public string Studio { get => studio; set => studio = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Jam_pemutaran { get => jam_pemutaran; set => jam_pemutaran = value; }

        
        #region METHODS
        public static List<JadwalPemutaranFilm> BacaData()
        {
            string perintah = "SELECT f.judul, c.nama_cabang, s.nama, jf.tanggal, jf.jam_pemutaran " +
                "FROM sesi_films sf " +
                "INNER JOIN studios s ON s.id = sf.studios_id " +
                "INNER JOIN cinemas c ON c.id = s.cinemas_id " +
                "INNER JOIN films f ON f.id = sf.films_id " +
                "INNER JOIN jadwal_films jf ON jf.id = sf.jadwal_film_id;";
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<JadwalPemutaranFilm> listHasil = new List<JadwalPemutaranFilm>();
            while (drHasil.Read() == true)
            {
                JadwalPemutaranFilm tampung = new JadwalPemutaranFilm();
                tampung.judul_film = drHasil.GetValue(0).ToString();
                tampung.cinema = drHasil.GetValue(1).ToString();
                tampung.studio = drHasil.GetValue(2).ToString();
                tampung.tanggal = DateTime.Parse(drHasil.GetValue(3).ToString());
                tampung.Jam_pemutaran = drHasil.GetValue(4).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        #endregion
    }
}
