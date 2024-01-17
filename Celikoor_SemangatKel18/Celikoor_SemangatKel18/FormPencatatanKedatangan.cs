using Celikoor_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Semangat18
{
    public partial class FormPencatatanKedatangan : Form
    {
        private int operator_id = 0;
        public FormPencatatanKedatangan(int operator_id)
        {
            InitializeComponent();
            this.operator_id = operator_id;
            loadData();
        }

        private void loadData()
        {
            List<Tiket> tikets = Tiket.BacaData();
            dataGridView1.DataSource = tikets;
            dataGridView1.Columns["status_hadir_int"].Visible = false;
            dataGridView1.Columns["operator_id_temp"].Visible = false;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string barcode = textBoxCari.Text;
            if (barcode.Length != 6)
            {
                MessageBox.Show("Format Barcode salah!");
                return;
            }

            try
            {
                int invoice_id = int.Parse(barcode.Substring(0, 3));
                string seat_name = barcode.Substring(3, 3);
                if (Tiket.CariData($"invoices_id='{invoice_id}' AND nomor_kursi='{seat_name}'") == false)
                {
                    MessageBox.Show("Data Barcode tidak ditemukan!");
                    return;
                }

                Tiket.UbahDataHadir(invoice_id, seat_name, this.operator_id);
                MessageBox.Show("Berhasil mencatat Kedatangan!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalah mencatat Kedatangan, "+ex.Message);
            }
        }

        private void FormPencatatanKedatangan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
