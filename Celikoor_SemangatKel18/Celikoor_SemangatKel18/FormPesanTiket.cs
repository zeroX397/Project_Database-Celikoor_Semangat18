using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_Library;
using static System.Net.WebRequestMethods;

namespace Celikoor_Semangat18
{
    public partial class FormPesanTiket : Form
    {
        List<Cinema> cinemas = new List<Cinema>();
        List<Studio> studios = new List<Studio>();
        List<Film> films = new List<Film>();
        List<Kelompok> kelompoks = new List<Kelompok>();
        List<GenreFilm> genreFilms = new List<GenreFilm>();
        List<AktorFilm> aktorFilms = new List<AktorFilm>();
        public FormPesanTiket()
        {
            InitializeComponent();
            loadAllData();
        }

        private void loadAllData()
        {
            cinemas = Cinema.BacaData();
            studios = Studio.BacaData();
            films = Film.BacaData();
            kelompoks = Kelompok.BacaData();
            genreFilms = GenreFilm.BacaData();
            aktorFilms = AktorFilm.BacaData();

            comboBoxJudul.DataSource = films;
            comboBoxJudul.DisplayMember = "judul";
            comboBoxJudul.ValueMember = "id";
            comboBoxJudul.SelectedIndex = 0;

            comboBoxCinema.DataSource = cinemas;
            comboBoxCinema.DisplayMember = "nama_cabang";
            comboBoxCinema.ValueMember = "id";
            comboBoxJudul.SelectedIndex = 0;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                MessageBox.Show($"Kursi {checkBox.Text} telah dipesan");
            }
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxJudul.SelectedIndex != -1)
            {
                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                setDeskripsiFilm(selectedFilm);
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
            textAkotorUtama.Text = setAktorFilm(film.Id.ToString());
            textGenre.Text = setGenreFilm(film.Id.ToString());
            textKelompok.Text = setKelompokFilm(film.Id.ToString());
        }


        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxCinema.SelectedIndex != -1)
            {
                Cinema selectedCinema = (Cinema)comboBoxCinema.SelectedItem;

                List<Studio> selectedStudio = new List<Studio>();
                foreach (Studio studio in studios)
                {
                    if (studio.CinemaId == selectedCinema.Id)
                    {
                        selectedStudio.Add(studio);
                    }
                }

                if (selectedStudio.Count == 0)
                {
                    MessageBox.Show("Tidak ada studio di cinema ini");
                    return;
                }

                comboBoxStudio.DataSource = selectedStudio;
                comboBoxStudio.DisplayMember = "nama";
                comboBoxStudio.ValueMember = "id";
                comboBoxStudio.SelectedIndex = 0;
                setDeskripsiStudio(selectedStudio[0]);
            }
        }

        private void setDeskripsiStudio(Studio studio)
        {
            textJenisStudio.Text = studio.JenisStudioNama;
            textKursi.Text = studio.Kapasitas.ToString() + " Kursi";
            textSisaKursi.Text = "(sisa " + studio.Kapasitas.ToString() + " kursi)";
            textHarga.Text = "Rp " + studio.HargaWeekday.ToString();
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudio.SelectedIndex != -1 && comboBoxJudul.SelectedIndex != -1)
            {
                Studio selectedStudio = (Studio)comboBoxStudio.SelectedItem;
                setDeskripsiStudio(selectedStudio);
                generateKursi(selectedStudio.Kapasitas);
            }
        }
        private void generateKursi(int jumlahKursi)
        {
            List<string> listHuruf = new List<string>() { "A", "B", "C" };

            for (int i = 0; i < listHuruf.Count; i++)
            {
                for (int j = 0; j < jumlahKursi / 12; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        CheckBox checkBox = new CheckBox();
                        int seatNumber = (k + 1) + (j * 4);
                        checkBox.Name = $"checkBox{listHuruf[i]}{seatNumber}";
                        checkBox.Text = $"{listHuruf[i]}{seatNumber}";
                        checkBox.BackColor = Color.SlateBlue;
                        checkBox.ForeColor = Color.White;
                        checkBox.Size = new Size(50, 12);
                        checkBox.Checked = false;
                        checkBox.Location = new Point(315 + (k * 50) + (i * 250), 220 + (j * 25));
                        checkBox.CheckedChanged += checkBox_CheckedChanged;
                        this.Controls.Add(checkBox);
                        checkBox.BringToFront();
                    }

                }
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

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }
    }
}
