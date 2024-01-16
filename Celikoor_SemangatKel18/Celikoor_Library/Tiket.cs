using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Tiket
    {
        private int invoices_id;
        private string nomor_kursi;
        private string status_hadir_int;
        private string status_hadir;
        private int operator_id_temp;
        private string operator_id;
        private int harga;
        private int jawdal_film_id;
        private int studios_id;
        private int films_id;

        public Tiket()
        {
        }

        public int Invoices_id { get => invoices_id; set => invoices_id = value; }
        public string Nomor_kursi { get => nomor_kursi; set => nomor_kursi = value; }
        public string Status_hadir_int { get => status_hadir_int; set => status_hadir_int = value; }
        public string Status_hadir { get => status_hadir; set => status_hadir = value; }
        public int Operator_id_temp { get => operator_id_temp; set => operator_id_temp = value; }
        public string Operator_id { get => operator_id; set => operator_id = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Jawdal_film_id { get => jawdal_film_id; set => jawdal_film_id = value; }
        public int Studios_id { get => studios_id; set => studios_id = value; }
        public int Films_id { get => films_id; set => films_id = value; }

        public static List<Tiket> BacaData(string kriteria = "")
        {
            string sql = "SELECT * FROM tikets";

            if (kriteria == "")
            {
                sql += ";";
            }
            else
            {
                sql += " WHERE " + kriteria;
            }

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(sql);
            List<Tiket> listHasil = new List<Tiket>();
            while (drHasil.Read())
            {
                Tiket tampung = new Tiket();
                tampung.Invoices_id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nomor_kursi = drHasil.GetValue(1).ToString();
                tampung.Status_hadir_int = drHasil.GetValue(2).ToString();
                if (tampung.status_hadir_int == "0")
                {
                    tampung.Status_hadir = "Belum Hadir";
                } else
                {
                    tampung.Status_hadir = "Sudah Hadir";
                }
                tampung.Operator_id_temp = drHasil.IsDBNull(3) ? -1 : int.Parse(drHasil.GetValue(3).ToString());
                if (tampung.Operator_id_temp == -1)
                {
                    tampung.Operator_id = "";
                } else
                {
                    tampung.Operator_id = tampung.Operator_id_temp.ToString();
                }
                tampung.Harga = int.Parse(drHasil.GetValue(4).ToString());
                tampung.Jawdal_film_id = int.Parse(drHasil.GetValue(5).ToString());
                tampung.Studios_id = int.Parse(drHasil.GetValue(6).ToString());
                tampung.Films_id = int.Parse(drHasil.GetValue(7).ToString());
                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public static bool CariData(string kriteria = "")
        {
            string sql = "SELECT * FROM tikets";

            if (kriteria == "")
            {
                sql += ";";
            }
            else
            {
                sql += " WHERE " + kriteria;
            }

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(sql);
            int ctr = 0;
            while (drHasil.Read())
            {
                ctr += 1;
            }
            return ctr > 0;
        }

        public static void TambahData(Tiket obj)
        {

            string perintah = "INSERT INTO tikets " +
                "(invoices_id, nomor_kursi, status_hadir, harga, jadwal_film_id, studios_id, films_id) VALUES " +
                $"('{obj.Invoices_id}', '{obj.Nomor_kursi}', '{obj.status_hadir}', '{obj.Harga}', '{obj.Jawdal_film_id}', '{obj.Studios_id}', '{obj.Films_id}');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UbahDataHadir(int id_tiket, string nomor_kursi, int operator_id)
        {
            string sql = "UPDATE tikets " +
                $"SET status_hadir = '1', operator_id='{operator_id}' " +
                $"WHERE invoices_id = '{id_tiket}' AND nomor_kursi = '{nomor_kursi}';";
            Console.WriteLine(sql);
            Koneksi.JalankanPerintahNonQuery(sql);
        }
    }
}
