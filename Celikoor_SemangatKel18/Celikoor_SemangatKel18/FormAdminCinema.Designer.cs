
namespace Celikoor_Semangat18
{
    partial class FormAdminCinema
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
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.radioButtonKelompok = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonJenisStudio = new System.Windows.Forms.RadioButton();
            this.radioButtonCinema = new System.Windows.Forms.RadioButton();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonStudio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCari
            // 
            this.textBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.Location = new System.Drawing.Point(716, 133);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(263, 30);
            this.textBoxCari.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Cari : ";
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Location = new System.Drawing.Point(527, 133);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(160, 33);
            this.comboBoxCari.TabIndex = 56;
            // 
            // radioButtonKelompok
            // 
            this.radioButtonKelompok.AutoSize = true;
            this.radioButtonKelompok.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKelompok.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonKelompok.Location = new System.Drawing.Point(228, 174);
            this.radioButtonKelompok.Name = "radioButtonKelompok";
            this.radioButtonKelompok.Size = new System.Drawing.Size(152, 32);
            this.radioButtonKelompok.TabIndex = 53;
            this.radioButtonKelompok.TabStop = true;
            this.radioButtonKelompok.Text = "Kelompok";
            this.radioButtonKelompok.UseVisualStyleBackColor = true;
            this.radioButtonKelompok.CheckedChanged += new System.EventHandler(this.radioButtonKelompok_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 280);
            this.dataGridView1.TabIndex = 51;
            // 
            // radioButtonJenisStudio
            // 
            this.radioButtonJenisStudio.AutoSize = true;
            this.radioButtonJenisStudio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJenisStudio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonJenisStudio.Location = new System.Drawing.Point(228, 106);
            this.radioButtonJenisStudio.Name = "radioButtonJenisStudio";
            this.radioButtonJenisStudio.Size = new System.Drawing.Size(168, 32);
            this.radioButtonJenisStudio.TabIndex = 48;
            this.radioButtonJenisStudio.TabStop = true;
            this.radioButtonJenisStudio.Text = "Jenis Studio";
            this.radioButtonJenisStudio.UseVisualStyleBackColor = true;
            this.radioButtonJenisStudio.CheckedChanged += new System.EventHandler(this.radioButtonJenisStudio_CheckedChanged);
            // 
            // radioButtonCinema
            // 
            this.radioButtonCinema.AutoSize = true;
            this.radioButtonCinema.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCinema.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonCinema.Location = new System.Drawing.Point(43, 106);
            this.radioButtonCinema.Name = "radioButtonCinema";
            this.radioButtonCinema.Size = new System.Drawing.Size(126, 32);
            this.radioButtonCinema.TabIndex = 46;
            this.radioButtonCinema.TabStop = true;
            this.radioButtonCinema.Text = "Cinema";
            this.radioButtonCinema.UseVisualStyleBackColor = true;
            this.radioButtonCinema.CheckedChanged += new System.EventHandler(this.radioButtonCinema_CheckedChanged);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Transparent;
            this.buttonUbah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonUbah.Location = new System.Drawing.Point(550, 536);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(137, 49);
            this.buttonUbah.TabIndex = 45;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTambah.Location = new System.Drawing.Point(43, 535);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(137, 50);
            this.buttonTambah.TabIndex = 44;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Transparent;
            this.buttonCari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCari.Location = new System.Drawing.Point(1005, 124);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(137, 49);
            this.buttonCari.TabIndex = 43;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Transparent;
            this.buttonHapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonHapus.Location = new System.Drawing.Point(1014, 536);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(137, 49);
            this.buttonHapus.TabIndex = 42;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
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
            // radioButtonStudio
            // 
            this.radioButtonStudio.AutoSize = true;
            this.radioButtonStudio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButtonStudio.Location = new System.Drawing.Point(42, 174);
            this.radioButtonStudio.Name = "radioButtonStudio";
            this.radioButtonStudio.Size = new System.Drawing.Size(103, 32);
            this.radioButtonStudio.TabIndex = 47;
            this.radioButtonStudio.TabStop = true;
            this.radioButtonStudio.Text = "Studio";
            this.radioButtonStudio.UseVisualStyleBackColor = true;
            this.radioButtonStudio.CheckedChanged += new System.EventHandler(this.radioButtonStudio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 70);
            this.panel1.TabIndex = 41;
            // 
            // FormAdminCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 609);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.radioButtonKelompok);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonJenisStudio);
            this.Controls.Add(this.radioButtonCinema);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.radioButtonStudio);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminCinema";
            this.Text = "FormAdminCinema";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.RadioButton radioButtonKelompok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonJenisStudio;
        private System.Windows.Forms.RadioButton radioButtonCinema;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonStudio;
        private System.Windows.Forms.Panel panel1;
    }
}