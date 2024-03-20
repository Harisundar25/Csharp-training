using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Task
    {
       public static void Exercise()
        {
            /*task is to practice the use of loops. There are two methods you have to fill:
             * in the ForLoop method you have to  print on a new line each value from -3 to 3 included using the for loop;
             * in the WhileLoop method you need to print values from 3 to -3 using the while loop;*/
            public static void ForLoop()
            {
                for (int i = -3; i <= 3; i++)
                {
                    Console.WriteLine(i);
                }
            }
            public static void WhileLoop()
            {
                int i = 3;
                while (i >= -3)
                {
                    Console.WriteLine(i);
                    i--;
                }
            }  
            static void Run()
            {
                ForLoop();
                WhileLoop();
            }
        }
    }
}
