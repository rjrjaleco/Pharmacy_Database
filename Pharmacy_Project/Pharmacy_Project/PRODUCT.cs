using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    class PRODUCT
    {
        #region Private Fields
        private int _id;
        private string _productName;
        private string _genericName;
        private string _type;
        private string _form;
        private double _sellingPrice;
        private double _buyingPrice;
        private int _quantity;
        #endregion

        #region Public Fields
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }
        public string GenericName
        {
            get
            {
                return _genericName;
            }
            set
            {
                _genericName = value;
                OnPropertyChanged("GenericName");
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }
        public string Form
        {
            get
            {
                return _form;
            }
            set
            {
                _form = value;
                OnPropertyChanged("Form");
            }
        }
        public double SellingPrice
        {
            get
            {
                return _sellingPrice;
            }
            set
            {
                _sellingPrice = value;
                OnPropertyChanged("SellingPrice");
            }
        }
        public double BuyingPrice
        {
            get
            {
                return _buyingPrice;
            }
            set
            {
                _buyingPrice = value;
                OnPropertyChanged("BuyingPrice");
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string e)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(e));
            }
        }
        #endregion

        #region Instantiate
        public PRODUCT() { }
        public PRODUCT(int iD, string productName, string genericName, string type, string form, double sellingPrice, double buyingPrice, int quantity)
        {
            Id = iD;
            ProductName = productName;
            GenericName = genericName;
            Type = type;
            Form = form;
            SellingPrice = sellingPrice;
            BuyingPrice = buyingPrice;
            Quantity = quantity;
        }
        #endregion
    }
}
