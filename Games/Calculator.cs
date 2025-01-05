using System;

namespace Games
{
    public class Calculator
    {
        public void Start()
        {
            int num1;
            int num2;
            float result;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator!");
            Console.WriteLine("Please enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Enter 'a' for addition, 's' for subtraction, 'm' for multiplication, 'd' for division:");
            answer = Console.ReadLine().ToLower();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else 
            {
                result = num2 == 0 ? float.NaN : (float)num1 / num2;
            }
            if(float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }
            

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thank you for using the calculator!");
            Console.ReadKey();
        }
    }
}
