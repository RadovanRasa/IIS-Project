using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class VoznjaService : GenericService<Model.Voznja>
    {
        

        public VoznjaService()
        {
            this.repository = new Repository.VoznjaRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Voznja.txt");
        }

        public override int returnId(Model.Voznja voznja)
        {
            return voznja.id_voz;
        }
        public override Model.Voznja returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Voznja voznja)
        {
            voznja.obrisan = true;
        }
        public override void updateOne(Model.Voznja voznja, Model.Voznja updatedVoznja)
        {
            voznja.autobus = updatedVoznja.autobus;
            voznja.dol_sat = updatedVoznja.dol_sat;
            voznja.pol_sat = updatedVoznja.pol_sat;
            voznja.polazna_stan = updatedVoznja.polazna_stan;
            voznja.preko = updatedVoznja.preko;
            voznja.brSlobodnih = updatedVoznja.brSlobodnih;
            voznja.cena = updatedVoznja.cena;
            voznja.peron = updatedVoznja.peron;
            voznja.datum = updatedVoznja.datum;
            voznja.popustPenzioner = updatedVoznja.popustPenzioner;
            voznja.popustPovratna = updatedVoznja.popustPovratna;
            voznja.popustStudentska = updatedVoznja.popustStudentska;
        }
        

        public void reduceBrojKarata(Model.Voznja voznja)
        {
            voznja.brSlobodnih--;
            Update(voznja);
        }

        public void addBrojKarata(Model.Voznja voznja)
        {
            voznja.brSlobodnih++;
            Update(voznja);
        }


        public List<Model.Voznja> filterByPolazna(String polaznaStanica)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();
            List<Model.Voznja> voznje = GetAll();

            foreach (Model.Voznja voznja in voznje)
            {
                if (voznja.polazna_stan.naz_stan.Contains(polaznaStanica))
                {
                    returnList.Add(voznja);
                }
            }
            return returnList;
        }

        public List<Model.Voznja> filterByKrajnja(String krajnjaStanica)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();
            List<Model.Voznja> voznje = GetAll();

            foreach (Model.Voznja voznja in voznje)
            {
                if (voznja.krajnja_stan.naz_stan.Contains(krajnjaStanica))
                {
                    returnList.Add(voznja);
                }
            }
            return returnList;
        }

        public Model.Voznja getVoznjaByPeronDatumVreme(int peronId, String datum, string vreme)
        {
            List<Model.Voznja> voznje = GetAll();
            foreach(Model.Voznja voznja in voznje)
            {
                if(voznja.peron.id_per == peronId && voznja.datum == datum && voznja.pol_sat == vreme)
                {
                    return voznja;
                }
            }
            return null;
        }

        public List<Model.Voznja> filterByPrevoznik(String nazivPrevoznika)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();
            List<Model.Voznja> voznje = GetAll();

            foreach (Model.Voznja voznja in voznje)
            {
                if (voznja.autobus.autoprev.naziv_prev.Contains(nazivPrevoznika))
                {
                    returnList.Add(voznja);
                }
            }
            return returnList;
        }
        public List<Model.Voznja> filterByDatum(String Datum)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();
            List<Model.Voznja> voznje = GetAll();

            foreach (Model.Voznja voznja in voznje)
            {
                if (voznja.datum.Contains(Datum))
                {
                    returnList.Add(voznja);
                }
            }
            return returnList;
        }

        public List<Model.Voznja> searchByStanica(List<Model.Voznja> voznje, String polaznaStanica, String krajnjaStanica)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();

            foreach(Model.Voznja voznja in voznje)
            {
                if(voznja.polazna_stan.naz_stan == polaznaStanica && voznja.krajnja_stan.naz_stan == krajnjaStanica)
                {
                    returnList.Add(voznja);
                }
            }
            return returnList;
        }

        public List<Model.Voznja> searchByDatum(List<Model.Voznja> voznje, String datum)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();
            foreach(Model.Voznja voznja in voznje)
            {
                if(datum == voznja.datum)
                {
                    returnList.Add(voznja);
                }
            }
            return returnList;
        }
            
        
        public List<Model.Voznja> searchByVreme(List<Model.Voznja> voznje, String vreme)
        {
            List<Model.Voznja> returnList = new List<Model.Voznja>();
            string[] vremena = vreme.Split(':');
            int sat = int.Parse(vremena[0]);
            int minut = int.Parse(vremena[1]);
            foreach (Model.Voznja voznja in voznje)
            {
                string[] vremenaVoznje = voznja.pol_sat.Split(':');
                int satVoznje = int.Parse(vremenaVoznje[0]);
                int minutVoznje = int.Parse(vremenaVoznje[1]);
                if (satVoznje > sat || (satVoznje == sat && minutVoznje>=minut))
                {
                    returnList.Add(voznja);
                }
            }

            return returnList;
        }

        public List<Model.Voznja> searchByParam(String polaznaStnaica, String krajnjaStanica, 
            String vreme, String datum)
        {
            List<Model.Voznja> voznje = GetAll();

            if(polaznaStnaica != "" && krajnjaStanica != "")
            {
                voznje = searchByStanica(voznje, polaznaStnaica, krajnjaStanica);
            }
            if(vreme != "")
            {
                voznje = searchByVreme(voznje, vreme);
            }
            if(datum != "")
            {
                voznje = searchByDatum(voznje, datum);
            }

            return voznje;
        }
    }
}
