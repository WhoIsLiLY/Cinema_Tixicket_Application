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
    public partial class FormMasterAktor : Form
    {
        public FormMasterAktor()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahAktor formTambahAktor = new FormTambahAktor();
            formTambahAktor.Owner = this;
            formTambahAktor.ShowDialog();

            FormMasterAktor_Load(this, e);
        }

        private void FormMasterAktor_Load(object sender, EventArgs e)
        {
            List<Aktor> listDataAktor = Aktor.BacaData();
            dgvData.DataSource = listDataAktor;

            if (dgvData.ColumnCount == 5)
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

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string filter;

            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "Nama";
            }

            else if (comboBoxCari.SelectedIndex == 1)
            {
                filter = "Gender";
            }

            else
            {
                filter = "Negara_Asal";
            }

            string nilai = textBoxCari.Text;

            List<Aktor> listDataAktor = Aktor.BacaData(filter, nilai);
            dgvData.DataSource = listDataAktor;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvData.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dgvData.Columns["buttonUpdateGrid"].Index)
            {
                MessageBox.Show("Update Id: " + id);
                FormUpdateAktor formUpdateAktor = new FormUpdateAktor();
                formUpdateAktor.Owner = this;
                formUpdateAktor.idUpdate = id;
                formUpdateAktor.ShowDialog();

                FormMasterAktor_Load(this, e);
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
                        Aktor.HapusData(id);
                        //refresh form master
                        FormMasterAktor_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete data: " + ex.Message);
                    }
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
