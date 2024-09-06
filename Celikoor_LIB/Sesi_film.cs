using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Sesi_film
    {
        #region FIELDS
        private Jadwal_film jadwalFilm;
        private Film_studio filmStudio;
        #endregion

        #region CONSTRUCTORS
        public Sesi_film()
        {
            JadwalFilm = new Jadwal_film();
            FilmStudio = new Film_studio();
        }
        #endregion

        #region PROPERTIES
        public Jadwal_film JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Film_studio FilmStudio { get => filmStudio; set => filmStudio = value; }
        #endregion
    }
}
