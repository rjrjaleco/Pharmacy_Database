using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    class TRANSACTION
    {
        #region Private Fields
        private int _id;
        private DateTime _transactionDate;
        private int _userID;
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
        public DateTime TransactionDate
        {
            get
            {
                return _transactionDate;
            }
            set
            {
                _transactionDate = value;
                OnPropertyChanged("TransactionDate");
            }
        }
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
                OnPropertyChanged("UserID");
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
        public TRANSACTION() { }
        public TRANSACTION(int iD, DateTime transactionDate, int userID)
        {
            Id = iD;
            TransactionDate = transactionDate;
            UserID = userID;
        }
        #endregion
    }
}
