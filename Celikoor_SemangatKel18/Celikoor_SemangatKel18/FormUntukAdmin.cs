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
    public partial class FormUntukAdmin : Form
    {
        public FormUntukAdmin()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            List<Cinema> listHasil = Cinema.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            List<Pegawai> listHasil = Pegawai.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonAktor_CheckedChanged(object sender, EventArgs e)
        {
            List<Aktor> listHasil = Aktor.BacaData();
            dataGridView1.DataSource = listHasil;

            List<Aktor> liscbo = new List<Aktor>();
            //comboBoxCari.DisplayMember = "Id_Aktor";
            //comboBoxCari.DisplayMember = "Nama_Aktor";
            //comboBoxCari.DisplayMember = "Tgl_lahir_Aktor";
            //comboBoxCari.DisplayMember = "Negara_asal_Aktor";
            //comboBoxCari.DataSource = listHasil;
        }

        private void radioButtonKelompok_CheckedChanged(object sender, EventArgs e)
        {
            List<Kelompok> listHasil = Kelompok.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonGenre_CheckedChanged(object sender, EventArgs e)
        {
            List<Genre> listHasil = Genre.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonJenisStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<JenisStudio> listHasil = JenisStudio.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            List<Konsumen> userList = Konsumen.BacaData();
            dataGridView1.DataSource = userList;
        }

        private void radioButtonStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<Studio> listHasil = Studio.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if(radioButtonCinema.Checked)
            {
                FormTambahCinema frm = new FormTambahCinema();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonCinema_CheckedChanged(this, e);
            }
            else if (radioButtonPegawai.Checked)
            {
                FormTambahPegawai frm = new FormTambahPegawai();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonPegawai_CheckedChanged(this, e);
            }
<<<<<<< HEAD
            else if (radioButtonKonsumen.Checked)
            {
                FormTambahKonsumen frm = new FormTambahKonsumen();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKonsumen_CheckedChanged(this, e);
            }
            else if (radioButtonAktor2.Checked)
=======
            else if (radioButtonAktor.Checked)
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            {
                FormTambahAktor frm = new FormTambahAktor();
                frm.Owner = this;
                frm.ShowDialog();
<<<<<<< HEAD
                radioButtonAktor2_CheckedChanged(this, e);
=======
                radioButtonAktor_CheckedChanged(this, e);
            }
            else if (radioButtonKelompok.Checked)
            {
                FormTambahKelompok frm = new FormTambahKelompok();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKelompok_CheckedChanged(this, e);
            }
            else if (radioButtonGenre.Checked)
            {
                FormTambahGenre frm = new FormTambahGenre();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonGenre_CheckedChanged(this, e);
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            }
            else if (radioButtonJenisStudio.Checked)
            {
                FormTambahJenisStudio frm = new FormTambahJenisStudio();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonJenisStudio_CheckedChanged(this, e);
            }
<<<<<<< HEAD
            else if (radioButtonStudio.Checked)
            {
                FormTambahStudio frm = new FormTambahStudio();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonStudio_CheckedChanged(this, e);
            }
=======
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (radioButtonCinema.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
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
            else if (radioButtonKelompok.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
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
                DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
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
                DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
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
            else if (radioButtonPegawai.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id_pegawai"].Value.ToString();
                DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Pegawai.HapusData(kode);
                        //refresh form master
                        radioButtonPegawai_CheckedChanged(this, e);
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
                DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
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
            //else if (radioButtonKonsumen.Checked)
            //{
            //    string kode = dataGridView1.CurrentRow.Cells["Id_konsumen"].Value.ToString();
            //    DialogResult dr = MessageBox.Show("Hapus data " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
            //    if (dr == DialogResult.Yes) //jika user setuju hapus data
            //    {
            //        try
            //        {
            //            //hapus data dari database
            //            Konsumen.HapusData(kode);
            //            //refresh form master
            //            radioButtonKonsumen_CheckedChanged(this, e);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Hapus data gagal! error: " + ex.Message);
            //        }
            //    }
            //}
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (radioButtonAktor.Checked)
            {
                FormUpdateAktor frm = new FormUpdateAktor();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonAktor_CheckedChanged(this, e);
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            if (radioButtonAktor.Checked)
            {
                string filter;
                if (comboBoxCari.SelectedIndex == 0)
                    filter = "id";
                else
                    filter = "nama";

<<<<<<< HEAD
        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            List<Konsumen> listHasil = Konsumen.BacaData();
            Console.WriteLine("listHasil" + listHasil);
            dataGridView1.DataSource = listHasil;

        }

        private void radioButtonStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<Studio> listHasil = Studio.BacaData();
            Console.WriteLine("listHasil" + listHasil);
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonPegawai_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Pegawai> listHasil = Pegawai.BacaData();
            Console.WriteLine("listHasil" + listHasil);
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonJenisStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<JenisStudio> listHasil = JenisStudio.BacaData();
            Console.WriteLine("listHasil" + listHasil);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listHasil;
=======
                string nilai = textBoxCari.Text;
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351

                List<Aktor> ListData = Aktor.BacaData(filter, nilai);
                dataGridView1.DataSource = ListData;
            }
        }

        private void radioButtonAktor2_CheckedChanged(object sender, EventArgs e)
        {
            List<Aktor> listAktor = Aktor.BacaData();
            Console.WriteLine("listHasil" + listAktor);
            dataGridView1.DataSource = listAktor;
        }
    }
}
