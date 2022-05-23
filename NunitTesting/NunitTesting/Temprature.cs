using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class Temprature
    {
        public void tempratureConvert()
        {

            Console.WriteLine("Enter the Celsius:");
            double celcius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            tempConversion(celcius, fahrenheit);
        }
        public  void tempConversion(double celcius, double fahrenheit)
        {
            double celToFarhen = (celcius * 9 / 5) + 32;
            double FarhenToCel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celusis To Fahrenheit Temperature : " + Math.Round(celToFarhen));
            Console.WriteLine("Fahrenheit To Celusis Temperature : " + Math.Round(FarhenToCel));
        }
    }
}
