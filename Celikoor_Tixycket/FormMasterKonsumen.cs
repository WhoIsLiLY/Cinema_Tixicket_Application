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
    public partial class FormMasterKonsumen : Form
    {
        public FormMasterKonsumen()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKonsumen formTambahKonsumen = new FormTambahKonsumen();
            formTambahKonsumen.Owner = this;
            formTambahKonsumen.ShowDialog();

            FormMasterKonsumen_Load(this, e);
        }

        private void FormMasterKonsumen_Load(object sender, EventArgs e)
        {
            List<Konsumen> listDataKonsumen = Konsumen.BacaData();
            dgvData.DataSource = listDataKonsumen;
            if (dgvData.Columns.Contains("password"))
            {
                dgvData.Columns.Remove("password");
            }
            if (dgvData.ColumnCount == 8)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Delete"; //judul button
                btnHapus.HeaderText = "Action"; //judul kolom
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
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (column.Name != "Id" && column.Name != "buttonHapusGrid" && column.Name != "buttonUpdateGrid")
                {
                    column.Width = 120;
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string filter;

            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "Nama";
            }

            else if (comboBoxCari.SelectedIndex == 1)
            {
                filter = "Email";
            }

            else
            {
                filter = "No_Hp";
            }

            string nilai = textBoxCari.Text;

            List<Konsumen> listDataKonsumen = Konsumen.BacaData(filter, nilai);
            dgvData.DataSource = listDataKonsumen;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dgvData.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dgvData.Columns["buttonUpdateGrid"].Index)
            {
                MessageBox.Show("Update Id: " + kode);
                FormUpdateAktor formUpdateAktor = new FormUpdateAktor();
                formUpdateAktor.Owner = this;
                formUpdateAktor.idUpdate = kode;
                formUpdateAktor.ShowDialog();

                FormMasterKonsumen_Load(this, e);
            }

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
                        Konsumen.HapusData(kode);
                        //refresh form master
                        FormMasterKonsumen_Load(this, e);
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
