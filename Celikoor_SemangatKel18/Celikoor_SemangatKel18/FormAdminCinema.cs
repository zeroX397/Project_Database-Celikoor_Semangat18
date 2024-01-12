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
        }

        private void radioButtonKelompok_CheckedChanged(object sender, EventArgs e)
        {
            List<Kelompok> listHasil = Kelompok.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonJenisStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<JenisStudio> listHasil = JenisStudio.BacaData();
            dataGridView1.DataSource = listHasil;
        }

        private void radioButtonStudio_CheckedChanged(object sender, EventArgs e)
        {
            List<Studio> listHasil = Studio.BacaData();
            dataGridView1.DataSource = listHasil;
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
            else if (radioButtonKelompok.Checked)
            {
                FormTambahKelompok frm = new FormTambahKelompok();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKelompok_CheckedChanged(this, e);
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
        }
    }
}
