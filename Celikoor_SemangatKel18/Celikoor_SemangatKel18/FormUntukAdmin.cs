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

<<<<<<< Updated upstream

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
            else if (radioButtonAktor.Checked)
            {
                FormTambahAktor frm = new FormTambahAktor();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonAktor_CheckedChanged(this, e);
            }
            else if (radioButtonKelompok.Checked)
            {
                FormTambahKelompok frm = new FormTambahKelompok();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKelompok_CheckedChanged(this, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
=======
        private void label1_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {

        }
    }
}
