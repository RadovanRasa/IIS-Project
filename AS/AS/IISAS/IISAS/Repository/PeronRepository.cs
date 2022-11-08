using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Repository
{
    class PeronRepository : GenericRepository<Model.Peron>
    {
        public PeronRepository(String FileLocation) : base(FileLocation) { }

        public override Model.Peron makeObject(string[] words)
        {
            Model.Peron peron = new Model.Peron(int.Parse(words[0]), words[1], int.Parse(words[2]));
            return peron;
        }
        public override int returnId(Model.Peron peron)
        {
            return peron.id_per;
        }
        public override bool isDeleted(Model.Peron peron)
        {
            return peron.obrisan;
        }
        public override String ObjectToString(Model.Peron peron)
        {
            String line = peron.id_per.ToString() + "," + peron.naz_per + peron.stanica.id_stan.ToString();
            return line;
        }
    }
}
