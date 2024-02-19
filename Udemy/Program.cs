using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of book1
            Book book1 = new Book();
            book1.name = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 500;
            //creating object of book2
            Book book2 = new Book();
            book2.name = "GOT";
            book2.author = "Logith";
            book2.pages = 700;

            Console.WriteLine(book1.name);
            Console.WriteLine(book1.author);
            Console.WriteLine(book2.name);
            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
}
