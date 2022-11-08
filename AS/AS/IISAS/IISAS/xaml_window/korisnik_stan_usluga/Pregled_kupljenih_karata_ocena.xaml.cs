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
    /// Interaction logic for Pregled_kupljenih_karata_ocena.xaml
    /// </summary>
    public partial class Pregled_kupljenih_karata_ocena : Window
    {
        public Pregled_kupljenih_karata_ocena()
        {
            InitializeComponent();
        }

        private void Oceni(object sender, RoutedEventArgs e)
        {

        }

        private void Izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
