using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Ticket
    {
        #region FIELDS
        private Invoices noInvoice;
        private string noKursi;
        private int statusHadir;
        private Pegawai operators;
        private double harga;
        private Jadwal_film jadwalFilm;
        private Studio studio;
        private Film film;

        
        #endregion

        #region CONSTRUCTORS
        public Ticket()
        {
            NoInvoice = new Invoices();
            NoKursi = "";
            StatusHadir = 0;
            Operators = new Pegawai();
            Harga = 0;
            JadwalFilm = new Jadwal_film();
            Studio = new Studio();
            Film = new Film();
        }
        #endregion

        #region PROPERTIES
        public Invoices NoInvoice { get => noInvoice; set => noInvoice = value; }
        public string NoKursi { get => noKursi; set => noKursi = value; }
        public int StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai Operators { get => operators; set => operators = value; }
        public double Harga { get => harga; set => harga = value; }
        public Jadwal_film JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Ticket ticket)
        {
            string perintah = $"INSERT INTO tikets (invoices_id, nomor_kursi, status_hadir, operator_id, harga, jadwal_film_id, studios_id, films_id) " +
                $"VALUES ('{ticket.NoInvoice.Id}', '{ticket.NoKursi}', '0', '1', '{ticket.Harga}'" +
                $", '{ticket.JadwalFilm.Id}', '{ticket.Studio.Id}', '{ticket.Film.Id}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD UBAH U
        public static void UbahData(Ticket ticket)
        {
            string perintah = $"UPDATE tikets SET status_hadir='1' WHERE invoices_id='{ticket.NoInvoice.Id}' and nomor_kursi='{ticket.NoKursi}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R
        public static string GenerateBarcode(Ticket ticket)
        {
            string barcodeBaru = "001" + ticket.NoKursi;

            string perintah = $"SELECT * FROM invoices " +
                //$"\nWHERE tanggal=current_date " +
                $"\norder by invoices desc " +
                $"\nlimit 1;";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            conn.KoneksiDB.Close(); //kirim ke command

            if (dr.Read() == true)
            {
                string noBarcodeAkhir = dr.GetValue(0).ToString().Substring(3);
                int noBarcodeBaru = int.Parse(noBarcodeAkhir) + 1;

                barcodeBaru = noBarcodeBaru.ToString().PadLeft(3, '0') + ticket.NoKursi;
            }

            return barcodeBaru;
        }
        public static List<Ticket> BacaDataSpesifik(string nomorKursi="", Film film = null, Studio studio = null, Jadwal_film jadwal_film = null)
        {
            string perintah = $"SELECT * FROM tikets WHERE nomor_kursi = '{nomorKursi}' and films_id = '{film.Id}' and studios_id = '{studio.Id}' and jadwal_film_id = '{jadwal_film.Id}'";

            List<Ticket> listTiket = new List<Ticket>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Ticket tampung = new Ticket();

                tampung.NoInvoice = Invoices.BacaData("id", dr.GetValue(0).ToString())[0];
                tampung.NoKursi = dr.GetValue(1).ToString();
                tampung.StatusHadir = int.Parse(dr.GetValue(2).ToString());
                //tampung.Operators = Pegawai.BacaDataSpesifik("id", dr.GetValue(3).ToString())[0];
                tampung.Harga = int.Parse(dr.GetValue(4).ToString());
                tampung.JadwalFilm = Jadwal_film.BacaData("id", dr.GetValue(5).ToString())[0];
                tampung.Studio = Studio.BacaData("id", dr.GetValue(6).ToString())[0];
                tampung.Film = Film.BacaData("id", dr.GetValue(7).ToString())[0];
                listTiket.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listTiket;
        }
        public static List<Ticket> BacaData(string nomorKursi="", string invoicesId="")
        {
            string perintah;
            if(nomorKursi == "")
            {
                perintah = $"SELECT * FROM tikets WHERE invoices_id = '{invoicesId}'";
            }
            else
            {
                perintah = $"SELECT * FROM tikets WHERE nomor_kursi = '{nomorKursi}' and invoices_id = '{invoicesId}'";
            }
            

            List<Ticket> listTiket = new List<Ticket>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Ticket tampung = new Ticket();

                tampung.NoInvoice = Invoices.BacaData("id", dr.GetValue(0).ToString())[0];
                tampung.NoKursi = dr.GetValue(1).ToString();
                tampung.StatusHadir = int.Parse(dr.GetValue(2).ToString());
                //tampung.Operators = Pegawai.BacaDataSpesifik("id", dr.GetValue(3).ToString())[0];
                tampung.Harga = int.Parse(dr.GetValue(4).ToString());
                tampung.JadwalFilm = Jadwal_film.BacaData("id", dr.GetValue(5).ToString())[0];
                tampung.Studio = Studio.BacaData("id", dr.GetValue(6).ToString())[0];
                tampung.Film = Film.BacaData("id", dr.GetValue(7).ToString())[0];
                listTiket.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listTiket;
        }
        #endregion
    }
}
