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
            /* This application asks the user to input a string in the first line like “Enter a string here: ”
            In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”
            On the third line, it should write the index of the first occurrence of the searched character from the string.
            Now on concatenation...
            It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.
            It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. 
            Try to store the full name in a variable, before displaying it.*/
            Console.WriteLine("Enter a string here : ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the character to search : ");
            char input_2 = Console.ReadLine()[0]; // will get the exact index of the char
            int index = input.IndexOf(input_2);
            Console.WriteLine("The index of the character is : {0}",index);

            Console.WriteLine("Enter your first name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your last name : ");
            string Name2 = Console.ReadLine();
            string concat = string.Concat(Name," ",Name2); //concat method to add two strings
            Console.WriteLine("Your full name is : {0}",concat);
            Console.ReadKey();
        }
    }
}
