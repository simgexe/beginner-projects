using System;

namespace Games
{
    public class DiceGame
    {
        public void Start()
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;

            Console.WriteLine("Welcome to the dice game!");
            Console.WriteLine("Press any key to roll the dice!");

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();
                 playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("The enemy rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
               {
                playerPoints++;
                Console.WriteLine("You win this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                enemyPoints++;
                Console.WriteLine("The enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
               }
               Console.WriteLine("The score is - You: "+playerPoints + " Enemy:  " + enemyPoints);
            }
            if(playerPoints>enemyPoints)
            {
                Console.WriteLine("You win !");
            }
            else if(playerPoints<enemyPoints)
            {
                Console.WriteLine("You lose !");
            }
            else
            {
                Console.WriteLine("The game is a tie!");
            }

            Console.WriteLine("Thank you for playing the dice game!");
            Console.ReadKey();
        }
    }
}
