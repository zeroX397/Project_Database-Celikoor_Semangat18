using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class LaporanFilmDgnKetidakhadiran
    {
        private Film films;
        private FilmStudio filmstudios;
        private SesiFilm sesiFilms;
        private Tiket tickets;

        public LaporanFilmDgnKetidakhadiran()
        {
            Films = new Film();
            Filmstudios = new FilmStudio();
            SesiFilms = new SesiFilm();
            Tickets = new Tiket();
        }

        public Film Films { get => films; set => films = value; }
        public FilmStudio Filmstudios { get => filmstudios; set => filmstudios = value; }
        public SesiFilm SesiFilms { get => sesiFilms; set => sesiFilms = value; }
        public Tiket Tickets { get => tickets; set => tickets = value; }

        public static List<LaporanFilmDgnKetidakhadiran> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
                perintah = "SELECT f.id AS film_id, f.judul, COUNT(t.nomor_kursi) AS jumlah_ketidakhadiran" +
                    "FROM films f INNER JOIN film_studio fs ON f.id = fs.films_id " +
                    "INNER JOIN sesi_films sf ON fs.studios_id = sf.films_id " +
                    "LEFT JOIN tikets t ON sf.films_id = t.jadwal_film_id AND t.status_hadir = false " +
                    "GROUP BY f.id, f.judul " +
                    "ORDER BY jumlah_ketidakhadiran " +
                    "DESC LIMIT 3; ";
            else
                perintah = "SELECT f.id AS film_id, f.judul, COUNT(t.nomor_kursi) AS jumlah_ketidakhadiran" +
                    "FROM films f INNER JOIN film_studio fs ON f.id = fs.films_id " +
                    "INNER JOIN sesi_films sf ON fs.studios_id = sf.films_id " +
                    "LEFT JOIN tikets t ON sf.films_id = t.jadwal_film_id AND t.status_hadir = false " +
                    "GROUP BY f.id, f.judul " +
                    "ORDER BY jumlah_ketidakhadiran " +
                    "DESC LIMIT 3; ";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<LaporanFilmDgnKetidakhadiran> listHasil = new List<LaporanFilmDgnKetidakhadiran>();
            while (drHasil.Read() == true)
            {
                LaporanFilmDgnKetidakhadiran tampung = new LaporanFilmDgnKetidakhadiran();

                tampung.Films = Film.BacaData("id", drHasil.GetValue(0).ToString())[0];
                tampung.Filmstudios = FilmStudio.BacaData("id", drHasil.GetValue(1).ToString())[0];
                tampung.SesiFilms = SesiFilm.BacaData("studios_id", drHasil.GetValue(2).ToString())[0];
                tampung.Tickets = Tiket.BacaData($"invoices_id='{drHasil.GetValue(3)}'")[0];
                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}
