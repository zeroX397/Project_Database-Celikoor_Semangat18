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

        private void radioButtonGenre_CheckedChanged(object sender, EventArgs e)
        {
            List<Genre> listHasil = Genre.BacaData();
            dataGridView1.DataSource = listHasil;
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
            if (radioButtonKelompok.Checked)
            {
                FormTambahKelompok frm = new FormTambahKelompok();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKelompok_CheckedChanged(this, e);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (radioButtonKelompok.Checked)
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
        }

        private void radioButtonKelompok_CheckedChanged(object sender, EventArgs e)
        {
            List<Kelompok> listHasil = Kelompok.BacaData();
            dataGridView1.DataSource = listHasil;
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

                string nilai = textBoxCari.Text;

                List<Aktor> ListData = Aktor.BacaData(filter, nilai);
                dataGridView1.DataSource = ListData;
            }
        }
    }
}
