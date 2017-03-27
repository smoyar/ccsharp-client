using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryApp.Models
{
    class User : IDataErrorInfo, INotifyPropertyChanged
    {
        private string price = string.Empty;
        private decimal _price = decimal.MinusOne;
        private string nameError= string.Empty;

        public string NameError
        {
            get
            {
                return nameError;
            }
            set
            {
                if (nameError != value)
                {
                    nameError = value;
                    OnPropertyChanged("NameError");
                }
            }
        }

        public string Price
        {
            get
            {
                if (decimal.TryParse(price, out _price))
                {
                    _price = decimal.Parse(price);
                }
                return price;
            }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        // IDataErrorInfo interface
        public string Error
        {
            get
            {
                return NameError;
            }
        }

        // IDataErrorInfo interface
        // Called when ValidatesOnDataErrors=True
        public string this[string columnName]
        {
            get
            {
                NameError = "";
                switch (columnName)
                {
                    case "Price":
                        {
                            if (string.IsNullOrEmpty(Price))
                            {
                                NameError = "Price cannot be empty.";
                            }
                            else if (decimal.TryParse(Price, out _price))
                            {
                                if ((decimal.Parse(Price) < 0)) { NameError = "Price has to be a positive number."; }
                                else { NameError = null; }                                                                
                            }
                            else
                            {
                                NameError = "Price has to be a number.";
                            }
                            break;
                        }
                }
                return NameError;
            }
        }

        // INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
