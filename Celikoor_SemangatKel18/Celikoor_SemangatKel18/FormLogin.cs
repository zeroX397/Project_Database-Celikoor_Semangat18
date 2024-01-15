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
            FormTambahKonsumen frm = new FormTambahKonsumen();
            frm.UbahJudulRegister();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormMainMenu frm = (FormMainMenu)this.Owner;
            
            if (radioButtonEmployee.Checked)
            {  
                string uid = textBoxUsername.Text;
                string pwd = textBoxPassword.Text;
                try
                {
                    frm.userLogin = Pegawai.Login(uid, pwd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonConsumen.Checked)
            {
                
                string uid = textBoxUsername.Text;
                string pwd = textBoxPassword.Text;
                try
                {
                    frm.konsumLogin = Konsumen.Login(uid, pwd);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            if (frm.userLogin != null || frm.konsumLogin != null)
            {
                frm.Visible = true;
                if (frm.userLogin != null)
                {
                    frm.AturMenu(frm.userLogin.Roles_Pegawai, frm.userLogin.Username_Pegawai);
                }
                if (frm.konsumLogin != null)
                {
                    frm.KonsumAturMenu(frm.konsumLogin.Username_Konsumen);
                }
                this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonConsumen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
