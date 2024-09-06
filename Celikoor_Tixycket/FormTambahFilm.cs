using Celikoor_LIB;
using Celikoor_Tixycket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Celikoor_Tixycket
{
    public partial class FormTambahFilm : Form
    {
        public FormTambahFilm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        string fileName;
        Genre selectedGenre;
        Aktor selectedAktor;
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film();
                film.Judul = textBoxJudul.Text;
                film.Sinopsis = textBoxSinopsis.Text;
                film.Tahun = int.Parse(textBoxTahun.Text);
                film.Durasi = int.Parse(textBoxDurasi.Text);
                film.KelompokUsia = (Kelompok)comboBoxKelompokUsia.SelectedItem;
                film.Bahasa = textBoxBahasa.Text;

                if (checkBoxSubIndo.Checked)
                {
                    film.Is_sub_indo = 1;
                }

                else
                {
                    film.Is_sub_indo = 0;
                }
                
                film.CoverImage = Film.GetCoverImageLastIndex();
                string newFileName = Film.GetCoverImageLastIndex() + ".jpg";
                string dir = Environment.CurrentDirectory;
                dir = Path.Combine(dir.Substring(0, dir.Length - 9), "Resources");
                string destPath = Path.Combine(dir, newFileName);
                File.Copy(fileName, destPath); // Resources/p16.jpg

                film.Diskon = double.Parse(textBoxDiskon.Text);
                Film.TambahData(film);

                for (int i = 0; i < dataGridViewGenre.Rows.Count; i++)
                {
                    string kode = dataGridViewGenre.Rows[i].Cells["id1"].Value.ToString();
                    List<Genre> listHasil = Genre.BacaData("id", kode);
                    
                    film.TambahGenreFilm(listHasil[0]);
                }
                for (int i = 0; i < dataGridViewAktor.Rows.Count; i++)
                {
                    string kode = dataGridViewAktor.Rows[i].Cells["id2"].Value.ToString();
                    List<Aktor> listHasil = Aktor.BacaData("id", kode);

                    film.TambahAktorFilm(listHasil[0], dataGridViewAktor.Rows[i].Cells["peran"].Value.ToString());
                }
                List<Film> listTampung = Film.BacaData("getLastIndex");
                film.Id = listTampung[0].Id;
                Film.TambahDataDetailFilm(film);
                MessageBox.Show("Success to add data!");
                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }

        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(1170, 720);
            List<Kelompok> listDataKelompokUsia = Kelompok.BacaData();
            comboBoxKelompokUsia.DataSource = listDataKelompokUsia;
            comboBoxKelompokUsia.DisplayMember = "Nama";

            List<Genre> listGenre = Genre.BacaData();
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "Nama";
            List<Aktor> listAktor = Aktor.BacaData();
            comboBoxAktor.DataSource = listAktor;
            comboBoxAktor.DisplayMember = "Nama";
            textBoxJudul.Select();

            DataGridViewButtonColumn btnHapusAktor = new DataGridViewButtonColumn();
            btnHapusAktor.Text = "Delete";
            btnHapusAktor.HeaderText = "Action";
            btnHapusAktor.UseColumnTextForButtonValue = true;
            btnHapusAktor.Name = "buttonHapusGridAktor";
            dataGridViewAktor.Columns.Add(btnHapusAktor);

            DataGridViewButtonColumn btnHapusGenre = new DataGridViewButtonColumn();
            btnHapusGenre.Text = "Delete";
            btnHapusGenre.HeaderText = "Action";
            btnHapusGenre.UseColumnTextForButtonValue = true;
            btnHapusGenre.Name = "buttonHapusGridGenre";
            dataGridViewGenre.Columns.Add(btnHapusGenre);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.jpg;)|*.jpg;";
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxCoverImage.BackgroundImage = new Bitmap(openFile.FileName);
                    fileName = openFile.FileName;
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void CekIndexGenre
        private void buttonTambahGenre_Click(object sender, EventArgs e)
        {
            try
            {
                bool isIdExists = dataGridViewGenre.Rows.Cast<DataGridViewRow>()
                         .Any(row => Convert.ToInt32(row.Cells["id1"].Value) == selectedGenre.Id);
                if (!isIdExists)
                {
                    dataGridViewGenre.Rows.Add(selectedGenre.Id, selectedGenre.Nama, selectedGenre.Deskripsi);
                }
                else
                {
                    MessageBox.Show("Genre with the same id already exist");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void buttonTambahAktor_Click(object sender, EventArgs e)
        {
            try
            {
                bool isIdExists = dataGridViewAktor.Rows.Cast<DataGridViewRow>()
                         .Any(row => Convert.ToInt32(row.Cells["id2"].Value) == selectedAktor.Id);
                if (!isIdExists)
                {
                    DateTime birthDate = DateTime.Now;
                    if (DateTime.TryParse(selectedAktor.TglLahir, out DateTime parsedDate))
                    {
                        birthDate = parsedDate;
                    }
                    dataGridViewAktor.Rows.Add(selectedAktor.Id, selectedAktor.Nama, birthDate.ToShortDateString(), selectedAktor.Gender, selectedAktor.NegaraAsal, comboBoxRole.Text);
                }
                else
                {
                    MessageBox.Show("Actor with the same id already exist");
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxGenre.Items.Count > 0)
            {
                List<Genre> listGenre = Genre.BacaData("nama", comboBoxGenre.Text);
                selectedGenre = listGenre[0];
            }
        }
        private void comboBoxAktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAktor.Items.Count > 0)
            {
                List<Aktor> listAktor = Aktor.BacaData("nama", comboBoxAktor.Text);
                selectedAktor = listAktor[0];
            }
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kode = (int)dataGridViewGenre.CurrentRow.Cells["id1"].Value;
            var rowToRemove = dataGridViewGenre.Rows.Cast<DataGridViewRow>()
                                    .FirstOrDefault(row => Convert.ToInt32(row.Cells["id1"].Value) == kode);
           

            if (e.ColumnIndex == dataGridViewGenre.Columns["buttonHapusGridGenre"].Index)
            {
                //konfirmasi penghapusan ke user
                DialogResult dr = MessageBox.Show("Delete data " + kode + "?", "Delete Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        dataGridViewGenre.Rows.Remove(rowToRemove);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete data: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kode = (int)dataGridViewAktor.CurrentRow.Cells["id2"].Value;
            var rowToRemove = dataGridViewAktor.Rows.Cast<DataGridViewRow>()
                                    .FirstOrDefault(row => Convert.ToInt32(row.Cells["id2"].Value) == kode);


            if (e.ColumnIndex == dataGridViewAktor.Columns["buttonHapusGridAktor"].Index)
            {
                //konfirmasi penghapusan ke user
                DialogResult dr = MessageBox.Show("Delete data " + kode + "?", "Delete Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        dataGridViewAktor.Rows.Remove(rowToRemove);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete data: " + ex.Message);
                    }
                }
            }
        }
    }
}
