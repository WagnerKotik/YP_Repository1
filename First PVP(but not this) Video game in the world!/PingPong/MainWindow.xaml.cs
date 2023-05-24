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
using System.Windows.Threading;

namespace PingPong
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        Ellipse Ball;
        Rectangle Player;
        DispatcherTimer Timer;
        int Time;
        double Rad = 10;
        double x, y;
        double Velocity = 3;
        double VelocityX, VelocityY;    
        double PlayerWidth = 100;
        double PlayerX;
        double PlayerVelocity = 25;

        

        public MainWindow()
        {
            InitializeComponent();

           

            Ball = new Ellipse();
            Ball.Fill = Brushes.Red;
            Ball.Width = 2 * Rad;
            Ball.Height = 2 * Rad;
            Ball.Margin = new Thickness(x, y, 0, 0);
            GameZone.Children.Add(Ball);


            Player = new Rectangle();
            Player.Fill = Brushes.Blue;
            Player.Width = PlayerWidth;
            Player.Height = 5;
            PlayerX = GameZone.Width / 2 - PlayerWidth / 2;
            Player.Margin = new Thickness(PlayerX, GameZone.Height, 0, 0);
            GameZone.Children.Add(Player);

            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(Tick);
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            Timer.Start();
            Restart();
        }

       


        void Tick(object sender, EventArgs e)
        {
            Time++;

            if ((x < 0) || (x > GameZone.Width - 2 * Rad))
            {
                VelocityX = -VelocityX;
            }

            if ((y < 0) || (y > GameZone.Height - 2 * Rad))
            {
                VelocityY = -VelocityY;
            }


            if (y > GameZone.Height - 2 * Rad)
            {
                double c = x + Rad;


                if ((c >= PlayerX) && (c <= PlayerX + PlayerWidth))
                {
                    VelocityX *= 1.1;
                    VelocityY *= 1.1;
                }
                else
                {
                    MessageBox.Show("A-a-a-a-a-a");
                    Restart();
                    Player.Margin = new Thickness(PlayerX, GameZone.Height, 0, 0);
                }
            }

            x += VelocityX;
            y += VelocityY;

            Ball.Margin = new Thickness(x, y, 0, 0);

            TBTime.Text = (Time / 100).ToString();
        }

        private void Management(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                PlayerX -= PlayerVelocity;
            }

            if (e.Key == Key.Right)
            {
                PlayerX += PlayerVelocity;
            }

            if (PlayerX < 0)
            {
                PlayerX = 0;
            }

            if (PlayerX > GameZone.Width - PlayerWidth)
            {
                PlayerX = GameZone.Width - PlayerWidth;
            }

            Player.Margin = new Thickness(PlayerX, GameZone.Height, 0, 0);

        }
        void Restart()
        {
            x = GameZone.Width / 2 - Rad;
            y = GameZone.Height / 2 - Rad;

            Random rnd = new Random();

            double Start = rnd.NextDouble() * Math.PI / 2 + Math.PI / 4;

            VelocityX = Velocity * Math.Cos(Start);
            VelocityY = Velocity * Math.Sin(Start);

            PlayerX = GameZone.Width / 2 - PlayerWidth / 2;

            Time = 0;
        }
    }
}
