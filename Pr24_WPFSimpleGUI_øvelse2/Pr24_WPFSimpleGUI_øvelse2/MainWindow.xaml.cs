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

namespace Pr24_WPFSimpleGUI_øvelse2
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Line1TextBox.Clear();
            Line2TextBox.Clear();
            Line3TextBox.Clear();
            Line4TextBox.Clear();
        }

        private void ScrollUpButton_Click(object sender, RoutedEventArgs e)
        {
            string temp = Line1TextBox.Text;
            Line1TextBox.Text = Line2TextBox.Text;
            Line2TextBox.Text = Line3TextBox.Text;
            Line3TextBox.Text = Line4TextBox.Text;
            Line4TextBox.Text = temp;
        }

        private void ScrollDownButton_Click(object sender, RoutedEventArgs e)
        {
            string temp = Line4TextBox.Text;
            Line4TextBox.Text = Line3TextBox.Text;
            Line3TextBox.Text = Line2TextBox.Text;
            Line2TextBox.Text = Line1TextBox.Text;
            Line1TextBox.Text = temp;
        }
    }
}