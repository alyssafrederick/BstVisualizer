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

        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            int num2Binserted = Convert.ToInt32(insertTextbox.Text);
            int rootNum = Convert.ToInt32(rootLabel.Content);

            if (insertTextbox.Text == "")
            {
                return;
            }

            Label number = new Label();
            Ellipse ell = new Ellipse();

            ell.Height = ell.Width = 40;
            ell.Fill = new SolidColorBrush(Color.FromArgb(200, 10, 60, 80));
            number.Content = insertTextbox.Text;
            number.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            
            ell.HorizontalAlignment = number.HorizontalAlignment = HorizontalAlignment.Center;
            ell.VerticalAlignment = number.VerticalAlignment = VerticalAlignment.Center;

         

            if (num2Binserted > rootNum)
            {
                ell.Margin = number.Margin = new Thickness(0, 0, 80, 300);
            }

            //

            grid.Children.Add(ell);
            grid.Children.Add(number);

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
