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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahJenisStudio_Load(object sender, EventArgs e)
        {
            textBoxJenisStudio.Select();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Jenis_Studio jenisStudio = new Jenis_Studio();
                jenisStudio.Nama = textBoxJenisStudio.Text;
                jenisStudio.Deskripsi = richTextBoxDeskripsi.Text;

                Jenis_Studio.TambahData(jenisStudio);
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
