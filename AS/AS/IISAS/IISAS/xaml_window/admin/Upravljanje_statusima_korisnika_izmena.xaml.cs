using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IISAS.xaml_window.admin
{
    /// <summary>
    /// Interaction logic for Upravljanje_statusima_korisnika_izmena.xaml
    /// </summary>
    public partial class Upravljanje_statusima_korisnika_izmena : Window
    {
        Model.Korisnik korisnik;
        Upravljanje_statusima_korisnika ups;
        public Upravljanje_statusima_korisnika_izmena(Model.Korisnik korisnik, Upravljanje_statusima_korisnika ups)
        {
            InitializeComponent();
            this.korisnik = korisnik;
            this.ups = ups;
            Load();
        }
        
        public void Load()
        {
            lbKorisnickoIme.Content = korisnik.username;
            cbStatus.Items.Add("Penzioner");
            cbStatus.Items.Add("Student");
            cbStatus.Items.Add("Standardan");
            cbStatus.Text = korisnik.status_korisnika;
            
        }

        private void Izmeni(object sender, RoutedEventArgs e)
        {
            korisnik.status_korisnika = cbStatus.Text;
            Service.KorisnikService korisnikService = new Service.KorisnikService();
            korisnikService.Update(korisnik);
            ups.LoadAll();
            this.Close();
        }

        private void Izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
