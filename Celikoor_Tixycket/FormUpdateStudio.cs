using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormUpdateStudio : Form
    {
        public FormUpdateStudio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string idUpdate;

        private void FormUpdateStudio_Load(object sender, EventArgs e)
        {
            List<Studio> listDataStudio = Studio.BacaData("id", idUpdate);
            textBoxNamaStudio.Text = listDataStudio[0].Nama;
            textBoxCapacity.Text = listDataStudio[0].Kapasitas.ToString();
            comboBoxJenisStudio.SelectedItem = listDataStudio[0].JenisStudio.Nama;
            comboBoxCinema.SelectedItem = listDataStudio[0].Cinema.Nama_cabang;
            textBoxWeekday.Text = listDataStudio[0].Harga_weekday.ToString();
            textBoxWeekend.Text = listDataStudio[0].Harga_weekend.ToString();

            List<Jenis_Studio> listDataJenisStudio = Jenis_Studio.BacaData();
            comboBoxJenisStudio.DataSource = listDataJenisStudio;
            comboBoxJenisStudio.DisplayMember = "Nama";
            comboBoxJenisStudio.Text = listDataStudio[0].JenisStudio.Nama;
            List<Cinema> listDataCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listDataCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
            comboBoxCinema.Text = listDataStudio[0].Cinema.Nama_cabang;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Studio studio = new Studio();
                studio.Id = int.Parse(idUpdate);
                studio.Nama = textBoxNamaStudio.Text;
                studio.Kapasitas = int.Parse(textBoxCapacity.Text);
                studio.JenisStudio = (Jenis_Studio)comboBoxJenisStudio.SelectedItem;
                studio.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                studio.Harga_weekday = int.Parse(textBoxWeekday.Text);
                studio.Harga_weekend = int.Parse(textBoxWeekend.Text);

                Studio.UbahData(studio);

                MessageBox.Show("Success to update data!");

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to update data! Error: " + ex.Message);
            }
        }
    }
}
