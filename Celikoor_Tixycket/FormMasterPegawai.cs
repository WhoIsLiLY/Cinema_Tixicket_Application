using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormMasterPegawai : Form
    {
        public FormMasterPegawai()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai formTambahPegawai = new FormTambahPegawai();
            formTambahPegawai.Owner = this;
            formTambahPegawai.ShowDialog();

            FormMasterPegawai_Load(this, e);
        }

        private void FormMasterPegawai_Load(object sender, EventArgs e)
        {
            List<Pegawai> listDataPegawai = Pegawai.BacaData();
            dgvData.DataSource = listDataPegawai;
            if (dgvData.Columns.Contains("Password"))
            {
                dgvData.Columns.Remove("Password");
            }
            if (dgvData.ColumnCount == 5)
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
                    column.Width = 237;
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
                filter = "Username";
            }

            else
            {
                filter = "Roles";
            }

            string nilai = textBoxCari.Text;

            List<Pegawai> listDataPegawai = Pegawai.BacaData(filter, nilai);
            dgvData.DataSource = listDataPegawai;
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
                        Pegawai.HapusData(kode);
                        //refresh form master
                        FormMasterPegawai_Load(this, e);
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
