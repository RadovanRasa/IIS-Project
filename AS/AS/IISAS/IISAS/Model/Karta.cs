using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Karta
    {
        public int id_karte { get; set; }
        public Voznja voznja { get; set; }
        //Ovde dodati korisniika
        public int broj_sedista { get; set; }
        public int cena { get; set; }
        public String vrsta_karte { get; set; }
        public String vazeca { get; set; }
        public bool obrisan { get; set; }
        public Korisnik korisnik { get; set; }

        public Karta(int id_karte, int voznjaId, int broj_sedista, int cena, String vrsta_karte, String vazeca, int korisnikId)
        {
            Service.VoznjaService voznjaService = new Service.VoznjaService();
            Service.KorisnikService korisnikService = new Service.KorisnikService();

            this.id_karte = id_karte;
            this.voznja = voznjaService.GetOne(voznjaId);
            this.broj_sedista = broj_sedista;
            this.cena = cena;
            this.vrsta_karte = vrsta_karte;
            this.vazeca = vazeca;
            this.obrisan = false;
            this.korisnik = korisnikService.GetOne(korisnikId);
        }
    }
}
