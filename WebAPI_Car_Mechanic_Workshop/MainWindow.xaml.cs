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

namespace WebAPI_Car_Mechanic_Workshop
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

        private void ChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            var selectedCustomer = CustomerDataGrid.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                var window = new ChangeStatusWindow(selectedCustomer);
                if (window.ShowDialog() ?? false)
                {
                    UpdateCustomerDataGrid();
                }

                CustomerDataGrid.UnselectAll();
            }
            else
            {
                MessageBox.Show("Válassz egy sort!");
            }
        }
        private void UpdateCustomerDataGrid()
        {
            var customers = CustomerDataProvider.GetCustomers();
            CustomerDataGrid.ItemsSource = customers;
        }
    }
}
