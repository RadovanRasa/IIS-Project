using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Voznja
    {
        public int id_voz { get; set; }
        public String dol_sat {get; set;}
        public String pol_sat { get; set; }
        public Stanica polazna_stan { get; set; }
        public Autobus autobus { get; set; }
        public bool obrisan { get; set; }
        public String preko { get; set; }
        public int brSlobodnih { get; set; }
        public float cena { get; set; }
        public Peron peron { get; set; }
        public String datum { get; set; }
        public Stanica krajnja_stan { get; set; }
        public float popustPovratna { get; set; }
        public float popustStudentska { get; set; }
        public float popustPenzioner { get; set; }
        public Voznja(int id_voz, String dol_sat, String pol_sat, int polaznaStanId, int krajnjaStanId, int autobusId, String preko, float cena, int peronId, String datum, int brSlobodnih, float popustPovratna, float popustStudentska, float popustPenzioner)
        {
            Service.AutobusService autobusService = new Service.AutobusService();
            Service.StanicaService stanicaService = new Service.StanicaService();
            Service.PeronService peronService = new Service.PeronService();
            
            this.id_voz = id_voz;
            this.dol_sat = dol_sat;
            this.pol_sat = pol_sat;
            this.polazna_stan = stanicaService.GetOne(polaznaStanId);
            this.krajnja_stan = stanicaService.GetOne(krajnjaStanId);
            this.autobus = autobusService.GetOne(autobusId);
            this.obrisan = false;
            this.preko = preko;
            this.brSlobodnih = brSlobodnih;
            this.cena = cena;
            this.peron = peronService.GetOne(peronId);
            this.datum = datum;
            this.popustPenzioner = popustPenzioner;
            this.popustPovratna = popustPovratna;
            this.popustStudentska = popustStudentska;
        }

        public Voznja(int id_voz, String dol_sat, String pol_sat, int polaznaStanId, int krajnjaStanId, int autobusId, String preko, float cena, int peronId, String datum, int brSlobodnih)
        {
            Service.AutobusService autobusService = new Service.AutobusService();
            Service.StanicaService stanicaService = new Service.StanicaService();
            Service.PeronService peronService = new Service.PeronService();

            this.id_voz = id_voz;
            this.dol_sat = dol_sat;
            this.pol_sat = pol_sat;
            this.polazna_stan = stanicaService.GetOne(polaznaStanId);
            this.krajnja_stan = stanicaService.GetOne(krajnjaStanId);
            this.autobus = autobusService.GetOne(autobusId);
            this.obrisan = false;
            this.preko = preko;
            this.brSlobodnih = brSlobodnih;
            this.cena = cena;
            this.peron = peronService.GetOne(peronId);
            this.datum = datum;
            this.popustPenzioner = 1;
            this.popustPovratna = 1;
            this.popustStudentska = 1;
        }
        public int getStanicaId()
        {
            return id_voz;
        }
    }
}
