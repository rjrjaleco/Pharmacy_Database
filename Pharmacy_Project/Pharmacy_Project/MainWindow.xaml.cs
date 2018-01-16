using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
using System.Windows.Media.Animation;
//using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Threading;
using System.IO.Ports;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharmacy_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //SqlConnection connection;
        //string connectionString;
        public MainWindow()
        {
            
            InitializeComponent();
            //this.DataContext = ViewModelLocator.MainViewModel;
            //SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\Pharmacy_Project\Pharmacy_Project\Pharmacy_Project.mdf;Integrated Security=True;Connect Timeout = 30;");
            //SqlDataAdapter autoNode = new SqlDataAdapter("SELECT ProductName, GenericName FROM [PRODUCT]", con);
            //DataTable dt = new DataTable();
            //autoNode.Fill(dt);
            //for(int x=0; x<dt.Rows.Count; x++)
            //{ 
            //    object obproductname = dt.Rows[x]["ProductName"];
            //    object obgenericname = dt.Rows[x]["GenericName"];
            //    MessageBox.Show(obproductname.ToString() + " "+ obgenericname.ToString());
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void pRODUCTDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pharmacy_Project.Pharmacy_ProjectDataSet pharmacy_ProjectDataSet = ((Pharmacy_Project.Pharmacy_ProjectDataSet)(this.FindResource("pharmacy_ProjectDataSet")));
            
           // MessageBox.Show(pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].GenericName.ToString());
            productNameTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].ProductName.ToString();
            genericNameTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].GenericName.ToString();
            typeTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Type.ToString();
            formTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Form.ToString();
            sellingPriceTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Selling_Price.ToString();
            buyingPriceTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Buying_Price.ToString();
            quanityTbx.Text = pharmacy_ProjectDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Quantity.ToString();
        }

        private void dELIVERYDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pharmacy_Project.Pharmacy_ProjectDataSet pharmacy_ProjectDataSet = ((Pharmacy_Project.Pharmacy_ProjectDataSet)(this.FindResource("pharmacy_ProjectDataSet")));
            supplierIDTbx.Text = pharmacy_ProjectDataSet.DELIVERY[dELIVERYDataGrid.SelectedIndex].SupplierID.ToString();
            orderDateTbx.Text = pharmacy_ProjectDataSet.DELIVERY[dELIVERYDataGrid.SelectedIndex].OrderDate.ToString();
            arrivalDateTBx.Text = pharmacy_ProjectDataSet.DELIVERY[dELIVERYDataGrid.SelectedIndex].ArrivalDate.ToString();
            driverNameTbx.Text = pharmacy_ProjectDataSet.DELIVERY[dELIVERYDataGrid.SelectedIndex].DriverName.ToString();
            
        }

        private void sUPPLIERDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pharmacy_Project.Pharmacy_ProjectDataSet pharmacy_ProjectDataSet = ((Pharmacy_Project.Pharmacy_ProjectDataSet)(this.FindResource("pharmacy_ProjectDataSet")));
            supplierNameTbx.Text = pharmacy_ProjectDataSet.SUPPLIER[sUPPLIERDataGrid.SelectedIndex].SupplierName.ToString();
            supplierDetailsTbx.Text = pharmacy_ProjectDataSet.SUPPLIER[sUPPLIERDataGrid.SelectedIndex].SupplierDetails.ToString();
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            Pharmacy_Project.Pharmacy_ProjectDataSet pharmacy_ProjectDataSet = ((Pharmacy_Project.Pharmacy_ProjectDataSet)(this.FindResource("pharmacy_ProjectDataSet")));
            MessageBox.Show(pharmacy_ProjectDataSet.PRODUCT.Rows.Count.ToString(), "count", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            ViewModelLocator.MainViewModel.AddProduct();
            Update();
            MessageBox.Show(pharmacy_ProjectDataSet.PRODUCT.Rows.Count.ToString(), "count", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void addDeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.MainViewModel.AddDelivery();
            Update();

        }
        private void Update()
        {
            Pharmacy_Project.Pharmacy_ProjectDataSet pharmacy_ProjectDataSet = ((Pharmacy_Project.Pharmacy_ProjectDataSet)(this.FindResource("pharmacy_ProjectDataSet")));
            // Load data into the table PRODUCT. You can modify this code as needed.
            Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.PRODUCTTableAdapter pharmacy_ProjectDataSetPRODUCTTableAdapter = new Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.PRODUCTTableAdapter();
            pharmacy_ProjectDataSetPRODUCTTableAdapter.Fill(pharmacy_ProjectDataSet.PRODUCT);
            //System.Windows.Data.CollectionViewSource pRODUCTViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("pRODUCTViewSource")));
            //pRODUCTViewSource.View.MoveCurrentToFirst();

            // Load data into the table DELIVERY. You can modify this code as needed.
            Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.DELIVERYTableAdapter pharmacy_ProjectDataSetDELIVERYTableAdapter = new Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.DELIVERYTableAdapter();
            pharmacy_ProjectDataSetDELIVERYTableAdapter.Fill(pharmacy_ProjectDataSet.DELIVERY);
            //System.Windows.Data.CollectionViewSource dELIVERYViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dELIVERYViewSource")));
            //dELIVERYViewSource.View.MoveCurrentToFirst();
            //for (int x = 0; x < pharmacy_ProjectDataSet.DELIVERY.Rows.Count; x++)
            //{
            //    var obid = pharmacy_ProjectDataSet.DELIVERY.Rows[x]["Id"];
            //    var obdelsupid = pharmacy_ProjectDataSet.DELIVERY.Rows[x]["SupplierID"];
            //    var oborderdate = pharmacy_ProjectDataSet.DELIVERY.Rows[x]["OrderDate"];
            //    var obarrivdate = pharmacy_ProjectDataSet.DELIVERY.Rows[x]["ArrivalDate"];
            //    var obdrivername = pharmacy_ProjectDataSet.DELIVERY.Rows[x]["DriverName"];
            //    var obdeldetails = pharmacy_ProjectDataSet.DELIVERY.Rows[x]["DeliveryDetails"];
            //    ViewModelLocator.MainViewModel.DeliveryList.Add(new DELIVERY(Convert.ToInt16(obid.ToString()), Convert.ToInt16(obdelsupid.ToString()), Convert.ToDateTime(oborderdate.ToString()), Convert.ToDateTime(obarrivdate.ToString()), obdrivername.ToString(), obdeldetails.ToString()));
            //}


            // Load data into the table SUPPLIER. You can modify this code as needed.
            Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.SUPPLIERTableAdapter pharmacy_ProjectDataSetSUPPLIERTableAdapter = new Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.SUPPLIERTableAdapter();
            pharmacy_ProjectDataSetSUPPLIERTableAdapter.Fill(pharmacy_ProjectDataSet.SUPPLIER);
            //System.Windows.Data.CollectionViewSource sUPPLIERViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("sUPPLIERViewSource")));
            //sUPPLIERViewSource.View.MoveCurrentToFirst();
            // Load data into the table TRANSACTION. You can modify this code as needed.
            Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.TRANSACTIONTableAdapter pharmacy_ProjectDataSetTRANSACTIONTableAdapter = new Pharmacy_Project.Pharmacy_ProjectDataSetTableAdapters.TRANSACTIONTableAdapter();
            pharmacy_ProjectDataSetTRANSACTIONTableAdapter.Fill(pharmacy_ProjectDataSet.TRANSACTION);
            //System.Windows.Data.CollectionViewSource tRANSACTIONViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tRANSACTIONViewSource")));
            //tRANSACTIONViewSource.View.MoveCurrentToFirst();
        }

        private void addSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.MainViewModel.AddSupplier();
            Update();
        }

        //private void BtnTest_Click(object sender, RoutedEventArgs e)
        //{
        //    var holder = new DELIVERY();
        //    var str = holder.getNumberOfDeliveries();
        //    MessageBox.Show(str.ToString(), "Number of Deliveries", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        //}
    }
}
