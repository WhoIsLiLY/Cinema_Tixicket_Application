using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor_film
    {
        #region FIELDS
        private Aktor aktor;
        private string peran;
        #endregion

        #region CONSTRUCTORS
        public Aktor_film()
        {
            Aktor = new Aktor();
            Peran = "";
        }
        #endregion

        #region PROPERTIES
        public Aktor Aktor { get => aktor; set => aktor = value; }
        public string Peran { get => peran; set => peran = value; }
        #endregion
        public static void BacaDataAktorFilm()
        {
            string perintah = $"SELECT a.nama, COUNT(aktors_id) as total FROM aktor_film af " + $"INNER JOIN aktors a on af.aktors_id = a.id " + $"GROUP BY aktors_id " + $"ORDER BY total DESC LIMIT 3";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            string nama = "Laporan Aktor Film";
            StreamWriter NamaFile = new StreamWriter(nama);
            NamaFile.WriteLine("Aktor dengan film terbanyak");
            NamaFile.WriteLine("Celikoor");
            NamaFile.WriteLine("------------------------------");
            NamaFile.WriteLine("");
            NamaFile.WriteLine("Nama Aktor       Jumlah Film");
            while (dr.Read() == true)
            {
                NamaFile.WriteLine(dr.GetValue(0) + "       " + dr.GetValue(1));
            }
            conn.KoneksiDB.Close();
            NamaFile.WriteLine("--------------------------------------------------");
            NamaFile.Close();

            // proses mencetak ke printer
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();
        }
    }
}
