using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Menus
    {
        private int id;
        private string nama;
        private string jenisMenu;
        private double harga;
        List<DetilMenu> listDetail;
        public Menus()
        {
            Id = 0;
            Nama = "";
            JenisMenu = "";
            Harga = 0; ;    
            ListDetail = new List<DetilMenu>(); 
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string JenisMenu { get => jenisMenu; set => jenisMenu = value; }
        public double Harga { get => harga; set => harga = value; }
        public List<DetilMenu> ListDetail { get => listDetail; set => listDetail = value; }

        public void TambahDetil(Menus menu, int totalHarga, int kuantitas)
        {
            DetilMenu newDetil = new DetilMenu();
            newDetil.MenuId = menu.Id;
            newDetil.TotalHarga = totalHarga;
            newDetil.Kuantitas = kuantitas;

            ListDetail.Add(newDetil);
        }
        public static void TambahData(Menus menu)
        {
            string perintah = $"INSERT INTO menus (nama, jenis_menu, harga) VALUES ('{menu.Nama}', '{menu.JenisMenu}', '{menu.Harga}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }
        public static void TambahDataDetilMenu(Menus menu, Invoices invoice, Jadwal_film jadwal, Studio studio, Film film)
        {
            for(int i =0; i < menu.ListDetail.Count; i++)
            {
                string perintah = $"INSERT INTO detail_menu (invoices_id, menus_id, waiters_id, total, jadwal_film_id, studios_id, films_id, kuantitas) VALUES ('{invoice.Id}', '{menu.ListDetail[i].MenuId}', '4', '{menu.ListDetail[i].TotalHarga}', '{jadwal.Id}', '{studio.Id}', '{film.Id}', '{menu.ListDetail[i].Kuantitas}');";
                Koneksi conn = new Koneksi();
                conn.JalankanPerintahQuery(perintah);
                conn.KoneksiDB.Close();
            }
        }
        public static void UbahData(Menus menu)
        {
            string perintah = $"UPDATE menus SET nama = '{menu.Nama}', jenis_menu = '{menu.JenisMenu}', harga = '{menu.Harga}' WHERE id = '{menu.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM menus WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static List<Menus> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM menus";
            }
            else if(filter == "FOOD")
            {
                perintah = $"SELECT * FROM menus where jenis_menu = 'FOOD'";
            }
            else if (filter == "BEVERAGE")
            {
                perintah = $"SELECT * FROM menus where jenis_menu = 'BEVERAGE'";
            }
            else if (filter == "id")
            {
                perintah = $"SELECT * FROM menus WHERE id = '{nilai}'";
            }

            else
            {
                perintah = $"SELECT * FROM menus WHERE {filter} like '%{nilai}%'";
            }

            List<Menus> listMenu = new List<Menus>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Menus tampung = new Menus();

                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();             
                tampung.JenisMenu = dr.GetValue(3).ToString();
                tampung.Harga = double.Parse(dr.GetValue(2).ToString());

                listMenu.Add(tampung);
            }

            return listMenu;
        }
    }
}
