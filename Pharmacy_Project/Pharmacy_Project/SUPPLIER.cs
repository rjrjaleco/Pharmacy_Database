using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    class SUPPLIER
    {
        #region Private Fields
        private int _id;
        private string _supplierName;
        private string _supplierDetails;
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
        public string SupplierName
        {
            get
            {
                return _supplierName;
            }
            set
            {
                _supplierName = value;
                OnPropertyChanged("SupplierName");
            }
        }
        public string SupplierDetails
        {
            get
            {
                return _supplierDetails;
            }
            set
            {
                _supplierDetails = value;
                OnPropertyChanged("SupplierDetails");
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
        public SUPPLIER() { }
        public SUPPLIER(int iD, string supplierName, string supplierDetails)
        {
            Id = iD;
            SupplierName = supplierName;
            SupplierDetails = supplierDetails;
        }
        #endregion
    }
}
