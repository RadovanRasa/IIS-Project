using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Repository
{
    class KartaRepository : GenericRepository<Model.Karta>
    {
        public KartaRepository(String FileLocation) : base(FileLocation) { }

        public override Model.Karta makeObject(string[] words)
        {
            Model.Karta karta = new Model.Karta(int.Parse(words[0]), int.Parse(words[1]), int.Parse(words[2]),
                int.Parse(words[3]), words[4], words[5], int.Parse(words[6]));
            return karta;
        }
        public override int returnId(Model.Karta karta)
        {
            return karta.id_karte;
        }
        public override bool isDeleted(Model.Karta karta)
        {
            return karta.obrisan;
        }
        public override String ObjectToString(Model.Karta karta)
        {
            String line = karta.id_karte.ToString() + "," + karta.voznja.id_voz.ToString() + "," +
                karta.broj_sedista.ToString() + "," + karta.cena.ToString() + "," +
                karta.vrsta_karte + "," + karta.vazeca + "," + karta.korisnik.id_kor.ToString();

            return line;
        }
    }
}
