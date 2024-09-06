namespace Celikoor_Tixycket
{
    partial class FormPenjadwalanFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjadwalanFilm));
            this.pictureBoxCoverImage = new System.Windows.Forms.PictureBox();
            this.comboBoxStudio = new System.Windows.Forms.ComboBox();
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.comboBoxJudulFilm = new System.Windows.Forms.ComboBox();
            this.labelNominalHargaWeekday = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelJenisStudio = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.richTextBoxSinopsis = new System.Windows.Forms.RichTextBox();
            this.labelKelompok = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAktorUtama = new System.Windows.Forms.Label();
            this.labelDurasi = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSesi3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSesi1 = new System.Windows.Forms.CheckBox();
            this.labelJumlahKursi = new System.Windows.Forms.Label();
            this.labelJam = new System.Windows.Forms.Label();
            this.labelNominalHargaWeekend = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPenjadwalanFilm = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.judulFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenjadwalanFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoverImage
            // 
            this.pictureBoxCoverImage.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBoxCoverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCoverImage.Location = new System.Drawing.Point(458, 15);
            this.pictureBoxCoverImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            this.pictureBoxCoverImage.Size = new System.Drawing.Size(354, 525);
            this.pictureBoxCoverImage.TabIndex = 44;
            this.pictureBoxCoverImage.TabStop = false;
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudio.Enabled = false;
            this.comboBoxStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Location = new System.Drawing.Point(150, 80);
            this.comboBoxStudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(88, 30);
            this.comboBoxStudio.TabIndex = 53;
            this.comboBoxStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudio_SelectedIndexChanged);
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(150, 35);
            this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(242, 30);
            this.comboBoxCinema.TabIndex = 52;
            this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
            // 
            // comboBoxJudulFilm
            // 
            this.comboBoxJudulFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJudulFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJudulFilm.FormattingEnabled = true;
            this.comboBoxJudulFilm.Location = new System.Drawing.Point(150, 288);
            this.comboBoxJudulFilm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxJudulFilm.Name = "comboBoxJudulFilm";
            this.comboBoxJudulFilm.Size = new System.Drawing.Size(242, 30);
            this.comboBoxJudulFilm.TabIndex = 51;
            this.comboBoxJudulFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudulFilm_SelectedIndexChanged);
            // 
            // labelNominalHargaWeekday
            // 
            this.labelNominalHargaWeekday.AutoSize = true;
            this.labelNominalHargaWeekday.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelNominalHargaWeekday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNominalHargaWeekday.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNominalHargaWeekday.ForeColor = System.Drawing.Color.Black;
            this.labelNominalHargaWeekday.Location = new System.Drawing.Point(258, 189);
            this.labelNominalHargaWeekday.Name = "labelNominalHargaWeekday";
            this.labelNominalHargaWeekday.Size = new System.Drawing.Size(22, 25);
            this.labelNominalHargaWeekday.TabIndex = 50;
            this.labelNominalHargaWeekday.Text = "-";
            this.labelNominalHargaWeekday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHarga.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.Color.Black;
            this.labelHarga.Location = new System.Drawing.Point(46, 189);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(186, 25);
            this.labelHarga.TabIndex = 49;
            this.labelHarga.Text = "Weekday Price";
            this.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJenisStudio
            // 
            this.labelJenisStudio.AutoSize = true;
            this.labelJenisStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelJenisStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJenisStudio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisStudio.ForeColor = System.Drawing.Color.Black;
            this.labelJenisStudio.Location = new System.Drawing.Point(81, 150);
            this.labelJenisStudio.Name = "labelJenisStudio";
            this.labelJenisStudio.Size = new System.Drawing.Size(152, 25);
            this.labelJenisStudio.TabIndex = 47;
            this.labelJenisStudio.Text = "Studio Type";
            this.labelJenisStudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(150, 339);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(242, 31);
            this.dateTimePicker.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Studio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cinema:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Day/Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelJudul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJudul.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.Black;
            this.labelJudul.Location = new System.Drawing.Point(76, 292);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(72, 25);
            this.labelJudul.TabIndex = 40;
            this.labelJudul.Text = "Title:";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(1242, 985);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(161, 49);
            this.buttonKeluar.TabIndex = 46;
            this.buttonKeluar.Text = "&CLOSE";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // richTextBoxSinopsis
            // 
            this.richTextBoxSinopsis.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSinopsis.Location = new System.Drawing.Point(33, 110);
            this.richTextBoxSinopsis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxSinopsis.Name = "richTextBoxSinopsis";
            this.richTextBoxSinopsis.Size = new System.Drawing.Size(518, 210);
            this.richTextBoxSinopsis.TabIndex = 59;
            this.richTextBoxSinopsis.Text = "-";
            // 
            // labelKelompok
            // 
            this.labelKelompok.AutoSize = true;
            this.labelKelompok.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKelompok.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelompok.ForeColor = System.Drawing.Color.Black;
            this.labelKelompok.Location = new System.Drawing.Point(28, 448);
            this.labelKelompok.Name = "labelKelompok";
            this.labelKelompok.Size = new System.Drawing.Size(141, 25);
            this.labelKelompok.TabIndex = 58;
            this.labelKelompok.Text = "Age Rated:";
            this.labelKelompok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGenre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.Color.Black;
            this.labelGenre.Location = new System.Drawing.Point(28, 414);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(90, 25);
            this.labelGenre.TabIndex = 57;
            this.labelGenre.Text = "Genre:";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAktorUtama
            // 
            this.labelAktorUtama.AutoSize = true;
            this.labelAktorUtama.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelAktorUtama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAktorUtama.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktorUtama.ForeColor = System.Drawing.Color.Black;
            this.labelAktorUtama.Location = new System.Drawing.Point(28, 380);
            this.labelAktorUtama.Name = "labelAktorUtama";
            this.labelAktorUtama.Size = new System.Drawing.Size(157, 25);
            this.labelAktorUtama.TabIndex = 56;
            this.labelAktorUtama.Text = "Main Actors:";
            this.labelAktorUtama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDurasi
            // 
            this.labelDurasi.AutoSize = true;
            this.labelDurasi.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelDurasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDurasi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurasi.ForeColor = System.Drawing.Color.Black;
            this.labelDurasi.Location = new System.Drawing.Point(28, 346);
            this.labelDurasi.Name = "labelDurasi";
            this.labelDurasi.Size = new System.Drawing.Size(122, 25);
            this.labelDurasi.TabIndex = 54;
            this.labelDurasi.Text = "Duration:";
            this.labelDurasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.NavajoWhite;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(27, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(156, 34);
            this.label.TabIndex = 54;
            this.label.Text = "Synopsis";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(1058, 985);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(166, 49);
            this.buttonSimpan.TabIndex = 45;
            this.buttonSimpan.Text = "&SAVE";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.richTextBoxSinopsis);
            this.panel2.Controls.Add(this.labelKelompok);
            this.panel2.Controls.Add(this.labelGenre);
            this.panel2.Controls.Add(this.labelAktorUtama);
            this.panel2.Controls.Add(this.labelDurasi);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(819, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 525);
            this.panel2.TabIndex = 41;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelData.Controls.Add(this.checkBox2);
            this.panelData.Controls.Add(this.checkBoxSesi3);
            this.panelData.Controls.Add(this.checkBox1);
            this.panelData.Controls.Add(this.checkBoxSesi1);
            this.panelData.Controls.Add(this.labelJumlahKursi);
            this.panelData.Controls.Add(this.labelJam);
            this.panelData.Controls.Add(this.labelNominalHargaWeekend);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.comboBoxStudio);
            this.panelData.Controls.Add(this.comboBoxCinema);
            this.panelData.Controls.Add(this.comboBoxJudulFilm);
            this.panelData.Controls.Add(this.labelNominalHargaWeekday);
            this.panelData.Controls.Add(this.labelHarga);
            this.panelData.Controls.Add(this.labelJenisStudio);
            this.panelData.Controls.Add(this.dateTimePicker);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.labelJudul);
            this.panelData.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.panelData.Location = new System.Drawing.Point(12, 15);
            this.panelData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(439, 456);
            this.panelData.TabIndex = 40;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(322, 394);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 28);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "IV";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSesi3
            // 
            this.checkBoxSesi3.AutoSize = true;
            this.checkBoxSesi3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBoxSesi3.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSesi3.Location = new System.Drawing.Point(267, 394);
            this.checkBoxSesi3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSesi3.Name = "checkBoxSesi3";
            this.checkBoxSesi3.Size = new System.Drawing.Size(51, 28);
            this.checkBoxSesi3.TabIndex = 64;
            this.checkBoxSesi3.Text = "III";
            this.checkBoxSesi3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(216, 394);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 28);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "II";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSesi1
            // 
            this.checkBoxSesi1.AutoSize = true;
            this.checkBoxSesi1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBoxSesi1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSesi1.Location = new System.Drawing.Point(166, 394);
            this.checkBoxSesi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSesi1.Name = "checkBoxSesi1";
            this.checkBoxSesi1.Size = new System.Drawing.Size(41, 28);
            this.checkBoxSesi1.TabIndex = 49;
            this.checkBoxSesi1.Text = "I";
            this.checkBoxSesi1.UseVisualStyleBackColor = true;
            // 
            // labelJumlahKursi
            // 
            this.labelJumlahKursi.AutoSize = true;
            this.labelJumlahKursi.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelJumlahKursi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJumlahKursi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahKursi.ForeColor = System.Drawing.Color.Black;
            this.labelJumlahKursi.Location = new System.Drawing.Point(258, 150);
            this.labelJumlahKursi.Name = "labelJumlahKursi";
            this.labelJumlahKursi.Size = new System.Drawing.Size(22, 25);
            this.labelJumlahKursi.TabIndex = 62;
            this.labelJumlahKursi.Text = "-";
            this.labelJumlahKursi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelJam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJam.ForeColor = System.Drawing.Color.Black;
            this.labelJam.Location = new System.Drawing.Point(43, 392);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(109, 25);
            this.labelJam.TabIndex = 57;
            this.labelJam.Text = "Session:";
            this.labelJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNominalHargaWeekend
            // 
            this.labelNominalHargaWeekend.AutoSize = true;
            this.labelNominalHargaWeekend.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelNominalHargaWeekend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNominalHargaWeekend.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNominalHargaWeekend.ForeColor = System.Drawing.Color.Black;
            this.labelNominalHargaWeekend.Location = new System.Drawing.Point(258, 228);
            this.labelNominalHargaWeekend.Name = "labelNominalHargaWeekend";
            this.labelNominalHargaWeekend.Size = new System.Drawing.Size(22, 25);
            this.labelNominalHargaWeekend.TabIndex = 56;
            this.labelNominalHargaWeekend.Text = "-";
            this.labelNominalHargaWeekend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Weekend Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPenjadwalanFilm
            // 
            this.dataGridViewPenjadwalanFilm.AllowUserToAddRows = false;
            this.dataGridViewPenjadwalanFilm.AllowUserToDeleteRows = false;
            this.dataGridViewPenjadwalanFilm.AllowUserToResizeColumns = false;
            this.dataGridViewPenjadwalanFilm.AllowUserToResizeRows = false;
            this.dataGridViewPenjadwalanFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPenjadwalanFilm.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewPenjadwalanFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenjadwalanFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.judulFilm,
            this.cinema,
            this.studio,
            this.tanggal,
            this.jam});
            this.dataGridViewPenjadwalanFilm.Location = new System.Drawing.Point(12, 548);
            this.dataGridViewPenjadwalanFilm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPenjadwalanFilm.Name = "dataGridViewPenjadwalanFilm";
            this.dataGridViewPenjadwalanFilm.ReadOnly = true;
            this.dataGridViewPenjadwalanFilm.RowHeadersWidth = 51;
            this.dataGridViewPenjadwalanFilm.RowTemplate.Height = 24;
            this.dataGridViewPenjadwalanFilm.Size = new System.Drawing.Size(1390, 416);
            this.dataGridViewPenjadwalanFilm.TabIndex = 47;
            this.dataGridViewPenjadwalanFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPenjadwalanFilm_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(14, 484);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(438, 49);
            this.buttonTambah.TabIndex = 48;
            this.buttonTambah.Text = "&ADD";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // judulFilm
            // 
            this.judulFilm.HeaderText = "Title";
            this.judulFilm.MinimumWidth = 6;
            this.judulFilm.Name = "judulFilm";
            this.judulFilm.ReadOnly = true;
            // 
            // cinema
            // 
            this.cinema.HeaderText = "Cinema";
            this.cinema.MinimumWidth = 6;
            this.cinema.Name = "cinema";
            this.cinema.ReadOnly = true;
            // 
            // studio
            // 
            this.studio.HeaderText = "Studio";
            this.studio.MinimumWidth = 6;
            this.studio.Name = "studio";
            this.studio.ReadOnly = true;
            // 
            // tanggal
            // 
            this.tanggal.HeaderText = "Date";
            this.tanggal.MinimumWidth = 6;
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            // 
            // jam
            // 
            this.jam.HeaderText = "Time";
            this.jam.MinimumWidth = 6;
            this.jam.Name = "jam";
            this.jam.ReadOnly = true;
            // 
            // FormPenjadwalanFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1424, 1049);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewPenjadwalanFilm);
            this.Controls.Add(this.pictureBoxCoverImage);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPenjadwalanFilm";
            this.Text = "TIXIE";
            this.Load += new System.EventHandler(this.FormPenjadwalanFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenjadwalanFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCoverImage;
        private System.Windows.Forms.ComboBox comboBoxStudio;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.ComboBox comboBoxJudulFilm;
        private System.Windows.Forms.Label labelNominalHargaWeekday;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelJenisStudio;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.RichTextBox richTextBoxSinopsis;
        private System.Windows.Forms.Label labelKelompok;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAktorUtama;
        private System.Windows.Forms.Label labelDurasi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridViewPenjadwalanFilm;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelNominalHargaWeekend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.Label labelJumlahKursi;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxSesi3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxSesi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn studio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam;
    }
}