using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor
    {
        #region FIELDS
        int id;
        string nama;
        string tglLahir;
        string gender;
        string negaraAsal;
        #endregion

        #region CONSTRUCTORS
        public Aktor()
        {
            Id = 0;
            Nama = "";
            TglLahir = "";
            Gender = "";
            NegaraAsal = "";
        }
        #endregion

        #region PROPERTIES
        public int Id 
        { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }

        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Aktor aktor)
        {
            string perintah = $"INSERT INTO aktors (nama, tgl_lahir, gender, negara_asal) " +
                $"VALUES ('{aktor.Nama}', '{aktor.TglLahir}', '{aktor.Gender}', '{aktor.NegaraAsal}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD UPDATE U
        public static void UbahData(Aktor aktor)
        {
            string perintah = $"UPDATE aktors SET nama='{aktor.Nama}', tgl_lahir='{aktor.TglLahir}' WHERE id='{aktor.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM aktors WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Aktor> BacaData(string filter="", string nilai ="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM aktors";
            }
            else if (filter == "id")
            {
                perintah = $"SELECT * FROM aktors WHERE id = '{nilai}'";
            }
            else
            {
                perintah = $"SELECT * FROM aktors WHERE {filter} like '%{nilai}%'";
            }

            List<Aktor> listAktor = new List<Aktor>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {   
                Aktor tampung = new Aktor();

                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.TglLahir = dr.GetValue(2).ToString();
                tampung.Gender = dr.GetValue(3).ToString();
                tampung.NegaraAsal = dr.GetValue(4).ToString();

                listAktor.Add(tampung);
            }
            conn.KoneksiDB.Close();
            //kirim list ke pemanggilnya
            return listAktor;
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
