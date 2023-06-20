using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_conversion
{
    internal class Conversion{

        public void conversionCelsusToFahrenheit(int value) {
            double result = (value * 1.8) + 32;
            Console.WriteLine("the result of conversion is= " + result);
        }
    }
}
