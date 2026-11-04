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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller = new();
        
        public MainWindow()
        {
            InitializeComponent();
            ToggleControls();
        }

        private void NewPersonButton_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            ToggleControls();
            UpdatePersonTextBoxes();
            AgeTextBox.Clear();
        }

        private void DeletePersonButton_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            ToggleControls();
            UpdatePersonTextBoxes();
        }

        private void UpdatePersonTextBoxes()
        {
            if (controller.CurrentPerson is not null)
            {
                FirstNameTextBox.Text = controller.CurrentPerson.FirstName;
                LastNameTextBox.Text = controller.CurrentPerson.LastName;
                AgeTextBox.Text = controller.CurrentPerson.Age.ToString();
                TelephoneNoTextBox.Text = controller.CurrentPerson.TelephoneNo;
            }
            else
            {
                FirstNameTextBox.Text = string.Empty;
                LastNameTextBox.Text = string.Empty;
                AgeTextBox.Text = string.Empty;
                TelephoneNoTextBox.Text = string.Empty;
            }
            PersonCountLabel.Content = $"Person Count {controller.PersonCount}";
            IndexLabel.Content = $"Index {controller.PersonIndex}";
        }

        private void ToggleControls()
        {
            if (controller.PersonCount == 0 && controller.PersonIndex == -1)
            {
                FirstNameTextBox.IsEnabled = false;
                LastNameTextBox.IsEnabled = false;
                AgeTextBox.IsEnabled = false;
                TelephoneNoTextBox.IsEnabled = false;
                DeletePersonButton.IsEnabled = false;
                UpButton.IsEnabled = false;
                DownButton.IsEnabled = false;
            }
            else
            {
                FirstNameTextBox.IsEnabled = true;
                LastNameTextBox.IsEnabled = true;
                AgeTextBox.IsEnabled = true;
                TelephoneNoTextBox.IsEnabled = true;
                DeletePersonButton.IsEnabled = true;
                UpButton.IsEnabled = true;
                DownButton.IsEnabled = true;
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.CurrentPerson is not null)
                controller.CurrentPerson.FirstName = FirstNameTextBox.Text;
        }

        private void LastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.CurrentPerson is not null)
                controller.CurrentPerson.LastName = LastNameTextBox.Text;
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.CurrentPerson is not null)
                if (int.TryParse(AgeTextBox.Text, out int age))
                    controller.CurrentPerson.Age = age;
        }

        private void TelephoneNoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.CurrentPerson is not null)
                controller.CurrentPerson.TelephoneNo = TelephoneNoTextBox.Text;
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            UpdatePersonTextBoxes();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            UpdatePersonTextBoxes();
        }
    }
}