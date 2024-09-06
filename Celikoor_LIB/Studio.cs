using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Celikoor_LIB
{
    public class Studio
    {
        #region FIELDS
        int id;
        string nama;
        int kapasitas;
        Jenis_Studio jenisStudio;
        Cinema cinema;
        int harga_weekday;
        int harga_weekend;
        #endregion

        #region CONSTRUCTORS
        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
            JenisStudio = new Jenis_Studio();
            Cinema = new Cinema();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public Jenis_Studio JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Studio studio)
        {
            string perintah = $"INSERT INTO studios (nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend)" +
                $"VALUES ('{studio.Nama}', '{studio.Kapasitas}', '{studio.JenisStudio.Id}', '{studio.Cinema.Id}'" +
                $", '{studio.Harga_weekday}', '{studio.Harga_weekend}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD UPDATE U
        public static void UbahData(Studio studio)
        {
            string perintah = $"UPDATE studios SET nama='{studio.Nama}', kapasitas='{studio.Kapasitas}'" +
                $", jenis_studios_id='{studio.JenisStudio.Id}', cinemas_id='{studio.Cinema.Id}'" +
                $", harga_weekday='{studio.Harga_weekday}', harga_weekend='{studio.Harga_weekend}' WHERE id='{studio.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM studios WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Studio> BacaData(string filter="", string nilai="", string additionParameter="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM studios";
            }
            else if(filter == "id")
            {
                perintah = $"SELECT * FROM studios WHERE id = '{nilai}'";
            }
            else if(filter == "fromCinema")
            {
                perintah = $"SELECT * FROM studios WHERE cinemas_id = '{nilai}' and nama = '{additionParameter}'";
            }
            else
            {
                perintah = $"SELECT * FROM studios WHERE {filter} like '%{nilai}%'";
            }
            List<Studio> listStudio = new List<Studio>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Studio tampung = new Studio();

                tampung.Id = int.Parse(dr.GetValue(0).ToString());
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(dr.GetValue(2).ToString());
                Jenis_Studio tampungJenisStudio = new Jenis_Studio();
                if (dr.GetValue(3).ToString() != "")
                {
                    tampung.JenisStudio.Id = int.Parse(dr.GetValue(3).ToString());
                    List<Jenis_Studio> listItem = Jenis_Studio.BacaData(tampung.JenisStudio.Id.ToString());
                    tampung.JenisStudio = listItem[0];
                }
                Cinema tampungCinema = new Cinema();
                if (dr.GetValue(4).ToString() != "")
                {
                    tampung.Cinema.Id = int.Parse(dr.GetValue(4).ToString());
                    List<Cinema> listItem = Cinema.BacaData("id", tampung.Cinema.Id.ToString());
                    tampung.Cinema = listItem[0];
                }
                tampung.Harga_weekday = int.Parse(dr.GetValue(5).ToString());
                tampung.Harga_weekend = int.Parse(dr.GetValue(6).ToString());
                listStudio.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listStudio;
        }
        public static void BacaDataUtilitasTerendah()
        {
            string perintah = $"SELECT cinemas.nama_cabang as 'Nama Cabang', studios.id as 'Studio Id', Monthname(invoices.tanggal) as Month, " +
                $"(SELECT SUM(studios.kapasitas)) - COUNT(tikets.status_hadir) as Jumlah FROM invoices " +
                $"INNER JOIN tikets on tikets.invoices_id = invoices_id " +
                $"INNER JOIN sesi_films on sesi_films.films_id = tikets.films_id " +
                $"INNER JOIN film_studio on film_studio.films_id = sesi_films.films_id " +
                $"INNER JOIN studios on studios.id = film_studio.studios_id " +
                $"INNER JOIN cinemas on cinemas.id = studios.cinemas_id " +
                $"WHERE tikets.status_hadir = '0' " +
                $"GROUP BY cinemas.nama_cabang, studios.id, Month " +
                $"order by Jumlah asc limit 3;";

            Koneksi conn = new Koneksi();

            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            string nama = "Studio Lowest Utilities_" + DateTime.Now.ToString("yyyyMMddHHmm");

            StreamWriter namaFile = new StreamWriter(nama);


            namaFile.WriteLine("THREE STUDIOS WITH THE LOWEST UTILITIES ALONG WITH THE CINEMA's NAME");
            namaFile.WriteLine();
            namaFile.WriteLine("CINEMA       STUDIO        MONTH        JUMLAH");
            namaFile.WriteLine("--------------------------------------------------------------------------------------------");
            while (dr.Read())
            {
                namaFile.WriteLine(dr.GetValue(0) + "      " + Studio.BacaData("id", dr.GetValue(1).ToString())[0].Nama + "          " + dr.GetValue(2) + "       " + dr.GetValue(3));
            }
            namaFile.WriteLine("--------------------------------------------------------------------------------------------");
            namaFile.WriteLine("Printed On: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            namaFile.WriteLine("--------------------------------------------------------------------------------------------");
            namaFile.Close();

            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();
            conn.KoneksiDB.Close();
        }
        public static void CetakStudioLowUtilities()
        {
            
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
