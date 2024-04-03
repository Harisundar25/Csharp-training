using System;

namespace Loops
{
    internal class Loops_Challenege
    {
        /* Imagine you are a developer and get a job in which you need to create a program 
         * for a teacher.He needs a program written in c# that calculates the average score of his
         * students. So he wants to be able to enter each score individually and then get the final
         * average score once he enters -1.
         * So the tool should check if the entry is a number and should add that to the sum.
         * Finally once he is done entering scores, the program should write onto the console
         * what the average score is.
         * The numbers entered should only be between 0 and 20. Make sure the program
         * doesn't crash if the teacher enters an incorrect value.
         * Test your program thoroughly.*/
        public static void Task()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("------------------------------------------------");
                    // calculate the average and let the teacher know
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!input.Equals("-1"))
                    {
                        Console.WriteLine("Please enter a valid number between 0 and 20");
                    }
                    continue;
                }
                count++;
            }
            Console.ReadLine();
        }
    }
}
