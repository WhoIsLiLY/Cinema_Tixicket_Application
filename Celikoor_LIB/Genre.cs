using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Genre
    {
        #region FIELDS
        int id;
        string nama;
        string deskripsi;
        #endregion

        #region CONSTRUCTORS
        public Genre()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Genre genre)
        {
            string perintah = $"INSERT INTO genres (nama, deskripsi) VALUES ('{genre.Nama}', '{genre.Deskripsi}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM genres WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R
        public static List<Genre> BacaData(string filter = "", string id="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM genres";
            }

            else
            {
                perintah = $"SELECT * FROM genres WHERE {filter} like '%{id}%'";
            }

            List<Genre> listGenre = new List<Genre>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            //selama masih ada data yang dapat dibaca dari datareader
            while (dr.Read() == true)
            {
                Genre tampung = new Genre();
                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Deskripsi = dr.GetValue(2).ToString();

                listGenre.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listGenre;
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
