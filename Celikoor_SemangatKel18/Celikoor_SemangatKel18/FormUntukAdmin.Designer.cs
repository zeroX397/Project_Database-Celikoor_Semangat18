
namespace Celikoor_Semangat18
{
    partial class FormUntukAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.radioButtonCinema = new System.Windows.Forms.RadioButton();
            this.radioButtonStudio = new System.Windows.Forms.RadioButton();
            this.radioButtonJenisStudio = new System.Windows.Forms.RadioButton();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonGenre = new System.Windows.Forms.RadioButton();
            this.radioButtonKelompok = new System.Windows.Forms.RadioButton();
            this.radioButtonAktor = new System.Windows.Forms.RadioButton();
<<<<<<< HEAD
            this.buttonTambah = new System.Windows.Forms.Button();
            this.radioButtonAktor2 = new System.Windows.Forms.RadioButton();
=======
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 70);
            this.panel1.TabIndex = 19;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1103, 18);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 32);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Halaman Admin";
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Transparent;
            this.buttonHapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonHapus.Location = new System.Drawing.Point(430, 472);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(137, 49);
            this.buttonHapus.TabIndex = 22;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Transparent;
            this.buttonCari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCari.Location = new System.Drawing.Point(968, 85);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(137, 49);
            this.buttonCari.TabIndex = 23;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTambah.Location = new System.Drawing.Point(32, 472);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(137, 50);
            this.buttonTambah.TabIndex = 25;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Transparent;
            this.buttonUbah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonUbah.Location = new System.Drawing.Point(234, 472);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(137, 49);
            this.buttonUbah.TabIndex = 26;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // radioButtonCinema
            // 
            this.radioButtonCinema.AutoSize = true;
            this.radioButtonCinema.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCinema.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonCinema.Location = new System.Drawing.Point(32, 92);
            this.radioButtonCinema.Name = "radioButtonCinema";
            this.radioButtonCinema.Size = new System.Drawing.Size(126, 32);
            this.radioButtonCinema.TabIndex = 27;
            this.radioButtonCinema.TabStop = true;
            this.radioButtonCinema.Text = "Cinema";
            this.radioButtonCinema.UseVisualStyleBackColor = true;
            this.radioButtonCinema.CheckedChanged += new System.EventHandler(this.radioButtonCinema_CheckedChanged);
            // 
            // radioButtonStudio
            // 
            this.radioButtonStudio.AutoSize = true;
            this.radioButtonStudio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonStudio.Location = new System.Drawing.Point(32, 188);
            this.radioButtonStudio.Name = "radioButtonStudio";
            this.radioButtonStudio.Size = new System.Drawing.Size(103, 32);
            this.radioButtonStudio.TabIndex = 28;
            this.radioButtonStudio.TabStop = true;
            this.radioButtonStudio.Text = "Studio";
            this.radioButtonStudio.UseVisualStyleBackColor = true;
            this.radioButtonStudio.CheckedChanged += new System.EventHandler(this.radioButtonStudio_CheckedChanged);
            // 
            // radioButtonJenisStudio
            // 
            this.radioButtonJenisStudio.AutoSize = true;
            this.radioButtonJenisStudio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJenisStudio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonJenisStudio.Location = new System.Drawing.Point(217, 92);
            this.radioButtonJenisStudio.Name = "radioButtonJenisStudio";
            this.radioButtonJenisStudio.Size = new System.Drawing.Size(168, 32);
            this.radioButtonJenisStudio.TabIndex = 29;
            this.radioButtonJenisStudio.TabStop = true;
            this.radioButtonJenisStudio.Text = "Jenis Studio";
            this.radioButtonJenisStudio.UseVisualStyleBackColor = true;
            this.radioButtonJenisStudio.CheckedChanged += new System.EventHandler(this.radioButtonJenisStudio_CheckedChanged);
            // 
            // radioButtonPegawai
            // 
<<<<<<< HEAD
            this.radioButtonPegawai.Location = new System.Drawing.Point(731, 138);
=======
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonPegawai.Location = new System.Drawing.Point(32, 394);
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(134, 32);
            this.radioButtonPegawai.TabIndex = 30;
            this.radioButtonPegawai.TabStop = true;
            this.radioButtonPegawai.Text = "Pegawai";
            this.radioButtonPegawai.UseVisualStyleBackColor = true;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // radioButtonKonsumen
            // 
<<<<<<< HEAD
            this.radioButtonKonsumen.Location = new System.Drawing.Point(155, 138);
=======
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonKonsumen.Location = new System.Drawing.Point(217, 394);
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(154, 32);
            this.radioButtonKonsumen.TabIndex = 31;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = true;
            this.radioButtonKonsumen.CheckedChanged += new System.EventHandler(this.radioButtonKonsumen_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dataGridView1.Location = new System.Drawing.Point(24, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.dataGridView1.Location = new System.Drawing.Point(447, 150);
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 276);
            this.dataGridView1.TabIndex = 33;
            // 
            // radioButtonGenre
            // 
            this.radioButtonGenre.AutoSize = true;
            this.radioButtonGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGenre.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonGenre.Location = new System.Drawing.Point(217, 189);
            this.radioButtonGenre.Name = "radioButtonGenre";
            this.radioButtonGenre.Size = new System.Drawing.Size(105, 32);
            this.radioButtonGenre.TabIndex = 34;
            this.radioButtonGenre.TabStop = true;
            this.radioButtonGenre.Text = "Genre";
            this.radioButtonGenre.UseVisualStyleBackColor = true;
            this.radioButtonGenre.CheckedChanged += new System.EventHandler(this.radioButtonGenre_CheckedChanged);
            // 
            // radioButtonKelompok
            // 
            this.radioButtonKelompok.AutoSize = true;
            this.radioButtonKelompok.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKelompok.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonKelompok.Location = new System.Drawing.Point(32, 290);
            this.radioButtonKelompok.Name = "radioButtonKelompok";
            this.radioButtonKelompok.Size = new System.Drawing.Size(152, 32);
            this.radioButtonKelompok.TabIndex = 35;
            this.radioButtonKelompok.TabStop = true;
            this.radioButtonKelompok.Text = "Kelompok";
            this.radioButtonKelompok.UseVisualStyleBackColor = true;
            this.radioButtonKelompok.CheckedChanged += new System.EventHandler(this.radioButtonKelompok_CheckedChanged);
            // 
            // radioButtonAktor
            // 
            this.radioButtonAktor.AutoSize = true;
            this.radioButtonAktor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAktor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonAktor.Location = new System.Drawing.Point(217, 290);
            this.radioButtonAktor.Name = "radioButtonAktor";
            this.radioButtonAktor.Size = new System.Drawing.Size(95, 32);
            this.radioButtonAktor.TabIndex = 36;
            this.radioButtonAktor.TabStop = true;
            this.radioButtonAktor.Text = "Aktor";
            this.radioButtonAktor.UseVisualStyleBackColor = true;
            this.radioButtonAktor.CheckedChanged += new System.EventHandler(this.radioButtonAktor_CheckedChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.Location = new System.Drawing.Point(684, 95);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(263, 30);
            this.textBoxCari.TabIndex = 39;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Location = new System.Drawing.Point(515, 94);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(160, 33);
            this.comboBoxCari.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cari : ";
            // 
            // radioButtonAktor2
            // 
            this.radioButtonAktor2.Location = new System.Drawing.Point(301, 136);
            this.radioButtonAktor2.Name = "radioButtonAktor2";
            this.radioButtonAktor2.Size = new System.Drawing.Size(115, 29);
            this.radioButtonAktor2.TabIndex = 40;
            this.radioButtonAktor2.Text = "Aktor";
            this.radioButtonAktor2.CheckedChanged += new System.EventHandler(this.radioButtonAktor2_CheckedChanged);
            // 
            // FormUntukAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1198, 708);
            this.Controls.Add(this.radioButtonAktor2);
            this.Controls.Add(this.buttonTambah);
=======
            this.ClientSize = new System.Drawing.Size(1154, 561);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonAktor);
            this.Controls.Add(this.radioButtonKelompok);
            this.Controls.Add(this.radioButtonGenre);
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.radioButtonJenisStudio);
            this.Controls.Add(this.radioButtonStudio);
            this.Controls.Add(this.radioButtonCinema);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUntukAdmin";
            this.Text = "FormHalamanAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.RadioButton radioButtonCinema;
        private System.Windows.Forms.RadioButton radioButtonStudio;
        private System.Windows.Forms.RadioButton radioButtonJenisStudio;
        private System.Windows.Forms.RadioButton radioButtonPegawai;
        private System.Windows.Forms.RadioButton radioButtonKonsumen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonGenre;
        private System.Windows.Forms.RadioButton radioButtonKelompok;
        private System.Windows.Forms.RadioButton radioButtonAktor;
<<<<<<< HEAD
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.RadioButton radioButtonAktor2;
=======
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
    }
}