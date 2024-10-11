using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAGS.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGS.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            // Arrage
            Temperature temperature = new Temperature();

            // Act
            double result = temperature.CelsiusToFahrenheit(25, 77);

            // Assert
            Assert.AreEqual(77, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            // Arrage
            Temperature temperature = new Temperature();

            // Act
            double result = temperature.FahrenheitToCelsius(77, 25);

            // Assert
            Assert.AreEqual(25, result);
        }
    }
}