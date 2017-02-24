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

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thanks {uxName.Text}. Your password has been submitted");
        }

        private bool TextBoxFilled(TextBox myTextBox)
        {
            if (myTextBox.Text.Length > 0) { return true; }
            else { return false; }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxFilled(sender as TextBox);
            if ((TextBoxFilled(uxName)) && (TextBoxFilled(uxPassword))) { uxSubmit.IsEnabled = true; }
            else { uxSubmit.IsEnabled = false; }
        }
    }
}
