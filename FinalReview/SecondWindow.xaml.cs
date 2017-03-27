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
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        
        public SecondWindow()
        {
            InitializeComponent();
            //var users = new List<Models.User>();
           // users.Add(new Models.User { Name = "Sarah", Password = "jijiji" });
           // users.Add(new Models.User { Name = "David", Password = "1234" });
           // users.Add(new Models.User { Name = "Leon", Password = "leon" });
           // uxList.ItemsSource = users;
        }
        public override void EndInit()
        {
            base.EndInit();
            //Creates EF to take data from data base
            var fREntities = new FinalReviewEntities();
            //Load the data
            fREntities.Users.Load();
            //Bind the data to uxList
            uxList.ItemsSource = fREntities.Users.Local;

        }
        
    }
}
