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
    public partial class FormTambahFilm : Form
    {
        private bool isTambah = true;
        private Film filmUpdate;
        public FormTambahFilm()
        {
            InitializeComponent();
            loadComboBoxKelompok();
        }
        public FormTambahFilm(Film filmUpdate)
        {
            InitializeComponent();
            List<Kelompok> kelommpoks = loadComboBoxKelompok();
            isTambah = false;
            this.filmUpdate = filmUpdate;

            label2.Text = "U B A H  F I L M";
            textBoxId.Text = filmUpdate.Id.ToString();
            textBoxJudul.Text = filmUpdate.Judul;
            textBoxSinopsis.Text = filmUpdate.Sinopsis;
            textBoxTahun.Text = filmUpdate.Tahun.ToString();
            textBoxDurasi.Text = filmUpdate.Durasi.ToString();

            // load kelompoks
            int selectedKelompoksIndex = kelommpoks.FindIndex(item => item.Id == filmUpdate.Kelompoks_id);
            if (selectedKelompoksIndex != -1) comboBoxKelompok.SelectedIndex = selectedKelompoksIndex;
            else comboBoxKelompok.SelectedIndex = 0;

            List<string> bahasas = new List<string>(){ "CHN", "EN", "ID", "JPN", "KOR", "OTH" };
            int selectedBahasaIndex = bahasas.FindIndex(item => item == filmUpdate.Bahasa);
            if (selectedBahasaIndex != -1) comboBoxBahasa.SelectedIndex = selectedKelompoksIndex;
            else comboBoxBahasa.SelectedIndex = 0;
            textBoxIsSubIndo.Text = filmUpdate.Is_sub_indo.ToString();
            textBoxCoverImage.Text = filmUpdate.Cover_image;
            textBoxDiskonNominal.Text = filmUpdate.Diskon_nominal.ToString();
        }

        private void buttonBatal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<Kelompok> loadComboBoxKelompok()
        {
            List<Kelompok> kelompoks = Kelompok.BacaData();
            comboBoxKelompok.DataSource = kelompoks;
            comboBoxKelompok.SelectedIndex = 0;
            comboBoxKelompok.DisplayMember = "nama";
            comboBoxKelompok.ValueMember = "id";
            comboBoxBahasa.SelectedIndex = 0;
            return kelompoks;
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                Film p = new Film();
                //buat objek penampung 
                p.Judul = textBoxJudul.Text;
                p.Sinopsis = textBoxSinopsis.Text;
                p.Tahun = int.Parse(textBoxTahun.Text);
                p.Durasi = int.Parse(textBoxDurasi.Text);
                p.Kelompoks_id = int.Parse(comboBoxKelompok.SelectedValue.ToString());
                p.Bahasa = comboBoxBahasa.SelectedItem.ToString();
                p.Is_sub_indo = int.Parse(textBoxIsSubIndo.Text);
                p.Cover_image = textBoxCoverImage.Text;
                p.Diskon_nominal = int.Parse(textBoxDiskonNominal.Text);

                //tambahkan ke database:
                if (isTambah)
                {
                    Film.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                }
                else
                {
                    Film.UbahData(filmUpdate.Id, p);
                    MessageBox.Show("Ubah Data berhasil");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }
    }
}
