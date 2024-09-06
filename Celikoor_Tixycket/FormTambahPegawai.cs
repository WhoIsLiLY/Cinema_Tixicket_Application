using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Celikoor_LIB;

namespace Celikoor_Tixycket
{
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai p = new Pegawai();
                p.Nama = textBoxNamaPegawai.Text;
                p.Email = textBoxEmailPegawai.Text;
                p.Username = textBoxUsernamePegawai.Text;
                p.Password = textBoxPasswordPegawai.Text;
                p.Role = (string)comboBoxRolePegawai.SelectedItem;

                Pegawai.TambahData(p);
                MessageBox.Show("Success to add data!");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            List<Pegawai> listDataPegawai = Pegawai.BacaData();
            comboBoxRolePegawai.DataSource = listDataPegawai;
            comboBoxRolePegawai.DisplayMember = "Roles";
        }

        private void FormTambahPegawai_Load_1(object sender, EventArgs e)
        {
            textBoxNamaPegawai.Select();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
