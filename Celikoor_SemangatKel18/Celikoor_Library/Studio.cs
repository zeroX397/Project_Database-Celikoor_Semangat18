using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Studio
    {
        private int id;
        private string nama;
        private int kapasitas;
        private int jenisStudioId;
        private string jenisStudioNama;
        private int cinemaId;
        private string cinemaNama;
        private int hargaWeekday;
        private int hargaWeekend;

        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
            JenisStudioId = 0;
            JenisStudioNama = "";
            CinemaId = 0;
            CinemaNama = "";
            HargaWeekday = 0;
            HargaWeekend = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public int JenisStudioId { get => jenisStudioId; set => jenisStudioId = value; }
        public string JenisStudioNama { get => jenisStudioNama; set => jenisStudioNama = value; }
        public int CinemaId { get => cinemaId; set => cinemaId = value; }
        public string CinemaNama { get => cinemaNama; set => cinemaNama = value; }
        public int HargaWeekday { get => hargaWeekday; set => hargaWeekday = value; }
        public int HargaWeekend { get => hargaWeekend; set => hargaWeekend = value; }

        public static List<Studio> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "" || nilai == "")
            {
                perintah = "select s.*, js.nama, c.nama_cabang from studios s left join jenis_studios js on s.jenis_studios_id = js.id left join cinemas c on s.cinemas_id = c.id;";
            }
            else
            {
                perintah = "select s.*, js.nama, c.nama_cabang from studios s left join jenis_studios js on s.jenis_studios_id = js.id left join cinemas c on s.cinemas_id = c.id " +
                    "where s." + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Studio> listHasil = new List<Studio>();

            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                Studio tampung = new Studio();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(drHasil.GetValue(2).ToString());
                tampung.JenisStudioId = int.Parse(drHasil.GetValue(3).ToString());
                tampung.cinemaId =  int.Parse(drHasil.GetValue(4).ToString());
                tampung.HargaWeekday = int.Parse(drHasil.GetValue(5).ToString());
                tampung.HargaWeekend = int.Parse(drHasil.GetValue(6).ToString());
                tampung.jenisStudioNama = drHasil.GetValue(7).ToString();
                tampung.cinemaNama = drHasil.GetValue(8).ToString();

                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(Studio studios)
        {
            string perintah = "INSERT INTO studios (nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) VALUES ("+
                $"'{studios.Nama}', '{studios.kapasitas}', '{studios.jenisStudioId}', '{studios.cinemaId}', '{studios.hargaWeekday}', '{studios.hargaWeekend}');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UbahData(int id_studio, Studio obj)
        {
            string sql = "UPDATE studios " +
                $"SET nama = '{obj.nama}', " +
                $"kapasitas = '{obj.kapasitas}', " +
                $"jenis_studios_id = '{obj.JenisStudioId}', " +
                $"cinemas_id = '{obj.cinemaId}', " +
                $"harga_weekday = '{obj.hargaWeekday}', " +
                $"harga_weekend = '{obj.hargaWeekend}' " +
                $"WHERE id = '{id_studio}';";
            Console.WriteLine(sql);
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from studios where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        }
    }
}
