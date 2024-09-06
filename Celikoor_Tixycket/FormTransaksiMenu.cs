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
    public partial class FormTransaksiMenu : Form
    {
        public FormTransaksiMenu()
        {
            InitializeComponent();
        }
        FormPemesananTiket formPemesananTiket;
        Menus selectedMakanan;
        Menus selectedMinuman;
        private void FormTransaksiMenu_Load(object sender, EventArgs e)
        {
            formPemesananTiket = (FormPemesananTiket)this.Owner;
            List<Menus> listMakanan = Menus.BacaData("FOOD");
            comboBoxFood.DataSource = listMakanan;
            comboBoxFood.DisplayMember = "Nama";
            List<Menus> listMinuman = Menus.BacaData("BEVERAGE");
            comboBoxBeverage.DataSource = listMinuman;
            comboBoxBeverage.DisplayMember = "Nama";

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.Text = "Delete";
            btnHapus.HeaderText = "Action";
            btnHapus.UseColumnTextForButtonValue = true;
            btnHapus.Name = "buttonHapusGrid";
            dataGridViewMenu.Columns.Add(btnHapus);

            if (formPemesananTiket.selectedMenu != null)
            {
                for(int i = 0; i < formPemesananTiket.selectedMenu.ListDetail.Count; i++)
                {
                    List<Menus> listMenu = Menus.BacaData("id", formPemesananTiket.selectedMenu.ListDetail[i].MenuId.ToString());
                    dataGridViewMenu.Rows.Add(listMenu[0].Nama, formPemesananTiket.selectedMenu.ListDetail[i].Kuantitas, formPemesananTiket.selectedMenu.ListDetail[i].TotalHarga);
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            dataGridViewMenu.Rows.Clear();
            if(numericUpDownQtyFood.Value > 0)
            {
                dataGridViewMenu.Rows.Add(selectedMakanan.Nama, (int)numericUpDownQtyFood.Value, labelTotalNominalFood.Text);
            }
            if(numericUpDownQtyBeverage.Value > 0)
            {
                dataGridViewMenu.Rows.Add(selectedMinuman.Nama, (int)numericUpDownQtyBeverage.Value, labelNominalTotalBeverage.Text);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if(dataGridViewMenu.Rows.Count > 0)
            {
                int totalHarga = dataGridViewMenu.Rows
                .Cast<DataGridViewRow>()
                .Sum(row => Convert.ToInt32(row.Cells["totalPrice"].Value));
                formPemesananTiket.labelTotalNominalMenu.Text = totalHarga.ToString();
                formPemesananTiket.selectedMenu = new Menus();
                for(int i = 0; i < dataGridViewMenu.Rows.Count; i++)
                {
                    List<Menus> listMenu = Menus.BacaData("nama", dataGridViewMenu.Rows[i].Cells["menu"].Value.ToString());
                    formPemesananTiket.selectedMenu.TambahDetil(listMenu[0], int.Parse(dataGridViewMenu.Rows[i].Cells["totalPrice"].Value.ToString()), int.Parse(dataGridViewMenu.Rows[i].Cells["quantity"].Value.ToString()));
                }
                this.Close();
            }
            else
            {
                formPemesananTiket.selectedMenu = null;
            }
        }

        private void numericUpDownQtyFood_ValueChanged(object sender, EventArgs e)
        {
            labelTotalNominalFood.Text = (selectedMakanan.Harga * (int)numericUpDownQtyFood.Value).ToString();
        }

        private void numericUpDownQtyBeverage_ValueChanged(object sender, EventArgs e)
        {
            labelNominalTotalBeverage.Text = (selectedMinuman.Harga * (int)numericUpDownQtyBeverage.Value).ToString();
        }

        private void comboBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMakanan = (Menus)comboBoxFood.SelectedItem;
            labelTotalNominalFood.Text = (selectedMakanan.Harga * (int)numericUpDownQtyFood.Value).ToString();
        }

        private void comboBoxBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMinuman = (Menus)comboBoxBeverage.SelectedItem;
            labelNominalTotalBeverage.Text = (selectedMinuman.Harga * (int)numericUpDownQtyBeverage.Value).ToString();
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMenu.Columns["buttonHapusGrid"].Index)
            {
                int rowIndex = e.RowIndex; // Get the clicked row index

                // Make sure the rowIndex is valid
                if (rowIndex >= 0 && rowIndex < dataGridViewMenu.Rows.Count)
                {
                    // konfirmasi penghapusan ke user
                    DialogResult dr = MessageBox.Show("Delete data at row " + (rowIndex + 1) + "?", "Delete Process",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes) // jika user setuju hapus data
                    {
                        try
                        {
                            dataGridViewMenu.Rows.RemoveAt(rowIndex);
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
}
