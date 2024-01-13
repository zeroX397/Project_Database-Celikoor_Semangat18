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
    public partial class FormAdminMovie : Form
    {
        public FormAdminMovie()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (radioButtonAktor.Checked)
            {
                FormTambahAktor frm = new FormTambahAktor();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonAktor_CheckedChanged(this, e);
            }
            else if (radioButtonGenre.Checked)
            {
                FormTambahGenre frm = new FormTambahGenre();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonGenre_CheckedChanged(this, e);
            }
            else if (radioButtonKelompok.Checked)
            {
                FormTambahKelompok frm = new FormTambahKelompok();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKelompok_CheckedChanged(this, e);
            }
            else if (radioButtonActorFilm.Checked)
            {
                
            }
            else if (radioButtonFilmStudio.Checked)
            {
                
            }
            else if (radioButtonGenreFilm.Checked)
            {
                
            }
            else if (radioButtonFilm.Checked)
            {
                
            }
            else if (radioButtonJadwalFilm.Checked)
            {
                
            }
            else if (radioButtonSesiFilm.Checked)
            {
                
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (radioButtonKelompok.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Kelompok.HapusData(kode);
                        //refresh form master
                        radioButtonKelompok_CheckedChanged(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                    }
                }
            }
            else if (radioButtonGenre.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id_genre"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Genre.HapusData(kode);
                        //refresh form master
                        radioButtonGenre_CheckedChanged(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                    }
                }
            }
            else if (radioButtonAktor.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id_aktor"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Aktor.HapusData(kode);
                        //refresh form master
                        radioButtonAktor_CheckedChanged(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                    }
                }
            }
            else if (radioButtonActorFilm.Checked)
            {
                
            }
            else if (radioButtonFilmStudio.Checked)
            {
                
            }
            else if (radioButtonGenreFilm.Checked)
            {
                
            }
            else if (radioButtonFilm.Checked)
            {
                
            }
            else if (radioButtonJadwalFilm.Checked)
            {
                
            }
            else if (radioButtonSesiFilm.Checked)
            {
                
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (radioButtonAktor.Checked)
            {
                Aktor aktor = new Aktor();
                aktor.Id_Aktor = Int32.Parse(dataGridView1.CurrentRow.Cells["Id_Aktor"].Value.ToString());
                aktor.Nama_Aktor = dataGridView1.CurrentRow.Cells["Nama_Aktor"].Value.ToString();
                aktor.Tgl_lahir_Aktor = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tgl_lahir_Aktor"].Value.ToString());
                aktor.Gender_Aktor = dataGridView1.CurrentRow.Cells["Gender_Aktor"].Value.ToString();
                aktor.Negara_asal_Aktor = dataGridView1.CurrentRow.Cells["Negara_asal_Aktor"].Value.ToString();

                FormTambahAktor frm = new FormTambahAktor(aktor);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonAktor_CheckedChanged(this, e);
            }
            else if (radioButtonKelompok.Checked)
            {
                Kelompok kelompok = new Kelompok();
                kelompok.Id = Int32.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                kelompok.Nama = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();

                FormTambahKelompok frm = new FormTambahKelompok(kelompok);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKelompok_CheckedChanged(this, e);
            }
            else if (radioButtonActorFilm.Checked)
            {
                
            }
            else if (radioButtonFilmStudio.Checked)
            {
                
            }
            else if (radioButtonGenreFilm.Checked)
            {
                
            }
            else if (radioButtonGenre.Checked)
            {
                Genre genre = new Genre();
                genre.Id_genre = Int32.Parse(dataGridView1.CurrentRow.Cells["Id_genre"].Value.ToString());
                genre.Nama_genre = dataGridView1.CurrentRow.Cells["Nama_genre"].Value.ToString();
                genre.Deskripsi_genre = dataGridView1.CurrentRow.Cells["Deskripsi_genre"].Value.ToString();

                FormTambahGenre frm = new FormTambahGenre(genre);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonGenre_CheckedChanged(this, e);
            }
            else if (radioButtonFilm.Checked)
            {
                
            }
            else if (radioButtonJadwalFilm.Checked)
            {
                
            }
            else if (radioButtonSesiFilm.Checked)
            {
                
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string selectedKey = comboBoxCari.SelectedItem.ToString();
            string searchText = textBoxCari.Text;
            if (radioButtonKelompok.Checked)
            {
                List<Kelompok> ListData = Kelompok.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
            else if (radioButtonAktor.Checked)
            {
                List<Aktor> ListData = Aktor.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
            else if (radioButtonActorFilm.Checked)
            {
                
            }
            else if (radioButtonFilmStudio.Checked)
            {
                
            }
            else if (radioButtonGenreFilm.Checked)
            {
                
            }
            else if (radioButtonGenre.Checked)
            {
                List<Genre> ListData = Genre.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
            else if (radioButtonFilm.Checked)
            {
                
            }
            else if (radioButtonJadwalFilm.Checked)
            {
                
            }
            else if (radioButtonSesiFilm.Checked)
            {
                
            }
        }

        private void radioButtonKelompok_CheckedChanged(object sender, EventArgs e)
        {
            List<Kelompok> listHasil = Kelompok.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "nama" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void radioButtonAktor_CheckedChanged(object sender, EventArgs e)
        {
            List<Aktor> listHasil = Aktor.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "nama", "tgl_lahir", "gender", "negara_asal" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void radioButtonGenre_CheckedChanged(object sender, EventArgs e)
        {
            List<Genre> listHasil = Genre.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "nama", "deskripsi" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void radioButtonFilm_CheckedChanged(object sender, EventArgs e)
        {
            List<Film> listHasil = Film.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonActorFilm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFilmStudio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGenreFilm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonJadwalFilm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSesiFilm_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
