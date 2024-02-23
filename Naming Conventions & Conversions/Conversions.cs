using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_Conventions___Conversions
{
    internal class Conversions
    {
        public static void Example()
        {
            // impicit conversion - which converts from bigger type to smaller type
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString(); // "13.37"
            string myfloatString = myFloat.ToString();
            bool sunIsShining = true;

            string myBoolstring = sunIsShining.ToString();
            Console.WriteLine(myBoolstring);
            Console.Read();
        }
    }
}
