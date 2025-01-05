using System;
    namespace Games{
        public class GuessGame{
            public void Start(){
                bool isCorrectGuess = false;
                Random random = new Random();
                int randNum = random.Next(1, 11);
               
                Console.WriteLine("Welcome to the random guessing game!");
                Console.WriteLine ("A number between 1 and 10 will be generated.");
                Console.WriteLine ("If you guess the number correctly, you win!");
                Console.WriteLine(randNum);
                while (!isCorrectGuess){
                   Console.WriteLine("Please enter your guess:");
                   int guess =Convert.ToInt32(Console.ReadLine());
                   if(guess>  randNum){
                    Console.WriteLine("Your guess is too high. Try again!");
                   }
                   else if (guess< randNum){
                    Console.WriteLine("Your guess is too low. Try again!");
                   }
                   else{
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                   }

                   }
                   Console.WriteLine("Congratulations, you have won the game! Thank you for playing.");
                }
                
                


            }
    }