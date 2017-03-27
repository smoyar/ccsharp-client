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

namespace FinalReview
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
            //this.WindowState = WindowState.Maximized; //To maximize the window
        }
        public override void EndInit()
        {
            base.EndInit();
            uxName.DataContext = user;
            uxNameError.DataContext = user; 
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Your Password {uxName.Text} has been submitted");
            //It creates a second window (instance reference) close the old window and makes the secondwindow the main window of the application
            var window = new SecondWindow();
            Close();
            window.Show();
            Application.Current.MainWindow = window;
        }

        private void OnNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Command");
        }

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Click CTRL+N to execute the shortcut
        private void OnNew_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //Set this to false if it's faded
            e.CanExecute = true;
        }

        private void OnNew_Click(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
