using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void rooCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point clickPoint = e.GetPosition(rooCanvas);
            if (IsPointInRectangle(clickPoint, new Rect(98, 75, 200, 150)))
            {
                MessageBox.Show("Кухня");
            }
            else if (IsPointInRectangle(clickPoint, new Rect(300, 100, 200, 150)))
            {
                MessageBox.Show("Коридор");
            }
            else if (IsPointInRectangle(clickPoint, new Rect(300, 250, 200, 150)))
            {
                MessageBox.Show("Спальня");
            }
            else if (IsPointInRectangle(clickPoint, new Rect(98, 225, 200, 175)))
            {
                MessageBox.Show("Зал");
            }
        }
        private bool IsPointInRectangle(Point point, Rect rectangle)
        {
            return point.X >= rectangle.Left && point.X <= rectangle.Right && point.Y >= rectangle.Top && point.Y <= rectangle.Bottom;
        }
    }
}