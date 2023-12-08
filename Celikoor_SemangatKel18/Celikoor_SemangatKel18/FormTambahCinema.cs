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
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Cinema p = new Cinema();
                p.Id = int.Parse(textBoxId.Text);
                p.Nama_cabang = textBoxNama.Text;
                p.Alamat = textBoxAlamat.Text;
                p.Tgl_buka = dateTimePicker1.Value;
                p.Kota = textBoxKota.Text;

                //tambahkan ke database:
                Cinema.TambahData(p);

                MessageBox.Show("Tambah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal. Error : " + ex.Message);
            }
        }
    }
}
