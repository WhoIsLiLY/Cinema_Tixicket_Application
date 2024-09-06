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
    public partial class FormTambahAktor : Form
    {
        public FormTambahAktor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Aktor a = new Aktor();
                a.Nama = textBoxNama.Text;
                a.TglLahir = dateTimePickerTglLahir.Value.ToString("yyyy-MM-dd");
                if (radioButtonMale.Checked)
                {
                    a.Gender = "L";
                }
                else if (radioButtonFemale.Checked)
                {
                    a.Gender = "P";
                }
                a.NegaraAsal = textBoxNegaraAsalAktor.Text;

                Aktor.TambahData(a);
                MessageBox.Show("Success to add data!");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }

        private void FormTambahAktor_Load(object sender, EventArgs e)
        {
            textBoxNama.Select();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
