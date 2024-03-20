using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class For_loop
    {
        public static void Output()
        {
            for(int counter = 0; counter < 50;  counter+=5)
            {
                Console.WriteLine(counter + " is lower than 50");
            }

            // for loop counter that prints only odd numbers
            Console.WriteLine("odd numbers");
            for (int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine(counter);
            }

            // for loop counter that prints only even numbers
            Console.WriteLine("even numbers");
            for (int counter = 0; counter < 20; counter+=2)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("For loop is done");
            Console.ReadKey();
        }
    }
}
