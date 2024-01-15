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
            if (userLogin != null)
            {
                AturMenu(userLogin.Roles_Pegawai);
            }
            else
            {
                KonsumAturMenu();
            }
            
        }

        private void AturMenu(string roles)
        {
            if (roles == "ADMIN")
            {
                masterToolStripMenuItem.Visible = true;
                recordToolStripMenuItem.Visible = true;
                invoiceToolStripMenuItem.Visible = true;
                barcodeToolStripMenuItem.Visible = true;
                ticketToolStripMenuItem.Visible = true;
            }
            else if (roles == "OPERATOR")
            {
                masterToolStripMenuItem.Visible = false;
                recordToolStripMenuItem.Visible = false;
                invoiceToolStripMenuItem.Visible = false;
                barcodeToolStripMenuItem.Visible = true;
                ticketToolStripMenuItem.Visible = false;
            }
            else if (roles == "KASIR")
            {
                masterToolStripMenuItem.Visible = false;
                recordToolStripMenuItem.Visible = false;
                invoiceToolStripMenuItem.Visible = true;
                barcodeToolStripMenuItem.Visible = false;
                ticketToolStripMenuItem.Visible = false;
            }
            
        }

        private void KonsumAturMenu()
        {
            masterToolStripMenuItem.Visible = false;
            recordToolStripMenuItem.Visible = false;
            invoiceToolStripMenuItem.Visible = false;
            barcodeToolStripMenuItem.Visible = false;
            ticketToolStripMenuItem.Visible = true;
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
    }
}
