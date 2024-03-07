using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Exercise
    {
        public static void Check(int number)
        {
            if (number % 2 == 0) // if the number is divisible by 2, it's even
                {
                    Console.WriteLine("Even number");
                }
            else // if the number is not divisible by 2, it's odd
                {
                    Console.WriteLine("Odd number");
                }
            Console.ReadKey();
        }
    }
}
