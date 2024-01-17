using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class LaporanPeringkatCabang
    {
        #region Data Member
        private Cinema cinema;
        private Studio studio;
        private FilmStudio film_studio;
        private SesiFilm sesi_film;
        private Tiket tiket;
        #endregion

        #region Constructor
        public LaporanPeringkatCabang()
        {
            Cinema = new Cinema();
            Studio = new Studio();
            Film_studio = new FilmStudio();
            Sesi_film = new SesiFilm();
            Tiket = new Tiket();
        }
        #endregion

        #region Properties
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public FilmStudio Film_studio { get => film_studio; set => film_studio = value; }
        public SesiFilm Sesi_film { get => sesi_film; set => sesi_film = value; }
        internal Tiket Tiket { get => tiket; set => tiket = value; }
        #endregion

        #region Method
        public static List<LaporanPeringkatCabang> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
                perintah = "SELECT c.id AS cinema_id, c.nama_cabang, c.alamat, c.kota, SUM(t.harga) AS total_pendapatan" +
                    " FROM cinemas c INNER JOIN studios s ON c.id = s.cinemas_id INNER JOIN film_studio fs ON s.id = studios_id INNER JOIN sesi_films sf ON fs.studios_id = sf.studios_id INNER JOIN tikets t ON sf.studios_id = t.studios_id " +
                    "GROUP BY c.id, c.nama_cabang, c.alamat, c.kota " +
                    "ORDER BY total_pendapatan DESC LIMIT 3; ";
            else
                perintah = "SELECT c.id AS cinema_id, c.nama_cabang, c.alamat, c.kota, SUM(t.harga) AS total_pendapatan" +
                    " FROM cinemas c INNER JOIN studios s ON c.id = s.cinemas_id INNER JOIN film_studio fs ON s.id = studios_id INNER JOIN sesi_films sf ON fs.studios_id = sf.studios_id INNER JOIN tikets t ON sf.studios_id = t.studios_id " +
                    "GROUP BY c.id, c.nama_cabang, c.alamat, c.kota " +
                    "ORDER BY total_pendapatan DESC LIMIT 3; ";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<LaporanPeringkatCabang> listHasil = new List<LaporanPeringkatCabang>();
            while (drHasil.Read() == true)
            {
                LaporanPeringkatCabang tampung = new LaporanPeringkatCabang();

                tampung.Cinema = Cinema.BacaData(drHasil.GetValue(0).ToString())[0];
                tampung.Studio = Studio.BacaData(drHasil.GetValue(1).ToString())[0];
                tampung.Film_studio = FilmStudio.BacaData(drHasil.GetValue(2).ToString())[0];
                tampung.Sesi_film = SesiFilm.BacaData(drHasil.GetValue(3).ToString())[0];
                tampung.Tiket = Tiket.BacaData(drHasil.GetValue(4).ToString())[0];
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        #endregion
    }
}
