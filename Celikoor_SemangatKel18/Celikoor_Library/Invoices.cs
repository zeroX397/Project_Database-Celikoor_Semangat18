using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Invoices
    {
        #region DATAMEMBERS
        private int id;
        private DateTime tanggal;
        private int grand_total;
        private int diskon_nominal;
        private int konsumens_id;
        private int kasir_id;
        private string status;

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int Grand_total { get => grand_total; set => grand_total = value; }
        public int Diskon_nominal { get => diskon_nominal; set => diskon_nominal = value; }
        public int Konsumens_id { get => konsumens_id; set => konsumens_id = value; }
        public int Kasir_id { get => kasir_id; set => kasir_id = value; }
        public string Status { get => status; set => status = value; }
        #endregion

        #region CONSTRUCTORS
        public Invoices()
        {

        }

        public Invoices(int id, DateTime tanggal, int grand_total, int diskon_nominal, int konsumens_id, int kasir_id, string status)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.Grand_total = grand_total;
            this.Diskon_nominal = diskon_nominal;
            this.Konsumens_id = konsumens_id;
            this.Kasir_id = kasir_id;
            this.Status = status;
        }
        #endregion


        #region METHODS
        public static void TambahData(Invoices obj)
        {

            string perintah = "INSERT INTO invoices " +
                "(tanggal, grand_total, diskon_nominal, konsumens_id, status) VALUES " + 
                $"('{obj.tanggal.ToString("yyyy-MM-dd")}', '{obj.Grand_total}', '{obj.diskon_nominal}', '{obj.konsumens_id}', '{obj.status}');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(int id_invoice, Invoices obj)
        {
            //string sql = "UPDATE invoices " +
            //    $"SET kasir_id= '{obj.nama_cabang}' " +
            //    $"WHERE id='{id_invoice}';";
            //Console.WriteLine(sql);
            //Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static List<Invoices> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
                perintah = "SELECT * from invoices";
            else
                perintah = "SELECT * from invoices where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Invoices> listHasil = new List<Invoices>();
            while (drHasil.Read() == true)
            {
                Invoices tampung = new Invoices();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.tanggal = DateTime.Parse(drHasil.GetValue(1).ToString());
                tampung.Grand_total = int.Parse(drHasil.GetValue(2).ToString());
                tampung.diskon_nominal = int.Parse(drHasil.GetValue(3).ToString());
                tampung.konsumens_id = int.Parse(drHasil.GetValue(4).ToString());
                tampung.kasir_id = drHasil.IsDBNull(5) ? -1 : int.Parse(drHasil.GetValue(5).ToString());
                tampung.status = drHasil.GetValue(6).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        #endregion
    }
}
