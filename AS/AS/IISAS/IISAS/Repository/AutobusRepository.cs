using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IISAS.Model;

namespace IISAS.Repository
{
    class AutobusRepository : GenericRepository<Autobus>
    {

        public AutobusRepository(String FileLocation) : base(FileLocation) { }

        public override Autobus makeObject(string[] words)
        {
            Autobus autobus = new Autobus(int.Parse(words[0]), int.Parse(words[1]), words[2], int.Parse(words[3]));
            return autobus;
        }
        public override int returnId(Autobus autobus)
        {
            return autobus.id_aut;
        }
        public override bool isDeleted(Autobus autobus)
        {
            return autobus.obrisan;
        }
        public override String ObjectToString(Autobus autobus)
        {
            String line = autobus.id_aut.ToString() + "," + autobus.kap_aut.ToString() + "," 
                + autobus.reg_aut.ToString() + "," + autobus.autoprev.id_prev.ToString();
            return line;
        }

    }
}
