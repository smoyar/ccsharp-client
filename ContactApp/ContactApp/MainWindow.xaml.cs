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
using ContactApp.Models;


namespace ContactApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadContacts(); //Calling method when mainWindow is up
        }

        private void LoadContacts()
        {
            var contacts = App.ContactRepository.GetAll();

            uxContactList.ItemsSource = contacts
                .Select(t => ContactModel.ToModel(t)) //Equivalent to the code below. It does a foreach loop to find the item and then select it.
                .ToList();

            // OR
            //var uiContactModelList = new List<ContactModel>();
            //foreach (var repositoryContactModel in contacts)
            //{
            //    This is the .Select(t => ... )
            //    var uiContactModel = ContactModel.ToModel(repositoryContactModel);
            //
            //    uiContactModelList.Add(uiContactModel);
            //}

            //uxContactList.ItemsSource = uiContactModelList;
        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ContactWindow();

            if (window.ShowDialog() == true)
            {
                var uiContactModel = window.Contact;

                var repositoryContactModel = uiContactModel.ToRepositoryModel();

                App.ContactRepository.Add(repositoryContactModel);

                // OR
                //App.ContactRepository.Add(window.Contact.ToRepositoryModel());

                LoadContacts(); //When adding an element call on load contacts to update, to show up
            }
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {

        }

        //We have to make sure the contact is selected
        private ContactModel selectedContact;
        private void uxContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedContact = (ContactModel)uxContactList.SelectedValue;//unboxing the object
        }
        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.ContactRepository.Remove(selectedContact.Id);
            selectedContact = null;
            LoadContacts();
        }
    }
}