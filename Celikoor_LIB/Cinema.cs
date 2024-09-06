using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Cinema
    {
        #region FIELDS
        int id;
        string nama_cabang;
        string alamat;
        DateTime tglDibuka;
        string kota;
        #endregion

        #region CONSTRUCTORS
        public Cinema()
        {
            Id = 0;
            Nama_cabang = "";
            Alamat = "";
            TglDibuka = DateTime.Now;
            Kota = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime TglDibuka { get => tglDibuka; set => tglDibuka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Cinema cinema)
        {
            string perintah = $"INSERT INTO cinemas (nama_cabang, alamat, tgl_dibuka, kota) " +
                $"VALUES ('{cinema.Nama_cabang}', '{cinema.Alamat}', '{cinema.TglDibuka.ToString("yyyy-MM-dd")}'" +
                $", '{cinema.Kota}');";
            
            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM cinemas WHERE id='{idHapus}'";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD RETRIEVE R
        public static List<Cinema> BacaData(string filter="", string nilai="")
        {
            //susun perintah query
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM cinemas";
            }
            else
            {
                perintah = $"SELECT * FROM cinemas WHERE {filter} = '{nilai}'";
            }

            List<Cinema> listCinema = new List<Cinema>();

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Cinema tampung = new Cinema();
                tampung.Id = dr.GetInt32(0);
                tampung.Nama_cabang = dr.GetValue(1).ToString();
                tampung.Alamat = dr.GetValue(2).ToString();
                tampung.TglDibuka = (DateTime)dr.GetValue(3);
                tampung.Kota = dr.GetValue(4).ToString();

                listCinema.Add(tampung);
            }
            //kirim list ke pemanggilnya
            conn.KoneksiDB.Close();
            return listCinema;
        }
        public static void BacaTigaPeringkatAtas()
        {
            string perintah = $"SELECT cinemas.nama_cabang as 'Nama Cabang' , SUM(tikets.harga) as 'Total'\r\nFROM tikets\r\nINNER JOIN sesi_films on sesi_films.films_id = tikets.films_id\r\nINNER JOIN film_studio on film_studio.films_id = sesi_films.films_id\r\nINNER JOIN studios on studios.id = film_studio.studios_id\r\nINNER JOIN cinemas on cinemas.id = studios.cinemas_id\r\nGROUP BY cinemas.nama_cabang\r\nORDER BY SUM(tikets.harga) desc;";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            string nama = "Omzet Penjualan Tiket_" + DateTime.Now.ToString("yyyyMMddHHmm");

            StreamWriter namaFile = new StreamWriter(nama);

            namaFile.WriteLine("LAPORAN OMZET PENJUALAN TIKET TERTINGGI BERDASARKAN CABANG CINEMA");
            namaFile.WriteLine();
            namaFile.WriteLine("NAMA CABANG      TOTAL");
            namaFile.WriteLine("---------------------------------------------------------------------");
            while (dr.Read() == true)
            {
                namaFile.WriteLine(dr.GetValue(0) + "   " + dr.GetValue(1));
            }
            //kirim list ke pemanggilnya
            conn.KoneksiDB.Close();
            namaFile.WriteLine("---------------------------------------------------------------------");
            namaFile.WriteLine("Tanggal cetak: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            namaFile.WriteLine("---------------------------------------------------------------------");
            namaFile.Close();

            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();
        }
        public override string ToString()
        {
            return Nama_cabang;
        }
        #endregion
    }
}
