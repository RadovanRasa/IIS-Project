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

namespace IISAS.xaml_window
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Prijava(object sender, RoutedEventArgs e)
        {
            Service.KorisnikService korisnikService = new Service.KorisnikService();
            Model.Korisnik korisnik = korisnikService.getOne(tbKorisnickoIme.Text, tbLozinka.Password);

            if(korisnik == null)
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka");
            }
            else
            {
                if(korisnik.tip_korisnika == "AdminAS")
                {
                    var ut = new IISAS.xaml_window.admin_as.Upravljanje_terminima();
                    ut.Show();
                    this.Close();
                }
                else if(korisnik.tip_korisnika == "Korisnik")
                {
                    var kk= new IISAS.xaml_window.korisnik_stan_usluga.Kupovina_karte(korisnik);
                    kk.Show();
                    this.Close();
                }
                else if(korisnik.tip_korisnika == "Admin")
                {
                    var ups = new IISAS.xaml_window.admin.Upravljanje_statusima_korisnika();
                    ups.Show();
                    this.Close();
                }
            }
        }

        private void tbkorisnickoIme_LostFocus(object sender, RoutedEventArgs e)
        {
            tbKorisnickoIme.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbKorisnickoIme.Text == "")
            {
                tbKorisnickoIme.Text = "Korisničko ime";
            }
        }

        private void tbKorisnickoIme_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbKorisnickoIme.Text == "Korisničko ime")
            {
                tbKorisnickoIme.Clear();
            }
           
            tbKorisnickoIme.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbKorisnickoIme_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbKorisnickoIme.Text != "Korisničko ime")
            {

            }
        }
        private void tbLozinka_LostFocus(object sender, RoutedEventArgs e)
        {
            tbLozinka.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbLozinka.Password == "")
            {
                lbLozinka.Content = "Lozinka";
            }
        }

        private void tbLozinka_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lbLozinka.Content.Equals("Lozinka") == true)
            {
                lbLozinka.Content.Equals(" ");
                lbLozinka.Content = " ";
            }

            tbLozinka.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbLozinka_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbLozinka.Password != "Lozinka")
            {

            }
        }

        private void Registracijaa(object sender, RoutedEventArgs e)
        {
            var reg = new IISAS.xaml_window.Registracija();
            reg.Show();
            this.Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            var mw = new IISAS.MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
