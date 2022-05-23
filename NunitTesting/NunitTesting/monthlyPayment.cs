using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class monthlyPayment
    {
        public void monthlyPay()
        {
                Console.WriteLine("Enter a principal");
                double principal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a rate amount ");
                double rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a year");
                double year = Convert.ToDouble(Console.ReadLine());
                
                double s = Math.Round(1 + (rate / 1200), 4);
                double t = 12 * year;
                double monthlyPayment = principal * (Math.Pow(s, t)) - principal;
                Console.WriteLine("Monthly payment " + Math.Round(monthlyPayment));


        }
    }
}