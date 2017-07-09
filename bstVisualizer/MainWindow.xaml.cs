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
        BinarySearchTree<int> tree;

        public MainWindow()
        {
            InitializeComponent();

            //creating tree
            tree = new BinarySearchTree<int>();
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            if (insertTextbox.Text == "")
            {
                return;
            }

            //if there is no root the inserted number is the root
            if (rootLabel.Content == "")
            {
                rootLabel.Content = insertTextbox.Text;
                tree.Add(Convert.ToInt32(insertTextbox.Text));
                insertTextbox.Text = "";
            }
            //if there is a root
            else
            {
                int num2Binserted = Convert.ToInt32(insertTextbox.Text);
                int rootNum = Convert.ToInt32(rootLabel.Content);

                Label number = new Label();
                Ellipse ell = new Ellipse();

                ell.Height = ell.Width = 40;
                ell.Fill = new SolidColorBrush(Color.FromArgb(200, 10, 60, 80));
                number.Content = insertTextbox.Text;
                number.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

                ell.HorizontalAlignment = number.HorizontalAlignment = HorizontalAlignment.Center;
                ell.VerticalAlignment = number.VerticalAlignment = VerticalAlignment.Center;

                //determining what side of the root the children should be on
                if (num2Binserted < rootNum)
                {
                    ell.Margin = number.Margin = new Thickness(-50 + root.Margin.Left, 50 + root.Margin.Top, 50 + root.Margin.Right, -50 + root.Margin.Bottom); 
                        //new Thickness(0, 0, 80, 300);
                }
                else if (num2Binserted >= rootNum)
                {
                    ell.Margin = number.Margin = new Thickness(50 + root.Margin.Left, 50 + root.Margin.Top, -50 + root.Margin.Right, -50 + root.Margin.Bottom);
                }

                //adding to the tree and resetting the textbox to empty
                tree.Add(num2Binserted);
                insertTextbox.Text = "";

                //adding the node and the number to the screen
                grid.Children.Add(ell);
                grid.Children.Add(number);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (deleteTextbox.Text == "" || (string)rootLabel.Content == "")
            {
                return;
            }
            //if there is a root
            else
            {
                tree.Search
            }
            

        }
    }
}
