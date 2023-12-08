using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Semangat18
{
    class Tiket
    {
        public enum statusTiket
        {
            PROSES,
            KONFIRM
        }

        public class Tiket
        {
            private int id;
            private DateTime tglBeli;
            private int slotJadwal;
            private int ruangBioskop;
            private int noKursi;
            private Film dataFilm;
            private Konsumen user;
            private statusTiket status;

            public Tiket()
            {
                Id = 0;
                TglBeli = DateTime.Now;
                SlotJadwal = 0;
                RuangBioskop = 0;
                NoKursi = 0;
                DataFilm = new Film();
                User = new Konsumen();
                Status = statusTiket.PROSES;
            }

            public Tiket(int id, string tglBeli, int slotJadwal, int ruangBioskop, int noKursi, Film dataFilm, Konsumen user, statusTiket status)
            {
                Id = id;
                TglBeli = DateTime.Parse(tglBeli);
                SlotJadwal = slotJadwal;
                RuangBioskop = ruangBioskop;
                NoKursi = noKursi;
                DataFilm = dataFilm;
                User = user;
                Status = status;
            }

            public int Id { get => id; set => id = value; }
            public DateTime TglBeli { get => tglBeli; set => tglBeli = value; }
            public int SlotJadwal { get => slotJadwal; set => slotJadwal = value; }
            public int RuangBioskop { get => ruangBioskop; set => ruangBioskop = value; }
            public int NoKursi { get => noKursi; set => noKursi = value; }
            public Film DataFilm { get => dataFilm; private set => dataFilm = value; }
            public Konsumen User { get => user; private set => user = value; }
            public statusTiket Status { get => status; set => status = value; }

            public static List<Tiket> BacaData(string kriteria, string nilaiKriteria)
            {
                string sql = "SELECT t.id as tiketID, t.tgl_beli, t.slot_jadwal, t.no_kursi, t.ruang_bioskop, t.films_id, t.pembelis_id, t.status, f.judul_film, u.nama " +
                    " FROM tikets t " +
                    " INNER JOIN films f ON f.id=t.films_id " +
                    " INNER JOIN penggunas u ON u.id=t.pembelis_id";

                if (kriteria == "")
                {
                    sql += ";";
                }
                else
                {
                    sql += " WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%';";
                }

                MySqlDataReader result = Koneksi.JalankanQuery(sql);

                List<Tiket> tiketList = new List<Tiket>();

                while (result.Read())
                {
                    Film tmpFilm = new Film();
                    tmpFilm.Id = result.GetInt32("films_id");
                    tmpFilm.Judul = result.GetString("judul_film");

                    Konsumen tmpUser = new Konsumen();
                    tmpUser.Id = result.GetInt32("pembelis_id");
                    tmpUser.Nama = result.GetString("nama");

                    Tiket tmp = new Tiket(result.GetInt32("tiketID"),
                        result.GetString("tgl_beli"),
                        result.GetInt32("slot_jadwal"),
                        result.GetInt32("ruang_bioskop"),
                        result.GetInt32("no_kursi"),
                        tmpFilm, tmpUser,
                        (result.GetString("status") == "PROSES" ? statusTiket.PROSES : statusTiket.KONFIRM));

                    tiketList.Add(tmp);
                }

                return tiketList;
            }

            public static List<Tiket> DaftarTiket(int pembeliID, string kriteria, string nilaiKriteria)
            {
                string sql = "SELECT t.id as tiketID, t.tgl_beli, t.slot_jadwal, t.no_kursi, t.ruang_bioskop, t.films_id, t.pembelis_id, t.status, f.judul_film, u.nama " +
                    " FROM tikets t " +
                    " INNER JOIN films f ON f.id=t.films_id " +
                    " INNER JOIN penggunas u ON u.id=t.pembelis_id " +
                    " WHERE t.pembelis_id=" + pembeliID;

                if (kriteria == "")
                {
                    sql += ";";
                }
                else
                {
                    sql += " AND " + kriteria + " LIKE '%" + nilaiKriteria + "%';";
                }

                MySqlDataReader result = Koneksi.JalankanQuery(sql);

                List<Tiket> tiketList = new List<Tiket>();

                while (result.Read())
                {
                    Film tmpFilm = new Film();
                    tmpFilm.Id = result.GetInt32("films_id");
                    tmpFilm.Judul = result.GetString("judul_film");

                    Konsumen tmpUser = new Pengguna();
                    tmpUser.Id = result.GetInt32("pembelis_id");
                    tmpUser.Nama = result.GetString("nama");

                    Tiket tmp = new Tiket(result.GetInt32("tiketID"),
                        result.GetString("tgl_beli"),
                        result.GetInt32("slot_jadwal"),
                        result.GetInt32("ruang_bioskop"),
                        result.GetInt32("no_kursi"),
                        tmpFilm, tmpUser,
                        (result.GetString("status") == "PROSES" ? statusTiket.PROSES : statusTiket.KONFIRM));

                    tiketList.Add(tmp);
                }

                return tiketList;
            }

            public static bool IsAvailable(Tiket tiket)
            {
                string sql = "SELECT id, tgl_beli, slot_jadwal, no_kursi, ruang_bioskop, films_id, pembelis_id, status " +
                    " FROM tikets " +
                    " WHERE films_id=" + tiket.DataFilm.Id + " AND slot_jadwal=" + tiket.SlotJadwal + " AND ruang_bioskop=" + tiket.RuangBioskop + " AND no_kursi=" + tiket.NoKursi + ";";

                MySqlDataReader result = Koneksi.JalankanQuery(sql);
                if (result.Read())
                {
                    return false;
                }
                return true;
            }

            public static bool InsertTiket(Tiket tiket)
            {
                if (!IsAvailable(tiket))
                {
                    throw new Exception("No kursi yang dipilih telah dibeli, silahkan pilih no kursi yang lain.");
                }

                string sql = "INSERT INTO tikets(tgl_beli, slot_jadwal, no_kursi, ruang_bioskop, films_id, pembelis_id, status) " +
                    " VALUES (NOW()," + tiket.SlotJadwal + "," + tiket.NoKursi + "," + tiket.RuangBioskop + "," + tiket.DataFilm.Id + "," + tiket.User.Id + ",'PROSES');";

                if (Koneksi.ExecuteDML(sql))
                {
                    return true;
                }

                return false;
            }

            public static bool ConfirmTiket(Tiket tiket)
            {
                string sql = "UPDATE tikets " +
                    " SET status='KONFIRM' " +
                    " WHERE id=" + tiket.Id + ";";

                if (Koneksi.ExecuteDML(sql))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
