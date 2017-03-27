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
using InventoryApp.Models;

namespace InventoryApp
{
    /// <summary>
    /// Interaction logic for ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public ItemWindow()
        {
            InitializeComponent();
            //Do not show this window in the task bar
            ShowInTaskbar = false;

        }

        //Data Binding for price
        private User user = new User();
        public override void EndInit()
        {
            base.EndInit();
            uxPrice.DataContext = user;
            uxNameError.DataContext = user;
        }
        public InventoryModel Item { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            Item.Name = uxName.Text;

            if (uxConsignment.IsChecked.Value)
            {
                Item.Contract = "Consignment";
            }
            else
            {
                Item.Contract = "Purchased";
            }

            //Combobox for Systems
            if ((ComboBoxItem)uxSystem.SelectedItem == null)
            {
                Item.System = "No system assigned";
            }
            else
            {
                Item.System = ((ComboBoxItem)uxSystem.SelectedItem).Content.ToString();
            }

            Item.Qty = (int)uxQty.Value; //Value of the sliding bar
            Item.Price = decimal.Parse(uxPrice.Text); //Data binding to assure the price is a valid number
            Item.Description = uxNotes.Text;
            Item.CreatedDate = DateTime.Now;

            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void uxPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Enable submit if all the data is correct
            if (uxNameError.HasContent) { uxSubmit.IsEnabled = false; }
            else { uxSubmit.IsEnabled = true; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Item != null)
            {
                if (Item.Contract == "Consignment")
                {
                    uxConsignment.IsChecked = true;
                }
                else
                {
                    uxPurchased.IsChecked = true;
                }
                uxSubmit.Content = "Update";
                uxPrice.Text = string.Format("{0:C}",Item.Price.ToString());
            }
            else
            {
                Item = new InventoryModel();
                Item.CreatedDate = DateTime.Now;
            }

            uxGrid.DataContext = Item;
        }
    }
}
