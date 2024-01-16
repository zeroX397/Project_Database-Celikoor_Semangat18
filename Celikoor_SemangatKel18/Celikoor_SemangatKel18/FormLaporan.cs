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
            List<Laporan> listHasil = Laporan.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {

        }
    }
}
