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
    public partial class FormAdminHR : Form
    {
        public FormAdminHR()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            List<Pegawai> listHasil = Pegawai.BacaData();
            dataGridView1.DataSource = listHasil;

            List<string> columnList = new List<string> { "id", "nama", "email", "username", "password", "roles" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }


        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            List<Konsumen> userList = Konsumen.BacaData();
            dataGridView1.DataSource = userList;

            List<string> columnList = new List<string> { "id", "nama", "email", "no_hp", "gender", "tgl_lahir", "saldo", "username", "password" };
            comboBoxCari.DataSource = columnList;
            comboBoxCari.SelectedIndex = 0;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (radioButtonPegawai.Checked)
            {
                FormTambahPegawai frm = new FormTambahPegawai();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonPegawai_CheckedChanged(this, e);
            }
            else if (radioButtonKonsumen.Checked)
            {
                FormTambahKonsumen frm = new FormTambahKonsumen();
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKonsumen_CheckedChanged(this, e);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (radioButtonPegawai.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id_pegawai"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
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
            else if (radioButtonKonsumen.Checked)
            {
                string kode = dataGridView1.CurrentRow.Cells["Id_konsumen"].Value.ToString();
                DialogResult dr = MessageBox.Show("Ingin hapus data id " + kode + "?", "HAPUS", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Konsumen.HapusData(kode);
                        //refresh form master
                        radioButtonKonsumen_CheckedChanged(this, e);
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
            if (radioButtonPegawai.Checked)
            {
                List<Pegawai> ListData = Pegawai.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
            else if (radioButtonKonsumen.Checked)
            {
                List<Konsumen> ListData = Konsumen.BacaData(selectedKey, searchText);
                dataGridView1.DataSource = ListData;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (radioButtonPegawai.Checked)
            {
                Pegawai pegawai = new Pegawai();
                pegawai.Id_Pegawai = Int32.Parse(dataGridView1.CurrentRow.Cells["Id_pegawai"].Value.ToString());
                pegawai.Nama_Pegawai = dataGridView1.CurrentRow.Cells["Nama_pegawai"].Value.ToString();
                pegawai.Email_Pegawai = dataGridView1.CurrentRow.Cells["Email_pegawai"].Value.ToString();
                pegawai.Username_Pegawai = dataGridView1.CurrentRow.Cells["Username_pegawai"].Value.ToString();
                pegawai.Password_Pegawai = dataGridView1.CurrentRow.Cells["Password_pegawai"].Value.ToString();
                pegawai.Roles_Pegawai = dataGridView1.CurrentRow.Cells["Roles_pegawai"].Value.ToString();

                FormTambahPegawai frm = new FormTambahPegawai(pegawai);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonPegawai_CheckedChanged(this, e);
            }
            else if (radioButtonKonsumen.Checked)
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Id_Konsumen = Int32.Parse(dataGridView1.CurrentRow.Cells["id_Konsumen"].Value.ToString());
                konsumen.Nama_Konsumen = dataGridView1.CurrentRow.Cells["nama_Konsumen"].Value.ToString();
                konsumen.Email_Konsumen = dataGridView1.CurrentRow.Cells["email_Konsumen"].Value.ToString();
                konsumen.NoHP_Konsumen = dataGridView1.CurrentRow.Cells["noHP_Konsumen"].Value.ToString();
                konsumen.Gender_Konsumen = dataGridView1.CurrentRow.Cells["gender_Konsumen"].Value.ToString();
                konsumen.Ttl_Konsumen = DateTime.Parse(dataGridView1.CurrentRow.Cells["ttl_Konsumen"].Value.ToString());
                konsumen.Saldo_Konsumen = Int32.Parse(dataGridView1.CurrentRow.Cells["saldo_Konsumen"].Value.ToString());
                konsumen.Username_Konsumen = dataGridView1.CurrentRow.Cells["username_Konsumen"].Value.ToString();
                konsumen.Password_Konsumen = dataGridView1.CurrentRow.Cells["password_Konsumen"].Value.ToString();

                FormTambahKonsumen frm = new FormTambahKonsumen(konsumen);
                frm.Owner = this;
                frm.ShowDialog();
                radioButtonKonsumen_CheckedChanged(this, e);
            }
            else {
                MessageBox.Show("Pilih radio button terlebih dahulu");
            }
        }
    }
}
