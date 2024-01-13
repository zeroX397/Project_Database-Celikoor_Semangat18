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
    public partial class FormTambahKelompok : Form
    {
        private bool isTambah = true;
        private Kelompok kelompokUpdate;
        public FormTambahKelompok()
        {
            InitializeComponent();
        }
        public FormTambahKelompok(Kelompok kelompokUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.kelompokUpdate = kelompokUpdate;

            textBoxId.Text = kelompokUpdate.Id.ToString();
            textBoxNama.Text = kelompokUpdate.Nama;
        }


        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Kelompok p = new Kelompok();
                
                p.Nama = textBoxNama.Text;

                //tambahkan ke database:
                if (isTambah)
                {
                    Kelompok.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Kelompok.UbahData(kelompokUpdate.Id, p);
                    MessageBox.Show("Ubah Data berhasil");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
