using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Office.Tests
{
    public class MockedValidateCustomerName
    {
        public bool ValidateCustomerName(string customerName)
        {
            Regex rgx = new Regex("^[a-záéíóöőúüűA-ZÁÉÍÓÖŐÚÜŰ0-9 ]*$");

            if (string.IsNullOrWhiteSpace(customerName))
            {
                return false;
            }
            else if (!rgx.IsMatch(customerName))
            {
                return false;
            }

            return true;
        }
    }
}
