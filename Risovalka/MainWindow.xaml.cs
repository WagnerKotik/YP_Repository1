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

namespace Risovalka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        double Thickness;
        bool IsDraw;
        Brush Color;

        public MainWindow()
        {
            InitializeComponent();

            IsDraw = false;

            Thickness = 1;

            Color = Brushes.Red;
            RBRed.IsChecked = true;
        }
        private void MHold(object sender, MouseButtonEventArgs e)
        {
            IsDraw = true;
        }

        private void MLetGo(object sender, MouseButtonEventArgs e)
        {
            IsDraw = false;
        }

        private void ClearCanvas(object sender, RoutedEventArgs e)
        {
            Holst.Children.Clear();
        }

        private void StylusRed(object sender, RoutedEventArgs e)
        {
            Color = Brushes.Red;
            ColorSelected.Fill = Color;
        }

        private void StylusBlue(object sender, RoutedEventArgs e)
        {
            Color = Brushes.Blue;
            ColorSelected.Fill = Color;
        }

        private void StylusGreen(object sender, RoutedEventArgs e)
        {
            Color = Brushes.Green;
            ColorSelected.Fill = Color;
        }

        private void WhatTheSize(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Thickness = StylusSize.Value;
        }
        private void MMove(object sender, MouseEventArgs e)
        {
            if (IsDraw)
            {

                if ((e.GetPosition(Holst).X < 0) || (e.GetPosition(Holst).X > Holst.Width))
                {
                    return;
                }
                if ((e.GetPosition(Holst).Y < 0) || (e.GetPosition(Holst).Y > Holst.Height))
                {
                    return;
                }


                Ellipse O = new Ellipse();
                O.Width = Thickness;
                O.Height = Thickness;
                O.Fill = Color;
                O.Margin = new Thickness(e.GetPosition(Holst).X - Thickness / 2, e.GetPosition(Holst).Y - Thickness / 2, 0, 0); // центр под указателем мышки

                Holst.Children.Add(O);

            }
        }
    }
}
