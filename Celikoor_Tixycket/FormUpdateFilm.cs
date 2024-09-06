using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormUpdateFilm : Form
    {
        public FormUpdateFilm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public string idUpdate;
        Film selectedFilm;
        Genre selectedGenre;
        Aktor selectedAktor;
        string fileName;
        private void FormUpdateFilm_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(1170, 720);
            List<Film> listDataFilm = Film.BacaData("id", idUpdate);
            this.selectedFilm = listDataFilm[0];
            textBoxJudul.Text = this.selectedFilm.Judul;
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            textBoxDurasi.Text = selectedFilm.Durasi.ToString();
            textBoxBahasa.Text = selectedFilm.Bahasa;
            comboBoxKelompokUsia.SelectedItem = selectedFilm.KelompokUsia;
            textBoxBahasa.Text = selectedFilm.Bahasa;
            if(selectedFilm.Is_sub_indo == 1)
            {
                checkBoxSubIndo.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxSubIndo.CheckState = CheckState.Unchecked;
            }
            List<Kelompok> listKelompok = Kelompok.BacaData();
            comboBoxKelompokUsia.DataSource = listKelompok;
            comboBoxKelompokUsia.DisplayMember = "Nama";
            comboBoxKelompokUsia.Text = selectedFilm.KelompokUsia.Nama;
            if (selectedFilm.Is_sub_indo == 0)
            {
                checkBoxSubIndo.Checked = false;
            }

            else
            {
                checkBoxSubIndo.Checked = true;
            }

            textBoxDiskon.Text = selectedFilm.Diskon.ToString();

            textBoxJudul.Select(0, textBoxJudul.TextLength);

            List<Genre> listGenre = Genre.BacaData();
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "Nama";
            //comboBoxGenre.Text = 
            List<Aktor> listAktor = Aktor.BacaData();
            comboBoxAktor.DataSource = listAktor;
            comboBoxAktor.DisplayMember = "Nama";

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
            selectedFilm.ListGenreFilm = Film.BacaDataDetailGenreFilm("films_id", selectedFilm.Id.ToString());
            selectedFilm.ListAktorFilm = Film.BacaDataDetailAktorFilm("films_id", selectedFilm.Id.ToString());
            for(int i = 0; i < selectedFilm.ListAktorFilm.Count; i++)
                dataGridViewAktor.Rows.Add(selectedFilm.ListAktorFilm[i].Aktor.Id, selectedFilm.ListAktorFilm[i].Aktor.Nama, DateTime.Parse(selectedFilm.ListAktorFilm[i].Aktor.TglLahir).ToShortDateString(), selectedFilm.ListAktorFilm[i].Aktor.Gender, selectedFilm.ListAktorFilm[i].Aktor.NegaraAsal, selectedFilm.ListAktorFilm[i].Peran);
            for (int i = 0; i < selectedFilm.ListGenreFilm.Count; i++)
                dataGridViewGenre.Rows.Add(selectedFilm.ListGenreFilm[i].Genre.Id, selectedFilm.ListGenreFilm[i].Genre.Nama, selectedFilm.ListGenreFilm[i].Genre.Deskripsi);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film();
                film.Id = selectedFilm.Id;
                film.Judul = textBoxJudul.Text;
                film.Sinopsis = richTextBoxSinopsis.Text;
                film.Durasi = int.Parse(textBoxDurasi.Text);
                film.KelompokUsia = (Kelompok)comboBoxKelompokUsia.SelectedItem;
                film.Bahasa = textBoxBahasa.Text;
                
                if (checkBoxSubIndo.Checked == false)
                {
                    film.Is_sub_indo = 0;
                }

                else
                {
                    film.Is_sub_indo = 1;
                }
                string newFileName = selectedFilm.CoverImage + ".jpg";
                string dir = Environment.CurrentDirectory;
                dir = Path.Combine(dir.Substring(0, dir.Length - 9), "Resources");
                string destPath = Path.Combine(dir, newFileName);
                File.Delete(destPath);
                System.Threading.Thread.Sleep(1000); // nunggu 1 detik
                File.Copy(fileName, destPath);

                film.Diskon = double.Parse(textBoxDiskon.Text);

                Film.UbahData(film);

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
                Film.HapusDataDetail(selectedFilm.Id.ToString());
                Film.TambahDataDetailFilm(film);
                MessageBox.Show("Success to update data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to update data! Error: " + x.Message);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.jpg;)|*.jpg;";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxCoverImage.BackgroundImage = new Bitmap(openFile.FileName);
                    fileName = openFile.FileName;
                }
            }
        }

        private void buttonTambahGenre_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambahAktor_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambahGenre_Click_1(object sender, EventArgs e)
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

        private void buttonTambahAktor_Click_1(object sender, EventArgs e)
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
            if (comboBoxGenre.Items.Count > 0)
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
    }
}
