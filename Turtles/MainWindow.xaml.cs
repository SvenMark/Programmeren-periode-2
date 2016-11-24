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
using ThinkLib;

namespace Turtles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Turtle alex;
        Turtle tess;


        public MainWindow()
        {
            InitializeComponent();
            alex = new Turtle(playground1);
            tess = new Turtle(playground);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //2
            //30 * 24 = 720, dus hij draait precies 2 rondje.
            //alex.WarpTo(200.0, 200.0);    // Warp without drawing
            //alex.BrushDown = false;       // Pick up the brush
            //double size = 10.0;
            //int i = 0;
            //while (i < 30)
            //{
            //    alex.Stamp();             // Stamp a footprint
            //    size = size + 2.0;
            //    alex.Forward(size);
            //    alex.Right(24.0);
            //    i = i + 1;
            //}

            //3
            //10 rondjes en eindigt op positie 45 graden naar links.
            //tess.Left(3645);

            //4
            //tess.WarpTo(200.0, 200.0);
            //int i = 0;
            //while (i < 3)
            //{
            //    tess.Left(360 / 3.0);
            //    tess.Forward(40);
            //    i++;
            //}

            //5
            //360/ 18.0 = 20 graden

            //9
            //tess.WarpTo(200.0, 200.0);
            //int i = 0;
            //tess.Left(175);
            //while (i < 5)
            //{
            //    tess.Left(144);
            //    tess.Forward(100);
            //    i++;
            //}

            //10
            int i = 0;
            while (i < 6)
            {
                tess.WarpTo((50 * i), 150);
                tess.Heading = 0;
                int j = 0;
                while (j < 5)
                {
                    tess.Right(144);
                    tess.Forward(40);
                    j++;
                }
                i++;
            }

            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //4
            tess.WarpTo(200.0, 200.0);
            int i = 0;
            while (i < 4)
            {
                tess.Left(360 / 4.0);
                tess.Forward(40);
                i++;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //4
            tess.WarpTo(200.0, 200.0);
            int i = 0;
            while (i < 6)
            {
                tess.Left(360 / 6.0);
                tess.Forward(40);
                i++;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //4
            tess.WarpTo(200.0, 200.0);
            int i = 0;
            while (i < 8)
            {
                tess.Left(360 / 8.0);
                tess.Forward(40);
                i++;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //6
            tess.Clear();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //7
            tess.BrushWidth = slider.Value;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            tess.BodyBrush = Brushes.Green;
            tess.LineBrush = Brushes.Green;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            tess.BodyBrush = Brushes.Blue;
            tess.LineBrush = Brushes.Blue;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            tess.BodyBrush = Brushes.Black;
            tess.LineBrush = Brushes.Black;
        }
    }
}
