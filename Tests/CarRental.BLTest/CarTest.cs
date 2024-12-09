using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarRental.BL

namespace CarRental.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Car_ShouldInitializeWithCorrectValues()
        {
            // Arrange
            Car car = new Car
            {
                CarId = 1,
                Make = "Toyota",
                Model = "Corolla",
                Year = 2020,
                LicensePlate = "ABC-1234",
                RentalPricePerDay = 50.00m,
                IsAvailable = true
            };

            // Act & Assert
            Assert.AreEqual(1, car.CarId);
            Assert.AreEqual("Toyota", car.Make);
            Assert.AreEqual("Corolla", car.Model);
            Assert.AreEqual(2020, car.Year);
            Assert.AreEqual("ABC-1234", car.LicensePlate);
            Assert.AreEqual(50.00m, car.RentalPricePerDay);
            Assert.IsTrue(car.IsAvailable);
        }

        [TestMethod]
        public void Car_ShouldAllowUpdatingAvailability()
        {
            // Arrange
            var car = new Car
            {
                CarId = 1,
                Make = "Toyota",
                Model = "Corolla",
                IsAvailable = true
            };

            // Act
            car.IsAvailable = false;

            // Assert
            Assert.IsFalse(car.IsAvailable);
        }

        [TestMethod]
        public void Car_ShouldAllowUpdatingRentalPrice()
        {
            // Arrange
            var car = new Car
            {
                CarId = 1,
                RentalPricePerDay = 50.00m
            };

            // Act
            car.RentalPricePerDay = 60.00m;

            // Assert
            Assert.AreEqual(60.00m, car.RentalPricePerDay);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Car_ShouldThrowExceptionForInvalidYear()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Year = 1899; // Assuming Year property has validation.

            // Assert is handled by ExpectedException
        }
    }
}
