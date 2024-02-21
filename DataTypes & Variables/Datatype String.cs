using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes___Variables
{
    internal class Datatype_String
    {
        public static void Example()
        {
            string myname = "Hari";
            string message = "My name is " + myname;
            string uppercase = message.ToUpper(); // this method converts it in uppercase
            string lowercase = message.ToLower(); // this method converts it in lowercase
            // Console.WriteLine(uppercase);
            // Console.WriteLine(lowercase);

            string[] splitArray = message.Split( ); // split the variables and store in the array
            foreach (string s in splitArray)
            {
                Console.WriteLine(s);
            }

            //string[] split = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(split);
            //Console.ReadKey();

            string substring = message.Substring(3); // this method prints from the char starts with the index that we give
            // Console.WriteLine(substring);
            string substring2 = message.Substring(3, 4);
            // Console.WriteLine(substring2);
            Console.ReadKey();

        }
    }
}
