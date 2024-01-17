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
    public partial class FormTambahPegawai : Form
    {
        private bool isTambah = true;
        private Pegawai pegawaiUpdate;
        public FormTambahPegawai()
        {
            InitializeComponent();
        }
        public FormTambahPegawai(Pegawai pegawaiUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.pegawaiUpdate = pegawaiUpdate;

            label2.Text = "UBAH  P E G A W A I";
            textBoxNama.Text = pegawaiUpdate.Nama_Pegawai;
            textBoxEmail.Text = pegawaiUpdate.Email_Pegawai;
            textBoxUsername.Text = pegawaiUpdate.Username_Pegawai;
            textBoxPassword.Text = pegawaiUpdate.Password_Pegawai;
            if (pegawaiUpdate.Roles_Pegawai == "ADMIN")
                comboBox1.SelectedIndex = 0;
            else if (pegawaiUpdate.Roles_Pegawai == "OPERATOR")
                comboBox1.SelectedIndex = 1;
            else if (pegawaiUpdate.Roles_Pegawai == "KASIR")
                comboBox1.SelectedIndex = 2;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Pegawai p = new Pegawai();
           
                p.Nama_Pegawai = textBoxNama.Text;
                p.Email_Pegawai = textBoxEmail.Text;
                p.Username_Pegawai = textBoxUsername.Text;
                p.Password_Pegawai = textBoxPassword.Text;
                p.Roles_Pegawai = comboBox1.Text;

                //tambahkan ke database:
                if (isTambah)
                {
                    Pegawai.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Pegawai.UbahData(pegawaiUpdate.Id_Pegawai, p);
                    MessageBox.Show("Ubah Data berhasil");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
