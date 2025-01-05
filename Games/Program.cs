using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which game would you like to play?");
            Console.WriteLine("1- Calculator");
            Console.WriteLine("2- Dice Game");
            Console.WriteLine("3- Random Guessing Game");
            Console.WriteLine("4- Turn Based Game");
            Console.WriteLine("5- Rock Paper Scissors");
            Console.WriteLine("6- Exit");

            Console.Write("Please enter the number of the game you would like to play: ");
            string gameChoice = Console.ReadLine() ?? string.Empty;

            switch (gameChoice)
            {
                case "1":
                    var calculator = new Calculator();
                    calculator.Start();
                    break;
                case "2":
                    var diceGame = new DiceGame();
                    diceGame.Start();
                    break;
                case "3":
                    var guessGame = new GuessGame();
                    guessGame.Start();
                    break;
                case "4":
                    var turnBased = new TurnBased();
                    turnBased.Start();
                    break;
                case "5":
                    var rockPaperScissors = new RockPaperScissors();
                    rockPaperScissors.Start();
                    break;
                case "6":
                    var Hangman = new Hangman();
                    Hangman.Start();
                    break;
                case "7":
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
