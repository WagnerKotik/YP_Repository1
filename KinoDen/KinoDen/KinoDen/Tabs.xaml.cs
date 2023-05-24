using KinoDen.Entities;
using KinoDen.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KinoDen
{
    /// <summary>
    /// Логика взаимодействия для Tabs.xaml
    /// </summary>
    public partial class Tabs : Page
    {
        public Tabs()
        {
            InitializeComponent();

            LViewFilm.ItemsSource = App.Context.Film.ToList();
            LViewZakup.ItemsSource = App.Context.Purchase.ToList();
            LViewCinema.ItemsSource = App.Context.Cinema.ToList();
            LViewRent.ItemsSource = App.Context.Rent.ToList();





        }
        private void ButtonPros(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(LViewRent, "печать");

            }

        }


        private void ButtonReiting(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(LViewFilm, "печать");

            }
        }

        private void ButtonViruchka(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(LViewZakup, "печать");

            }
        }

        private void ButtonArenda(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(LViewRent, "печать");

            }
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPage());
        }
    }
}

