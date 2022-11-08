﻿using System;
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
    /// Interaction logic for Upravljanje_popustima_izmena.xaml
    /// </summary>
    public partial class Upravljanje_popustima_izmena : Window
    {
        Upravljanje_popustima upravljanje_Popustima;
        Model.Voznja voznja;
        public Upravljanje_popustima_izmena(Upravljanje_popustima upravljanje_Popustima, Model.Voznja voznja)
        {
            InitializeComponent();
            this.upravljanje_Popustima = upravljanje_Popustima;
            this.voznja = voznja;
            LoadAll();
        }
        public void LoadAll()
        {
            lbAutobus.Content = voznja.autobus.id_aut;
            lbCena.Content = voznja.cena;
            lbDatum.Content = voznja.datum;
            lbDolaznoVreme.Content = voznja.dol_sat;
            lbKrajnja.Content = voznja.krajnja_stan.naz_stan;
            tbPenzionerska.Text = voznja.popustPenzioner.ToString();
            lbPeron.Content = voznja.peron.naz_per;
            lbPocetna.Content = voznja.polazna_stan.naz_stan;
            lbPolaznoVreme.Content = voznja.pol_sat;
            tbPovratna.Text = voznja.popustPovratna.ToString();
            lbPreko.Content = voznja.preko;
            lbPrevoznik.Content = voznja.autobus.autoprev.naziv_prev;
            tbStudentska.Text = voznja.popustStudentska.ToString();
        }

        private void Izmeni(object sender, RoutedEventArgs e)
        {
            voznja.popustPenzioner = float.Parse(tbPenzionerska.Text);
            voznja.popustPovratna = float.Parse(tbPovratna.Text);
            voznja.popustStudentska = float.Parse(tbStudentska.Text);
            Service.VoznjaService voznjaService = new Service.VoznjaService();
            voznjaService.Update(voznja);
            upravljanje_Popustima.LoadAll();
            this.Close();
        }

        private void Izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
