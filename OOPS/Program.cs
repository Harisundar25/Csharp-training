using System;
using System.ComponentModel.DataAnnotations;
namespace OOPS

{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Classes_and_Objects audi = new Classes_and_Objects("Audi A5", 1500, "Red");
            //audi.Drive();
            //audi.Details();

            //Classes_and_Objects bmw = new Classes_and_Objects("BMW M4", 2000);
            //bmw.Drive();
            //bmw.Details();

            //string userInput = Console.ReadLine();
            //Console.WriteLine("Press 0 to stop the car");
            //if (userInput == "0")
            //{
            //    audi.stop();
            //}
            //else
            //{
            //    Console.WriteLine("Car drives indefinitely");


            Phone Samsung = new Phone();
            Phone.Introduce();
            
        }

    }
}