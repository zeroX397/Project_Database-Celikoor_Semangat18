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
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Pengecekan username dan password tidak boleh kosong
                if (textBoxUsername.Text == "")
                {
                    throw new Exception("Username tidak boleh kosong");
                }
                if (textBoxPassword.Text == "")
                {
                    throw new Exception("Password tidak boleh kosong");
                }

                Pegawai hasil = Pegawai.Login(textBoxUsername.Text, textBoxPassword.Text);
                if (hasil == null)
                {
                    throw new Exception("Data Pegawai tidak ditemukan");
                }

                Console.WriteLine(hasil.Roles_Pegawai);
                if (hasil.Roles_Pegawai == "ADMIN")
                {
                    this.DialogResult = DialogResult.OK;
                    FormUntukAdmin form = new FormUntukAdmin();
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
                if (hasil.Roles_Pegawai == "OPERATOR")
                {
                    this.DialogResult = DialogResult.OK;
                    FormUntukOperator form = new FormUntukOperator();
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
                if (hasil.Roles_Pegawai == "KASIR")
                {
                    this.DialogResult = DialogResult.OK;
                    FormUntukKasir form = new FormUntukKasir();
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Close();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message, "Terjadi Kesalahan");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
}
