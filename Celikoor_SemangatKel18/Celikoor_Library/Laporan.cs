using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Laporan
    {
        private Cinema cinema;
        private Studio studio;
        private FilmStudio film_studio;
        private SesiFilm sesi_film;
        private Tiket tiket;

        public Laporan()
        {
            Cinema = new Cinema();
            Studio = new Studio();
            Film_studio = new FilmStudio();
            Sesi_film = new SesiFilm();
            Tiket = new Tiket();
        }

        public Cinema Cinema { get => cinema; set => cinema = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public FilmStudio Film_studio { get => film_studio; set => film_studio = value; }
        public SesiFilm Sesi_film { get => sesi_film; set => sesi_film = value; }
        internal Tiket Tiket { get => tiket; set => tiket = value; }

        public static List<Laporan> BacaData(string filter = "", string nilai = "")
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

            List<Laporan> listHasil = new List<Laporan>();
            while (drHasil.Read() == true)
            {
                Laporan tampung = new Laporan();

                tampung.Cinema = Cinema.BacaData("id", drHasil.GetValue(0).ToString())[0];
                tampung.Studio = Studio.BacaData("id", drHasil.GetValue(1).ToString())[0];
                tampung.Film_studio = FilmStudio.BacaData("studios_id", drHasil.GetValue(2).ToString())[0];
                tampung.Sesi_film = SesiFilm.BacaData("jadwal_film_id", drHasil.GetValue(3).ToString())[0];
                tampung.Tiket = Tiket.BacaData($"invoices_id='{drHasil.GetValue(4)}'")[0];
                listHasil.Add(tampung);
            }
            return listHasil;
        }

    }
}
