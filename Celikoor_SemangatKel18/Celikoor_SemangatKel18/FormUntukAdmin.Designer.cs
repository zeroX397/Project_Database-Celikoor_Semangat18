
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButtonCinema = new System.Windows.Forms.RadioButton();
            this.radioButtonStudio = new System.Windows.Forms.RadioButton();
            this.radioButtonJenisStudio = new System.Windows.Forms.RadioButton();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonGenre = new System.Windows.Forms.RadioButton();
            this.radioButtonKelompok = new System.Windows.Forms.RadioButton();
            this.radioButtonAktor = new System.Windows.Forms.RadioButton();
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Location = new System.Drawing.Point(676, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.Location = new System.Drawing.Point(981, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "Filter";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTambah.Location = new System.Drawing.Point(83, 399);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(137, 49);
            this.buttonTambah.TabIndex = 25;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.Location = new System.Drawing.Point(371, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 49);
            this.button6.TabIndex = 26;
            this.button6.Text = "Ubah";
            this.button6.UseVisualStyleBackColor = false;
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
            this.radioButtonStudio.Location = new System.Drawing.Point(32, 170);
            this.radioButtonStudio.Name = "radioButtonStudio";
            this.radioButtonStudio.Size = new System.Drawing.Size(103, 32);
            this.radioButtonStudio.TabIndex = 28;
            this.radioButtonStudio.TabStop = true;
            this.radioButtonStudio.Text = "Studio";
            this.radioButtonStudio.UseVisualStyleBackColor = true;
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
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonPegawai.Location = new System.Drawing.Point(32, 336);
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
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonKonsumen.Location = new System.Drawing.Point(217, 336);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(154, 32);
            this.radioButtonKonsumen.TabIndex = 31;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(688, 276);
            this.dataGridView1.TabIndex = 33;
            // 
            // radioButtonGenre
            // 
            this.radioButtonGenre.AutoSize = true;
            this.radioButtonGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGenre.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonGenre.Location = new System.Drawing.Point(217, 170);
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
            this.radioButtonKelompok.Location = new System.Drawing.Point(32, 253);
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
            this.radioButtonAktor.Location = new System.Drawing.Point(217, 253);
            this.radioButtonAktor.Name = "radioButtonAktor";
            this.radioButtonAktor.Size = new System.Drawing.Size(95, 32);
            this.radioButtonAktor.TabIndex = 36;
            this.radioButtonAktor.TabStop = true;
            this.radioButtonAktor.Text = "Aktor";
            this.radioButtonAktor.UseVisualStyleBackColor = true;
            this.radioButtonAktor.CheckedChanged += new System.EventHandler(this.radioButtonAktor_CheckedChanged);
            // 
            // FormUntukAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 483);
            this.Controls.Add(this.radioButtonAktor);
            this.Controls.Add(this.radioButtonKelompok);
            this.Controls.Add(this.radioButtonGenre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.radioButtonJenisStudio);
            this.Controls.Add(this.radioButtonStudio);
            this.Controls.Add(this.radioButtonCinema);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioButtonCinema;
        private System.Windows.Forms.RadioButton radioButtonStudio;
        private System.Windows.Forms.RadioButton radioButtonJenisStudio;
        private System.Windows.Forms.RadioButton radioButtonPegawai;
        private System.Windows.Forms.RadioButton radioButtonKonsumen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonGenre;
        private System.Windows.Forms.RadioButton radioButtonKelompok;
        private System.Windows.Forms.RadioButton radioButtonAktor;
    }
}