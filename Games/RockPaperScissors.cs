using System;
namespace Games {
    class RockPaperScissors {
        public void Start() {
            int playerScore = 0;
            int enemyScore = 0;
            Random random = new Random();   
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");

        while(playerScore!=3 && enemyScore !=3){
            Console.WriteLine("Player Score:" +playerScore + "Enemy Score:" +enemyScore);
            Console.WriteLine("Enter 'r' for Rock, 'p' for Paper, 's' for Scissors:");

            string playerChoice = Console.ReadLine() ?? string.Empty;
            int enemyChoice = random.Next(0, 3);
            
            if(enemyChoice ==0){
                Console.WriteLine("Enemy chooses Rock!");
                switch(playerChoice){
                    case "r":
                    Console.WriteLine("It's a tie!");
                    break;
                    case "p":
                    Console.WriteLine("Player wins!");
                    playerScore++;
                    break;
                    case "s":
                    Console.WriteLine("Enemy wins!");
                    enemyScore++;
                    break;
                    default:
                    Console.WriteLine("Invalid choice!");
                    break;
                }
            }
            else if(enemyChoice ==1){
                Console.WriteLine("Enemy chooses Paper!");
                switch(playerChoice){
                    case "r":
                    Console.WriteLine("Enemy wins!");
                    enemyScore++;
                    break;
                    case "p":
                    Console.WriteLine("It's a tie!");
                    break;
                    case "s":
                    Console.WriteLine("Player wins!");
                    playerScore++;
                    break;
                    default:
                    Console.WriteLine("Invalid choice!");
                    break;
                }
            }
            else{
                Console.WriteLine("Enemy chooses Scissors!");
                switch(playerChoice){
                    case "r":
                    Console.WriteLine("Player wins!");
                    playerScore++;
                    break;
                    case "p":
                    Console.WriteLine("Enemy wins!");
                    enemyScore++;
                    break;
                    case "s":
                    Console.WriteLine("It's a tie!");
                    break;
                    default:
                    Console.WriteLine("Invalid choice!");
                    break;
                }
            }

        }
        if (playerScore ==3){
            Console.WriteLine("Congratulations! You won the game!");
        }
        else{
            Console.WriteLine("You lose!");
        }

        
    }
}
}