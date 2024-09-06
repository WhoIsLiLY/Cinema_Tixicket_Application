using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Celikoor_Tixycket
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }
        FormUtama formUtama;
        string barcodeString;
        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pictureBox1.Image = barcode.Draw(textBoxGenerate.Text, 50);
        }

        private void save()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += printBarcode;
            pd.Document = pDoc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
        }

        private void printBarcode(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            float x = e.MarginBounds.Left + (e.MarginBounds.Width - bmp.Width) / 2;
            float y = e.MarginBounds.Top + (e.MarginBounds.Height - bmp.Height) / 40;
            e.Graphics.DrawImage(bmp, x, y);

            // Draw text above the barcode
            Font textFont = new Font("Arial", 24, FontStyle.Bold); // You can adjust the font and size
            float textX = x + (bmp.Width - e.Graphics.MeasureString(barcodeString, textFont).Width) / 2;
            float textY = y + 140; // Adjust the vertical position as needed
            e.Graphics.DrawString(barcodeString, textFont, Brushes.Black, textX, textY);
            bmp.Dispose();
        }
        private void FormKasir_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
            List<Invoices> listInvoices = Invoices.BacaData();
            dgvData.DataSource = listInvoices;
            if(formUtama.pegawaiLogin.Role == "KASIR")
            {
                //int statusColumnIndex = 6;
                //! Ini buat apa ya?
                int actionColumnIndex = 7;

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    DataGridViewButtonColumn btnValidasi = new DataGridViewButtonColumn();
                    btnValidasi.Text = "Validasi";
                    btnValidasi.HeaderText = "Action";
                    btnValidasi.UseColumnTextForButtonValue = true;
                    btnValidasi.Name = "buttonValidasiGrid";
                    if (!dgvData.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == btnValidasi.Name))
                    {
                        dgvData.Columns.Insert(actionColumnIndex, btnValidasi);
                    }
                    
                    DataGridViewButtonColumn btnSelesai = new DataGridViewButtonColumn();
                    btnSelesai.Text = "Selesai";
                    btnSelesai.HeaderText = "Action";
                    btnSelesai.UseColumnTextForButtonValue = true;
                    btnSelesai.Name = "buttonSelesaiGrid";

                    if (!dgvData.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == btnSelesai.Name))
                    {
                        dgvData.Columns.Insert(actionColumnIndex, btnSelesai);
                    }
                    
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dgvData.CurrentRow.Cells["Id"].Value.ToString();
            Invoices invoice = new Invoices();
            invoice.Id = int.Parse(kode);
            invoice.Kasir = formUtama.pegawaiLogin;
            if (e.ColumnIndex == dgvData.Columns["buttonValidasiGrid"].Index)
            {
                if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PENDING")
                {
                    DialogResult dr = MessageBox.Show("Validate invoice " + kode + "?", "Validate Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) //jika user setuju hapus data
                    {
                        try
                        {
                            //hapus data dari database
                            Invoices.UbahData(invoice, false);
                            //refresh form master
                            FormKasir_Load(this, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to validate data: " + ex.Message);
                        }
                    }
                }
                else if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "VALIDASI")
                {
                    MessageBox.Show("Has been validated!");
                }
                else
                {
                    MessageBox.Show("Has been paid!");
                }
                //konfirmasi penghapusan ke user
                
            }
            else if (e.ColumnIndex == dgvData.Columns["buttonSelesaiGrid"].Index)
            {
                if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "VALIDASI")
                {
                    DialogResult dr = MessageBox.Show("Finish process " + kode + "?", "Finish Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) //jika user setuju hapus data
                    {
                        try
                        {
                            //hapus data dari database
                            Invoices.UbahData(invoice, true);
                            List<Ticket> listTiket = Ticket.BacaData("", invoice.Id.ToString());
                            //print

                            for(int i = 0; i < listTiket.Count(); i++)
                            {
                                barcodeString = listTiket[i].NoInvoice.Id.ToString().PadLeft(3, '0') + $"{listTiket[i].NoKursi}";
                                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                                pictureBox1.Image = barcode.Draw(barcodeString, 50);
                                save();
                            }
                            //refresh form master
                            FormKasir_Load(this, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to finish data: " + ex.Message);
                        }
                    }
                }
                else if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PENDING")
                {
                    MessageBox.Show("Hasn't been validated!");
                }
                else
                {
                    MessageBox.Show("Has been paid!");
                }
                //konfirmasi penghapusan ke user
                
            }
        }
    }
}
