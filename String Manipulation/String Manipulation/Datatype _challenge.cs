using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    internal class Datatype_challenge
    {
        /* Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitive datatypes 
            (you can find the list here - https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN). Leave the Object datatype out.
            And also please initialize each variable with a working value.
            Then create two values of type string. The first one should say "I control text"
            The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.
            Add each an output for each of the variables and write it onto the console. (WriteLine)
            Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours. Have fun :)*/
        public void Example()
        {
            byte A = 25; // uses 1 byte of memory - range 0 to 255
            Console.WriteLine(A);
            sbyte mySbyte = -15; // uses 1 byte of memory - range -128 to 128
            Console.WriteLine(mySbyte);
            int B = -12318925; // uses 4 bytes of memory - range -2,147,483,648 to 2,147,483,647
            Console.WriteLine(B);
            uint C = 123091; // uses 4 bytes of memory - range 0 to 4294967295
            Console.WriteLine(C);
            short D = -32768; // uses 2 bytes of memory - range -32,768 to 32,767
            Console.WriteLine(D);
            ushort E = 65535; // uses 2 bytes of memory - range 0 to 65535
            Console.WriteLine(E);
            float F = -31.1289f; // uses 4 bytes of memory - range -3.402823e38 to 3.402823e38
            Console.WriteLine(F);
            double X = -12.1231250; // uses 8 bytes of memory - range -1.79769313486232e308 to 1.79769313486232e308
            Console.WriteLine(X);
            char Y = 'A'; // uses 2 bytes of memory 
            Console.WriteLine(Y);
            bool Z = true; // uses 1 byte of memory
            Console.WriteLine(Z);
            string example = "I control text";
            Console.WriteLine(example);
            string Text = "15";

            int myNumFromText = Int32.Parse(Text);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
