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

namespace IISAS.xaml_window.admin_as
{
    /// <summary>
    /// Interaction logic for Manipulacija_cene_voznje.xaml
    /// </summary>
    public partial class Manipulacija_cene_voznje : Window
    {
        Service.VoznjaService voznjaService;
        public List<Model.Voznja> voznje;
        public Manipulacija_cene_voznje()
        {
            InitializeComponent();
            voznjaService = new Service.VoznjaService();
            LoadAll();
        }

        public void LoadAll()
        {
            
            voznje = voznjaService.GetAll();

            lvDataBinding.Items.Clear();
            foreach (Model.Voznja voznja in voznje)
            {
                lvDataBinding.Items.Add(voznja);
            }

        }
        private void Dodaj(object sender, RoutedEventArgs e)
        {
            var dodaj = new IISAS.xaml_window.admin_as.Manipulacija_cene_voznje_dodaj();
            dodaj.Show();
        }

        private void Izmeni(object sender, RoutedEventArgs e)
        {
            if (lvDataBinding.SelectedItems.Count > 0)
            {
                Model.Voznja selectedVoznja = (Model.Voznja)lvDataBinding.SelectedItems[0];
                var izmeni = new IISAS.xaml_window.admin_as.manipulacija_cene_voznje_izmena(this, selectedVoznja);
                izmeni.Show();
            }
            else
            {
                MessageBox.Show("Molim Vas selektujte voznju za koju hocete da izmenite cenu");
            }
            
        }

        private void Obrisi(object sender, RoutedEventArgs e)
        {

        }

        private void Voznje(object sender, RoutedEventArgs e)
        {
            var voznje = new IISAS.xaml_window.admin_as.Upravljanje_terminima();
            voznje.Show();
            this.Close();
        }

        private void Popusti(object sender, RoutedEventArgs e)
        {
            var popusti = new IISAS.xaml_window.admin_as.Upravljanje_popustima();
            popusti.Show();
            this.Close();
        }
        private void tbSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            tbPretraga.Foreground = new SolidColorBrush(Colors.Gray);
            if (tbPretraga.Text == "")
            {
                tbPretraga.Text= "Pretraga voznje...";
            }
        }

        private void tbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPretraga.Text == "Pretraga voznje...")
            {
                tbPretraga.Clear();
            }
            tbPretraga.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPretraga.Text != "Pretraga voznje...")
            {
                List<Model.Voznja> voznje = new List<Model.Voznja>();
                if(rbDatum.IsChecked == true)
                {
                    voznje = voznjaService.filterByDatum(tbPretraga.Text);
                }
                else if(rbPolaznaStanica.IsChecked == true)
                {
                    voznje = voznjaService.filterByPolazna(tbPretraga.Text);
                }
                else if(rbKrajnjaStanica.IsChecked == true)
                {
                    voznje = voznjaService.filterByKrajnja(tbPretraga.Text);
                }
                else if(rbPrevoznik.IsChecked == true)
                {
                    voznje = voznjaService.filterByPrevoznik(tbPretraga.Text);
                }

                lvDataBinding.Items.Clear();
                foreach (Model.Voznja voznja in voznje)
                {
                    lvDataBinding.Items.Add(voznja);
                }
            }
        }

        private void Korisnik_st_usluga_logout(object sender, RoutedEventArgs e)
        {
            var mw = new IISAS.MainWindow();
            mw.Show();
            this.Close();
        }

        private void tbPretraga_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
