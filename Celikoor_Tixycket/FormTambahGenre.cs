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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Genre g = new Genre();
                g.Nama = textBoxGenre.Text;
                g.Deskripsi = richTextBoxDeskripsi.Text;

                Genre.TambahData(g);
                MessageBox.Show("Success to add data!");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }

        private void FormTambahGenre_Load(object sender, EventArgs e)
        {
            textBoxGenre.Select();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
