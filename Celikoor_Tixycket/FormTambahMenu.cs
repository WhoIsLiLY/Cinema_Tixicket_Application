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
    public partial class FormTambahMenu : Form
    {
        public FormTambahMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Menus menu = new Menus();
                menu.Nama = textBoxNamaMenu.Text;
                menu.JenisMenu = (string)comboBoxJenisMenu.SelectedItem;
                menu.Harga = double.Parse(textBoxHarga.Text);

                Menus.TambahData(menu);

                MessageBox.Show("Success to add data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }
    }
}
