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

        Turtle tess;


        public MainWindow()
        {
            InitializeComponent();
            tess = new Turtle(playground);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tess.Forward(80.0);
            tess.Right(90.0);
            tess.Forward(30.0);
            tess.Right(90.0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
