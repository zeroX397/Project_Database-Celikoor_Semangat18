﻿using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTambah_Click_1(object sender, EventArgs e)
        {
            if (radioButtonCinema.Checked)
            {
                FormTambahCinema frm = new FormTambahCinema();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonCinema_CheckedChanged_1(this, e);
            }
            else if (radioButtonPegawai.Checked)
            {
                FormTambahPegawai frm = new FormTambahPegawai();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonPegawai_CheckedChanged_1(this, e);
            }
            else if (radioButtonKonsumen.Checked)
            {
                FormTambahKonsumen frm = new FormTambahKonsumen();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKonsumen_CheckedChanged(this, e);
            }
            else if (radioButtonAktor2.Checked)
            {
                FormTambahAktor frm = new FormTambahAktor();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonAktor2_CheckedChanged(this, e);
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonCinema_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Cinema> listHasil = Cinema.BacaData();
            Console.WriteLine("listHasil" + listHasil);
            dataGridView1.DataSource = listHasil;
        }

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

        }

        private void radioButtonAktor2_CheckedChanged(object sender, EventArgs e)
        {
            List<Aktor> listAktor = Aktor.BacaData();
            Console.WriteLine("listHasil" + listAktor);
            dataGridView1.DataSource = listAktor;
        }
    }
}
