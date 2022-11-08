using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    class KorisnikService : GenericService<Model.Korisnik>
    {
        public KorisnikService()
        {
            repository = new Repository.KorisnikRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\IISBaza\Korisnik.txt");
        }
        public override int returnId(Model.Korisnik korisnik)
        {
            return korisnik.id_kor;
        }
        public override Model.Korisnik returnNULL()
        {
            return null;
        }
        public override void deleteOne(Model.Korisnik korisnik)
        {
            korisnik.obrisan = true;
        }
        public override void updateOne(Model.Korisnik korisnik, Model.Korisnik updatedKorisnik)
        {
            korisnik.email = updatedKorisnik.email;
            korisnik.ime = updatedKorisnik.ime;
            korisnik.password = updatedKorisnik.password;
            korisnik.prezime = updatedKorisnik.prezime;
            korisnik.status_korisnika = updatedKorisnik.status_korisnika;
            korisnik.tip_korisnika = updatedKorisnik.tip_korisnika;
            korisnik.username = updatedKorisnik.username;
        }

        public List<Model.Korisnik> filterByPrezime(String prezime)
        {
            List<Model.Korisnik> returnList = new List<Model.Korisnik>();
            List<Model.Korisnik> korisnici = GetAll();

            foreach (Model.Korisnik korisnik in korisnici)
            {
                if (korisnik.prezime.Contains(prezime))
                {
                    returnList.Add(korisnik);
                }
            }
            return returnList;
        }

        public List<Model.Korisnik> filterByStatus(String status)
        {
            List<Model.Korisnik> returnList = new List<Model.Korisnik>();
            List<Model.Korisnik> korisnici = GetAll();

            foreach (Model.Korisnik korisnik in korisnici)
            {
                if (korisnik.status_korisnika.Contains(status))
                {
                    returnList.Add(korisnik);
                }
            }
            return returnList;
        }

        public List<Model.Korisnik> filterByUsername(String username)
        {
            List<Model.Korisnik> returnList = new List<Model.Korisnik>();
            List<Model.Korisnik> korisnici = GetAll();

            foreach (Model.Korisnik korisnik in korisnici)
            {
                if (korisnik.username.Contains(username))
                {
                    returnList.Add(korisnik);
                }
            }
            return returnList;
        }
        public List<Model.Korisnik> filterByName(String name)
        {
            List<Model.Korisnik> returnList = new List<Model.Korisnik>();
            List<Model.Korisnik> korisnici = GetAll();

            foreach (Model.Korisnik korisnik in korisnici)
            {
                if (korisnik.ime.Contains(name))
                {
                    returnList.Add(korisnik);
                }
            }
            return returnList;
        }

        public Model.Korisnik getOne(String username, String password)
        {
            List<Model.Korisnik> korisnici = GetAll();
            foreach(Model.Korisnik korisnik in korisnici)
            {
                if(korisnik.username == username)
                {
                    if(korisnik.password == password)
                    {
                        return korisnik;
                    }
                }
            }
            return null;
        }
        
    }
}
