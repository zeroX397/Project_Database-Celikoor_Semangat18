using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_Library;

namespace Celikoor_Semangat18
{ 
    public partial class FormMainMenu : Form
    {
        public Pegawai userLogin;
        public Konsumen konsumLogin;
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            this.Visible = false;
            //this.WindowState = FormWindowState.Maximized;
            //this.IsMdiContainer = true;//untuk men-set form sebagai mdiParent
            try
            {
                string server = connect.Default.dbServer;
                int port = connect.Default.dbPort;
                string name = connect.Default.dbName;
                string uid = connect.Default.dbUsername;
                string pwd = connect.Default.dbPassword;
                Console.WriteLine(name);
                Koneksi k = new Koneksi(server, port, name, uid, pwd);
                MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal! error: " + ex.Message);
            }

            FormLogin form = new FormLogin();
            form.Owner = this;
            this.Visible = false;
            form.ShowDialog();
        }

        public void AturMenu(string roles, string username)
        {
            if (roles == "ADMIN")
            {
                masterToolStripMenuItem.Visible = true;
                invoiceToolStripMenuItem.Visible = true;
                barcodeToolStripMenuItem.Visible = true;
                jadwalFilmToolStripMenuItem.Visible = true;
                pesanTiketToolStripMenuItem.Visible = true;
                profilToolStripMenuItem.Visible = false;

                label1.Text = $"Welcome to the Celikoor Cinema Apps, {username} (ADMIN)";
            }
            else if (roles == "OPERATOR")
            {
                masterToolStripMenuItem.Visible = false;
                invoiceToolStripMenuItem.Visible = false;
                barcodeToolStripMenuItem.Visible = true;
                jadwalFilmToolStripMenuItem.Visible = false;
                pesanTiketToolStripMenuItem.Visible = false;
                profilToolStripMenuItem.Visible = false;

                label1.Text = $"Welcome to the Celikoor Cinema Apps, {username} (OPERATOR)";
            }
            else if (roles == "KASIR")
            {
                masterToolStripMenuItem.Visible = false;
                invoiceToolStripMenuItem.Visible = true;
                barcodeToolStripMenuItem.Visible = false;
                jadwalFilmToolStripMenuItem.Visible = false;
                pesanTiketToolStripMenuItem.Visible = false;
                profilToolStripMenuItem.Visible = false;

                label1.Text = $"Welcome to the Celikoor Cinema Apps, {username} (KASIR)";
            }
            
        }

        public void KonsumAturMenu(string username)
        {
            masterToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = false;
            barcodeToolStripMenuItem.Visible = false;
            jadwalFilmToolStripMenuItem.Visible = false;
            pesanTiketToolStripMenuItem.Visible = true;
            profilToolStripMenuItem.Visible = true;

            label1.Text = $"Welcome to the Celikoor Cinema Apps, {username} (KONSUMEN)";
        }
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HumanResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormAdminHR"];
            if (frm == null)
            {
                FormAdminHR frmMaster = new FormAdminHR();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormAdminCinema"];
            if (frm == null)
            {
                FormAdminCinema frmMaster = new FormAdminCinema();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormAdminMovie"];
            if (frm == null)
            {
                FormAdminMovie frmMaster = new FormAdminMovie();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jadwalFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormJadwalFilm"];
            if (frm == null)
            {
                FormJadwalFilm frmMaster = new FormJadwalFilm();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void pesanTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPesanTiket"];
            if (frm == null)
            {
                if (konsumLogin != null){
                    FormPesanTiket frmMaster = new FormPesanTiket(konsumLogin);
                    frmMaster.MdiParent = this;
                    frmMaster.Show();
                } else {
                    FormPesanTiket frmMaster = new FormPesanTiket(userLogin);
                    frmMaster.MdiParent = this;
                    frmMaster.Show();
                }
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

        }

        private void barcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPencatatanKedatangan"];
            if (frm == null)
            {
                FormPencatatanKedatangan frmMaster = new FormPencatatanKedatangan(userLogin.Id_Pegawai);
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }
        
        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormLaporan"];
            if (frm == null)
            {
                FormLaporan frmMaster = new FormLaporan();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormProifle"];
            if (frm == null)
            {
                FormProfile frmMaster = new FormProfile(konsumLogin);
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }
    }
}
