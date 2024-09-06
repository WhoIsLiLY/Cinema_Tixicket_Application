using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Kelompok
    {
        #region FIELDS
        int id;
        string nama;
        #endregion

        #region CONSTRUCTORS
        public Kelompok()
        {
            Id = 0;
            Nama = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Kelompok kelompok)
        {
            //susun perintah query
            string perintah = $"INSERT INTO kelompoks (nama) VALUES ('{kelompok.Nama}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            //susun perintah query
            string perintah = $"DELETE FROM kelompoks WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R
        public static List<Kelompok> BacaData(string id="")
        {
            //susun perintah query
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM kelompoks";
            }

            else
            {
                perintah = $"SELECT * FROM kelompoks WHERE id ='{id}'";
            }

            //eksekusi perintah di atas
            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Kelompok> listKelompok = new List<Kelompok>();
            Koneksi conn = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, conn.KoneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader();
            //selama masih ada data yang dapat dibaca dari datareader
            while (dr.Read() == true)
            { 
                Kelompok tampung = new Kelompok();
                tampung.Id = int.Parse(dr.GetValue(0).ToString()); //kolom pertama
                tampung.Nama = dr.GetValue(1).ToString(); //kolom kedua

                listKelompok.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listKelompok;
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
