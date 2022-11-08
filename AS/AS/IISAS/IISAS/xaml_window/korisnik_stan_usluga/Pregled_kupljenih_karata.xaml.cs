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

namespace IISAS.xaml_window.korisnik_stan_usluga
{
    /// <summary>
    /// Interaction logic for Pregled_kupljenih_karata.xaml
    /// </summary>
    public partial class Pregled_kupljenih_karata : Window
    {
        Service.KartaService kartaService;
        List<Model.Karta> karte;
        public Model.Korisnik korisnik;
        public Pregled_kupljenih_karata(Model.Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
            kartaService = new Service.KartaService();
            Load();
        }

        public void Load()
        {

            lvDataBinding.Items.Clear();
            karte = kartaService.getKarteByKorisnik(korisnik);

            foreach (Model.Karta karta in karte)
            {
                lvDataBinding.Items.Add(karta);
            }
        
        }

        private void RedVoznje(object sender, RoutedEventArgs e)
        {
            var rv = new IISAS.xaml_window.korisnik_stan_usluga.Kupovina_karte(korisnik);
            rv.Show();
            this.Close();
        }

        private void KupovinaKarte(object sender, RoutedEventArgs e)
        {
            var kk = new IISAS.xaml_window.korisnik_stan_usluga.Kupovina_karata_prava(korisnik);
            kk.Show();
            this.Close();
        }

        private void Obrisi(object sender, RoutedEventArgs e)
        {
            if (lvDataBinding.SelectedItems.Count > 0)
            {
                Model.Karta selectedKarta = (Model.Karta)lvDataBinding.SelectedItems[0];
                MessageBoxResult mr = MessageBox.Show("Da li ste sigurni da zelite da otkazete kartu?","Potvrda", MessageBoxButton.YesNo);
                if(mr == MessageBoxResult.Yes)
                {
                    kartaService.DeleteElement(selectedKarta.id_karte);
                    Service.VoznjaService voznjaService = new Service.VoznjaService();
                    voznjaService.addBrojKarata(selectedKarta.voznja);
                    Load();
                }
            }
            else
            {
                MessageBox.Show("Molim Vas selektujte kartu koju hocete da otkazete");
            }
        }

        private void Detaljnije(object sender, RoutedEventArgs e)
        {
            if (lvDataBinding.SelectedItems.Count > 0)
            {
                Model.Karta selectedKarta = (Model.Karta)lvDataBinding.SelectedItems[0];
                var det = new IISAS.xaml_window.korisnik_stan_usluga.Pregled_kupljenih_karata_detaljnije(this, selectedKarta);
                det.Show();

            }
            else
            {
                MessageBox.Show("Molim Vas selektujte voznju za koju hocete da vidite detalje");
            }
            
        }

        private void Oceni(object sender, RoutedEventArgs e)
        {
            var oc = new IISAS.xaml_window.korisnik_stan_usluga.Pregled_kupljenih_karata_ocena();
            oc.Show();
        }

        private void Korisnik_st_usluga_logout(object sender, RoutedEventArgs e)
        {
            var mn = new IISAS.MainWindow();
            mn.Show();
            this.Close();
        }
        private void tbSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            tbPretraga.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbPretraga.Text == "")
            {
                tbPretraga.Text = "Pretraga karata...";
            }
        }

        private void tbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPretraga.Text == "Pretraga karata...")
            {
                tbPretraga.Clear();
            }
            tbPretraga.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPretraga.Text != "Pretraga karata...")
            {
                List<Model.Karta> karte = new List<Model.Karta>();
                if (rbDatum.IsChecked == true)
                {
                    karte = kartaService.filterByDatum(tbPretraga.Text, korisnik);
                }
                else if (rbPolaznaStanica.IsChecked == true)
                {
                    karte = kartaService.filterByPolazna(tbPretraga.Text, korisnik);
                }
                else if (rbKrajnjaStanica.IsChecked == true)
                {
                    karte = kartaService.filterByKrajnja(tbPretraga.Text, korisnik);
                }
                else if (rbPrevoznik.IsChecked == true)
                {
                    karte = kartaService.filterByPrevoznik(tbPretraga.Text, korisnik);
                }

                lvDataBinding.Items.Clear();
                foreach (Model.Karta karta in karte)
                {
                    lvDataBinding.Items.Add(karta);
                }
            }
        }
    }
}
