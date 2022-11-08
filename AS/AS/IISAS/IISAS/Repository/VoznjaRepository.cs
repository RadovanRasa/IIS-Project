using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Repository
{
    class VoznjaRepository : GenericRepository<Model.Voznja>
    {
        public VoznjaRepository(String FileLocation) : base(FileLocation) { }

        public override Model.Voznja makeObject(string[] words)
        {
            Model.Voznja voznja = new Model.Voznja(int.Parse(words[0]), words[1], words[2], int.Parse(words[3]), 
                int.Parse(words[4]), int.Parse(words[5]), words[6], float.Parse(words[7]), int.Parse(words[8]), 
                words[9], int.Parse(words[10]), float.Parse(words[11]), float.Parse(words[12]), float.Parse(words[13]));
            return voznja;
        }
        public override int returnId(Model.Voznja voznja)
        {
            return voznja.id_voz;
        }
        public override bool isDeleted(Model.Voznja voznja)
        {
            return voznja.obrisan;
        }
        public override String ObjectToString(Model.Voznja voznja)
        {
            String line = voznja.id_voz.ToString()+ "," + voznja.dol_sat + "," + voznja.pol_sat + "," +
                voznja.polazna_stan.id_stan.ToString() + "," + voznja.krajnja_stan.id_stan.ToString() + "," + 
                voznja.autobus.id_aut.ToString() + "," + voznja.preko + "," + voznja.cena.ToString() + "," + 
                voznja.peron.id_per.ToString() + "," + voznja.datum + "," + voznja.brSlobodnih + "," + 
                voznja.popustPovratna.ToString() + "," + voznja.popustStudentska.ToString() + "," + voznja.popustPenzioner.ToString();
            return line;
        }
    }
}
