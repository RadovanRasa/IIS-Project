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
    /// Interaction logic for manipulacija_cene_voznje_izmena.xaml
    /// </summary>
    public partial class manipulacija_cene_voznje_izmena : Window
    {
        public Manipulacija_cene_voznje manipulacijaCene;
        public Model.Voznja voznja;
        public manipulacija_cene_voznje_izmena(Manipulacija_cene_voznje manipulacijaCene, Model.Voznja voznja)
        {

            InitializeComponent();
            this.manipulacijaCene = manipulacijaCene;
            this.voznja = voznja;
            tbCena.Text = voznja.cena.ToString();
        }

        private void Potvrdi(object sender, RoutedEventArgs e)
        {
            Service.VoznjaService voznjaService = new Service.VoznjaService();
            voznja.cena = int.Parse(tbCena.Text);
            voznjaService.Update(voznja);
            manipulacijaCene.LoadAll();
            this.Close();
        }

        private void Izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
