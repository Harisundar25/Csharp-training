using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Switch
    {
        public static void Example()
        {
            int age = 25;
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party int the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go !");
                    break;
                case 35:
                    Console.WriteLine("You are over the hill!");
                    break;
                default:
                    Console.WriteLine("How old are you?");
                    break;
            }

            if(age == 15)
            {
                Console.WriteLine("Too young to party int the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go !");
            }
            else if (age == 35)
            {
                Console.WriteLine("You are over the hill!");
            }
            else
            {
                Console.WriteLine("How old are you?");
            }

            string username = "Hari";
            switch (username)
            {
                case "Hari":
                    Console.WriteLine("Username is Hari");
                    break;
                case "Sundar":
                    Console.WriteLine("Username is Sundar");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }
            Console.Read();
        }
    }
}
s