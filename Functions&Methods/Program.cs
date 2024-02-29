using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class Program
    {
        public enum Action
        {
            Methods
        }
        static void Main(string[] args)
        {
            //  Void_Methods.Example();
            //  Void_Methods.SpecificMethod("This is an argument called from a method"); // after calling from an method, this is an argument
            //  Console.Read();
            //  Return_Value.Return();
            Challenge.GreetFriend(Challenge.Example());
        }
    }
}
