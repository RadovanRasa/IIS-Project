using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Autobus
    {
        public int id_aut {get; set;}
        public int kap_aut { get; set; }
        public String reg_aut { get; set; }
        public bool obrisan { get; set; }
        public Autoprevoznik autoprev { get; set; }


        public Autobus(int id_aut, int kap_aut, String reg_aut, int autoprevId)
        {
            Service.AutoprevoznikService autoprevoznikService = new Service.AutoprevoznikService();

            this.id_aut = id_aut;
            this.kap_aut = kap_aut;
            this.reg_aut = reg_aut;
            this.autoprev = autoprevoznikService.GetOne(autoprevId);
            this.obrisan = false;
        }

        public int getAutoprevId()
        {
            return autoprev.id_prev;
        }
    }
}
