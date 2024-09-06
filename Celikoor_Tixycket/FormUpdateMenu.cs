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
    public partial class FormUpdateMenu : Form
    {
        public FormUpdateMenu()
        {
            InitializeComponent();
        }

        public string idUpdate;

        private void FormUpdateMenu_Load(object sender, EventArgs e)
        {
            List<Menus> listMenu = Menus.BacaData("id", idUpdate);
            textBoxNamaMenu.Text = listMenu[0].Nama;
            comboBoxJenisMenu.SelectedItem = listMenu[0].JenisMenu;
            textBoxHarga.Text = listMenu[0].Harga.ToString();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Menus menu = new Menus();
                menu.Id = int.Parse(idUpdate);
                menu.Nama = textBoxNamaMenu.Text;
                menu.JenisMenu = (string)comboBoxJenisMenu.SelectedItem;
                menu.Harga = double.Parse(textBoxHarga.Text);

                Menus.UbahData(menu);

                MessageBox.Show("Success to update data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to update data! Error: " + x.Message);
            }
        }
    }
}
