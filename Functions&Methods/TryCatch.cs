using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Methods
{
    internal class TryCatch
    {
        public static void Output()
        {
            Console.WriteLine("Please enter a number !");
            string input = Console.ReadLine();

            int A = 50;
            int B = 0;
            int result;
            try
            {
                result = A / B;
            }
            catch (DivideByZeroException) // this exception can used to handle anything divide by zero
            {
                Console.WriteLine("can't divide by zero !");
            }


            try
            {
                if (input == null)
                {
                    throw new ArgumentNullException(nameof(input), "Input cannot be null");
                }
                int inputasInt = int.Parse(input);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, enter the correct type");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
                Console.ReadKey();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNu11Exception, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

        }
    }
}
