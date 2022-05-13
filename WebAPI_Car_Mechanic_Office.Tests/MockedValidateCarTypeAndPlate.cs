using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAPI_Car_Mechanic_Office.Tests
{
    public class MockedValidateCarTypeAndPlate
    {
        public bool ValidateCarTypeAndPlate(string carType, string carPlate)
        {
            Regex rgx = new Regex("^[a-zA-Z0-9 ]*$");
            Regex carPlatergx = new Regex("^[A-Z]{3}-[0-9]{3}$");

            
            if (string.IsNullOrWhiteSpace(carType) || !rgx.IsMatch(carType))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(carPlate) || !carPlatergx.IsMatch(carPlate))
            {               
                return false;
            }

            return true;
        }
    }
}
