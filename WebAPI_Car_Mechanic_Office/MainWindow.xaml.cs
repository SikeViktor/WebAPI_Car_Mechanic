using System;
using System.Collections.Generic;
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
using WebAPI_Car_Mechanic_Common.Models;
using WebAPI_Car_Mechanic_Common.DataProviders;

namespace WebAPI_Car_Mechanic_Office
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateCustomerDataGrid();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var window = new CustomerWindow(null);
            if (window.ShowDialog() ?? false)
            {
                UpdateCustomerDataGrid();
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCustomer = CustomerDataGrid.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                var window = new CustomerWindow(selectedCustomer);
                if (window.ShowDialog() ?? false)
                {
                    UpdateCustomerDataGrid();
                }
                
                CustomerDataGrid.UnselectAll();
            }
            
        }

        private void UpdateCustomerDataGrid()
        {
            var customers = CustomerDataProvider.GetCustomers();
            CustomerDataGrid.ItemsSource = customers;
        }
    }
}
