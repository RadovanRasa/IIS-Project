using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Repository
{
    class StanicaRepository : GenericRepository<Model.Stanica>
    {
        public StanicaRepository(String FileLocation) : base(FileLocation) { }

        public override Model.Stanica makeObject(string[] words)
        {
            Model.Stanica stanica = new Model.Stanica(int.Parse(words[0]), words[1], words[2]);
            return stanica;
        }
        public override int returnId(Model.Stanica stanica)
        {
            return stanica.id_stan;
        }
        public override bool isDeleted(Model.Stanica stanica)
        {
            return stanica.obrisan;
        }
        public override String ObjectToString(Model.Stanica stanica)
        {
            String line = stanica.id_stan.ToString() + "," + stanica.naz_stan + "," + stanica.grad_stan;
            return line;
        }
    }
}
