﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes
{
    public partial class FormLoginOperator : Form
    {
        FormMainMenu frmMainMenu;
        public FormLoginOperator()
        {
            InitializeComponent();
        }

        private void FormLoginOperator_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
