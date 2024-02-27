using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class Challenge_2
    {
        public void Example()
        {
            /* */
            Console.WriteLine("Enter a string here : ");
            string Input = Console.ReadLine();
            Console.WriteLine("Enter the character to search : ");
            char Input_2 = Console.ReadLine()[0]; // will get the exact index of the char
            int Index = Input.IndexOf(Input_2);
            Console.WriteLine("The index of the character is :", Index);

            Console.WriteLine("Enter your first name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your last name : ");
            string Name2 = Console.ReadLine();
            string concat = string.Concat(Name," ", Name2); //concat method to add two strings
            Console.WriteLine("Your full name is {0} : ", concat);
            Console.ReadKey();
        }
    }
}
