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
using System.Windows.Shapes;
using WebAPI_Car_Mechanic_Common.DataProviders;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Workshop
{
    /// <summary>
    /// Interaction logic for ChangeStatusWindow.xaml
    /// </summary>
    public partial class ChangeStatusWindow : Window
    {
        private Customer _customer;
        private IList<string> _Status = new List<string>() { "Felvett munka", "Elvégzés alatt", "Befejezett" };
        public ChangeStatusWindow(Customer customer)
        {
            this._customer = customer;
            InitializeComponent();
            
            CustomerName.Content = customer.CustomerName;
            CarType.Content = customer.CarType;
            CarPlateNumber.Content = customer.CarPlateNumber;
            ProblemDescription.Text = customer.ProblemDescription;
            CarStatus.Content = customer.SelectedStatus;
            NewStatusComboBox.ItemsSource = _Status;
            DateAndTime.Content = $"{customer.DateAndTime.Year}.{customer.DateAndTime.Month}.{customer.DateAndTime.Day}.";
        }
        
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewStatusComboBox.Text != "")
            { 
                _customer.SelectedStatus = NewStatusComboBox.Text;
                CustomerDataProvider.UpdateCustomer(_customer, _customer.Id);
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Válassz munka állapotot!");
            }
        }
    }
}
