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
        private bool isTambah = true;
        private Cinema cinemaUpdate;
        public FormTambahCinema()
        {
            InitializeComponent();
        }
        public FormTambahCinema(Cinema cinemaUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.cinemaUpdate = cinemaUpdate;

            label2.Text = "U B A H  C I N E M A";
            textBoxId.Text = cinemaUpdate.Id.ToString();
            textBoxNama.Text = cinemaUpdate.Nama_cabang;
            textBoxAlamat.Text = cinemaUpdate.Alamat;
            dateTimePicker1.Value = cinemaUpdate.Tgl_buka;
            textBoxKota.Text = cinemaUpdate.Kota;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Cinema p = new Cinema();
               
                p.Nama_cabang = textBoxNama.Text;
                p.Alamat = textBoxAlamat.Text;
                p.Tgl_buka = dateTimePicker1.Value;
                p.Kota = textBoxKota.Text;

                //tambahkan ke database:
                if (isTambah)
                {
                    Cinema.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Cinema.UbahData(cinemaUpdate.Id, p);
                    MessageBox.Show("Ubah Data berhasil");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxKota_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
