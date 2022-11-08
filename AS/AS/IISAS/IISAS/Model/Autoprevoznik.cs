using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Autoprevoznik
    {
        public int id_prev { get; set; }
        public String naziv_prev { get; set; }
        public bool obrisan;

        public Autoprevoznik(int Id_prev, String Naziv_prev)
        {
            id_prev = Id_prev;
            naziv_prev = Naziv_prev;
            obrisan = false;
        }
    }
}
