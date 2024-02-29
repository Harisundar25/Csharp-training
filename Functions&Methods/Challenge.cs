using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class Challenge
    {
        public static string Example()
        {
            string name1 = "Logith";
            string name2 = "harry";
            string name3 = "ajith";
            return name1;
        }
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend !");
            Console.ReadKey();
        }
    }
}
