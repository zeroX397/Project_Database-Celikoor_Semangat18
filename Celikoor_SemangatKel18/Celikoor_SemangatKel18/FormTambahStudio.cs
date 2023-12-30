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
        public FormTambahStudio()
        {
            InitializeComponent();
            loadComboBoxJenisStudio();
            loadComboBoxCinema();
        }
        private void loadComboBoxJenisStudio()
        {
            List<JenisStudio> jenisStudio = JenisStudio.BacaData();
            comboBoxJenisStudio.DataSource = jenisStudio;
            comboBoxJenisStudio.SelectedIndex = 0;
            comboBoxJenisStudio.DisplayMember = "nama";
            comboBoxJenisStudio.ValueMember = "id";


        }
        private void loadComboBoxCinema()
        {

            List<Cinema> cinema = Cinema.BacaData();
            comboBoxCinema.DataSource = cinema;
            comboBoxCinema.SelectedIndex = 0;
            comboBoxCinema.DisplayMember = "nama_cabang";
            comboBoxCinema.ValueMember = "id";

        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Studio p = new Studio();
                
                p.Nama = textBoxNama.Text;
                p.Cinema = (Cinema)Enum.Parse(typeof(Cinema), comboBoxCinema.SelectedValue.ToString());
                p.Kapasitas = int.Parse(textBoxKapasitas.Text);
                p.Jenisstud = (JenisStudio)Enum.Parse(typeof(JenisStudio), comboBoxJenisStudio.SelectedValue.ToString());
                p.HargaWeekday = int.Parse(textBoxHargaWeekday.Text);
                p.HargaWeekend = int.Parse(textBoxHargaWeekend.Text);




                //tambahkan ke database:
                //Studio.TambahData(p);

                MessageBox.Show("Tambah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal. Error : " + ex.Message);
            }
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
