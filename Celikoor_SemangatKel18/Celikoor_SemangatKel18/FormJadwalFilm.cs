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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Celikoor_Semangat18
{
    public partial class FormJadwalFilm : Form
    {
        List<Cinema> cinemas = new List<Cinema>();
        List<Studio> studios = new List<Studio>();
        List<JenisStudio> jenisStudios = new List<JenisStudio>();
        List<FilmStudio> filmStudios = new List<FilmStudio>();
        List<Film> films = new List<Film>();
        List<Kelompok> kelompoks = new List<Kelompok>();
        List<GenreFilm> genreFilms = new List<GenreFilm>();
        List<AktorFilm> aktorFilms = new List<AktorFilm>();
        List<JadwalPemutaranFilm> jadwalPemutaranFilm = new List<JadwalPemutaranFilm>();
        public FormJadwalFilm()
        {
            InitializeComponent();
            loadAllData();
            loadJadwalFilm();
        }

        private void loadAllData()
        {
            cinemas = Cinema.BacaData();
            comboBoxCinema.DataSource = cinemas;
            comboBoxCinema.DisplayMember = "nama_cabang";
            comboBoxCinema.ValueMember = "id";
            comboBoxCinema.ResetText();
            comboBoxCinema.SelectedIndex = -1;

            studios = Studio.BacaData();
            jenisStudios = JenisStudio.BacaData();
            filmStudios = FilmStudio.BacaData();
            films = Film.BacaData();
            kelompoks = Kelompok.BacaData();
            genreFilms = GenreFilm.BacaData();
            aktorFilms = AktorFilm.BacaData();
        }

        private void loadJadwalFilm()
        {
            jadwalPemutaranFilm = JadwalPemutaranFilm.BacaData();
            dataGridView1.DataSource = jadwalPemutaranFilm;
        }

        private void comboBoxCinema_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCinema.SelectedIndex != -1)
            {
                Cinema selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
                List<Studio> selectedStudios = new List<Studio>();
                foreach (Studio studio in studios)
                {
                    if (studio.CinemaId == selectedCinema.Id)
                    {
                        foreach (JenisStudio jenisStudio in jenisStudios)
                        {
                            if (jenisStudio.ID == studio.JenisStudioId)
                            {
                                studio.JenisStudioNama = jenisStudio.Nama;
                                break;
                            }
                        }
                        selectedStudios.Add(studio);
                    }
                }

                if (selectedStudios.Count == 0)
                {
                    MessageBox.Show("Tidak ada studio di cinema ini");
                    return;
                }

                comboBoxStudio.DataSource = selectedStudios;
                comboBoxStudio.DisplayMember = "nama";
                comboBoxStudio.ValueMember = "id";
                comboBoxStudio.SelectedIndex = 0;

                setDeskripsiStudio(studios[0]);
            }
        }

        private void setDeskripsiStudio(Studio studio)
        {
            textJenisStudio.Text = studio.JenisStudioNama;
            textKapasitas.Text = studio.Kapasitas.ToString() + " Kursi";
            textHargaWeekday.Text = "Rp " + studio.HargaWeekday.ToString();
            textHargaWeekend.Text = "Rp " + studio.HargaWeekend.ToString();
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudio.SelectedIndex != -1)
            {
                Studio selectedStudio = (Studio)comboBoxStudio.SelectedItem;
                setDeskripsiStudio(selectedStudio);

                List<Film> selectedFilms = new List<Film>();
                foreach (FilmStudio filmstudio in filmStudios)
                {
                    if (filmstudio.Studios_id == selectedStudio.Id)
                    {
                        foreach (Film film in films)
                        {
                            if (film.Id == filmstudio.Films_id)
                            {
                                selectedFilms.Add(film);
                                break;
                            }
                        }
                    }
                }

                if (selectedFilms.Count == 0)
                {
                    MessageBox.Show("Tidak ada film di studio ini");
                    return;
                }

                comboBoxJudul.DataSource = selectedFilms;
                comboBoxJudul.DisplayMember = "judul";
                comboBoxJudul.ValueMember = "id";
                comboBoxJudul.SelectedIndex = 0;

                setDeskripsiFilm(films[0]);
            }
        }

        private void setDeskripsiFilm(Film film)
        {
            if (film.Cover_image != "")
            {
                //pictureBox1. = film.Cover_image;
            }

            textSinopsis.Text = film.Sinopsis.ToString();
            textDurasi.Text = film.Durasi.ToString();
            textAktor.Text = setAktorFilm(film.Id.ToString());
            textGenre.Text = setGenreFilm(film.Id.ToString());
            textKelompok.Text = setKelompokFilm(film.Id.ToString());
        }

        private void comboBoxJudul_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxJudul.SelectedIndex != -1)
            {
                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                setDeskripsiFilm(selectedFilm);
            }
        }

        private string setAktorFilm(string film_id)
        {
            string aktorsString = "";
            int aktorCtr = 0;
            foreach (AktorFilm aktorFilm in aktorFilms)
            {
                if (aktorFilm.Films_id.ToString() == film_id)
                {
                    if (aktorCtr >= 2)
                    {
                        aktorsString += "...";
                        break;
                    }
                    aktorsString += aktorFilm.Aktors_nama + ", ";
                    aktorCtr += 1;

                }
            }
            return aktorsString;
        }

        private string setGenreFilm(string film_id)
        {
            string genresString = "";
            int genreCtr = 0;
            foreach (GenreFilm genreFilm in genreFilms)
            {
                if (genreFilm.Films_id.ToString() == film_id)
                {
                    if (genreCtr >= 2)
                    {
                        genresString += "...";
                        break;
                    }
                    genresString += genreFilm.Genres_nama + ", ";
                    genreCtr += 1;

                }
            }
            return genresString;
        }

        private string setKelompokFilm(string kelompok_id)
        {
            foreach (Kelompok kelompok in kelompoks)
            {
                if (kelompok.Id.ToString() == kelompok_id)
                {
                    return kelompok.Nama;
                }
            }
            return "";
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void FormPesanTiket_Load(object sender, EventArgs e)
        {
            //List<Film> listFilm = Film.BacaData();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if ((!rbJamI.Checked && !rbJamII.Checked && !rbJamIII.Checked && !rbJamIV.Checked) ||
                comboBoxCinema.SelectedIndex == -1 || comboBoxStudio.SelectedIndex == -1 || 
                comboBoxJudul.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon isi data terlebih dahulu");
                return;
            }

            try
            {
                // Tambah ke Jadwal Film
                JadwalFilm jadwalFilm = new JadwalFilm();
                jadwalFilm.Tanggal = dateTimePickerTanggal.Value;
                if (rbJamI.Checked) jadwalFilm.Jam_pemutaran = "I";
                else if (rbJamII.Checked) jadwalFilm.Jam_pemutaran = "II";
                else if (rbJamIII.Checked) jadwalFilm.Jam_pemutaran = "III";
                else if (rbJamIV.Checked) jadwalFilm.Jam_pemutaran = "IV";

                JadwalFilm.TambahData(jadwalFilm);

                List<JadwalFilm> jadwalFilms = JadwalFilm.BacaData();
                JadwalFilm latestJadwalFilm = jadwalFilms[jadwalFilms.Count - 1];

                // Tambah ke Sesi Film
                SesiFilm sesiFilm = new SesiFilm();
                sesiFilm.Jadwal_films_id = latestJadwalFilm.Id;
                sesiFilm.Studios_id = ((Studio)comboBoxStudio.SelectedItem).Id;
                sesiFilm.Films_id = ((Film)comboBoxJudul.SelectedItem).Id;
                SesiFilm.TambahData(sesiFilm);

                MessageBox.Show("Berhasil menambahkan Jadwal Film");
                loadJadwalFilm();
            } catch (Exception ex)
            {
                MessageBox.Show("Ada masalah menambahkan data, ", ex.Message);
            }
        }
    }
}
