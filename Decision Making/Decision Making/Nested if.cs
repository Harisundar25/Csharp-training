using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decision_Making
{
    internal class Nested_if
    {
        public static void Example()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("P1ease enter your username");
            userName = Console.ReadLine();
            if (isRegistered)
            {
                Console.WriteLine("Hi, registered user");
                if (userName != "")  // if given input is not null
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi, admin");
                    }
                }
            }
        }
    }
}
