<<<<<<< HEAD
﻿using MySql.Data.MySqlClient;
=======
﻿using Celikoor_Semangat18;
using MySql.Data.MySqlClient;
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
=======

>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
namespace Celikoor_Library
{
    public class Studio
    {
<<<<<<< HEAD
        #region DATAMEMBERS
        private int id;
        private string nama;
        private int kapasitas;
        private int jenis_studio_id;
        private int cinema_id;
        private int harga_weekday;
        private int harga_weekend;

    
        #endregion

        #region CONSTRUCTORS
=======
        private int id;
        private string nama;
        private int kapasitas;
        private JenisStudio jenisstud;
        private Cinema cinema;
        private int hargaWeekday;
        private int hargaWeekend;
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351

        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
<<<<<<< HEAD
            Jenis_studio_id = 0;
            Cinema_id = 0;
            Harga_weekday = 0;
            Harga_weekend = 0;
        }

        public Studio(int id, string nama, int kapasitas, int jenis_studio_id, int cinema_id, int harga_weekday, int harga_weekend)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
            this.Jenis_studio_id = jenis_studio_id;
            this.Cinema_id = cinema_id;
            this.Harga_weekday = harga_weekday;
            this.Harga_weekend = harga_weekend;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public int Jenis_studio_id { get => jenis_studio_id; set => jenis_studio_id = value; }
        public int Cinema_id { get => cinema_id; set => cinema_id = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }
        #endregion

        #region METHODS
        public static void TambahData(Studio obj)
        {
            //something new: 
            //obj.Tgllahir.ToString("YYYY-MM-dd") --> unt mengubah ke format yang diterima oleh mysql
            //obj.Posisi.Id --> mengambil ID dari posisi yang dimiliki oleh pegawai

            string perintah = "INSERT INTO studios " +
                " nama, kapasitas, jenis_studio_id, cinema_id, harga_weekday, harga_weekend) VALUES " + 
                "('" + obj.Nama + "', '" + obj.kapasitas + "', '" + obj.jenis_studio_id + "', '" +
                    obj.cinema_id + "', '" + obj.harga_weekday + "', '" + obj.harga_weekend + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(int KodeHapus)
        {
            string perintah = "DELETE FROM studios WHERE id = '" + KodeHapus.ToString() + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Studio> BacaData()
        {
            string perintah = "SELECT * from studios";
            //if (filter != "")
            //    perintah = " " +
            //        "where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Studio> listHasil = new List<Studio>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                //pindah isi datareader ke penampung sementara
                Studio tampung = new Studio();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.nama = drHasil.GetValue(1).ToString();
                tampung.kapasitas = int.Parse(drHasil.GetValue(2).ToString());
                tampung.jenis_studio_id = int.Parse(drHasil.GetValue(3).ToString());
                tampung.cinema_id = int.Parse(drHasil.GetValue(4).ToString());
                tampung.harga_weekday = int.Parse(drHasil.GetValue(5).ToString());
                tampung.harga_weekend = int.Parse(drHasil.GetValue(6).ToString());
=======
            Jenisstud = new JenisStudio();
            Cinema = new Cinema();
            HargaWeekday = 0;
            HargaWeekend = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public JenisStudio Jenisstud { get => jenisstud; set => jenisstud = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public int HargaWeekday { get => hargaWeekday; set => hargaWeekday = value; }
        public int HargaWeekend { get => hargaWeekend; set => hargaWeekend = value; }

        public static List<Studio> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on s.id = js.id inner join cinemas c on s.id = c.id;";
                //SELECT p.*, j.nama FROM pegawai p inner join jabatan j on p.idjabatan = j.idjabatan;
            }
            else
            {
                perintah = "select s.*, js.nama, c.nama_cabang from studios s inner join jenis_studios js on s.id = js.jenis_studios.id inner join cinemas c on s.id = c.cinemas.id where " + filter + " like '%" + nilai + "%'";
                //"SELECT p.*, j.nama FROM pegawai p inner join jabatan j on p.idjabatan=j.idjabatan where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Studio> listHasil = new List<Studio>();

            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                Studio tampung = new Studio();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(drHasil.GetValue(2).ToString());

                JenisStudio js = new JenisStudio();
                js.ID = int.Parse(drHasil.GetValue(3).ToString());
                js.Nama = drHasil.GetValue(4).ToString();

                Cinema c = new Cinema();
                c.Id = int.Parse(drHasil.GetValue(5).ToString());
                c.Nama_cabang = drHasil.GetValue(6).ToString();

                tampung.HargaWeekday = int.Parse(drHasil.GetValue(7).ToString());
                tampung.HargaWeekend = int.Parse(drHasil.GetValue(8).ToString());

                tampung.Jenisstud = js;
                tampung.Cinema = c;

>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
                listHasil.Add(tampung);
            }
            return listHasil;
        }
<<<<<<< HEAD
        #endregion
=======
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
    }
}
