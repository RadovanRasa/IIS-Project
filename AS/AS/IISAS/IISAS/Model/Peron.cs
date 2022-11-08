using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Peron
    {
        public int id_per { get; set; }

        public Stanica stanica;
        public String naz_per { get; set; }
        public bool obrisan { get; set; }

        public Peron(int id_per, String naz_per, int stanicaId)
        {
            Service.StanicaService stanicaService = new Service.StanicaService();

            this.id_per = id_per;
            this.naz_per = naz_per;
            this.stanica = stanicaService.GetOne(stanicaId);
            this.obrisan = false;
        }

        public int getPeronId()
        {
            return id_per;
        }
    }
}
