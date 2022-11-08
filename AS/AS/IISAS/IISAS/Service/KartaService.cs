using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class KartaService : GenericService<Model.Karta>
    {
        public KartaService()
        {
            repository = new Repository.KartaRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Karta.txt");
        }
        public override int returnId(Model.Karta karta)
        {
            return karta.id_karte;
        }
        public override Model.Karta returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Karta karta)
        {
            karta.obrisan = true;
        }
        public List<Model.Karta> filterByPolazna(String polaznaStanica, Model.Korisnik korisnik)
        {
            List<Model.Karta> returnList = new List<Model.Karta>();
            List<Model.Karta> karte = getKarteByKorisnik(korisnik);

            foreach (Model.Karta karta in karte)
            {
                if (karta.voznja.polazna_stan.naz_stan.Contains(polaznaStanica))
                {
                    returnList.Add(karta);
                }
            }
            return returnList;
        }

        public List<Model.Karta> filterByKrajnja(String krajnjaStanica, Model.Korisnik korisnik)
        {
            List<Model.Karta> returnList = new List<Model.Karta>();
            List<Model.Karta> karte = getKarteByKorisnik(korisnik);

            foreach (Model.Karta karta in karte)
            {
                if (karta.voznja.krajnja_stan.naz_stan.Contains(krajnjaStanica))
                {
                    returnList.Add(karta);
                }
            }
            return returnList;
        }

        public List<Model.Karta> filterByPrevoznik(String nazivPrevoznika, Model.Korisnik korisnik)
        {
            List<Model.Karta> returnList = new List<Model.Karta>();
            List<Model.Karta> karte = getKarteByKorisnik(korisnik);

            foreach (Model.Karta karta in karte)
            {
                if (karta.voznja.autobus.autoprev.naziv_prev.Contains(nazivPrevoznika))
                {
                    returnList.Add(karta);
                }
            }
            return returnList;
        }
        public List<Model.Karta> filterByDatum(String Datum, Model.Korisnik korisnik)
        {
            List<Model.Karta> returnList = new List<Model.Karta>();
            List<Model.Karta> karte = getKarteByKorisnik(korisnik);

            foreach (Model.Karta karta in karte)
            {
                if (karta.voznja.datum.Contains(Datum))
                {
                    returnList.Add(karta);
                }
            }
            return returnList;
        }
        public override void updateOne(Model.Karta karta, Model.Karta updatedKarta)
        {
            karta.broj_sedista = updatedKarta.broj_sedista;
            karta.cena = updatedKarta.cena;
            karta.vazeca = updatedKarta.vazeca;
            karta.voznja = updatedKarta.voznja;
            karta.vrsta_karte = updatedKarta.vrsta_karte;
        }
        public List<Model.Karta> getKarteByKorisnik(Model.Korisnik korisnik)
        {
            List<Model.Karta> karte = GetAll();
            List<Model.Karta> returnKarte = new List<Model.Karta>();

            foreach(Model.Karta karta in karte)
            {
                if(karta.korisnik.id_kor == korisnik.id_kor)
                {
                    returnKarte.Add(karta);
                }
            }
            return returnKarte;
        }
    }
}
