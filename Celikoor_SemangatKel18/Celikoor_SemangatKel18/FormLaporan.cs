using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
