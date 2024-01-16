using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    class Tiket
    {
        private int invoices_id;
        private string nomor_kursi;
        private string status_hadir;
        private int operator_id;
        private int harga;
        private int jawdal_film_id;
        private int studios_id;
        private int films_id;

        public Tiket()
        {
        }

        public static List<Tiket> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "SELECT * FROM tikets";

            if (kriteria == "")
            {
                sql += ";";
            }
            else
            {
                sql += " WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%';";
            }

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(sql);
            List<Tiket> listHasil = new List<Tiket>();
            while (drHasil.Read())
            {
                Tiket tampung = new Tiket();
                tampung.invoices_id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.nomor_kursi = drHasil.GetValue(1).ToString();
                tampung.status_hadir = drHasil.GetValue(2).ToString();
                tampung.operator_id = int.Parse(drHasil.GetValue(3).ToString());
                tampung.harga = int.Parse(drHasil.GetValue(4).ToString());
                tampung.jawdal_film_id =int.Parse(drHasil.GetValue(5).ToString());
                tampung.studios_id = int.Parse(drHasil.GetValue(6).ToString());
                tampung.films_id = int.Parse(drHasil.GetValue(7).ToString());
                listHasil.Add(tampung);
            }

            return listHasil;
        }

        public static void TambahData(Tiket obj)
        {

            string perintah = "INSERT INTO tikets " +
                "(invoices_id, nomor_kursi, status_hadir, operator_id, harga, jawdal_film_id, studios_id, films_id) VALUES " +
                $"('{obj.invoices_id}', '{obj.nomor_kursi}', '0', '{obj.operator_id}', '{obj.harga}', '{obj.jawdal_film_id}', '{obj.studios_id}', '{obj.films_id}');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
    }
}
