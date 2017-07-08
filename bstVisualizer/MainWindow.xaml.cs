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

namespace bstVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            Label number = new Label();           
            Ellipse ell = new Ellipse();

            ell.Height = ell.Width = 40;
            ell.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            number.Content = "hi";
            number.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));


            ell.Margin = number.Margin = new Thickness(200, 100, 20, 100);
            ell.HorizontalAlignment = number.HorizontalAlignment = HorizontalAlignment.Center;
            ell.VerticalAlignment = number.VerticalAlignment = VerticalAlignment.Center;

            grid.Children.Add(ell);
            grid.Children.Add(number);
        }
    }
}
