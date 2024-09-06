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
    public partial class FormMasterMenu : Form
    {
        public FormMasterMenu()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterMenu_Load(object sender, EventArgs e)
        {
            List<Menus> listDataMenu = Menus.BacaData();
            dgvData.DataSource = listDataMenu;

            if (dgvData.ColumnCount == 4)
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
                FormUpdateMenu formUpdateMenu = new FormUpdateMenu();
                formUpdateMenu.Owner = this;
                formUpdateMenu.idUpdate = id;
                formUpdateMenu.ShowDialog();

                FormMasterMenu_Load(this, e);
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
                        Menus.HapusData(id);
                        //refresh form master
                        FormMasterMenu_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete data: " + ex.Message);
                    }
                }
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
                filter = "Jenis_Menu";
            }

            else
            {
                filter = "Harga";
            }

            string nilai = textBoxCari.Text;

            List<Menus> listDataMenu = Menus.BacaData(filter, nilai);
            dgvData.DataSource = listDataMenu;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahMenu formTambahMenu = new FormTambahMenu();
            formTambahMenu.Owner = this;
            formTambahMenu.ShowDialog();

            FormMasterMenu_Load(this, e);
        }
    }
}
