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
    public partial class FormMasterFilm : Form
    {
        public FormMasterFilm()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterFilm_Load(object sender, EventArgs e)
        {
            List<Film> listDataFilm = Film.BacaData();
            dgvData.DataSource = listDataFilm;

            if (dgvData.ColumnCount == 10)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Update"; //judul button
                btnUpdate.HeaderText = "Update"; //judul kolom
                btnUpdate.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnUpdate.Name = "buttonUpdateGrid"; //nama objek button
                dgvData.Columns.Add(btnUpdate); //tambahkan button ke grid

                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Delete"; //judul button
                btnHapus.HeaderText = "Action"; //judul kolom
                btnHapus.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnHapus.Name = "buttonHapusGrid"; //nama objek button
                dgvData.Columns.Add(btnHapus); //tambahkan button ke grid              
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvData.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dgvData.Columns["buttonUpdateGrid"].Index)
            {
                MessageBox.Show("Update Id: " + id);
                FormUpdateFilm formUpdateFilm = new FormUpdateFilm();
                formUpdateFilm.Owner = this;
                formUpdateFilm.idUpdate = id;
                formUpdateFilm.ShowDialog();

                FormMasterFilm_Load(this, e);
            }

            if (e.ColumnIndex == dgvData.Columns["buttonHapusGrid"].Index)
            {

                //konfirmasi penghapusan ke user
                DialogResult dr = MessageBox.Show("Delete data " + id + "?", "Delete Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        List<Film> listFilm = Film.BacaData("id", id);
                        string newFileName = listFilm[0].CoverImage + ".jpg";
                        string dir = Environment.CurrentDirectory;
                        dir = Path.Combine(dir.Substring(0, dir.Length - 9), "Resources");
                        string destPath = Path.Combine(dir, newFileName);
                        File.Delete(destPath);
                        //hapus data dari database
                        Film.HapusData(id);
                        //refresh form master
                        FormMasterFilm_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete data: " + ex.Message);
                    }
                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahFilm formTambahFilm = new FormTambahFilm();
            formTambahFilm.Owner = this;
            formTambahFilm.ShowDialog();

            FormMasterFilm_Load(this, e);
        }

        private void labelMasterFilm_Click(object sender, EventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string filter;

            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "judul";
            }

            else
            {
                filter = "tahun";
            }

            string nilai = textBoxCari.Text;

            List<Film> listDataPegawai = Film.BacaData(filter, nilai);
            dgvData.DataSource = listDataPegawai;
        }
    }
}
