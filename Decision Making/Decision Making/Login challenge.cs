using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Login_challenge
    {
        static string username; // declaring variables globally
        static string password;
        public static void Output()
        {
            Register();
            Login();
        }
        static void Register()
        {
            Console.WriteLine("Please enetr your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enetr your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed .........");

        }
        static void Login()
        {
            Console.WriteLine("Please eneter your username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please eneter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password !");
                }
            }
            else
            {
                Console.WriteLine("Login failed, worng username !");
            }
        }
    }
}
