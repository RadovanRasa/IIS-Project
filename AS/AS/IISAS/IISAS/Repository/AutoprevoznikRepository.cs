using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IISAS.Model;

namespace IISAS.Repository
{
    class AutoprevoznikRepository : GenericRepository<Model.Autoprevoznik>
    {
        public AutoprevoznikRepository(String FileLocation) : base(FileLocation) { }

        public override Autoprevoznik makeObject(string[] words)
        {
            Autoprevoznik autoprevoznik = new Autoprevoznik(int.Parse(words[0]), words[1]);
            return autoprevoznik;
        }
        public override int returnId(Autoprevoznik autoprevoznik)
        {
            return autoprevoznik.id_prev;
        }
        public override bool isDeleted(Autoprevoznik autoprevoznik)
        {
            return autoprevoznik.obrisan;
        }
        public override String ObjectToString(Autoprevoznik autoprevoznik)
        {
            String line = autoprevoznik.id_prev.ToString() + "," + autoprevoznik.naziv_prev;
            return line;
        }

    }
}
