using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Stanica
    {
        public int id_stan {get; set;}
        public String naz_stan { get; set; }
        public String grad_stan { get; set; }
        public bool obrisan { get; set; }
        public Stanica(int Id_stan, String Naz_stan, String Grad_stan)
        {
            id_stan = Id_stan;
            naz_stan = Naz_stan;
            grad_stan = Grad_stan;
            obrisan = false;
        }

        public int getStanicaId()
        {
            return id_stan;
        }
    }
}
