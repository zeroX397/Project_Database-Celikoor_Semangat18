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
    public partial class FormTambahAktor : Form
    {
        private bool isTambah = true;
        private Aktor aktorUpdate;
        public FormTambahAktor()
        {
            InitializeComponent();
        }
        public FormTambahAktor(Aktor aktorUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.aktorUpdate = aktorUpdate;

            label2.Text = "U B A H  A K T O R";
            textBoxId.Text = aktorUpdate.Id_Aktor.ToString();
            textBoxNama.Text = aktorUpdate.Nama_Aktor;
            dateTimePickerTglLahir.Value = aktorUpdate.Tgl_lahir_Aktor;
            textBoxNegara.Text = aktorUpdate.Negara_asal_Aktor;
            if (aktorUpdate.Gender_Aktor == "L") 
                comboBox1.SelectedIndex = 0;
            else 
                comboBox1.SelectedIndex = 1;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Aktor p = new Aktor();
                
                p.Nama_Aktor = textBoxNama.Text;
                p.Tgl_lahir_Aktor= dateTimePickerTglLahir.Value;
                p.Gender_Aktor = comboBox1.Text;
                p.Negara_asal_Aktor= textBoxNegara.Text;

                //tambahkan ke database:
                if (isTambah)
                {
                Aktor.TambahData(p);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Aktor.UbahData(aktorUpdate.Id_Aktor, p);
                    MessageBox.Show("Ubah Data berhasil");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
