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
    public partial class FormTambahStudio : Form
    {
        private bool isTambah = true;
        private Studio studioUpdate;
        public FormTambahStudio()
        {
            InitializeComponent();
            loadComboBoxJenisStudio();
            loadComboBoxCinema();
        }
        public FormTambahStudio(Studio studioUpdate)
        {
            InitializeComponent();
            List<JenisStudio> jenisStudio = loadComboBoxJenisStudio();
            List<Cinema> cinemas = loadComboBoxCinema();
            isTambah = false;
            this.studioUpdate = studioUpdate;

            label2.Text = "U B A H  S T U D I O";
            // load jenis studio
            int selectedJenisStudioIndex = jenisStudio.FindIndex(item => item.ID == studioUpdate.JenisStudioId);
            if (selectedJenisStudioIndex != -1) comboBoxJenisStudio.SelectedIndex = selectedJenisStudioIndex;
            else  comboBoxJenisStudio.SelectedIndex = 0;


            // load cinemas
            int selectedCinemasIndex = cinemas.FindIndex(item => item.Id == studioUpdate.CinemaId);
            if (selectedCinemasIndex != -1) comboBoxCinema.SelectedIndex = selectedCinemasIndex;
            else  comboBoxCinema.SelectedIndex = 0;

            textBoxId.Text = studioUpdate.Id.ToString();
            textBoxNama.Text = studioUpdate.Nama;
            textBoxKapasitas.Text = studioUpdate.Kapasitas.ToString();
            textBoxHargaWeekday.Text = studioUpdate.HargaWeekday.ToString();
            textBoxHargaWeekend.Text = studioUpdate.HargaWeekend.ToString();
        }
        private List<JenisStudio> loadComboBoxJenisStudio()
        {
            List<JenisStudio> jenisStudio = JenisStudio.BacaData();
            comboBoxJenisStudio.DataSource = jenisStudio;
            comboBoxJenisStudio.SelectedIndex = 0;
            comboBoxJenisStudio.DisplayMember = "nama";
            comboBoxJenisStudio.ValueMember = "id";
            return jenisStudio;
        }
        private List<Cinema> loadComboBoxCinema()
        {
            List<Cinema> cinema = Cinema.BacaData();
            comboBoxCinema.DataSource = cinema;
            comboBoxCinema.SelectedIndex = 0;
            comboBoxCinema.DisplayMember = "nama_cabang";
            comboBoxCinema.ValueMember = "id";
            return cinema;
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Studio p = new Studio();
                
                p.Nama = textBoxNama.Text;
                p.JenisStudioId = int.Parse(comboBoxJenisStudio.SelectedValue.ToString());
                p.CinemaId = int.Parse(comboBoxCinema.SelectedValue.ToString());
                p.Kapasitas = int.Parse(textBoxKapasitas.Text);
                p.HargaWeekday = int.Parse(textBoxHargaWeekday.Text);
                p.HargaWeekend = int.Parse(textBoxHargaWeekend.Text);

                //tambahkan ke database:
                if (isTambah)
                {
                    Studio.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Studio.UbahData(studioUpdate.Id, p);
                    MessageBox.Show("Ubah Data berhasil");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
