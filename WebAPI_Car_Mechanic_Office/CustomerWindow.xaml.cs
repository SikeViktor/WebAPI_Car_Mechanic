using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WebAPI_Car_Mechanic_Common.DataProviders;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Office
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private Customer _customer;
        private IList<string> Status = new List<string>() { "Felvett munka", "Elvégzés alatt", "Befejezett" };

        public CustomerWindow(Customer customer)
        {
            InitializeComponent();


            if (customer != null)
            {
                _customer = customer;

                CustomerNameTextBox.Text = _customer.CustomerName;
                CarTypeTextBox.Text = _customer.CarType;
                CarPlateTextBox.Text = _customer.CarPlateNumber;
                DescriptionTextBox.Text = _customer.ProblemDescription;

                StatusComboBox.ItemsSource = Status;
                StatusComboBox.SelectedItem = _customer.SelectedStatus;

                DatePicker.SelectedDate = _customer.DateAndTime;

                CreateButton.Visibility = Visibility.Collapsed;
                UpdateButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;
            }
            else
            {
                _customer = new Customer();

                StatusComboBox.SelectedItem = Status[0];
                StatusComboBox.ItemsSource = Status;
                //DatePicker.SelectedDate = DateTime.Now;

                CreateButton.Visibility = Visibility.Visible;
                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateCustomerName(CustomerNameTextBox.Text) && ValidateCustomers())
            {
                _customer.CustomerName = CustomerNameTextBox.Text;
                _customer.CarType = CarTypeTextBox.Text;
                _customer.CarPlateNumber = CarPlateTextBox.Text;
                _customer.ProblemDescription = DescriptionTextBox.Text;
                _customer.SelectedStatus = Status[0];
                _customer.DateAndTime = DatePicker.SelectedDate.Value;

                CustomerDataProvider.CreateCustomer(_customer);

                DialogResult = true;
                Close();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (ValidateCustomerName(CustomerNameTextBox.Text) && ValidateCustomers())
            {
                
                _customer.CustomerName = CustomerNameTextBox.Text;
                _customer.CarType = CarTypeTextBox.Text;
                _customer.CarPlateNumber = CarPlateTextBox.Text;
                _customer.ProblemDescription = DescriptionTextBox.Text;
                _customer.SelectedStatus = StatusComboBox.Text;
                _customer.DateAndTime = DatePicker.SelectedDate.Value;

                CustomerDataProvider.UpdateCustomer(_customer, _customer.Id);

                DialogResult = true;
                Close();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akarod törölni?", "Kérdés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                CustomerDataProvider.DeleteCustomer(_customer.Id);

                DialogResult = true;
                Close();
            }
        }

        private bool ValidateCustomers()
        {
            if (string.IsNullOrEmpty(CarTypeTextBox.Text))
            {
                MessageBox.Show("Az autó típusa kötelező!");
                return false;
            }

            if (string.IsNullOrEmpty(CarPlateTextBox.Text))
            {
                MessageBox.Show("Az autó rendszáma kötelező!");
                return false;
            }

            if (string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("A probléma leírása kötelező!");
                return false;
            }

            if (!DatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Dátum megadása kötelező!");
                return false;
            }

            return true;
        }
        
        public bool ValidateCustomerName(string customerName)
        {
            Regex rgx = new Regex("^[a-záéíóöőúüűA-ZÁÉÍÓÖŐÚÜŰ0-9 ]*$");

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Ügyfél neve kötelező!");
                return false;
            }
            else if (!rgx.IsMatch(customerName))
            {
                MessageBox.Show("Ügyfél neve speciális karaktert nem tartalmazhat!");
                return false;
            }

            return true;
        }

    }
}
