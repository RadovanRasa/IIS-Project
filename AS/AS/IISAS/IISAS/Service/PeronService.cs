using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class PeronService : GenericService<Model.Peron>
    {
        
        public PeronService()
        {
            repository = new Repository.PeronRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Peron.txt");
        }

        public override int returnId(Model.Peron peron)
        {
            return peron.id_per;
        }
        public override Model.Peron returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Peron peron)
        {
            peron.obrisan = true;
        }
        public override void updateOne(Model.Peron peron, Model.Peron updatedPeron)
        {
            peron.naz_per = updatedPeron.naz_per;
            peron.stanica = updatedPeron.stanica;
        }

        public List<Model.Voznja> getByDatumVreme(String datum, String vreme)
        {
            Service.VoznjaService voznjaService = new VoznjaService();
            List<Model.Peron> peroni = GetAll();
            List<Model.Voznja> voznje = new List<Model.Voznja>();

            foreach(Model.Peron peron in peroni)
            {
                Model.Voznja voznja = voznjaService.getVoznjaByPeronDatumVreme(peron.id_per, datum, vreme);
                if(voznja == null)
                {
                    voznja = new Model.Voznja(0, "-", "-",0,0, 0, "-", 0, peron.id_per, datum, 0);
                }
                voznje.Add(voznja);
            }
            return voznje;
        }

        public List<Model.Peron> getAllByStanica(String stanica)
        {
            List<Model.Peron> peroni = GetAll();
            List<Model.Peron> returnPeroni = new List<Model.Peron>();

            foreach(Model.Peron peron in peroni)
            {
                if (peron.stanica.naz_stan == stanica)
                {
                    returnPeroni.Add(peron);
                }
            }
            return returnPeroni;
        }

    }
}
