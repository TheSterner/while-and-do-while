using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I want to play a game. Guess my favorite number. Enter your guess.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = number == 14;

            while (!guess)
            {
                switch (number)
                {
                    case 14:
                        Console.WriteLine("You guessed 14. You are correct! Well Done!");
                        guess = true;
                        break;

                    default:
                        Console.WriteLine("You guessed incorrectly. Please try again.");
                        Console.WriteLine("Your guess?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            Console.ReadLine(); 

        }
    }
}
