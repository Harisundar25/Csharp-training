using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Try_Parse
    {
        public static void Example()
        { 
            string numberAsString = "128";
            float parsedValue;
            bool success = float.TryParse(numberAsString, out parsedValue); // will print true if it parse the int successfully

            if(success)
            {
                Console.WriteLine("The string was successfully parsed to an float: " + parsedValue);
            }
            else
            {
                Console.WriteLine("The string could not be parsed to an float");
            }
            Console.ReadKey();
        }
    }
}
