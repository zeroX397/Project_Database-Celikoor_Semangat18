﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Semangat18.Konsumen
{
    public partial class FormProfilKonsumen : Form
    {
        public FormProfilKonsumen()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = Application.OpenForms["FormMainMenu"];
            form.Show();
            form.BringToFront();
        }
    }
}
