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
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void buttonPrint4_Click(object sender, EventArgs e)
        {
            Studio.BacaDataUtilitasTerendah();
        }

        private void buttonPrint3_Click(object sender, EventArgs e)
        {
            Film.BacaDataFilmTidakHadir();
        }

        private void buttonPrint1_Click(object sender, EventArgs e)
        {
            Film.BacaDataFilmTerlaris();
        }

        private void buttonPrint2_Click(object sender, EventArgs e)
        {
            Cinema.BacaTigaPeringkatAtas();
        }

        private void buttonPrint5_Click(object sender, EventArgs e)
        {
            Konsumen.BacaDataNontonFilmComedy();
        }

        private void buttonPrint6_Click(object sender, EventArgs e)
        {
            Aktor_film.BacaDataAktorFilm();
        }
    }
}
