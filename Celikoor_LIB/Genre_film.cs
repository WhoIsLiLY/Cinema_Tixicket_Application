using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Genre_film
    {
        #region FIELDS
        private Genre genre;
        #endregion

        #region CONSTRUCTORS
        public Genre_film()
        {
            Genre = new Genre();
        }
        #endregion

        #region PROPERTIES
        public Genre Genre { get => genre; set => genre = value; }
        #endregion
    }
}
