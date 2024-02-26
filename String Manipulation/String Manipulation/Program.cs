using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class Program
    {
        public enum Action
        {
            Manipulation,
            StringMethods,
            Challenge
        }
        public static void Output(Action files)
        {
            switch (files)
            {
                case Action.Manipulation:
                    Console.WriteLine("Manipulation.cs");
                    Manipulation obj_Manipulaion = new Manipulation();
                    obj_Manipulaion.Example();
                    break;
                case Action.StringMethods:
                    Console.WriteLine("StringMethods.cs");
                    StringMethods obj_StringMethods = new StringMethods();
                    obj_StringMethods.Method();
                    break;
                case Action.Challenge:
                    Console.WriteLine("Challenge.cs");
                    Challenge obj_Challenge = new Challenge();
                    obj_Challenge.Example();
                    break;

            }
        }
        static void Main(string[] args)
        {
            // Manipulation.Example();
            // StringMethods.Method(args);
            // Challenge.Example(); 
            Output(Action.StringMethods);

        }

    }
}
