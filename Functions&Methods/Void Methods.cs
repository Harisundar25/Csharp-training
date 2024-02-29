using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class Void_Methods
    {
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void Example()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void SpecificMethod(string myText) //this is a parameter inside a method
        {
            Console.WriteLine(myText);
        }
    }
}
