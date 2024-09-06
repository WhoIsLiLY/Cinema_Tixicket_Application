using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_LIB
{
    public class Film
    {
        #region FIELDS
        int id;
        string judul;
        string sinopsis;
        int tahun;
        int durasi;
        Kelompok kelompokUsia;
        string bahasa;
        int is_sub_indo;
        string coverImage;
        double diskon;
        List<Genre_film> listGenreFilm;
        List<Aktor_film> listAktorFilm;
        List<Film_studio> listFilmStudio = new List<Film_studio>();
        List<Sesi_film> listSesiFilm;
        #endregion

        #region CONSTRUCTORS
        public Film()
        {
            Id = 0;
            Judul = "";
            Sinopsis = "";
            Tahun = DateTime.Now.Year;
            Durasi = 0;
            KelompokUsia = new Kelompok();
            Bahasa = "";
            Is_sub_indo = 0;
            CoverImage = "";
            Diskon = 0;
            ListAktorFilm = new List<Aktor_film>();
            ListGenreFilm = new List<Genre_film>();
            ListSesiFilm = new List<Sesi_film>();
            ListFilmStudio = new List<Film_studio>();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        
        public double Diskon { get => diskon; set => diskon = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok KelompokUsia { get => kelompokUsia; set => kelompokUsia = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public int Is_sub_indo { get => is_sub_indo; set => is_sub_indo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public List<Aktor_film> ListAktorFilm { get => listAktorFilm; set => listAktorFilm = value; }
        public List<Genre_film> ListGenreFilm { get => listGenreFilm; set => listGenreFilm = value; }
        public List<Sesi_film> ListSesiFilm { get => listSesiFilm; set => listSesiFilm = value; }
        public List<Film_studio> ListFilmStudio { get => listFilmStudio; set => listFilmStudio = value; }
        #endregion

        #region METHODS

        public void TambahGenreFilm(Genre genre)
        {
            Genre_film genre_film = new Genre_film();
            genre_film.Genre = genre;

            ListGenreFilm.Add(genre_film);
        }
        public void TambahAktorFilm(Aktor aktor, string peran)
        {
            Aktor_film aktor_film = new Aktor_film();
            aktor_film.Aktor = aktor;
            aktor_film.Peran = peran;

            ListAktorFilm.Add(aktor_film);
        }
        public void TambahFilmStudio(Studio s, Film f)
        {
            Film_studio film_studio = new Film_studio();
            film_studio.Film = f;
            Console.WriteLine(film_studio.Film.Id);
            film_studio.Studio = s;

            ListFilmStudio.Add(film_studio);
        }
        public void TambahSesiFilm(Jadwal_film jf, Film_studio fs)
        {
            Sesi_film sesi_Film = new Sesi_film();
            sesi_Film.JadwalFilm = jf;
            sesi_Film.FilmStudio = fs;

            ListSesiFilm.Add(sesi_Film);
        }
        //! METHOD CREATE C
        public static void TambahData(Film film)
        {
            string perintah = $"INSERT INTO films (judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal)" +
                $"VALUES ('{film.Judul}', '{film.Sinopsis}', '{film.Tahun}', '{film.Durasi}', '{film.KelompokUsia.Id}', '{film.Bahasa}', '{film.Is_sub_indo}', '{film.CoverImage}', '{film.Diskon}');";
            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }
        public static void TambahDataDetailFilm(Film film)
        {
            string perintah;
            for (int i = 0; i < film.ListGenreFilm.Count; i++)
            {
                perintah = "INSERT INTO `genre_film`(`films_id`, `genres_id`) VALUES ('" + film.Id + "','" + film.ListGenreFilm[i].Genre.Id + "')";
                Koneksi conn = new Koneksi();
                conn.JalankanPerintahQuery(perintah);
                conn.KoneksiDB.Close();
            }
            for (int i = 0; i < film.ListAktorFilm.Count; i++)
            {
                perintah = $"INSERT INTO `aktor_film`(`aktors_id`, `films_id`, `peran`) VALUES ('{film.ListAktorFilm[i].Aktor.Id}','{film.Id}','{film.ListAktorFilm[i].Peran}')";
                Koneksi conn = new Koneksi();
                conn.JalankanPerintahQuery(perintah);
                conn.KoneksiDB.Close();
            }
        }
        public static void TambahDataStudioFilm(Film film)
        {
            string perintah = $"INSERT IGNORE INTO `film_studio`(`studios_id`, `films_id`) VALUES ('{film.ListFilmStudio[0].Studio.Id}','{film.ListFilmStudio[0].Film.Id}')";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }
        public static void TambahDataSesiFilm(Film film)
        {
            string perintah = "";
            for(int i = 0; i < film.ListSesiFilm.Count; i++)
            {
                perintah = $"INSERT INTO `sesi_films`(`jadwal_film_id`, `studios_id`, `films_id`) VALUES ('{film.ListSesiFilm[i].JadwalFilm.Id}','{film.ListSesiFilm[i].FilmStudio.Studio.Id}','{film.ListSesiFilm[i].FilmStudio.Film.Id}')";
                Koneksi conn = new Koneksi();
                conn.JalankanPerintahQuery(perintah);
                conn.KoneksiDB.Close();
            }
        }
        //! METHOD UPDATE U
        public static void UbahData(Film film)
        {
            string perintah = "UPDATE films SET judul= '"+film.Judul+"', sinopsis=\""+film.Sinopsis+"\", tahun='"+film.Tahun+"', durasi="+film.Durasi+", kelompoks_id="+film.KelompokUsia.Id+", bahasa='"+film.Bahasa+"', is_sub_indo="+film.Is_sub_indo+", diskon_nominal="+film.Diskon+" WHERE id = "+film.Id+";";
            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            Koneksi conn = new Koneksi();
            string perintah;
            perintah = $"DELETE FROM genre_film WHERE films_id= '{idHapus}';";
            conn.JalankanPerintahQuery(perintah);
            perintah = $"DELETE FROM aktor_film WHERE films_id= '{idHapus}';";
            conn.JalankanPerintahQuery(perintah);
            perintah = $"DELETE FROM films WHERE id = '{idHapus}';";
            conn.JalankanPerintahQuery(perintah);

            conn.KoneksiDB.Close();
        }
        public static void HapusDataDetail(string idHapus)
        {
            Koneksi conn = new Koneksi();
            string perintah;
            perintah = $"DELETE FROM genre_film WHERE films_id= '{idHapus}';";
            conn.JalankanPerintahQuery(perintah);
            perintah = $"DELETE FROM aktor_film WHERE films_id= '{idHapus}';";
            conn.JalankanPerintahQuery(perintah);

            conn.KoneksiDB.Close();
        }
        //! METHOD RETRIEVE R dan FILTER F
        public static List<Film> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM films";
            }
            else if (filter == "getLastIndex")
            {
                perintah = $"SELECT * FROM films ORDER BY id DESC LIMIT 1";
            }
            else if(filter == "id")
            {
                perintah = $"SELECT * FROM films where id = '{nilai}'";
            }
            else
            {
                perintah = $"SELECT * FROM films WHERE {filter} like '%{nilai}%'";
            }

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Film> listFilm = new List<Film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {
                Film tampung = new Film();
                tampung.Id = int.Parse(dr.GetValue(0).ToString());
                tampung.Judul = dr.GetValue(1).ToString();
                tampung.Sinopsis = dr.GetValue(2).ToString();
                tampung.Tahun = int.Parse(dr.GetValue(3).ToString());
                tampung.Durasi = int.Parse(dr.GetValue(4).ToString());
                
                tampung.KelompokUsia = new Kelompok();
                if (dr.GetValue(5).ToString() != "")
                {
                    tampung.KelompokUsia.Id = int.Parse(dr.GetValue(5).ToString());
                    int num = tampung.KelompokUsia.Id;
                    List<Kelompok> listKel = Kelompok.BacaData(tampung.KelompokUsia.Id.ToString());
                    tampung.KelompokUsia = listKel[0];
                }
                tampung.Bahasa = dr.GetValue(6).ToString();
                tampung.Is_sub_indo = int.Parse(dr.GetValue(7).ToString());
                tampung.CoverImage = dr.GetValue(8).ToString();
                tampung.Diskon = double.Parse(dr.GetValue(9).ToString());

                listFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listFilm;
        }
        public static List<Film> BacaDataFilmAdaSesi(string filter = "", string nilai = "")
        {
            string perintah = $"SELECT DISTINCT f.id, f.judul, f.sinopsis, f.tahun, f.durasi, f.kelompoks_id, f.bahasa, f.is_sub_indo, f.cover_image, f.diskon_nominal FROM sesi_films sf inner join films f on sf.films_id = f.id";
            
            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Film> listFilm = new List<Film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {
                Film tampung = new Film();
                tampung.Id = int.Parse(dr.GetValue(0).ToString());
                tampung.Judul = dr.GetValue(1).ToString();
                tampung.Sinopsis = dr.GetValue(2).ToString();
                tampung.Tahun = int.Parse(dr.GetValue(3).ToString());
                tampung.Durasi = int.Parse(dr.GetValue(4).ToString());

                tampung.KelompokUsia = new Kelompok();
                if (dr.GetValue(5).ToString() != "")
                {
                    tampung.KelompokUsia.Id = int.Parse(dr.GetValue(5).ToString());
                    int num = tampung.KelompokUsia.Id;
                    List<Kelompok> listKel = Kelompok.BacaData(tampung.KelompokUsia.Id.ToString());
                    tampung.KelompokUsia = listKel[0];
                }
                tampung.Bahasa = dr.GetValue(6).ToString();
                tampung.Is_sub_indo = int.Parse(dr.GetValue(7).ToString());
                tampung.CoverImage = dr.GetValue(8).ToString();
                tampung.Diskon = double.Parse(dr.GetValue(9).ToString());

                listFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listFilm;
        }
        public static List<Genre_film> BacaDataDetailGenreFilm(string filter = "", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM genre_film";
            }
            else
            {
                perintah = $"SELECT * FROM genre_film WHERE {filter} = '{nilai}'";
            }

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Genre_film> listGenreFilm = new List<Genre_film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {
                Genre_film tampung = new Genre_film();
                tampung.Genre = Genre.BacaData("id", dr.GetValue(1).ToString())[0];

                listGenreFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listGenreFilm;
        }
        public static List<Aktor_film> BacaDataDetailAktorFilm(string filter = "", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM aktor_film";
            }
            else
            {
                perintah = $"SELECT * FROM aktor_film WHERE {filter} = '{nilai}'";
            }

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Aktor_film> listAktorFilm = new List<Aktor_film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {
                Aktor_film tampung = new Aktor_film();
                tampung.Aktor = Aktor.BacaData("id", dr.GetValue(0).ToString())[0];
                tampung.Peran = dr.GetValue(2).ToString();

                listAktorFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listAktorFilm;
        }
        public static List<Film_studio> BacaDataDetailFilmStudio(string filter = "", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM film_studio";
            }
            else if(filter == "getLastIndex")
            {
                perintah = $"SELECT * FROM film_studio order by id DESC LIMIT 1";
            }
            else
            {
                perintah = $"SELECT * FROM film_studio WHERE {filter} = '{nilai}'";
            }

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Film_studio> listFilmStudio = new List<Film_studio>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {
                Film_studio tampung = new Film_studio();
                tampung.Studio = Studio.BacaData("id", dr.GetValue(0).ToString())[0];

                listFilmStudio.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listFilmStudio;
        }
        public static List<Film_studio> BacaDataDetailSesiFilm(string filter = "", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM sesi_film";
            }
            else if (filter == "getLastIndex")
            {
                perintah = $"SELECT * FROM sesi_film order by id DESC LIMIT 1";
            }
            else
            {
                perintah = $"SELECT * FROM sesi_film WHERE {filter} = '{nilai}'";
            }

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Film_studio> listFilmStudio = new List<Film_studio>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            while (dr.Read() == true)
            {
                Film_studio tampung = new Film_studio();
                tampung.Studio = Studio.BacaData("id", dr.GetValue(0).ToString())[0];

                listFilmStudio.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listFilmStudio;
        }
        public static string GetCoverImageLastIndex()
        {
            int lastIndex = 0;
            string perintah = "SELECT CAST(SUBSTRING(cover_image FROM 2) AS UNSIGNED) AS modified_id FROM films ORDER BY id DESC LIMIT 1;";
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            if (dr.Read())
            {
                lastIndex = int.Parse(dr.GetValue(0).ToString()) + 1;
            }
            else
            {
                lastIndex = 1;
            }
            conn.KoneksiDB.Close();
            return "p"+lastIndex.ToString();
        }
        public static void BacaDataFilmTerlaris()
        {
            string perintah = $"SELECT films.judul as JudulFilm, SUM(films.id) as TotalDitonton, monthname(invoices.tanggal) as Bulan "
                + $"FROM invoices INNER JOIN tikets on tikets.invoices_id = invoices.id "
                + $"INNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id "
                + $"INNER JOIN films on films.id = sesifilms.films_id "
                + $"WHERE YEAR(invoices.tanggal) = '2023' "
                + $"GROUP BY films.judul, Bulan "
                + $"ORDER BY Bulan desc, TotalDitonton desc;";

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            string nama = "Laporan Film Terlaris";
            StreamWriter NamaFile = new StreamWriter(nama);
            NamaFile.WriteLine("Film Terlaris di tahun 2023");
            NamaFile.WriteLine("Celikoor");
            NamaFile.WriteLine("--------------------------------------------------------");
            NamaFile.WriteLine("");
            NamaFile.WriteLine("Judul Film"+"               "+"Total Ditonton"+"        "+"Bulan");
            while (dr.Read() == true)
            {
                NamaFile.WriteLine(dr.GetValue(0) + "               " + dr.GetValue(1) + "      " + dr.GetValue(2));
            }
            conn.KoneksiDB.Close();
            NamaFile.WriteLine("--------------------------------------------------------");
            NamaFile.Close();

            // proses mencetak ke printer
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();
        }

        public static void BacaDataFilmTidakHadir()
        {
            string perintah = $"SELECT films.judul, COUNT(tikets.status_hadir) as jumlah FROM tikets INNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id INNER JOIN films on films.id = sesifilms.films_id WHERE tikets.status_hadir = 0 GROUP BY films.judul ORDER BY jumlah DESC LIMIT 3;";
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            string nama = "Laporan 3 Film dengan banyak jumlah tidak hadir";
            StreamWriter NamaFile = new StreamWriter(nama);
            NamaFile.WriteLine("3 film dengan banyak jumlah penonton tidak hadir");
            NamaFile.WriteLine("Celikoor");
            NamaFile.WriteLine("--------------------------------------------------------------");
            NamaFile.WriteLine("");
            NamaFile.WriteLine("Judul Film"+"               "+"Total Ditonton");
            while (dr.Read() == true)
            {
                NamaFile.WriteLine(dr.GetValue(0) + "        " + dr.GetValue(1));
            }
            conn.KoneksiDB.Close();
            NamaFile.WriteLine("--------------------------------------------------------------");
            NamaFile.Close();

            // proses mencetak ke printer
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();
        }
        public override string ToString()
        {
            return Judul;
        }
        #endregion
    }
}
