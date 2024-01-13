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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Celikoor_Semangat18
{
    public partial class FormTambahJadwalFilm : Form
    {
        private bool isTambah = true;
        private JadwalFilm jadwalFilmUpdate;
        public FormTambahJadwalFilm()
        {
            InitializeComponent();
            comboBoxJamPemutaran.SelectedIndex = 0;
        }
        public FormTambahJadwalFilm(JadwalFilm jadwalFilmUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.jadwalFilmUpdate = jadwalFilmUpdate;

            label2.Text = "UBAH JADWAL FILM";
            dateTimePickerTanggal.Value = jadwalFilmUpdate.Tanggal;
            if (jadwalFilmUpdate.Jam_pemutaran == "I")
                comboBoxJamPemutaran.SelectedIndex = 0;
            else if (jadwalFilmUpdate.Jam_pemutaran == "II")
                comboBoxJamPemutaran.SelectedIndex = 1;
            else if (jadwalFilmUpdate.Jam_pemutaran == "III")
                comboBoxJamPemutaran.SelectedIndex = 2;
            else if (jadwalFilmUpdate.Jam_pemutaran == "IV")
                comboBoxJamPemutaran.SelectedIndex = 3;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                JadwalFilm p = new JadwalFilm();
                
                p.Jam_pemutaran = comboBoxJamPemutaran.Text;
                p.Tanggal= dateTimePickerTanggal.Value;

                //tambahkan ke database:
                if (isTambah)
                {
                    JadwalFilm.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    JadwalFilm.UbahData(jadwalFilmUpdate.Id, p);
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
