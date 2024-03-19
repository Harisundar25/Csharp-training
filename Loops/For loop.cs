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
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
