using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    internal class StringMethods
    {
        public static void Method(string[] args)
        {
            string message = " Hello World ";
            string upperMessage = message.ToUpper(); // this method converts the string to upper case
            // Console.WriteLine(upperMessage);
            string lowerMessage = message.ToLower(); // this method converts the string to lower case
            // Console.WriteLine(lowerMessage);
            string trimmedMessage = message.Trim(); // this method removes the white spaces from the start and the end of the string
            // Console.WriteLine(trimmedMessage);
            string message2 = "Hello Globle";
            string replacedMessage = message2.Replace("Globle", "C#"); // this method replaces the first string with the second string
            // Console.WriteLine(replacedMessage);
            string message3 = "Hello World";
            string[] words = message3.Split(' '); // this method splits the string into an array of strings
            // Console.WriteLine(words[0]);
            // Console.WriteLine(words[1]);
            string message4 = "Hello Earth";
            string substring = message4.Substring(3); // this method prints from the char starts with the index that we give
            // Console.WriteLine(substring);
            string substring2 = message4.Substring(3, 4);
            // Console.WriteLine(substring2);
            string message5 = "Hello guys";
            string indexOf = message5.IndexOf("g").ToString(); // this method returns the index of the first occurrence of the specified string
            // Console.WriteLine(indexOf);
            string message6 = "Hello friends";
            string IsNull = string.IsNullOrEmpty(message6).ToString(); // this method checks if the string is null or empty
             Console.WriteLine(IsNull);
            Console.ReadKey();
        }   
    }
}
