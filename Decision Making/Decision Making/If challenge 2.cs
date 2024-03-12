using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    public class If_challenge_2
    {
        static int highscore = 300; // global variables
        static string highscorePlayer = "Rob";
        public static void Output() // method to call the highscore method
        {
            CheckHighscore(250, "Maria");
            CheckHighscore(315, "Alex");
            CheckHighscore(350, "Harry");
        }

        public static void CheckHighscore(int score, string playerName) // method to check highscore
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + 
                    " could not be broken and is still held by " + highscorePlayer);
            }
            Console.ReadKey();
        }
    }
}
