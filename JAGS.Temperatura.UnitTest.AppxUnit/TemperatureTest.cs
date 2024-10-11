using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGS.Temperatura.UnitTest.AppxUnit
{
    public class TemperatureTest
    {
        [Fact]
        public void CelsiusToFahrenheit_ShouldReturnTheCorrectFormula()
        {
            Temperature temperature = new Temperature();
            double celsius = 25.0;
            double fahrenheit = 77.0;

            double result = temperature.CelsiusToFahrenheit(celsius, fahrenheit);

            Assert.Equal(77.0, result);
        }

        [Fact]
        public void FahrenheitToCelsius_ShouldReturnTheCorrectFormula()
        {
           Temperature temperature = new Temperature();
            double fahrenheit = 77.0;
            double celsius = 25.0;

            double result = temperature.FahrenheitToCelsius(fahrenheit, celsius);

            Assert.Equal(25.0, result);
        }
    }
}
