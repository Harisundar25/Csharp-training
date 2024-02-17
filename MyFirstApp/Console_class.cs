using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
       public class Sample
        {
            public static void Main()
            {
                // print line by line
                System.Console.WriteLine("Welcome");
                System.Console.WriteLine("team");
                // print side by side
                System.Console.Write("Welcome");
                System.Console.Write("team");

                // wait for pressing some key on keyboard
                System.Console.ReadKey();

                //clear screen
                System.Console.Clear();

                System.Console.WriteLine("Thank you");
                System.Console.ReadKey();

            }
       }
}
