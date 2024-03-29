using System;

namespace Loops
{
    internal class Break_Continue
    {
        public static void Run()
        {
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
                Console.WriteLine(counter);
            }
            Console.Read();
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("We skip at num 3!");
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.Read();
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter%2 == 0)
                {
                    Console.WriteLine("Now comes odd num!");
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
