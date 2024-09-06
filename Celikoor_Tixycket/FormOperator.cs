using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormOperator : Form
    {
        public FormOperator()
        {
            InitializeComponent();
        }
        Ticket tiket;
        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            tiket = new Ticket();
            try
            {
                string barcode = textBoxCari.Text;
                string pattern = @"(?<Number>\d+)(?<SeatCode>[A-Za-z0-9]+)";

                // Match the pattern against the input barcodes
                Match match = Regex.Match(barcode, pattern);
                if (match.Success)
                {
                    string invoiceID = match.Groups["Number"].Value;
                    string seatCode = match.Groups["SeatCode"].Value;
                    List<Ticket> listTicket = Ticket.BacaData(seatCode, invoiceID);
                    tiket = listTicket[0];
                }
                labelMovieName.Text = tiket.Film.Judul;
                labelCinema.Text = tiket.Studio.Cinema.Nama_cabang;
                labelTanggal.Text = tiket.JadwalFilm.Tanggal;
                labelSession.Text = tiket.JadwalFilm.Jam_pemutaran;
                labelInvoice.Text = tiket.NoInvoice.Id.ToString();
                labelSeat.Text = tiket.NoKursi;
                labelStudio.Text = tiket.Studio.Nama;
                if(tiket.StatusHadir == 0)
                {
                    labelStatus.Text = "NOT SCANNED";
                }
                else{
                    labelStatus.Text = "SCANNED";
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ticket with ID {textBoxCari.Text} not found" + x.Message);
            }
        }

        private void FormOperator_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tiket.StatusHadir == 0)
            {
                Ticket.UbahData(tiket);
                MessageBox.Show("Scanned!");
                FormOperator_Load(this, e);
            }
            else MessageBox.Show("Already Scanned!");
        }
    }
}
