using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class Manipulation
    {
        public void Example()
        {
            //define few variables
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";
            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am" + age + " years old");
            //2. String formatting.
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I'm a {2}", name, age, job);

            //3. String interpolation
            //string Interpolation uses $ at the start which will allow us to write our
            //variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            //4. Verbatim strings.
            //verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum is a Latin text used as a placeholder in graphic design, 
            publishing,
            and typing. It was introduced by Adobe in 1983 and has since become the industry standard. 
            This text lacks semantic meaning, but it is visually appealing and helps designers create readable and 
            visually pleasing layouts. It can be used for a wide range of media, including websites, books, and printing. 
            non-Latin scripts.");

            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");
            //with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Yes \n have no powers here!.");
            Console.WriteLine("Yes \\n have no powers here!.");
            Console.ReadKey();
        }
    }
}
