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
using System.Windows.Shapes;

namespace InventoryApp
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((uxPassword.Password == "TBMBertha") && (uxUser.Text == "DUSA"))
            {
                var window = new MainWindow();
                Close();
                window.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user or password. Please try again");
            }
        }

        private void uxCancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using DUSA Inventory Control. Have a nice day! ");
            Close();
        }
    }
}
