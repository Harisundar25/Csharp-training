using System;

namespace Loops
{
    internal class While
    {
        public static void Output()
        {
            int counter = 0;
            string wholeText = "";

           /* while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }*/
           while(wholeText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +
                    "enter if you want to finish countinng");
                wholeText = Console.ReadLine();
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} People are inside the bus. Press enter to close the program", counter);
            Console.ReadKey();
        }
    }
}
