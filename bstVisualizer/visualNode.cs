using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace bstVisualizer
{
    class VisualNode : UIElement, IComparable
    {
        public Ellipse ell;
        public Label number;

        public VisualNode()
        {

        }

        public VisualNode(int value)
        {
            int num2Binserted = value;

            ell = new Ellipse();
            number = new Label();
            ell.Height = ell.Width = 40;
            ell.Fill = new SolidColorBrush(Color.FromArgb(200, 10, 60, 80));
            number.Content = value;
            number.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            ell.HorizontalAlignment = number.HorizontalAlignment = HorizontalAlignment.Center;
            ell.VerticalAlignment = number.VerticalAlignment = VerticalAlignment.Center;
            
        }

        public void FixPosition(VisualNode parent, bool firstChild)
        {
            if ((int)number.Content < (int)parent.number.Content)
            {
                ell.Margin = number.Margin = new Thickness(parent.ell.Margin.Left - 40, parent.ell.Margin.Top + 40, parent.ell.Margin.Right + 40, parent.ell.Margin.Bottom - 40);
                if(firstChild)
                {
                    ell.Margin = number.Margin = new Thickness(ell.Margin.Left, ell.Margin.Top - 200, ell.Margin.Right, ell.Margin.Bottom + 200);
                }
            }

            else if ((int)number.Content >= (int)parent.number.Content)
            {
                ell.Margin = number.Margin = new Thickness(parent.ell.Margin.Left + 40, parent.ell.Margin.Top + 40, parent.ell.Margin.Right - 40, parent.ell.Margin.Bottom - 40);
                if (firstChild)
                {
                    ell.Margin = number.Margin = new Thickness(ell.Margin.Left, ell.Margin.Top - 200, ell.Margin.Right, ell.Margin.Bottom + 200);
                }
            }
        }

        public int CompareTo(object obj)
        {
            return ((int)this.number.Content).CompareTo((int)((VisualNode)obj).number.Content);
        }
    }
}
