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
    public partial class FormMasterStudio : Form
    {
        public FormMasterStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio frmTambahStudio = new FormTambahStudio();
            frmTambahStudio.Owner = this;
            frmTambahStudio.ShowDialog();

            FormMasterStudio_Load(this, e);
        }

        private void FormMasterStudio_Load(object sender, EventArgs e)
        {
            List<Studio> listStudio = Studio.BacaData();
            dgvData.DataSource = listStudio;

            if (dgvData.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Delete"; //judul button
                btnHapus.HeaderText = "Delete"; //judul kolom
                btnHapus.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnHapus.Name = "buttonHapusGrid"; //nama objek button
                dgvData.Columns.Add(btnHapus); //tambahkan button ke grid

                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Update"; //judul button
                btnUpdate.HeaderText = "Update"; //judul kolom
                btnUpdate.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnUpdate.Name = "buttonUpdateGrid"; //nama objek button
                dgvData.Columns.Add(btnUpdate); //tambahkan button ke grid
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            try
            {
                string nilai = textboxCari.Text;
                string filter = "";
                if(comboboxCari.SelectedIndex == 0)
                {
                    filter = "nama";
                }

                else if (comboboxCari.SelectedIndex == 1)
                {
                    filter = "kapasitas";
                }

                else if (comboboxCari.SelectedIndex == 2)
                {
                    filter = "jenis_studios_id.nama";
                }

                List<Studio> listDataStudio = Studio.BacaData(filter, nilai);
                dgvData.DataSource = listDataStudio;
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvData.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dgvData.Columns["buttonUpdateGrid"].Index)
            {
                MessageBox.Show("Update Id: " + id);
                FormUpdateStudio formUpdateStudio = new FormUpdateStudio();
                formUpdateStudio.Owner = this;
                formUpdateStudio.idUpdate = id;
                formUpdateStudio.ShowDialog();

                FormMasterStudio_Load(this, e);
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
                        //hapus data dari database
                        Studio.HapusData(id);
                        //refresh form master
                        FormMasterStudio_Load(this, e);
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
