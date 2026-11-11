using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pr25_WPFDialogGUI
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort OneFlower { get; set; }
        
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!AreFieldsFilledOut())
                return;

            OneFlower = new FlowerSort
            {
                Name = NameTextBox.Text,
                PicturePath = ImageTextBox.Text,
                ProductionTime = int.Parse(ProductionTimeTextBox.Text),
                HalfLifeTime = int.Parse(HalfTimeTextBox.Text),
                Size = int.Parse(SizeTextBox.Text)
            };

            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ImageTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TryLoadImage(ImageTextBox.Text);
        }

        private bool TryLoadImage(string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                    return false;

                Uri newImageUri = new(path, UriKind.Absolute);
                ImageImageBox.Source = new BitmapImage(newImageUri);
                ImageTextBox.ClearValue(TextBox.BackgroundProperty);
                return true;
            }
            catch (UriFormatException)
            {
                ImageTextBox.Background = Brushes.Red;
                MessageBox.Show("Stien har forkert format!", "Fejl!", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (FileNotFoundException)
            {
                ImageTextBox.Background = Brushes.Red;
                MessageBox.Show("Inte billede fundet på valgte sti!", "Fejl!", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        private bool AreFieldsFilledOut()
        {
            if (NameTextBox.Text.IsWhiteSpace())
            {
                NameTextBox.Background = Brushes.Crimson;
                return false;
            }
            if (ImageTextBox.Text.IsWhiteSpace())
            {
                ImageTextBox.Background = Brushes.Red;
                return false;
            }
            if (ProductionTimeTextBox.Text.IsWhiteSpace() || !IsInt(ProductionTimeTextBox.Text))
            {
                ProductionTimeTextBox.Background = Brushes.DarkRed;
                return false;
            }
            if (string.IsNullOrWhiteSpace(HalfTimeTextBox.Text) || !IsInt(HalfTimeTextBox.Text))
            {
                HalfTimeTextBox.Background = Brushes.Purple;
                return false;
            }
            if (string.IsNullOrWhiteSpace(SizeTextBox.Text) || !IsInt(SizeTextBox.Text))
            {
                SizeTextBox.Background = Brushes.PaleGoldenrod;
                return false;
            }
            return true;
        }

        private void OKButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!AreFieldsFilledOut())
                OKButton.IsEnabled = false;
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameTextBox.ClearValue(TextBox.BackgroundProperty);
            OKButton.IsEnabled = true;
        }

        private void ProductionTimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProductionTimeTextBox.ClearValue(TextBox.BackgroundProperty);
            OKButton.IsEnabled = true;
        }

        private void HalfTimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            HalfTimeTextBox.ClearValue(TextBox.BackgroundProperty);
            OKButton.IsEnabled = true;
        }

        private void SizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SizeTextBox.ClearValue(TextBox.BackgroundProperty);
            OKButton.IsEnabled = true;

        }

        private bool IsInt(string someString)
        {
            if (int.TryParse(someString, out int _))
                return true;
            return false;
        }

        private void ChoosePictureButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                ImageTextBox.ClearValue(TextBox.BackgroundProperty);
                OKButton.IsEnabled = true;
                ImageTextBox.Text = openFileDialog.FileName;
                TryLoadImage(openFileDialog.FileName);
            }
        }

    }
}
