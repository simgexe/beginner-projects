using System;

namespace Games{
    class TurnBased{

        public void Start(){
            int playerHp =40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

        while(playerHp> 0 && enemyHp> 0){
            //Player's turn
            Console.WriteLine("----Player's turn!----");
            Console.WriteLine("Player HP: "+ playerHp+" Enemy HP: "+ enemyHp);
            Console.WriteLine("Enter 'a' to attack or 'h' to heal:");


            string choice = Console.ReadLine() ?? string.Empty;
            if (choice =="a"){
                enemyHp -= playerAttack;
                Console.WriteLine("Player attack enemy and deals"+ playerAttack+ "damage!");  
            }
            else {
                playerHp += healAmount;
                Console.WriteLine("Player restores"+ healAmount+ "HP!");
            }
           //Enemy's turn
              
             if(enemyHp> 0){
              Console.WriteLine("----Enemy's turn!----");  
              int enemyChoice = random.Next(0, 3);

              if(enemyChoice == 0){
                  playerHp -= enemyAttack;
                  Console.WriteLine("Enemy attacks player and deals "+ enemyAttack+ "damage!");
              }
              else{
                  enemyHp += healAmount;
                  Console.WriteLine("Enemy restores "+ healAmount+ "HP!");
              }
             }
             
                
        }
        if(playerHp>0){
                Console.WriteLine("Congratulations! You won the battle!");
             }
             else{
                 Console.WriteLine("You lost the battle!");
             }
    }
}}