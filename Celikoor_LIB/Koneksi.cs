using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Celikoor_LIB
{
    public class Koneksi : IDisposable
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB
        {
            get => koneksiDB; private set =>
                koneksiDB = value;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (KoneksiDB != null)
                {
                    KoneksiDB.Close();
                    KoneksiDB.Dispose();
                }
            }
        }

        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string conString =
                "Server= " + pS + ";Database= " + pD + ";Uid= " + pU + ";Pwd= " + pP + ";Max Pool Size=200;"; // updated version *
            //"Server=localhost;Database=jualBeli;Uid=root;Pwd=;";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            //KoneksiDB.Open();

            Connect();
        }

        public Koneksi()
        {
            Configuration myC = ConfigurationManager.OpenExeConfiguration
                (ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myC.SectionGroups["userSettings"];

            var sectionSetting = userSettings.Sections["Celikoor_Tixycket.db"]
                as ClientSettingsSection;

            //ambil data dari file setting - sesuaikan dengan nama parameter di file setting Anda
            string vServer = sectionSetting.Settings.Get("dbServer").Value.ValueXml.InnerText;
            string vDb = sectionSetting.Settings.Get("dbName").Value.ValueXml.InnerText;
            string vUID = sectionSetting.Settings.Get("dbUsername").Value.ValueXml.InnerText;
            string vPWD = sectionSetting.Settings.Get("dbPassword").Value.ValueXml.InnerText;

            //akses ke app config sampai di sini
            //--------------------------------------------------------------------------------

            string conString =
                "Server= " + vServer + ";Database= " + vDb + ";Uid= " + vUID + ";Pwd= " + vPWD + ";Max Pool Size=200;";
            //"Server=localhost;Database=jualBeli;Uid=root;Pwd=;";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            //KoneksiDB.Open();

            Connect();
        }

        public void Connect()
        {
            try
            {
                //Jika koneksi sedang terbuka, tutup dulu koneksi yang sedang aktif
                if (KoneksiDB.State == System.Data.ConnectionState.Open)
                    KoneksiDB.Close();

                KoneksiDB.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show("Too much connection has been made! Please try again later...!" + x.Message);
            }
        }


        public void JalankanPerintahQuery(string perintah)
        {
            MySqlCommand cmd = new MySqlCommand(perintah, KoneksiDB);
            cmd.ExecuteNonQuery(); // untuk insert update delete
        }
        
        public MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            MySqlCommand cmd = new MySqlCommand(perintah, KoneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
