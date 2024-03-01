using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class Exercise
    {
            public static void Example()
            
        {
                // but don't forget to put the default string back at the end of your testing.
                string b = "How aRe YOu";
                string s = "HeY ThErE !";

                b = LowUpper(b);
                Console.WriteLine(b);
                Count(b);
                Console.ReadKey();

            }
            public static string LowUpper(string b)
            {
                return (b.ToLower() + b.ToUpper());
            }
            public static void Count(string b)
            {
                //int c = s.IndexOf('!');
                //int r = c+1;
                Console.WriteLine("The amount of characters is " + b.Length + ".");
            }
    }
}
