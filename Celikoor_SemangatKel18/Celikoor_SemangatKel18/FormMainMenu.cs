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
using Celikoor_Semangat18.KONSUMEN;

namespace Celikoor_Semangat18
{ 
    public partial class FormMainMenu : Form
    {
    public FormMainMenu()
    {
        InitializeComponent();
    }

    private void FormMainMenu_Load(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
        this.IsMdiContainer = true;
        this.WindowState = FormWindowState.Maximized;
        this.IsMdiContainer = true;//untuk men-set form sebagai mdiParent
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

            FormLogin form = new FormLogin();
            form.MdiParent = this;
            form.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Koneksi Gagal! error: " + ex.Message);
        }
    }
    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form frm = Application.OpenForms["FormLogin"];
        if (frm == null)
        {
            FormLogin frmlog = new FormLogin();
            Form form = Application.OpenForms["FormLoginKonsumen"];
            if (form == null)
            {
                FormLogin frmlogin = new FormLogin();
                frmlogin.MdiParent = this;
                frmlogin.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }

    private void registerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form form = Application.OpenForms["FormRegisterKonsumen"];
        if (form == null)
        {
            FormRegisterKonsumen frmRegisterKonsumen = new FormRegisterKonsumen();
            frmRegisterKonsumen.MdiParent = this;
            frmRegisterKonsumen.Show();
        }
        else
        {
            form.Show();
            form.BringToFront();
        }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }
    }
}
