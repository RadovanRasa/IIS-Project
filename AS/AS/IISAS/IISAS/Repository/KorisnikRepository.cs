using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Repository
{
    class KorisnikRepository : GenericRepository<Model.Korisnik>
    {
        public KorisnikRepository(String FileLocation) : base(FileLocation) { }

        public override Model.Korisnik makeObject(string[] words)
        {
            Model.Korisnik korisnik = new Model.Korisnik(int.Parse(words[0]), words[1], words[2], words[3],
                words[4], words[5], words[6], words[7]);
            return korisnik;
        }
        public override int returnId(Model.Korisnik korisnik)
        {
            return korisnik.id_kor;
        }
        public override bool isDeleted(Model.Korisnik korisnik)
        {
            return korisnik.obrisan;
        }
        public override String ObjectToString(Model.Korisnik korisnik)
        {
            String line = korisnik.id_kor.ToString() + "," + korisnik.ime + "," + korisnik.prezime + "," +
                korisnik.tip_korisnika + "," + korisnik.status_korisnika + "," + korisnik.email + "," +
                korisnik.username + "," + korisnik.password;
            return line;        
        }                       
    }                           
}                               
                                
                                