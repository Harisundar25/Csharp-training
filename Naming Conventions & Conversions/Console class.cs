using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_Conventions___Conversions
{
    internal class Console_class
    {
        public static void Example()
        {
            Console.WriteLine("HELLO WELCOME"); // prints the text and jumps to a new new line.
            Console.Write("HELLO"); // prints the text in the same line.
            Console.Write("WELCOME");
            Console.ReadKey();

            Console.Write("Enter a string and press enter :");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered : {0}", readInput);
            Console.Write("Enter a string and press enter :");
            Console.Beep(); // Will give a beep sound while enter a key
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is : {0}", asciiValue);
            Console.ReadKey(); // returns the ASCII value of the given input char
            

        }
    }
}
