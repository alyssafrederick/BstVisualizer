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

    public partial class MainWindow : Window
    {
        BinarySearchTree<VisualNode> tree;

        VisualNode head;

        List<UIElement> nodes = new List<UIElement>();

        public MainWindow()
        {
            InitializeComponent();

            //creating tree
            tree = new BinarySearchTree<VisualNode>();

            head = new VisualNode();
            head.ell = root;

        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {

            if (insertTextbox.Text == "")
            {
                return;
            }

            //if there is no root the inserted number is the root
            if (rootLabel.Content.ToString() == "")
            {
                rootLabel.Content = insertTextbox.Text;
                tree.Add(new VisualNode(int.Parse(insertTextbox.Text)));

                insertTextbox.Text = "";
                head.number = rootLabel;
            }
            //if there is a root
            else
            {
                int num2Binserted = Convert.ToInt32(insertTextbox.Text);
                int parent = Convert.ToInt32(rootLabel.Content);

                VisualNode newNode = new VisualNode(num2Binserted);
                BSTNode<VisualNode> mother = tree.Add(newNode).parent;
 //fix                  newNode.FixPosition(mother.Value);

                insertTextbox.Text = "";

                //adding the node and the number to the screen
                grid.Children.Add(newNode.ell);
                grid.Children.Add(newNode.number);
                //nodes.Add(ell);
                //nodes.Add(number);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            //if (deleteTextbox.Text == "" || (string)rootLabel.Content == "")
            //{
            //    return;
            //}
            //if there is a root
            draw();
        }

        public void draw()
        {
            //deleting 
            foreach (UIElement e in nodes)
            {
                grid.Children.Remove(e);
            }
            nodes.Clear();

        }

    }
}
