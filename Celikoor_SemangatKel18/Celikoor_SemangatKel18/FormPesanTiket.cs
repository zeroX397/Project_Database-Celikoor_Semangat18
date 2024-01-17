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
        List<SesiFilm> sesiFilms = new List<SesiFilm>();
        List<SesiFilm> selectedSesiFilms = new List<SesiFilm>();
        List<Tiket> kursiTerpesan = new List<Tiket>();
        Konsumen konsumenLogin;
        Pegawai adminLogin;

        int hargaTiketSatuan = 0;
        List<string> kursiDiambil = new List<string>();
        int totalHarga = 0;
        int diskon = 0;
        int saldo = 0;
        int totalAkhir = 0;

        bool finishLoad = false;

        public FormPesanTiket(Konsumen konsumenLogin)
        {
            InitializeComponent();
            this.konsumenLogin = konsumenLogin;
            this.saldo = konsumenLogin.Saldo_Konsumen;
            loadAllData();
            setInvoiceDetail();
        }
        public FormPesanTiket(Pegawai adminLogin)
        {
            InitializeComponent();
            this.adminLogin = adminLogin;
            this.saldo = 0;
            loadAllData();
            setInvoiceDetail();
        }

        private void loadAllData()
        {
            cinemas = Cinema.BacaData();
            studios = Studio.BacaData();
            films = Film.BacaData();
            kelompoks = Kelompok.BacaData();
            genreFilms = GenreFilm.BacaData();
            aktorFilms = AktorFilm.BacaData();
            sesiFilms = SesiFilm.BacaData();

            comboBoxJudul.DataSource = films;
            comboBoxJudul.DisplayMember = "judul";
            comboBoxJudul.ValueMember = "id";
            comboBoxJudul.ResetText();
            comboBoxJudul.SelectedIndex = -1;
            finishLoad = true;
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            if (finishLoad && comboBoxJudul.SelectedIndex != -1)
            {
                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                setDeskripsiFilm(selectedFilm);

                // find available Cinema by Film
                List<Cinema> selectedCinemas = findAvailableCinema(selectedFilm);
                if (selectedCinemas.Count == 0) {
                    MessageBox.Show("Film tidak diputar dimana-mana");
                    return;
                }

                comboBoxCinema.DataSource = selectedCinemas;
                comboBoxCinema.DisplayMember = "nama_cabang";
                comboBoxCinema.ValueMember = "id";
                comboBoxCinema.SelectedIndex = 0;
            }
        }

        private List<Cinema> findAvailableCinema(Film selectedFilm) 
        {
            List<Cinema> selectedCinema = new List<Cinema>();
            selectedSesiFilms = new List<SesiFilm>();
            foreach (SesiFilm sesiFilm in sesiFilms)
            {
                if (sesiFilm.Films_id == selectedFilm.Id) 
                {
                    selectedSesiFilms.Add(sesiFilm);
                    foreach (Studio studio in studios)
                    {
                        if (studio.Id == sesiFilm.Studios_id)
                        {
                            foreach (Cinema cinema in cinemas)
                            {
                                if (cinema.Id == studio.CinemaId) {
                                    selectedCinema.Add(cinema);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            return selectedCinema;
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
            diskon = film.Diskon_nominal;
        }


        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            if (finishLoad &&  comboBoxJudul.SelectedIndex != -1 && comboBoxCinema.SelectedIndex != -1)
            {
                Cinema selectedCinema = (Cinema)comboBoxCinema.SelectedItem;

                List<Studio> selectedStudio = new List<Studio>();
                foreach (Studio studio in studios)
                {
                    // Studio milik cinema terpilih dan Studio memutar film
                    if (studio.CinemaId == selectedCinema.Id && 
                        selectedSesiFilms.FindIndex(item => item.Studios_id == studio.Id) != -1)
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
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            if (finishLoad && comboBoxJudul.SelectedIndex != -1 && 
                comboBoxCinema.SelectedIndex != -1 && comboBoxStudio.SelectedIndex != -1 
            ) {
                Studio selectedStudio = (Studio)comboBoxStudio.SelectedItem;
                setDeskripsiStudio(selectedStudio);
                generateKursi(selectedStudio.Kapasitas);
                kursiTerpesan = getKursiTerpesan();
            }
        }

        private void setDeskripsiStudio(Studio studio)
        {
            textJenisStudio.Text = studio.JenisStudioNama;
            textKursi.Text = studio.Kapasitas.ToString() + " Kursi";
            List<Tiket> tiketTerpesan = getKursiTerpesan();
            textSisaKursi.Text = "(sisa " + (studio.Kapasitas - tiketTerpesan.Count) + " kursi)";
            textHarga.Text = "Rp " + studio.HargaWeekday.ToString();
            hargaTiketSatuan = studio.HargaWeekday;
        }

        private List<Tiket> getKursiTerpesan()
        {
            Studio selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
            List<Tiket> tikets = Tiket.BacaData(
                $"films_id='{selectedFilm.Id}' AND " + 
                $"studios_id='{selectedStudio.Id}'"
            );

            return tikets;
        }

        private void generateKursi(int jumlahKursi)
        {
            panel10.Controls.Clear();
            List<string> listHuruf = new List<string>() { "A", "B", "C" };
            int ctrGenerated = 0;
            for (int i = 0; i < listHuruf.Count; i++)
            {
                for (int j = 0; j < jumlahKursi / 12; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (ctrGenerated >= jumlahKursi) break;
                        CheckBox checkBox = new CheckBox();
                        int seatNumber = (k + 1) + (j * 4);
                        string seatNumberString = seatNumber.ToString();
                        if(seatNumberString.Length <= 2)
                        {
                            seatNumberString = seatNumberString.PadLeft(2, '0');
                        }
                        string seatName = $"{listHuruf[i]}{seatNumberString}";
                        checkBox.Name = seatName;
                        checkBox.Text = seatName;
                        checkBox.BackColor = Color.SlateBlue;
                        checkBox.ForeColor = Color.White;
                        checkBox.Size = new Size(50, 20);
                        checkBox.Checked = false;
                        checkBox.Location = new Point(315 + (k * 50) + (i * 250), 220 + (j * 25));
                        checkBox.CheckedChanged += checkBox_CheckedChanged;
                        if (kursiTerpesan.FindIndex(item => item.Nomor_kursi == seatName) == -1) {
                            checkBox.Checked = false;
                            checkBox.Enabled = true;
                        } else {
                            checkBox.Checked = true;
                            checkBox.Enabled = false;
                        }
                        this.Controls.Add(checkBox);
                        checkBox.BringToFront();

                        ctrGenerated += 1;
                    }

                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked && checkBox.Enabled == false)
            {
                MessageBox.Show($"Kursi {checkBox.Text} telah dipesan");
                return;
            }

            bool checkboxKursiDiambil = kursiTerpesan.FindIndex(item => item.Nomor_kursi == checkBox.Name) != -1;
            if (checkBox.Enabled == true && !checkboxKursiDiambil){
                if (checkBox.Checked) {
                    kursiDiambil.Add(checkBox.Name);
                    totalHarga += hargaTiketSatuan;
                } else {
                    kursiDiambil.Remove(checkBox.Name);
                    totalHarga -= hargaTiketSatuan;
                }
                totalAkhir = totalHarga - diskon;
                setInvoiceDetail();
            }
        }

        private void setInvoiceDetail()
        {
            string tmp = "";
            foreach (string kursi in kursiDiambil)
            {
                tmp += kursi + ", ";
            }
            textKursiAmbil.Text = tmp == "" ? "-" : tmp.Substring(0, tmp.Length - 2);;
            textTotalHarga.Text = $"Rp {totalHarga},-";
            textDiskon.Text = $"Rp {diskon},-";
            textTotalAkhir.Text = $"Rp {totalAkhir},-";
            textSaldo.Text = $"Rp {saldo},-";
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxJudul.SelectedIndex == -1 || comboBoxCinema.SelectedIndex == -1 ||
                comboBoxStudio.SelectedIndex == -1 || kursiDiambil.Count == 0
            ) {
                MessageBox.Show("Mohon isi data terlebih dahulu");
                return;
            }

            if (totalAkhir > saldo)
            {
                MessageBox.Show("Saldo anda tidak cukup");
                return;
            }

            try {
                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                DateTime tanggal = dateTimePicker1.Value;
                Cinema selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
                Studio selectedStudio = (Studio)comboBoxStudio.SelectedItem;

                Invoices invoice = new Invoices();
                invoice.Tanggal = tanggal;
                invoice.Grand_total = totalAkhir;
                invoice.Diskon_nominal = diskon;
                invoice.Konsumens_id = konsumenLogin.Id_Konsumen;
                invoice.Status = "PENDING";
                Invoices.TambahData(invoice);
                MessageBox.Show("Berhasil menambah Invoice");

                List<Invoices> invoices = Invoices.BacaData();
                Invoices latestInvoices = invoices[invoices.Count - 1];

                SesiFilm selectedSesiFilm = selectedSesiFilms.Find(
                    item => item.Studios_id == selectedStudio.Id && item.Films_id == selectedFilm.Id
                );
                foreach (string kursi in kursiDiambil)
                {
                    Tiket tiket = new Tiket();
                    tiket.Invoices_id = latestInvoices.Id;
                    tiket.Nomor_kursi = kursi;
                    tiket.Status_hadir = "0";
                    tiket.Harga = hargaTiketSatuan;
                    tiket.Jawdal_film_id = selectedSesiFilm.Jadwal_films_id;
                    tiket.Studios_id = selectedStudio.Id;
                    tiket.Films_id = selectedFilm.Id;
                    Tiket.TambahData(tiket);
                }

                saldo -= totalAkhir;
                konsumenLogin.Saldo_Konsumen = saldo;
                Konsumen.UbahData(konsumenLogin.Id_Konsumen, konsumenLogin);

                MessageBox.Show("Berhasil memesan tiket");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Ada masalah memesan tiket, " + ex.Message);
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void FormPesanTiket_Load(object sender, EventArgs e)
        {


        }
        private void GenerateCheckBoxes(string columnName, Panel panel)
        {
            /*Studio s = (Studio)comboBoxStudio.SelectedItem;
            int kapastitas = s.Kapasitas;
            int rows = (int)Math.Ceiling((decimal)kapastitas / 12);
            int limit = 4;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    int seatNumber = i * limit + j + 1;
                    CheckBox cb = new CheckBox();
                    cb.Text = seatNumber.ToString();
                    cb.AutoSize = true;
                    cb.Location = new Point(10 + j 45, 30 + i 30);
                    cb.Name = columnName + seatNumber.ToString();
                    panel.Controls.Add(cb);
                }
                CheckCheckBoxes(panel);
            }*/
        }
        private void CheckCheckBoxes(Panel panel)
        {
            /*Studio s = (Studio)comboBoxStudio.SelectedItem;
            List<string> listKursi = new List<string>();
            listKursi = Tiket.GetNomorKursi(s, dataFilm);
            foreach (CheckBox checkBox in panel.Controls)
            {
                if (listkursi.Contains(checkBox.Name))
                {
                    checkBox.Enabled = false;
                    checkBox.Checked = true;
                }
            }*/ 
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
