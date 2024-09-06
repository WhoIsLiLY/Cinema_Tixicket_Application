using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormPenjadwalanFilm : Form
    {
        public FormPenjadwalanFilm()
        {
            InitializeComponent();
        }
        Film selectedFilm;
        Cinema selectedCinema;
        Studio selectedStudio;
        
        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
            List<Studio> listStudio = Studio.BacaData("cinemas_id", ((Cinema)comboBoxCinema.SelectedItem).Id.ToString());
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "Nama";
            comboBoxStudio.Enabled = true;
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            labelJenisStudio.Text = ((Studio)comboBoxStudio.SelectedItem).JenisStudio.ToString();
            DateTime selectedDate = dateTimePicker.Value;
            labelJumlahKursi.Text = ((Studio)comboBoxStudio.SelectedItem).Kapasitas.ToString() + " kursi";
            labelNominalHargaWeekday.Text = ((Studio)comboBoxStudio.SelectedItem).Harga_weekday.ToString();
            labelNominalHargaWeekend.Text = ((Studio)comboBoxStudio.SelectedItem).Harga_weekend.ToString();
            
        }

        private void comboBoxJudulFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewPenjadwalanFilm.Rows.Clear();
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            string dir = Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

            pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
            labelDurasi.Text = "Durasi: " + selectedFilm.Durasi.ToString() + " menit";
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            List<Genre_film> listGenreFilm = Film.BacaDataDetailGenreFilm("films_id", selectedFilm.Id.ToString());
            List<Aktor_film> listAktorFilm = Film.BacaDataDetailAktorFilm("films_id", selectedFilm.Id.ToString());

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
        }

        private void FormPenjadwalanFilm_Load(object sender, EventArgs e)
        {
            List<Film> listFilm = Film.BacaData();
            comboBoxJudulFilm.DataSource = listFilm;
            comboBoxJudulFilm.DisplayMember = "Judul";
            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.Text = "Delete";
            btnHapus.HeaderText = "Action";
            btnHapus.UseColumnTextForButtonValue = true;
            btnHapus.Name = "buttonHapusGrid";
            dataGridViewPenjadwalanFilm.Columns.Add(btnHapus);
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                List<string>checkedSession = new List<string>();

                foreach (Control control in panelData.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        checkedSession.Add(checkBox.Text);
                    }
                }
                // Misalkan dataGridViewFilm memiliki 5 kolom: judulFilm, cinema, studio, tanggal, jam
                string judulFilm = selectedFilm.Judul;
                string cinema = selectedCinema.Nama_cabang;
                string studio = selectedStudio.Nama;
                string tanggal = dateTimePicker.Value.ToString("yyyy-MM-dd");

                // Membuat array untuk menyimpan nilai-nilai yang ingin ditambahkan
                for(int i = 0; i < checkedSession.Count; i++)
                {
                    string[] newValues = { judulFilm, cinema, studio, tanggal, checkedSession[i] };

                    // Mengecek apakah nilai-nilai tersebut sudah ada dalam DataGridView
                    bool isDuplicate = dataGridViewPenjadwalanFilm.Rows
                        .Cast<DataGridViewRow>()
                        .Any(row =>
                            Enumerable.Range(0, 5).All(j =>
                                Convert.ToString(row.Cells[j].Value) == newValues[j]));
                    // Menambahkan baris baru jika kombinasi nilai berbeda
                    if (!isDuplicate)
                    {
                        dataGridViewPenjadwalanFilm.Rows.Add(newValues);
                    }
                    else
                    {
                        MessageBox.Show($"Data yang sama sudah ada untuk sesi {checkedSession[i]}!");
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dataGridViewPenjadwalanFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPenjadwalanFilm.Columns["buttonHapusGrid"].Index)
            {
                int rowIndex = e.RowIndex; // Get the clicked row index

                // Make sure the rowIndex is valid
                if (rowIndex >= 0 && rowIndex < dataGridViewPenjadwalanFilm.Rows.Count)
                {
                    // konfirmasi penghapusan ke user
                    DialogResult dr = MessageBox.Show("Delete data at row " + (rowIndex + 1) + "?", "Delete Process",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes) // jika user setuju hapus data
                    {
                        try
                        {
                            dataGridViewPenjadwalanFilm.Rows.RemoveAt(rowIndex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to delete data: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film();

                for (int i = 0; i < dataGridViewPenjadwalanFilm.Rows.Count; i++)
                {
                    Jadwal_film newJadwal = new Jadwal_film();
                    newJadwal.Tanggal = dataGridViewPenjadwalanFilm.Rows[i].Cells["tanggal"].Value.ToString();
                    newJadwal.Jam_pemutaran = dataGridViewPenjadwalanFilm.Rows[i].Cells["jam"].Value.ToString();
                    
                    string judulFilm = dataGridViewPenjadwalanFilm.Rows[i].Cells["judulFilm"].Value.ToString();
                    List<Film> listFilm = Film.BacaData("judul", judulFilm);

                    string namaStudio = dataGridViewPenjadwalanFilm.Rows[i].Cells["studio"].Value.ToString();
                    List<Studio> listStudio = Studio.BacaData("fromCinema", Cinema.BacaData("nama_cabang", dataGridViewPenjadwalanFilm.Rows[i].Cells["cinema"].Value.ToString())[0].Id.ToString(), namaStudio);
                    List<Jadwal_film> listJadwal = Jadwal_film.CekKetersediaanJadwal(newJadwal, listFilm[0], listStudio[0], "spesifik");


                    if (listJadwal.Count == 0)
                    {
                        Jadwal_film.TambahData(newJadwal);
                        List<Jadwal_film> listJadwalFilm = Jadwal_film.BacaData("getLastIndex");

                        film.TambahFilmStudio(listStudio[0], listFilm[0]);
                        Film.TambahDataStudioFilm(film);

                        film.TambahSesiFilm(listJadwalFilm[0], film.ListFilmStudio[i]);
                        MessageBox.Show($"Add data success for film {selectedFilm.Judul}, cinema {selectedCinema.Nama_cabang} in studio {selectedStudio.Nama}!");
                    }
                    else
                    {
                        MessageBox.Show($"Schedule for film {selectedFilm.Judul}, cinema {selectedCinema.Nama_cabang} in studio {selectedStudio.Nama} has been set by another film");
                    }
                    
                }
                Film.TambahDataSesiFilm(film);
                dataGridViewPenjadwalanFilm.Rows.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
