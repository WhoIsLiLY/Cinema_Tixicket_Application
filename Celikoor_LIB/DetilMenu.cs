using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class DetilMenu
    {
        int menuId;
        int totalHarga;
        int kuantitas;

        public DetilMenu()
        {
            this.MenuId = 0;
            this.TotalHarga = 0;
            this.Kuantitas = 0;
        }

        public int TotalHarga { get => totalHarga; set => totalHarga = value; }
        public int MenuId { get => menuId; set => menuId = value; }
        public int Kuantitas { get => kuantitas; set => kuantitas = value; }
    }
}
