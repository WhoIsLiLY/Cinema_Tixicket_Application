using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Jadwal_film
    {
        #region FIELDS
        int id;
        string tanggal;
        string jam_pemutaran;
        #endregion

        #region CONSTRUCTORS
        public Jadwal_film()
        {
            Id = 0;
            Tanggal = "";
            Jam_pemutaran = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Jam_pemutaran { get => jam_pemutaran; set => jam_pemutaran = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Jadwal_film jadwalFilm)
        {
            string perintah = $"INSERT INTO jadwal_films (tanggal, jam_pemutaran) VALUES ('{jadwalFilm.Tanggal}', '{jadwalFilm.Jam_pemutaran}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD UPDATE U
        public static void UbahData(Jadwal_film jadwalFilm)
        {
            string perintah = $"UPDATE jadwal_films SET tanggal='{jadwalFilm.Tanggal}', jam_pemutaran='{jadwalFilm.Jam_pemutaran}' WHERE id='{jadwalFilm.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus="")
        {
            string perintah = $"DELETE FROM jadwal_films WHERE id='{idHapus}'";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }
        public static List<Jadwal_film> CekKetersediaanJadwal(Jadwal_film jadwal, Film film, Studio studio, string tipe="")
        {
            string perintah = $"select * from sesi_films sf inner join film_studio fs on fs.films_id = sf.films_id and fs.studios_id = sf.studios_id inner join films f on f.id = fs.films_id inner join studios s on s.id = fs.studios_id where sf.studios_id = {studio.Id} and sf.films_id = {film.Id};";
            List<Jadwal_film> listJadwalFilm = new List<Jadwal_film>();
            List<Sesi_film> listSesiFilm = new List<Sesi_film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read())
            {
                Sesi_film tampung = new Sesi_film();
                tampung.JadwalFilm.Id = int.Parse(dr.GetValue(0).ToString());
                tampung.FilmStudio.Studio.Id = int.Parse(dr.GetValue(1).ToString());
                tampung.FilmStudio.Film.Id = int.Parse(dr.GetValue(2).ToString());

                listSesiFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            if(tipe == "spesifik")
            {
                listJadwalFilm = AmbilSpesifik(listSesiFilm, conn, jadwal);
            }
            else
            {
                listJadwalFilm = AmbilSemua(listSesiFilm, conn);
            }
            
            return listJadwalFilm;
        }
        public static List<Jadwal_film> AmbilSpesifik(List<Sesi_film> listSesiFilm, Koneksi conn, Jadwal_film jadwal)
        {
            List<Jadwal_film> listJadwalFilm = new List<Jadwal_film>();
            for (int i = 0; i < listSesiFilm.Count; i++)
            {
                string perintah = $"select * from jadwal_films where id='{listSesiFilm[i].JadwalFilm.Id}' and tanggal = '{jadwal.Tanggal}' and jam_pemutaran = '{jadwal.Jam_pemutaran}';";
                conn.KoneksiDB.Open();
                MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
                while (dr.Read())
                {
                    Jadwal_film tampung = new Jadwal_film();
                    tampung.Id = int.Parse(dr.GetValue(0).ToString());
                    tampung.Tanggal = dr.GetValue(1).ToString();
                    tampung.Jam_pemutaran = dr.GetValue(2).ToString();

                    listJadwalFilm.Add(tampung);
                }
                conn.KoneksiDB.Close();
            }
            return listJadwalFilm;
        }
        public static List<Jadwal_film> AmbilSemua(List<Sesi_film> listSesiFilm, Koneksi conn)
        {
            List<Jadwal_film> listJadwalFilm = new List<Jadwal_film>();
            for (int i = 0; i < listSesiFilm.Count; i++)
            {
                string perintah = $"select * from jadwal_films where id='{listSesiFilm[i].JadwalFilm.Id}'";
                conn.KoneksiDB.Open();
                MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
                while (dr.Read())
                {
                    Jadwal_film tampung = new Jadwal_film();
                    tampung.Id = int.Parse(dr.GetValue(0).ToString());
                    if (DateTime.TryParse(dr.GetValue(1).ToString(), out DateTime parsedDate))
                    {
                        tampung.Tanggal = parsedDate.ToString("yyyy-MM-dd");
                    }
                    tampung.Jam_pemutaran = dr.GetValue(2).ToString();

                    listJadwalFilm.Add(tampung);
                }
                conn.KoneksiDB.Close();
            }
            return listJadwalFilm;
        }
        //! METHOD RETRIEVE R dan FILTER F
        public static List<Jadwal_film> BacaData(string filter="", string nilai = "", Jadwal_film jadwal_film = null)
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM jadwal_films";
            }
            else if(filter == "getLastIndex")
            {
                perintah = $"SELECT * FROM jadwal_films order by id DESC LIMIT 1;";
            }
            else if(filter == "specific")
            {
                perintah = $"SELECT * FROM jadwal_films where id = '{jadwal_film.Id}' and tanggal = '{jadwal_film.Tanggal}' and jam_pemutaran = '{jadwal_film.Jam_pemutaran}';";
            }
            else
            {
                perintah = $"SELECT * FROM jadwal_films WHERE {filter} = '{nilai}'";
            }

            List<Jadwal_film> listJadwalFilm = new List<Jadwal_film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Jadwal_film tampung = new Jadwal_film();
                tampung.Id = dr.GetInt32(0);
                tampung.Tanggal = dr.GetValue(1).ToString();
                tampung.Jam_pemutaran = dr.GetValue(2).ToString();

                listJadwalFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listJadwalFilm;
        }
        #endregion
    }
}
