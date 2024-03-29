using System;

namespace Loops
{
    internal class Challenge
    {
       /* break and continue practice
        * Implement conditions for the given while loop.
        * To pass the tests, your loop should skip all divisible by 3 values 
        * and stops running when i = 10.*/
        public static void Run()
        {
            int i = -10;
            while(true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                {
                    break;
                }
                if (i == 11)
                {
                    Console.WriteLine("Final break reached!" +
                        "This should not happen!");
                    break;
                }
                Console.WriteLine(i++);
            }
            Console.ReadKey();
        }
    }
}
