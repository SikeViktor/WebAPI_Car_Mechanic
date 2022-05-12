using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_Car_Mechanic_Common.Models;
using WebAPI_Car_Mechanic_Server.Repositories;

namespace WebAPI_Car_Mechanic_Server.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var customers = CustomerRepository.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(long id)
        {
            var customer = CustomerRepository.GetCustomer(id);

            if (customer != null)
            {
                return Ok(customer);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post(Customer customer)
        {
            CustomerRepository.AddCustomer(customer);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Customer customer, long id)
        {
            var customerToUpdate = CustomerRepository.GetCustomer(id);

            if(customerToUpdate != null)
            {
                CustomerRepository.UpdateCustomer(customer);

                return Ok();
            }
          
            return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var customerToDelete = CustomerRepository.GetCustomer(id);
            
            if (customerToDelete != null)
            {
                CustomerRepository.DeleteCustomer(customerToDelete);

                return Ok();
            }

            return NotFound();
        }

    }
}
