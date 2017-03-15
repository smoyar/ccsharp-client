using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Submitting your password {uxName.Text}: {uxPassword.Password}");
            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }
        public override void EndInit()
        {
            base.EndInit();

            var sample =new SampleEntities();
            sample.Users.Load();
            uxList.ItemsSource = sample.Users.Local;

            uxName.DataContext = user;
        }

        private void uxSubmit_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            MessageBox.Show($"Submitting your password {uxName.Text}: {uxPassword.Password}");
        }
    }
}
