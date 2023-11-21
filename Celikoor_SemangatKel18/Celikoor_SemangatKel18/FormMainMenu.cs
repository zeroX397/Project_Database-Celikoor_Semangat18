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

namespace tes
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
        }

        private void konsumenRegister_ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void konsumenLogin_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLoginKonsumen"];
            if (form == null)
            {
                FormLoginKonsumen frmLoginKonsumen = new FormLoginKonsumen();
                frmLoginKonsumen.MdiParent = this;
                frmLoginKonsumen.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void operatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLoginOperator"];
            if (form == null)
            {
                FormLoginOperator frmLoginOperator = new FormLoginOperator();
                frmLoginOperator.MdiParent = this;
                frmLoginOperator.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLoginKasir"];
            if (form == null)
            {
                FormLoginKasir frmLoginKasir = new FormLoginKasir();
                frmLoginKasir.MdiParent = this;
                frmLoginKasir.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLoginAdmin"];
            if (form == null)
            {
                FormLoginAdmin frmLoginAdmin = new FormLoginAdmin();
                frmLoginAdmin.MdiParent = this;
                frmLoginAdmin.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
