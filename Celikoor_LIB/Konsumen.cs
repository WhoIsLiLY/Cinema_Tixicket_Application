using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Konsumen
    {
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string noHp;
        private string gender;
        private string tglLahir;
        private double saldo;
        private string username;
        private string password;
        #endregion

        #region CONSTRUCTORS
        public Konsumen()
        {
            Id = 0;
            Nama = "";
            Email = "";
            NoHp = "";
            Gender = "";
            TglLahir = "";
            Saldo = 0;
            Username = "";
            Password = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Gender { get => gender; set => gender = value; }
        public string TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Konsumen konsumen)
        {
            string perintah = $"INSERT INTO konsumens (nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " +
                $"VALUES ('{konsumen.Nama}', '{konsumen.Email}', '{konsumen.NoHp}', '{konsumen.Gender}'" +
                $", '{konsumen.TglLahir}', '{konsumen.Saldo}', '{konsumen.Username}', '{konsumen.Password}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD UPDATE U
        public static void UbahData(Konsumen konsumen)
        {
            string perintah = $"UPDATE konsumens SET nama='{konsumen.Nama}', email='{konsumen.Email}', no_hp='{konsumen.NoHp}'" +
                $", gender='{konsumen.Gender}', tgl_lahir='{konsumen.TglLahir}', saldo='{konsumen.Saldo}'" +
                $", username='{konsumen.Username}', password='{konsumen.Password}' WHERE id='{konsumen.Id}'";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }
        public static void UbahNominalSaldo(Konsumen konsumen)
        {
            string perintah = $"UPDATE konsumens SET saldo='{konsumen.Saldo}' WHERE id='{konsumen.Id}'";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }
        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM konsumens WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Konsumen> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM konsumens";
            }
            else if(filter == "id")
            {
                perintah = $"SELECT * FROM konsumens where id = '{nilai}'";
            }
            else
            {
                perintah = $"SELECT * FROM konsumens WHERE {filter} like '%{nilai}%'";
            }

            List<Konsumen> listKonsumen = new List<Konsumen>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            
            while (dr.Read() == true)
            {
                Konsumen tampung = new Konsumen();

                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Email = dr.GetValue(2).ToString();
                tampung.NoHp = dr.GetValue(3).ToString();
                tampung.Gender = dr.GetValue(4).ToString();
                tampung.TglLahir = dr.GetValue(5).ToString();
                tampung.Saldo = double.Parse(dr.GetValue(6).ToString());
                tampung.Username = dr.GetValue(7).ToString();
                tampung.Password = dr.GetValue(8).ToString();
                listKonsumen.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listKonsumen;
        }

        //! METHOD CEK LOGIN KONSUMEN
        public static Konsumen CekLogin(string username, string pswd)
        {
            string perintah = $"SELECT * FROM konsumens k WHERE k.username='{username}' and k.password = '{pswd}'";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            if (dr.Read() == true)
            {
                Konsumen tampung = new Konsumen();

                tampung.Id= int.Parse(dr.GetValue(0).ToString());
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Email = dr.GetValue(2).ToString();
                tampung.NoHp = dr.GetValue(3).ToString();
                tampung.Gender = dr.GetValue(5).ToString(); //password tidak boleh diakses oleh siapapun kecuali pemiliknya
                tampung.TglLahir = dr.GetValue(5).ToString();
                tampung.Saldo = double.Parse(dr.GetValue(6).ToString());
                tampung.Username = dr.GetValue(7).ToString();

                conn.KoneksiDB.Close();
                return tampung;
            }

            else conn.KoneksiDB.Close(); return null;
        }
        public static void BacaDataNontonFilmComedy()
        {
            string perintah = $"SELECT konsumens.nama, COUNT(invoices.id) as jumlah\r\nFROM invoices\r\nINNER JOIN konsumens on konsumens.id = invoices.konsumens_id\r\nINNER JOIN tikets on tikets.invoices_id = invoices.id\r\nINNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id\r\nINNER JOIN film_studio on film_studio.films_id = sesifilms.films_id\r\nINNER JOIN films on films.id = sesifilms.films_id\r\nINNER JOIN genre_film on genre_film.films_id = films.id\r\nINNER JOIN genres on genres.id = genre_film.genres_id\r\nWHERE genres.nama = 'Comedy'\r\nGROUP BY konsumens.nama\r\nLIMIT 10;";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            string nama = "Customer's Watching Comedy_" + DateTime.Now.ToString("yyyyMMddHHmm");

            StreamWriter namaFile = new StreamWriter(nama);

            namaFile.WriteLine("TEN CUSTOMER THAT WATCHED MOST COMEDY FILMS");
            namaFile.WriteLine();
            namaFile.WriteLine("ID        CUSTOMERS");
            namaFile.WriteLine("--------------------------------------------------------------------------------------------");
            while (dr.Read() == true)
            {
                namaFile.WriteLine(dr.GetValue(0) + "      " + dr.GetValue(1));
            }
            //kirim list ke pemanggilnya
            conn.KoneksiDB.Close();
            namaFile.WriteLine("--------------------------------------------------------------------------------------------");
            namaFile.WriteLine("Printed On: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            namaFile.WriteLine("--------------------------------------------------------------------------------------------");
            namaFile.Close();
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
