using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Kelompok
    {
        private int id;
        private string nama;

        public Kelompok(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public Kelompok()
        {
            Id = 0;
            Nama = "";
        }
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public static void TambahData(Kelompok obj)
        {
            string perintah = "INSERT INTO kelompoks " + "(id, nama) VALUES " + "('" + obj.Id + "', '" + obj.Nama + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static List<Kelompok> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT * from kelompoks";
            }
            else
            {
                perintah = "SELECT * from kelompoks " +
                    "where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Kelompok> listHasil = new List<Kelompok>();

            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                Kelompok tampung = new Kelompok();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();

                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}
