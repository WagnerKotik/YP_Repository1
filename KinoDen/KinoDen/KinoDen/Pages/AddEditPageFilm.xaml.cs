using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace KinoDen.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Entities.Film _currentEntity = null;
        public AddEditPage()
        {
            InitializeComponent();
            KinoF.Text = _currentEntity.NameFilm;
            Avtor.Text = _currentEntity.NameFilm;
            Discr.Text = _currentEntity.NameFilm;
            Prod.Text = _currentEntity.NameFilm;
            Comp.Text = _currentEntity.NameFilm;
            YearF.Text = _currentEntity.NameFilm.ToString();
            Country.Text = _currentEntity.NameFilm;
            TimeF.Text = _currentEntity.NameFilm.ToString();
            CenaF.Text = _currentEntity.NameFilm.ToString();
            RateF.Text = _currentEntity.NameFilm.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
