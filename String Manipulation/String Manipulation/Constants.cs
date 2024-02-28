using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program.
    internal class Constants
    {
        // constants as fields
        const double PI = 3.1415926535897932384;
        const int weeks = 52, months = 12;
        const int days = 365;
        // Create a constant of type string with your birthday as its value
        const string mybirthday = "25.11.2002";
        public void Example()
        {
            Console.WriteLine("My birthday is in : {0}", mybirthday);
            Console.ReadKey();
        }
    }
}
