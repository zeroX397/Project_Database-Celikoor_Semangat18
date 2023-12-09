using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    class Film
    {
        private int id;
        private string judul;
        private int harga;

        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Harga { get => harga; set => harga = value; }

        public Film()
        {
            Id = 0;
            Judul = "";
            Harga = 0;
        }

        public Film(int id, string judul, int harga)
        {
            Id = id;
            Judul = judul;
            Harga = harga;
        }

        public static List<Film> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "SELECT id, judul_film, status, harga " +
                " FROM films " +
                " WHERE status='AKTIF' ";

            if (kriteria == "")
            {
                sql += ";";
            }
            else
            {
                sql += " AND " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader result = Koneksi.JalankanPerintahSelect(sql);

            List<Film> filmList = new List<Film>();

            while (result.Read())
            {
                Film tmp = new Film(result.GetInt32("id"),
                    result.GetString("judul_film"),
                    result.GetInt32("harga"));

                filmList.Add(tmp);
            }

            return filmList;
        }

        public override string ToString()
        {
            return Judul;
        }
    }
}
