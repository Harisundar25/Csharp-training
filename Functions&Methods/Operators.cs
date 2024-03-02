using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class Operators
    {
        public static void Output()
        {
            int num1 = 6;
            int num2 = 4;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);
            bool isSunny = true;
            Console.WriteLine("is it Sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); // post - increment
            Console.WriteLine("num is {0}", ++num); // pre - increment

            // decrement operators
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--); // post - decrement
            Console.WriteLine("num is {0}", --num); // pre - decrement

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1 > num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2; // == is comparison operator
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);
            isEqual = num1 != num2; // != is not equal
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operator
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; // && is and operator
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny; // || is or operator
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);
            Console.ReadKey();
        }
    }
}
