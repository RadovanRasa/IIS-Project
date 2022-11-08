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
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Window
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void tbTextChangedKorisnickoIme(object sender, TextChangedEventArgs e)
        {

        }
        private void tbLostFocusKorisnickoIme(object sender, RoutedEventArgs e)
        {
            tbKorisnickoIme.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbKorisnickoIme.Text == "")
            {
                tbKorisnickoIme.Text = "Korisničko ime";
            }
        }
        private void tbGotFocusKorisnickoIme(object sender, RoutedEventArgs e)
        {
            if (tbKorisnickoIme.Text == "Korisničko ime")
            {
                tbKorisnickoIme.Clear();
            }

            tbKorisnickoIme.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbTextChangedIme(object sender, TextChangedEventArgs e)
        {

        }
        private void tbLostFocusIme(object sender, RoutedEventArgs e)
        {
            tbIme.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbIme.Text == "")
            {
                tbIme.Text = "Ime";
            }
        }
        private void tbGotFocusIme(object sender, RoutedEventArgs e)
        {
            if (tbIme.Text == "Ime")
            {
                tbIme.Clear();
            }

            tbIme.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbTextChangedPrezime(object sender, TextChangedEventArgs e)
        {

        }

        private void tbLostFocusPrezime(object sender, RoutedEventArgs e)
        {
            tbPrezime.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbPrezime.Text == "")
            {
                tbPrezime.Text = "Prezime";
            }
        }
        private void tbGotFocusPrezime(object sender, RoutedEventArgs e)
        {
            if (tbPrezime.Text == "Prezime")
            {
                tbPrezime.Clear();
            }

            tbPrezime.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbTextChangedLozinka(object sender, TextChangedEventArgs e)
        {

        }

        private void tbLostFocusLozinka(object sender, RoutedEventArgs e)
        {
            tbLozinka.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbLozinka.Text == "")
            {
                tbLozinka.Text = "Lozinka";
            }
        }
        private void tbGotFocusLozinka(object sender, RoutedEventArgs e)
        {
            if (tbLozinka.Text == "Lozinka")
            {
                tbLozinka.Clear();
            }

            tbLozinka.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void Registracijaa(object sender, RoutedEventArgs e)
        {
            Service.KorisnikService korisnikService = new Service.KorisnikService();
            Model.Korisnik korisnik = new Model.Korisnik(korisnikService.getNextId(),
                tbIme.Text, tbPrezime.Text, "Korisnik", "Standardan", "email@gmail.com", tbKorisnickoIme.Text, tbLozinka.Text);
            korisnikService.CreateElement(korisnik);
            MessageBox.Show(korisnik.ime + " uspesno ste registrovali na nas sajt");
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
