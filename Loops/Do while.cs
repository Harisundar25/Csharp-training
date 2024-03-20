using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Do_while
    {
        public static void Output()
        {
            int counter = 0;
            int lengthOfText = 5;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of the friend");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                counter++;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that's enough! " + wholeText);
            Console.ReadKey();
        }
    }
}
