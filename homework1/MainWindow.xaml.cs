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

namespace homework1
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

        private bool FormFilled(TextBox myTextBox)
        {
            bool result = false;
            if (myTextBox.Text.Length > 0) { result = true; }
            return result;         
        }
        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Password submitted. Thank you {uxName.Text}");
        }
        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            FormFilled(sender as TextBox);
            if (FormFilled(uxName) && FormFilled(uxPassword)) { uxSubmit.IsEnabled = true; }
            else { uxSubmit.IsEnabled = false; }
        }

        private void uxCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true) {}
            else { }
        }
    }
}
