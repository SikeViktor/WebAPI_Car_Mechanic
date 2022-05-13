using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using WebAPI_Car_Mechanic_Common.Models;
using WebAPI_Car_Mechanic_Office;
using System.Windows;


namespace WebAPI_Car_Mechanic_Office.Tests
{
    [TestClass]
    public class CustomerNameUnitTest

    // Arrange
    // Act
    // Assert
    {
        [TestMethod]
        public void ValidateCustomerName_WithValidArgument_ValidName()
        {
            // Arrange
            var customerName = "Teszt Elek";

            // Act
            var checkName = new MockedValidateCustomerName().ValidateCustomerName(customerName);

            // Assert
            Assert.IsTrue(checkName);
        }

        [TestMethod]
        public void ValidateCustomerName_WithHungarianArgument_ValidName()
        {
            // Arrange
            var customerName = "Árvíztûrõ tükörfúrógép";

            // Act
            var checkName = new MockedValidateCustomerName().ValidateCustomerName(customerName);

            // Assert
            Assert.IsTrue(checkName);
        }

        [TestMethod]
        public void ValidateCustomerName_WithInValidArgument_ValidName()
        {
            // Arrange
            var customerName = "Teszt Elek?";

            // Act
            var checkName = new MockedValidateCustomerName().ValidateCustomerName(customerName);

            // Assert
            Assert.IsFalse(checkName);
        }

        [TestMethod]
        public void ValidateCustomerName_WithWhiteSpaces_ValidName()
        {
            // Arrange
            var customerName = "            ";

            // Act
            var checkName = new MockedValidateCustomerName().ValidateCustomerName(customerName);

            // Assert
            Assert.IsFalse(checkName);
        }

        [TestMethod]
        public void ValidateCustomerName_WithSpecialCharacters_ValidName()
        {
            // Arrange
            var customerName = "!?_-:;#";

            // Act
            var checkName = new MockedValidateCustomerName().ValidateCustomerName(customerName);

            // Assert
            Assert.IsFalse(checkName);
        }


    }
}
