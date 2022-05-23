using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class Binary
    {
        public void toBinary()
        {
            Console.WriteLine("Enter a decimal number");
            int dec = Convert.ToInt32(Console.ReadLine());
            int i; 
            int[] Array = new int[15];
            for (i = 0; dec > 0; i++)
            {
                Array[i] = dec % 2;
                dec = dec / 2;
            }
            Console.WriteLine("Binary of the given decimal is:");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(Array[i]);
            }
        }
    }
}
