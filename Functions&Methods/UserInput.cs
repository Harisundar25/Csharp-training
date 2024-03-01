using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class UserInput
    {
      public static void Output()
        {
            Console.WriteLine(Calculate());
            Console.ReadKey();
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.Read();
        }
        public static int Calculate()
        {
            Console.WriteLine("Enter the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            int result = num1 + num2;
            return result;
        }
    }
}
