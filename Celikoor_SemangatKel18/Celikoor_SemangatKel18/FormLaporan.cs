using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Celikoor_Library;

namespace Celikoor_Semangat18
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void buttonPeringkat_Click(object sender, EventArgs e)
        {
            List<LaporanPeringkatCabang> listHasil = LaporanPeringkatCabang.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {

        }

        private void buttonFilmPenontonTdkHadir_Click(object sender, EventArgs e)
        {
            List<LaporanFilmDgnKetidakhadiran> listHasil = LaporanFilmDgnKetidakhadiran.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void buttonFilmTerlaris_Click(object sender, EventArgs e)
        {
            /*dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            string sql = "SELECT films.judul, SUM(films.id) as total , monthname(invoices.tanggal) as month\r\n" +
                "FROM invoices\r\nINNER JOIN tikets on tikets.invoices_id = invoices.id\r\nINNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id\r\nINNER JOIN films on films.id = sesifilms.films_id\r\nWHERE YEAR(invoices.tanggal) = '2023'\r\nGROUP BY films.judul, month\r\nORDER BY month desc, total desc;\r\n";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(sql);
            dataGridView1.Columns.Add("colJudul", "Judul");
            dataGridView1.Columns.Add("colTotal", "Total");
            dataGridView1.Columns.Add("colMonth", "Month");

            while (hasil.Read())
            {
                dataGridView1.Rows.Add(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());
            }*/
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
