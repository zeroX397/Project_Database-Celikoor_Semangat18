using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Film
    {
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private int kelompoks_id;
        private string kelompoks_nama;
        private string bahasa;
        private int is_sub_indo;
        private string cover_image;
        private int diskon_nominal;

        public Film() {
            
        }

        public Film(int id, string judul, string sinopsis, int tahun, int durasi, int kelompoks_id, string kelompoks_nama, string bahasa, int is_sub_indo, string cover_image, int diskon_nominal)
        {
            this.id = id;
            this.judul = judul;
            this.sinopsis = sinopsis;
            this.tahun = tahun;
            this.durasi = durasi;
            this.kelompoks_id = kelompoks_id;
            this.kelompoks_nama = kelompoks_nama;
            this.bahasa = bahasa;
            this.is_sub_indo = is_sub_indo;
            this.cover_image = cover_image;
            this.diskon_nominal = diskon_nominal;
        }

        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public int Kelompoks_id { get => kelompoks_id; set => kelompoks_id = value; }
        public string Kelompoks_Nama { get => kelompoks_nama; set => kelompoks_nama = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public int Is_sub_indo { get => is_sub_indo; set => is_sub_indo = value; }
        public string Cover_image { get => cover_image; set => cover_image = value; }
        public int Diskon_nominal { get => diskon_nominal; set => diskon_nominal = value; }

        public static List<Film> BacaData(string kriteria = "", string nilaiKriteria = "")
        {
            string sql = "SELECT f.*, k.nama FROM films f LEFT JOIN kelompoks k ON f.kelompoks_id = k.id ";
            if (kriteria == "")
            {
                sql += ";";
            }
            else
            {
                sql += "WHERE f." + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader result = Koneksi.JalankanPerintahSelect(sql);
            List<Film> filmList = new List<Film>();

            while (result.Read())
            {
                Film film = new Film();

                film.Id = int.Parse(result.GetValue(0).ToString());
                film.Judul = result.GetValue(1).ToString();
                film.sinopsis = result.GetValue(2).ToString();
                film.tahun = int.Parse(result.GetValue(3).ToString());
                film.durasi = int.Parse(result.GetValue(4).ToString());
                film.kelompoks_id = int.Parse(result.GetValue(5).ToString());
                film.bahasa = result.GetValue(6).ToString();
                film.is_sub_indo = int.Parse(result.GetValue(7).ToString());
                film.cover_image = result.GetValue(8).ToString();
                if (result.GetValue(9).ToString() == "")
                    film.diskon_nominal = 0;
                else
                    film.diskon_nominal = int.Parse(result.GetValue(9).ToString());
                film.Kelompoks_Nama = result.GetValue(10).ToString();
                filmList.Add(film);
            }

            return filmList;
        }

        public static void TambahData(Film f)
        {
            string sql = "INSERT INTO films " + "(judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal) VALUES " + 
                $"('{f.judul}', '{f.sinopsis}', '{f.tahun}', '{f.durasi}', '{f.kelompoks_id}', '{f.bahasa}', '{f.is_sub_indo}', '{f.cover_image}', '{f.diskon_nominal}');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from films where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        }

        public static void UbahData(int id_film, Film obj)
        {
            string sql = "UPDATE films " +
                $"SET judul = '{obj.judul}', " +
                $"sinopsis = '{obj.sinopsis}', " +
                $"tahun = '{obj.tahun}', " +
                $"durasi = '{obj.durasi}', " +
                $"kelompoks_id = '{obj.kelompoks_id}', " +
                $"bahasa = '{obj.bahasa}', " +
                $"is_sub_indo = '{obj.is_sub_indo}', " +
                $"cover_image = '{obj.cover_image}', " +
                $"diskon_nominal = '{obj.diskon_nominal}' " +
                $"WHERE id = '{id_film}';";
            Console.WriteLine(sql);
            Koneksi.JalankanPerintahNonQuery(sql);
        }
    }
}
