using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Pegawai
    {
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string role;
        #endregion

        #region CONSTRUCTORS
        public Pegawai()
        {
            Id = 0;
            Nama = "";
            Email = "";
            Username = "";
            Password = "";
            Role = "";
        }

        public Pegawai(int id, string nama, string email, string username, string role)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Username = username;
            this.Role = role;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Pegawai pegawai)
        {
            string perintah = $"INSERT INTO pegawais (nama, email, username, password, roles) " +
                $"VALUES ('{pegawai.Nama}', '{pegawai.Email}', '{pegawai.Username}', '{pegawai.Password}'" +
                $", '{pegawai.Role}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM pegawais WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT id, nama, email, username, roles FROM pegawais";
            }
            else if (filter == "id")
            {
                perintah = $"SELECT id, nama, email, username, roles FROM pegawais where id = '{nilai}'";
            }
            else
            {
                perintah = $"SELECT id, nama, email, username, roles FROM pegawais WHERE {filter} like '%{nilai}%'";
            }

            List<Pegawai> listPegawai = new List<Pegawai>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {   
                Pegawai tampung = new Pegawai();
                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Email = dr.GetValue(2).ToString();
                tampung.Username = dr.GetValue(3).ToString();
                tampung.Role = dr.GetValue(4).ToString();

                listPegawai.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listPegawai;
        }

        //! METHOD CEK LOGIN PEGAWAI
        public static Pegawai CekLogin(string username, string pswd)
        {
            string perintah = $"SELECT * FROM pegawais p WHERE p.username='{username}' and p.password = '{pswd}'";
            //eksekusi perintah di atas
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
             //kirim ke command
            //selama masih ada data yang dapat dibaca dari datareader
            if (dr.Read() == true)
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                string nama = dr.GetValue(1).ToString();
                string email = dr.GetValue(2).ToString();
                string usernamePegawai = dr.GetValue(3).ToString();
                string role = dr.GetValue(5).ToString();
                Pegawai tampung = new Pegawai(id, nama, email, usernamePegawai, role);

                conn.KoneksiDB.Close();
                return tampung;
            }
            
            else conn.KoneksiDB.Close(); return null;
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
