﻿using System;
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
    /// Interaction logic for AddNewProductWindow.xaml
    /// </summary>
    public partial class AddNewProductWindow : Window
    {
        public AddNewProductWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rjrjaleco\Documents\Visual Studio 2015\Projects\Pharmacy_Project\Pharmacy_Project\Pharmacy_Project.mdf;Integrated Security=True;Connect Timeout = 30;");
            con.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO [PRODUCT] VALUES('" + ProductNameTbx.Text + "','" + GenericNameTbx.Text + "','" + TypeTbx.Text + "','" + FormTbx.Text + "','" + BuyingPriceTbx.Text + "','" + SellingPriceTbx.Text + "','" + QuanityTbx.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
