using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    internal class var_Keyword
    {
        public void task()
        {
            // used to declare implicitly typed local variable 
            var num = 10; // int
            var number = 12;
            var myVariable = "text"; // string
            var isTrue = false; // boolean
            Console.WriteLine("int number : {0}", num);
            Console.WriteLine("String : {0}", myVariable);
            Console.WriteLine("Boolean : {0}", isTrue);
            Console.Beep();
            Console.ReadKey();
        }
    }
}
