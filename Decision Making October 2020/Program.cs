using System;

namespace Decision_Making_October_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Decision Maker");
            Console.Write("Please enter a number between 1 - 100: ");

            string input = Console.ReadLine();

            int number = int.Parse(input);

            if(number % 2 > 0)
            {
                if(number >= 60)
                {
                    Console.WriteLine($"{number} is odd");
                }
                else
                {
                    Console.WriteLine("You have entered an Odd number");
                }
            }
            else
            {
                if(number < 25)
                {
                    Console.WriteLine("The number entered is even and less than 25");
                }
                else if (number <= 60)
                {
                    Console.WriteLine($"{number} is even");
                }
                else if(number <= 100)
                {

                }
            }
        }
    }
}
