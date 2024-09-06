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
    public partial class FormMasterJenisStudio : Form
    {
        public FormMasterJenisStudio()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterJenisStudio_Load(object sender, EventArgs e)
        {
            List<Jenis_Studio> listDataJenisStudio = Jenis_Studio.BacaData();
            dgvData.DataSource = listDataJenisStudio;

            if (dgvData.ColumnCount == 3)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Delete"; //judul button
                btnHapus.HeaderText = "Action"; //judul kolom
                btnHapus.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnHapus.Name = "buttonHapusGrid"; //nama objek button
                dgvData.Columns.Add(btnHapus); //tambahkan button ke grid
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (column.Name != "Id" && column.Name != "buttonHapusGrid")
                {
                    column.Width = 300;
                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJenisStudio formTambahJenisStudio = new FormTambahJenisStudio();
            formTambahJenisStudio.Owner = this;
            formTambahJenisStudio.ShowDialog();

            FormMasterJenisStudio_Load(this, e);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dgvData.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dgvData.Columns["buttonHapusGrid"].Index)
            {
                //konfirmasi penghapusan ke user
                DialogResult dr = MessageBox.Show("Delete data " + kode + "?", "Delete Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) //jika user setuju hapus data
                {
                    try
                    {
                        //hapus data dari database
                        Jenis_Studio.HapusData(kode);
                        //refresh form master
                        FormMasterJenisStudio_Load(this, e);
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
