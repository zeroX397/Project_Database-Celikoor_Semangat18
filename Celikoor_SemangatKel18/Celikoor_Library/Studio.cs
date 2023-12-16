using Celikoor_Semangat18;
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
        private JenisStudio jenisstud;
        private Cinema cinema;
        private int hargaWeekday;
        private int hargaWeekend;

        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
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

                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}
