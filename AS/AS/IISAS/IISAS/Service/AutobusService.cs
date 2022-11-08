using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class AutobusService : GenericService<Model.Autobus>
    {
        

        public AutobusService()
        {
            repository = new Repository.AutobusRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Autobus.txt");
        }
        public override int returnId(Model.Autobus autobus)
        {
            return autobus.id_aut;
        }
        public override Model.Autobus returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Autobus autobus)
        {
            autobus.obrisan = true;
        }
        public override void updateOne(Model.Autobus autobus, Model.Autobus updatedAutobus)
        {
            autobus.kap_aut = updatedAutobus.kap_aut;
            autobus.reg_aut = updatedAutobus.reg_aut;
            autobus.autoprev = updatedAutobus.autoprev;
        }

        public List<Model.Autobus> getAllByPrevoznik(String autoprevoznik)
        {
            List<Model.Autobus> autobusi = GetAll();
            List<Model.Autobus> returnAutobusi = new List<Model.Autobus>();

            foreach(Model.Autobus autobus in autobusi)
            {
                if(autobus.autoprev.naziv_prev == autoprevoznik)
                {
                    returnAutobusi.Add(autobus);
                }
            }

            return returnAutobusi;
        }
    }
}
