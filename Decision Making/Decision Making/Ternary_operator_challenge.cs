using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Ternary_operator_challenge
    {/*
      * Create a small application that takes a temperature value as input and checks if the input is an integer or not.
      * If the input value is not an integer value, it should print to the console "Not a valid Temperature".
      * And if the input value is the valid integer then it should work as mentioned below.
      * If input temperature value is <=15 it should write "it is too cold here" to the console.
      * If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
      * If the input temperature value is > 28 it should write "it is hot here" to the console.
      * Make sure to use ternary operators and not if statements to check for the three conditions, 
      * however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.
      */
        public static void Output()
        {
            Console.WriteLine("Enter the current temperature: ");
            string input = Console.ReadLine();
            int temperature;
            if (int.TryParse(input, out temperature))
            {    // condition ? iftrue : iffalse
                string stateOfMatter = temperature <= 15 ? "it is too cold here" : 
                    // false case
                    (temperature >= 16 && temperature <= 28) ? "it is cold here" :
                    //false case
                    temperature > 28 ? "it is hot here" :"";
                Console.WriteLine(stateOfMatter);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature, please enter a valid input");
            }
            Console.ReadKey();
        }
    }
}
