using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    class USER
    {
        #region Private Fields
        private int _id;
        private string _userName;
        private string _userPassword;
        private string _userLevel;
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
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        public string UserPassword
        {
            get
            {
                return _userPassword;
            }
            set
            {
                _userPassword = value;
                OnPropertyChanged("UserPassword");
            }
        }
        public string UserLevel
        {
            get
            {
                return _userLevel;
            }
            set
            {
                _userLevel = value;
                OnPropertyChanged("UserLevel");
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
        public USER() { }
        public USER(int iD, string userName, string userPassword, string userLevel)
        {
            Id = iD;
            UserName = userName;
            UserPassword = userPassword;
            UserLevel = userLevel;
        }
        #endregion
    }
}
