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

namespace Pr25_WPFDialogGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;

        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = [];
            // [] same as:
            //new();
            // or:
            //new List<FlowerSort>();
        }

        private void CreateFlowerSortButton_Click(object sender, RoutedEventArgs e)
        {
            // Following is called an Object Initializer
            // (An object initializer lets you set an object’s properties as part of creating it.)
            CreateFlowerSortDialog createFlowerSortDialogBox = new()
            {
                Owner = this
            };

            if (createFlowerSortDialogBox.ShowDialog() == true)
            {
                flowerSorts.Add(createFlowerSortDialogBox.OneFlower);
                ShowFlowerSortNamesTextBlock.Text += createFlowerSortDialogBox.OneFlower.Name + Environment.NewLine;
            }
        }
    }
}