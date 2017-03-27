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
using System.Data.Entity;
namespace FinalReview
{
    /// <summary>
    /// Interaction logic for ComboWindow.xaml
    /// </summary>
    public partial class ComboWindow : Window
    {
        public ComboWindow()
        {
            InitializeComponent();

            //Data binding using EF
            var entity = new FinalReviewEntities();
            entity.Users.Load();
            uxComboBox.DataContext = entity.Users.Local;
        }

        private void uxComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //When the user select something returns a list with the items selected
            uxGrid.DataContext = e.AddedItems[0];
        }
    }
}
