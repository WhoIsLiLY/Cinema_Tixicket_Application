using Celikoor_LIB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormPemesananTiket : Form
    {
        public FormPemesananTiket()
        {
            InitializeComponent();
        }
        FormUtama formUtama;
        Film selectedFilm;
        Studio selectedStudio;
        List<Jadwal_film> listJadwalFilm;
        Jadwal_film jadwal_film = new Jadwal_film();
        public Menus selectedMenu;
        private void LayoutTempatDuduk()
        {
            foreach (Control control in new ArrayList(panelTempatDuduk.Controls))
            {
                if (control is Label label && label.Name == "labelError")
                {
                    label.Dispose();
                }
            }
            string[] seatType = { "A", "B", "C" };
            int capacity = selectedStudio.Kapasitas;
            int currentCapacity = capacity;
            for (int i = 0; i < 3; i++)
            {
                string sectionSeat = seatType[i];
                int seatNumber = 1;
                int pointX = 33 + (i * 247);
                int pointY = 129;
                for (int j = 0; j < capacity/3; j++)
                {
                    CheckBox newCheckBox = new CheckBox();
                    newCheckBox.Location = new System.Drawing.Point(pointX, pointY);
                    newCheckBox.Size = new System.Drawing.Size(45, 22);
                    newCheckBox.Text = seatNumber.ToString();
                    newCheckBox.Name = sectionSeat + seatNumber.ToString();
                    listJadwalFilm = Jadwal_film.CekKetersediaanJadwal(jadwal_film, selectedFilm, selectedStudio, "spesifik");
                    List<Ticket> listTiket = Ticket.BacaDataSpesifik(newCheckBox.Name, selectedFilm, selectedStudio, listJadwalFilm[0]);
                    
                    if(listTiket.Count > 0)
                    {
                        newCheckBox.CheckState = CheckState.Checked;
                        newCheckBox.Enabled = false;
                        currentCapacity--;
                    }
                    seatNumber++;
                    pointX += 46;

                    panelTempatDuduk.Controls.Add(newCheckBox);
                    if ((j+1) % 4 == 0 && j != 0)
                    {
                        pointX = 33 + (i * 247);
                        pointY += 38;
                    }
                    
                }
            }
            SetupCheckBoxEvents();
            labelSisaKursi.Text = "sisa " + currentCapacity.ToString() + " kursi";
            labelJumlahKursi.Text = capacity + " kursi";
            labelNominalSaldo.Text = formUtama.konsumenLogin.Saldo.ToString();
            buttonTransaksi.Enabled = true;
        }
        private void DeleteAllSeat()
        {
            foreach (Control control in new ArrayList(panelTempatDuduk.Controls))
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Dispose();
                }
            }
            Label newLabel = new Label();
            newLabel.Location = new Point(220, 220);
            newLabel.Name = "labelError";
            newLabel.Font = new Font("Arial Narrow", 15, FontStyle.Bold);
            newLabel.ForeColor = Color.Black;
            newLabel.Size = new Size(390, 35);
            newLabel.Text = "No Session Added Yet. Stay Tuned!";
            panelTempatDuduk.Controls.Add(newLabel);
            newLabel.BringToFront();
            labelJumlahKursi.Text = "-";
            labelSisaKursi.Text = "(-)";
            buttonTransaksi.Enabled = false;
        }
        private void SetUpSeat()
        {
            if (selectedStudio != null && jadwal_film.Tanggal != null && jadwal_film.Jam_pemutaran != null)
            {
                DeleteAllSeat();
                LayoutTempatDuduk();
                labelKursi.Text = "Kursi:";
                labelNominalTotal.Text = "0";
                labelNominalTotalAkhir.Text = "0";
            }
        }
        private void FormPemesananTiket_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
            labelNominalSaldo.Text = formUtama.konsumenLogin.Saldo.ToString();

            List<Film> listFilm = Film.BacaData();
            comboBoxJudulFilm.DataSource = listFilm;
            comboBoxJudulFilm.DisplayMember = "Judul";

            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
            if (formUtama.film != null)
            {
                selectedFilm = formUtama.film;
                List<Genre_film> listGenreFilm = Film.BacaDataDetailGenreFilm("films_id", selectedFilm.Id.ToString());
                List<Aktor_film> listAktorFilm = Film.BacaDataDetailAktorFilm("films_id", selectedFilm.Id.ToString());

                string dir = Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.Length - 9);
                dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

                pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
                labelDurasi.Text = "Durasi: " + selectedFilm.Durasi.ToString() + " menit";
                richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
                labelAktorUtama.Text = "Aktor Utama: ";
                for (int i = 0; i < listAktorFilm.Count; i++)
                {
                    labelAktorUtama.Text += listAktorFilm[i].Aktor.Nama;
                    if (i == listAktorFilm.Count - 1)
                    {
                        break;
                    }
                    if (i + 1 < 2)
                    {
                        labelAktorUtama.Text += ", ";
                    }
                    else
                    {
                        labelAktorUtama.Text += ",...";
                        break;
                    }
                }
                labelGenre.Text = "Genre: ";
                for (int i = 0; i < listGenreFilm.Count; i++)
                {
                    labelGenre.Text += listGenreFilm[i].Genre.Nama;
                    if (i + 1 < listGenreFilm.Count)
                    {
                        labelGenre.Text += ", ";
                    }
                }
                labelKelompok.Text = "Kelompok: " + selectedFilm.KelompokUsia;

                comboBoxJudulFilm.Text = selectedFilm.Judul;
                comboBoxStudio_SelectedIndexChanged(sender, e);
            }
            
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            labelJenisStudio.Text = selectedStudio.JenisStudio.ToString();

            listJadwalFilm = Jadwal_film.CekKetersediaanJadwal(jadwal_film, selectedFilm, selectedStudio);
            if (listJadwalFilm.Count != 0)
            {
                comboBoxJam.Enabled = true;
                List<string> uniqueDates = listJadwalFilm.Select(j => j.Tanggal).Distinct().ToList();
                comboBoxTanggal.DataSource = uniqueDates;
                comboBoxTanggal.DisplayMember = "Tanggal";
                DateTime selectedDate = DateTime.Parse(comboBoxTanggal.Text);
                if (selectedDate.DayOfWeek >= DayOfWeek.Monday && selectedDate.DayOfWeek <= DayOfWeek.Friday)
                {
                    labelNominalHarga.Text = ((Studio)comboBoxStudio.SelectedItem).Harga_weekday.ToString();
                }
                else
                {
                    labelNominalHarga.Text = ((Studio)comboBoxStudio.SelectedItem).Harga_weekend.ToString();
                }
                labelJumlahKursi.Text = ((Studio)comboBoxStudio.SelectedItem).Kapasitas.ToString() + " kursi";
                if (selectedStudio != null && jadwal_film.Tanggal != "" && jadwal_film.Jam_pemutaran != "" && listJadwalFilm.Count != 0)
                {
                    SetUpSeat();
                }
                else DeleteAllSeat();
            }
            else{
                comboBoxJam.Enabled = false;
                DeleteAllSeat();
            }
            
        }

        private void comboBoxJudulFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            List<Genre_film> listGenreFilm = Film.BacaDataDetailGenreFilm("films_id", selectedFilm.Id.ToString());
            List<Aktor_film> listAktorFilm = Film.BacaDataDetailAktorFilm("films_id", selectedFilm.Id.ToString());
            string dir = Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

            pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
            labelDurasi.Text = "Durasi: " + selectedFilm.Durasi.ToString() + " menit";
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            labelAktorUtama.Text = "Aktor Utama: ";
            for (int i = 0; i < listAktorFilm.Count; i++)
            {
                labelAktorUtama.Text += listAktorFilm[i].Aktor.Nama;
                if (i == listAktorFilm.Count - 1)
                {
                    break;
                }
                if (i + 1 < 2)
                {
                    labelAktorUtama.Text += ", ";
                }
                else
                {
                    labelAktorUtama.Text += ",...";
                    break;
                }
            }
            labelGenre.Text = "Genre: ";
            for (int i = 0; i < listGenreFilm.Count; i++)
            {
                labelGenre.Text += listGenreFilm[i].Genre.Nama;
                if (i + 1 < listGenreFilm.Count)
                {
                    labelGenre.Text += ", ";
                }
            }
            labelKelompok.Text = "Kelompok: " + selectedFilm.KelompokUsia;

            if (selectedStudio != null && jadwal_film.Tanggal != "" && jadwal_film.Jam_pemutaran != "")
            {
                listJadwalFilm = Jadwal_film.CekKetersediaanJadwal(jadwal_film, selectedFilm, selectedStudio, "spesifik");
                if (listJadwalFilm.Count != 0)
                {
                    SetUpSeat();
                }
                else DeleteAllSeat();
            }
            labelNominalDiskon.Text = selectedFilm.Diskon.ToString() + "%";
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Studio> listStudio = Studio.BacaData("cinemas_id", ((Cinema)comboBoxCinema.SelectedItem).Id.ToString());
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "Nama";
            comboBoxStudio.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(labelNominalSaldo.Text) >= int.Parse(labelNominalTotalAkhir.Text))
                {
                    formUtama.konsumenLogin.Saldo -= int.Parse(labelNominalTotalAkhir.Text);
                    Konsumen.UbahNominalSaldo(formUtama.konsumenLogin);

                    Invoices invoice = new Invoices();
                    invoice.Grand_total = int.Parse(labelNominalTotalAkhir.Text);
                    invoice.Diskon_nominal = selectedFilm.Diskon;
                    invoice.Penonton = formUtama.konsumenLogin;

                    Invoices.TambahData(invoice);
                    List<Invoices> listInvoice = Invoices.BacaData("getLastIndex");
                    listJadwalFilm = Jadwal_film.CekKetersediaanJadwal(jadwal_film, selectedFilm, selectedStudio, "spesifik");
                    foreach (Control control in panelTempatDuduk.Controls)
                    {
                        if (control is CheckBox clickedCheckBox && clickedCheckBox.Checked == true && clickedCheckBox.Enabled == true)
                        {
                            Ticket tiket = new Ticket();
                            tiket.NoInvoice = listInvoice[0];
                            tiket.NoKursi = clickedCheckBox.Name;
                            tiket.Harga = int.Parse(labelNominalHarga.Text);
                            tiket.JadwalFilm = listJadwalFilm[0];
                            tiket.Film = selectedFilm;
                            tiket.Studio = selectedStudio;

                            Ticket.TambahData(tiket);
                        }
                    }
                    Menus.TambahDataDetilMenu(selectedMenu, listInvoice[0], listJadwalFilm[0], selectedStudio, selectedFilm);
                    MessageBox.Show("Transaction success!");
                    SetUpSeat();
                }
                else
                {
                    MessageBox.Show("Your balance is insufficient");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Please select your seat first" + x.Message);
            }
            
            //input ke invoice

            //input ke tiket
        }

        private void comboBoxJam_SelectedIndexChanged(object sender, EventArgs e)
        {
            jadwal_film.Jam_pemutaran = comboBoxJam.Text;
            listJadwalFilm = Jadwal_film.CekKetersediaanJadwal(jadwal_film, selectedFilm, selectedStudio, "spesifik");
            if(listJadwalFilm.Count != 0)
            {
                if (selectedStudio != null && jadwal_film.Tanggal != "" && jadwal_film.Jam_pemutaran != "" && listJadwalFilm.Count != 0)
                {
                    SetUpSeat();
                }
                else DeleteAllSeat();
            }
            else
            {
                DeleteAllSeat();
            }
        }

        private void comboBoxTanggal_SelectedIndexChanged(object sender, EventArgs e)
        {
            jadwal_film.Tanggal = comboBoxTanggal.Text;
            listJadwalFilm = Jadwal_film.CekKetersediaanJadwal(jadwal_film, selectedFilm, selectedStudio, "spesifik");
            if (listJadwalFilm.Count != 0)
            {
                if (selectedStudio != null && jadwal_film.Tanggal != "" && jadwal_film.Jam_pemutaran != "" && listJadwalFilm.Count != 0)
                {
                    SetUpSeat();
                }
                else DeleteAllSeat();
            }
        }
        private void SetupCheckBoxEvents()
        {
            
            foreach (Control control in panelTempatDuduk.Controls)
            {
                if (control is CheckBox checkBox)
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            labelKursi.Text = "Kursi:";
            labelNominalTotal.Text = "0";
            foreach (Control control in panelTempatDuduk.Controls)
            {
                if (control is CheckBox clickedCheckBox && clickedCheckBox.Checked && clickedCheckBox.Enabled == true)
                {
                    if (labelKursi.Text == "Kursi:")
                    {
                        labelKursi.Text += " " + clickedCheckBox.Name;
                    }
                    else
                    {
                        labelKursi.Text += ", " + clickedCheckBox.Name;
                    }
                    labelNominalTotal.Text = (int.Parse(labelNominalTotal.Text) + int.Parse(labelNominalHarga.Text)).ToString();
                    labelNominalTotalAkhir.Text = ((int.Parse(labelNominalTotal.Text) * (100 - selectedFilm.Diskon) / 100) + int.Parse(labelTotalNominalMenu.Text)).ToString();
                }
            }
        }

        private void buttonTambahMenu_Click(object sender, EventArgs e)
        {
            FormTransaksiMenu formTransaksiMenu = new FormTransaksiMenu();
            formTransaksiMenu.Owner = this;
            formTransaksiMenu.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalNominalMenu_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalNominalMenu_TextChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(this, e);
        }
    }
}
