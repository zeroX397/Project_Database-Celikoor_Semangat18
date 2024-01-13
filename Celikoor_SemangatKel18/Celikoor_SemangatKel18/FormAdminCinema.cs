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
    public partial class FormAdminCinema : Form
    {
        public FormAdminCinema()
        {
            InitializeComponent();
        }

        private void radioButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            List<Cinema> listHasil = Cinema.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "nama_cabang", "alamat", "tgl_dibuka", "kota" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void radioButtonJenisStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<JenisStudio> listHasil = JenisStudio.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "nama", "deskripsi" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void radioButtonStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<Studio> listHasil = Studio.BacaData();
            dataGridView1.DataSource = listHasil;
            dataGridView1.Columns["jenisStudioId"].Visible = false;
            dataGridView1.Columns["cinemaId"].Visible = false;

            List<string> columnList = new List<string> { "id", "nama", "kapasitas", "jenis_studios_id", "cinemas_id", "harga_weekday", "harga_weekend" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (radioButtonCinema.Checked)
            {
                FormTambahCinema frm = new FormTambahCinema();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonCinema_CheckedChanged(this, e);
            }
            else if (radioButtonJenisStudio.Checked)
            {
                FormTambahJenisStudio frm = new FormTambahJenisStudio();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonJenisStudio_CheckedChanged(this, e);
            }
            else if (radioButtonStudio.Checked)
            {
                FormTambahStudio frm = new FormTambahStudio();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonStudio_CheckedChanged(this, e);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (radioButtonCinema.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Cinema.HapusData(kode);
                        //refresh form master
                        radioButtonCinema_CheckedChanged(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                    }
                }
            }
            else if (radioButtonJenisStudio.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        JenisStudio.HapusData(kode);
                        //refresh form master
                        radioButtonJenisStudio_CheckedChanged(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                    }
                }
            }
            else if (radioButtonCinema.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Cinema.HapusData(kode);
                        //refresh form master
                        radioButtonCinema_CheckedChanged(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal! error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string selectedKey = comboBoxCari.SelectedItem.ToString();
            string searchText = textBoxCari.Text;
            if (radioButtonCinema.Checked)
            {
                List<Cinema> ListData = Cinema.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
            else if (radioButtonJenisStudio.Checked)
            {
                List<JenisStudio> ListData = JenisStudio.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
            else if (radioButtonStudio.Checked)
            {
                List<Studio> ListData = Studio.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {

            if (radioButtonCinema.Checked)
            {
                Cinema cinema = new Cinema();
                cinema.Id = Int32.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                cinema.Nama_cabang = dataGridView1.CurrentRow.Cells["Nama_cabang"].Value.ToString();
                cinema.Alamat = dataGridView1.CurrentRow.Cells["Alamat"].Value.ToString();
                cinema.Tgl_buka = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tgl_buka"].Value.ToString());
                cinema.Kota = dataGridView1.CurrentRow.Cells["Kota"].Value.ToString();

                FormTambahCinema frm = new FormTambahCinema(cinema);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonCinema_CheckedChanged(this, e);
            }
            else if (radioButtonJenisStudio.Checked)
            {
                JenisStudio jenisStudio = new JenisStudio();
                jenisStudio.ID = Int32.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                jenisStudio.Nama = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();
                jenisStudio.Deskripsi = dataGridView1.CurrentRow.Cells["Deskripsi"].Value.ToString();

                FormTambahJenisStudio frm = new FormTambahJenisStudio(jenisStudio);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonJenisStudio_CheckedChanged(this, e);
            }
            else if (radioButtonStudio.Checked)
            {
                Studio studio = new Studio();
                studio.Id = Int32.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                studio.Nama = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();
                studio.Kapasitas = Int32.Parse(dataGridView1.CurrentRow.Cells["Kapasitas"].Value.ToString());
                studio.JenisStudioId = Int32.Parse(dataGridView1.CurrentRow.Cells["JenisStudioId"].Value.ToString());
                studio.CinemaId = Int32.Parse(dataGridView1.CurrentRow.Cells["cinemaId"].Value.ToString());
                studio.HargaWeekday = Int32.Parse(dataGridView1.CurrentRow.Cells["HargaWeekday"].Value.ToString());
                studio.HargaWeekend = Int32.Parse(dataGridView1.CurrentRow.Cells["HargaWeekend"].Value.ToString());

                FormTambahStudio frm = new FormTambahStudio(studio);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonStudio_CheckedChanged(this, e);
            }
            else {
                MessageBox.Show("Pilih radio button terlebih dahulu");
            }
        }
    }
}
