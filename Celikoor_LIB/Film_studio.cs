using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Film_studio
    {
        #region FIELDS
        private Studio studio;
        private Film film;
        #endregion

        #region CONSTRUCTORS
        public Film_studio()
        {
            Studio = new Studio();
            Film = new Film();
        }
        #endregion

        #region PROPERTIES
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion
    }
}
