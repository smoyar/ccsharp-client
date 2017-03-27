using InventoryApp.Models;
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

namespace InventoryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            var inventory = App.InventoryRepository.GetAll();

            uxInventoryList.ItemsSource = inventory
               .Select(t => InventoryModel.ToModel(t))
               .ToList();
        }
        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ItemWindow();

            if (window.ShowDialog() == true)
            {
                var uiInventoryModel = window.Item;

                var repositoryInventoryModel = uiInventoryModel.ToRepositoryModel();

                App.InventoryRepository.Add(repositoryInventoryModel);

                LoadInventory();
            }
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {            
            App.InventoryRepository.Remove(selectedItem.Id);
            selectedItem = null;
            LoadInventory();
        }

        private void uxFileExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxFileUpdate_Click(object sender, RoutedEventArgs e)
        {
            var window = new ItemWindow();
            window.Item = selectedItem;

            if (window.ShowDialog() == true)
            {
                App.InventoryRepository.Update(window.Item.ToRepositoryModel());
                LoadInventory();
            }
        }
        private void uxFileUpdate_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileUpdate.IsEnabled = (selectedItem != null);
        }

        public InventoryModel selectedItem;
        private void uxInventoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (InventoryModel)uxInventoryList.SelectedValue;
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedItem != null);
        }

        private void uxInventoryList_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            uxContextFileDelete.IsEnabled = (selectedItem != null);
            uxContextFileChange.IsEnabled = (selectedItem != null);
        }
    }
}
