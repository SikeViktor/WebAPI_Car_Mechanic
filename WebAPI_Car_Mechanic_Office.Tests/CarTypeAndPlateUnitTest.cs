using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Car_Mechanic_Office.Tests
{
    [TestClass]
    public class CarTypeAndPlateUnitTest
    {
        [TestMethod]
        public void ValidateCarTypeAndPlate_WithValidArgument_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "Opel";
            var carPlate = "ABC-123";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsTrue(checkCar);
        }

        [TestMethod]
        public void ValidateCarTypeAndPlate_WithInValidPlate_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "Opel";
            var carPlate = "BC-123";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsFalse(checkCar);
        }
        [TestMethod]
        public void ValidateCarTypeAndPlate_WithInValidType_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "!?_-:;#";
            var carPlate = "ABC-123";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsFalse(checkCar);
        }
        [TestMethod]
        public void ValidateCarTypeAndPlate_WithInValidArguments_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "!?_-:;#";
            var carPlate = "!?_-:;#";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsFalse(checkCar);
        }
        [TestMethod]
        public void ValidateCarTypeAndPlate_WithWhiteSpaceArguments_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "       ";
            var carPlate = "      ";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsFalse(checkCar);
        }
        [TestMethod]
        public void ValidateCarTypeAndPlate_WithWhiteSpaceType_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "       ";
            var carPlate = "ABC-123";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsFalse(checkCar);
        }
        [TestMethod]
        public void ValidateCarTypeAndPlate_WithWhiteSpacePlate_ValidTypeAndPlate()
        {
            // Arrange
            var carType = "Opel";
            var carPlate = "              ";

            // Act
            var checkCar = new MockedValidateCarTypeAndPlate().ValidateCarTypeAndPlate(carType, carPlate);

            // Assert
            Assert.IsFalse(checkCar);
        }
    }
}
