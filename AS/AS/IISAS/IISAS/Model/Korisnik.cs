using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Model
{
    public class Korisnik
    {
        public int id_kor { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String tip_korisnika { get; set; }
        public String status_korisnika { get; set; }
        public String email { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public bool obrisan { get; set; }

        public Korisnik(int id_kor, String ime, String prezime, String tip_korisnika, 
            String status_korisnika,String email,String username,String password)
        {
            this.id_kor = id_kor;
            this.ime = ime;
            this.prezime = prezime;
            this.tip_korisnika = tip_korisnika;
            this.status_korisnika = status_korisnika;
            this.email = email;
            this.username = username;
            this.password = password;
            this.obrisan = false;
        }

    }
}
