using System;
namespace OOPS

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Classes_and_Objects audi = new Classes_and_Objects();
            audi.Drive();
            Classes_and_Objects bmw = new Classes_and_Objects();

            string userInput = Console.ReadLine();
            Console.WriteLine("Press 0 to stop the car");
            if (userInput == "0")
            {
                audi.stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinitely");
            }
        }
    }
}