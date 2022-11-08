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
    /// Interaction logic for Kupovina_karata_prava.xaml
    /// </summary>
    public partial class Kupovina_karata_prava : Window
    {
        Service.VoznjaService voznjaService;
        List<Model.Voznja> voznje;
        Model.Korisnik korisnik;
        public Kupovina_karata_prava(Model.Korisnik korisnik)
        {
            InitializeComponent();
            voznjaService = new Service.VoznjaService();
            LoadAll();
            this.korisnik = korisnik;
        }
        public void LoadStanice()
        {
            cbKrajnjaStanica.Items.Clear();
            cbPocetnaStanica.Items.Clear();
            Service.StanicaService stanicaService = new Service.StanicaService();
            List<Model.Stanica> stanice = stanicaService.GetAll();
            foreach (Model.Stanica stanica in stanice)
            {
                cbKrajnjaStanica.Items.Add(stanica.naz_stan);
                cbPocetnaStanica.Items.Add(stanica.naz_stan);
            }
        }

        public void LoadAll()
        {
            lvDataBinding.Items.Clear();
            voznje = voznjaService.GetAll();

            foreach (Model.Voznja voznja in voznje)
            {
                lvDataBinding.Items.Add(voznja);
                
            }
            LoadStanice();

        }

        private void Kupi(object sender, RoutedEventArgs e)
        {
            
            Model.Voznja selectedVoznja = (Model.Voznja)lvDataBinding.SelectedItems[0];
            if (selectedVoznja.brSlobodnih > 0)
            {
                var kk = new IISAS.xaml_window.korisnik_stan_usluga.Kupovina_karata_kupi(selectedVoznja, this, korisnik);
                kk.Show();
            }
            else
            {
                MessageBox.Show("Za izabranu voznju nema slobodnih karata");
            }
            

        }

        private void Korisnik_st_usluga_logout(object sender, RoutedEventArgs e)
        {
            var mw = new IISAS.MainWindow();
            mw.Show();
            this.Close();
        }

        private void Red_voznje(object sender, RoutedEventArgs e)
        {
            var rv = new IISAS.xaml_window.korisnik_stan_usluga.Kupovina_karte(korisnik);
            rv.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            voznje = voznjaService.searchByParam(cbPocetnaStanica.Text, cbKrajnjaStanica.Text, tbVreme.Text, dpDatum.Text);
            lvDataBinding.Items.Clear();

            foreach (Model.Voznja voznja in voznje)
            {
                lvDataBinding.Items.Add(voznja);
            }
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void PregledKarata(object sender, RoutedEventArgs e)
        {
            var pkk = new IISAS.xaml_window.korisnik_stan_usluga.Pregled_kupljenih_karata(korisnik);
            pkk.Show();
            this.Close();
        }
    }
}
