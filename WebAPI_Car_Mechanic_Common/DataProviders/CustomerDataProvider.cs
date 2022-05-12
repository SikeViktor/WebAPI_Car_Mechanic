using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Common.DataProviders
{
    public class CustomerDataProvider
    {
        private const string _url = "http://localhost:5000/api/customer";

        public static IEnumerable<Customer> GetCustomers()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(_url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var customers = JsonConvert.DeserializeObject<IEnumerable<Customer>>(rawData);
                    return customers;
                }

                throw new InvalidOperationException(response.StatusCode.ToString());
            }
        }

        public static void CreateCustomer(Customer customer)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(customer);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateCustomer(Customer customer, long id)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(customer);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync($"{_url}/{id}", content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeleteCustomer(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync($"{_url}/{id}").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
