using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Pharmacy_Project
{
    /// <summary>
    /// Interaction logic for AddNewDeliveryWindow.xaml
    /// </summary>
    public partial class AddNewDeliveryWindow : Window
    {
        public AddNewDeliveryWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\Pharmacy_Project\Pharmacy_Project\Pharmacy_Project.mdf;Integrated Security=True;Connect Timeout = 30;");
            con.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO [DELIVERY] VALUES('" +SuppIDTbx.Text + "','" + OrderDateDtp.SelectedDate + "','" + ArrivDateDtp.SelectedDate + "','"+DriverNameTbx.Text+"','"+DelDetailsTbx.Text+"')", con);
            comm.ExecuteNonQuery();
            con.Close();
            //SqlCommand cmd = new SqlCommand("sp_insert")
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
