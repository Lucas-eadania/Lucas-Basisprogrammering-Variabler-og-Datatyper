using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Variabler_og_Datatyper_Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess The Number!\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Lovely to meet you " + name);

            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            Console.WriteLine("\nNow its time to guess a number, pick one between 1 and 100");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == randomNumber)
            {
                Console.WriteLine("You guessed the right number! " + randomNumber);
                Console.ReadLine();
            }
            else
            {
                int difference = Math.Abs(randomNumber - guess);

                Console.WriteLine("\nThe right answer was " + randomNumber + "\nYou were " + difference + " away from the right answer!");
            }
            Console.WriteLine("\nThanks for playing!\n Press any key to exit");
            Console.ReadLine();

        }
    }
}
