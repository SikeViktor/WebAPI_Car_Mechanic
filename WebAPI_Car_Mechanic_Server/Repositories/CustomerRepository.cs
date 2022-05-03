using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Server.Repositories
{
    public class CustomerRepository
    {
        
        public static IList<Customer> GetCustomers()
        {
            using (var db = new CustomerContext())
            {
                var customers = db.Customers.ToList();

                return customers;
            }
            
        }
        public static Customer GetCustomer(long id)
        {
            using (var db = new CustomerContext())
            {
                var customer = db.Customers.Where(c => c.Id == id).FirstOrDefault();

                return customer;
            }

        }

        public static void AddCustomer(Customer customer)
        {
            using (var db = new CustomerContext())
            {
                db.Customers.Add(customer);

                db.SaveChanges();
            }
        }
        public static void UpdateCustomer(Customer customer)
        {
            using (var db = new CustomerContext())
            {
                    db.Customers.Update(customer);

                    db.SaveChanges();  
            }
        }

        public static void DeleteCustomer(Customer customer)
        {
            using (var db = new CustomerContext())
            {
                db.Customers.Remove(customer);

                db.SaveChanges();
            }
        }
    }
}
