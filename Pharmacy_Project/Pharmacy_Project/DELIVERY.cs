using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    class DELIVERY
    {
        #region Private Fields
        private int _id;
        private int _supplierID;
        private DateTime _orderDate;
        private DateTime _arrivalDate;
        private string _driverName;
        private string _deliveryDetails;
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
        public int SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = value;
                OnPropertyChanged("SupplierID");
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                OnPropertyChanged("OrderDate");
            }
        }
        public DateTime ArrivalDate {
            get
            {
                return _arrivalDate;
            }
            set
            {
                _arrivalDate = value;
                OnPropertyChanged("ArrivalDate");
            }
        }
        public string DriverName {
            get
            {
                return _driverName;
            }
            set
            {
                _driverName = value;
                OnPropertyChanged("DriverName");
            }
        }
        public string DeliveryDetails {
            get
            {
                return _deliveryDetails;
            }
            set
            {
                _deliveryDetails = value;
                OnPropertyChanged("DeliveryDetails");
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
        public DELIVERY () { }
        public DELIVERY(int iD, int supplierID, DateTime orderDate, DateTime arrivalDate, string driverName, string deliveryDetails)
        {
            Id = iD;
            SupplierID = supplierID;
            OrderDate = orderDate;
            ArrivalDate = arrivalDate;
            DriverName = driverName;
            DeliveryDetails = deliveryDetails;
        }
        #endregion
        
        #region Functions
        public int getTimeRemaining()
        {
            DateTime Arrive = ArrivalDate;
            DateTime Order = OrderDate;

            var Result = Arrive.Subtract(Order);
            return Result.Days;
        }
        public int getNumberOfDeliveries()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\Pharmacy_Project\Pharmacy_Project.mdf");
            SqlDataAdapter sdadel = new SqlDataAdapter("SELECT Id, SupplierID, OrderDate, ArrivalDate, DriverName, DeliveryDetails FROM [DELIVERY]", con);
            DataTable dt = new DataTable();
            //sdadel.Fill(dt);
            return dt.Rows.Count;
        }
        #endregion


    }
}
