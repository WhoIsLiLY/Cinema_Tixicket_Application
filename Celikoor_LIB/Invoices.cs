using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Invoices
    {
        #region FIELDS
        private int id;
        private string tanggal;
        private double grand_total;
        private double diskon_nominal;
        private Konsumen penonton;
        private Pegawai kasir;
        private string status;
        #endregion

        #region CONSTRUCTORS
        public Invoices()
        {
            Id = 0;
            Tanggal = "";
            Grand_total = 0;
            Diskon_nominal = 0;
            Penonton = new Konsumen();
            Kasir = new Pegawai();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public double Grand_total { get => grand_total; set => grand_total = value; }
        public double Diskon_nominal { get => diskon_nominal; set => diskon_nominal = value; }
        public Konsumen Penonton { get => penonton; set => penonton = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Invoices invoice)
        {
            string perintah = $"INSERT INTO invoices (tanggal, grand_total, diskon_nominal, konsumens_id, status) " +
                $"VALUES (now(), '{invoice.Grand_total}'" +
                $", '{invoice.Diskon_nominal}', '{invoice.Penonton.Id}', 'PENDING');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD UPDATE U
        public static void UbahData(Invoices invoice, bool isPaid)
        {
            string perintah;

            if (!isPaid)
            {
                perintah = $"UPDATE invoices SET status='VALIDASI', kasir_id = '{invoice.Kasir.Id}' WHERE id='{invoice.id}';";
            }

            else
            {
                perintah = $"UPDATE invoices SET status='TERBAYAR' WHERE id='{invoice.Id}';";
            }

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD RETRIEVE R
        public static string GenerateNoInvoice()
        {
            string invoiceBaru = "001";

            string perintah = $"SELECT * FROM invoices " +
                $"\norder by invoices desc " +
                $"\nlimit 1;";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            if (dr.Read() == true)
            {
                string noInvoiceAkhir = dr.GetValue(0).ToString().Substring(3);
                int noInvoiceBaru = int.Parse(noInvoiceAkhir) + 1;

                invoiceBaru = noInvoiceBaru.ToString().PadLeft(3, '0');
            }
            conn.KoneksiDB.Close();
            return invoiceBaru;
        }
        public static List<Invoices> BacaData(string filter="", string nilai = "")
        {
            string perintah;
            if(filter == "")
            {
                perintah = $"SELECT * FROM invoices";
            }else if (filter == "getLastIndex")
            {
                perintah = $"select * from invoices order by id DESC limit 1";
            }
            else
            {
                perintah = $"SELECT * FROM invoices where {filter} = '{nilai}'";
            }

            List<Invoices> listInvoices = new List<Invoices>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Invoices tampung = new Invoices();

                tampung.Id = int.Parse(dr.GetValue(0).ToString());
                tampung.Tanggal = dr.GetValue(1).ToString();
                tampung.Grand_total = int.Parse(dr.GetValue(2).ToString());
                tampung.Diskon_nominal = int.Parse(dr.GetValue(3).ToString());
                tampung.Penonton = Konsumen.BacaData("id", dr.GetValue(4).ToString())[0];
                //Pegawai kasir = new Pegawai();
                if (dr.GetValue(5).ToString() != "")
                {
                    tampung.Kasir.Id = int.Parse(dr.GetValue(5).ToString());
                    List<Pegawai> listItem = Pegawai.BacaData("id", tampung.Kasir.Id.ToString());
                    tampung.Kasir = listItem[0];
                }
                tampung.Status = dr.GetValue(6).ToString();
                listInvoices.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listInvoices;
        }
        #endregion
    }
}
