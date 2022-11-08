using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class AutoprevoznikService : GenericService<Model.Autoprevoznik>
    {
        

        public AutoprevoznikService()
        {
            repository = new Repository.AutoprevoznikRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Autoprevoznik.txt");
        }
        public override int returnId(Model.Autoprevoznik autoprevoznik)
        {
            return autoprevoznik.id_prev;
        }
        public override Model.Autoprevoznik returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Autoprevoznik autoprevoznik)
        {
            autoprevoznik.obrisan = true;
        }
        public override void updateOne(Model.Autoprevoznik autoprevoznik, Model.Autoprevoznik updatedAutoprevoznik)
        {
            autoprevoznik.naziv_prev = updatedAutoprevoznik.naziv_prev;
        }


        public List<Model.Autobus> GetAutobusi(String autoprevoznik)
        {
            AutobusService autobusService = new AutobusService();
            List<Model.Autobus> autobusi = autobusService.getAllByPrevoznik(autoprevoznik);
            return autobusi;
        }

    }
}
