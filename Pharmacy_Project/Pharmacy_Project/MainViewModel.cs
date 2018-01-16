using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pharmacy_Project
{
    class MainViewModel
    {
        ObservableCollection<DELIVERY> _deliveryList = new ObservableCollection<DELIVERY>();
        public ObservableCollection<DELIVERY> DeliveryList { get { return _deliveryList; } }

        public MainViewModel()
        {
            //SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\Pharmacy_Project\Pharmacy_Project\Pharmacy_Project.mdf;Integrated Security=True;Connect Timeout = 30;");
            //SqlDataAdapter auNode = new
        }
        public void AddDelivery()
        {
            var window = new AddNewDeliveryWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            Application.Current.MainWindow.Hide();
            var result = window.ShowDialog();
            Application.Current.MainWindow.Show();
        }
        public void AddProduct()
        {
            var window = new AddNewProductWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            Application.Current.MainWindow.Hide();
            var result = window.ShowDialog();
            Application.Current.MainWindow.Show();
        }
        public void AddSupplier()
        {
            var window = new AddNewSupplierWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            Application.Current.MainWindow.Hide();
            var result = window.ShowDialog();
            Application.Current.MainWindow.Show();
        }
    }
}
