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
    public partial class FormInvoice : Form
    {
        private Invoices invoiceUpdate;
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            List<Invoices> listHasil = Invoices.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "tanggal", "grand_total", "tdiskon_nominal", "konsumen", "kasir_id", "status" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices();
            invoice.Status = "VALIDASI";
            
            string kode = dataGridView1.CurrentRow.Cells["status"].Value.ToString();
            DialogResult dr = MessageBox.Show("Ingin ubah status " + kode + "?", "UBAH", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) //jika user setuju hapus data
            {
                try
                {
                    //ubah data dari database
                    Invoices.UbahData(invoiceUpdate.Id, invoice);
                    //refresh form master
                    FormInvoice_Load(this, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                }
            }
        }
    }
}
