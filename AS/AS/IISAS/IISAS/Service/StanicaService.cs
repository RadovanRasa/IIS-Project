using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class StanicaService : GenericService<Model.Stanica>
    {
        

        public StanicaService()
        {
            repository = new Repository.StanicaRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Stanica.txt");
        }

        public override int returnId(Model.Stanica stanica)
        {
            return stanica.id_stan;
        }
        public override Model.Stanica returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Stanica stanica)
        {
            stanica.obrisan = true;
        }
        public override void updateOne(Model.Stanica stanica, Model.Stanica updatedStanica)
        {
            stanica.grad_stan = updatedStanica.grad_stan;
            stanica.naz_stan = updatedStanica.naz_stan;
        }

        public List<Model.Peron> getPeroni(String stanica)
        {
            PeronService peronService = new PeronService();
            List<Model.Peron> peroni = peronService.getAllByStanica(stanica);
            return peroni;
        }

        public int getIdByName(String name)
        {
            List<Model.Stanica> stanice = GetAll();
            foreach (Model.Stanica stanica in stanice)
            {
                if(stanica.naz_stan == name)
                {
                    return stanica.id_stan;
                }
            }
            return 0;
        }
    }
}
