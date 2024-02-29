using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class Return_Value
    {
        public static void Return()
        {
            Console.WriteLine(Add(15, 25));
            //  Console.WriteLine(Add(Add(1, 3), Add(4, 2)));
            Console.WriteLine(Multiply(4, 3));
            Console.WriteLine(Divide(4, 12));
            Console.ReadKey();
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return (a * b);
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
