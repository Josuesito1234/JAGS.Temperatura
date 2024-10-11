using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGS.Temperatura
{
    public class Temperature
    {
        public double CelsiusToFahrenheit(double celsius, double fahrenheit)
        {
            fahrenheit = (celsius * 9/5) + 32;
            return fahrenheit;
        }

        public double FahrenheitToCelsius(double fahrenheit, double celsius)
        {
             celsius = (fahrenheit - 32) * 5/9;
            return celsius;
        }
    }
}
