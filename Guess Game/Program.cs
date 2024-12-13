using System.Collections.Concurrent;

namespace Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                var numberGuess = rnd.Next(1,101);
                int userGuess = 0;
                

                Console.WriteLine("welcome to guess game");
                Console.WriteLine("I have chosen a number between 1 ,100 ");

                while (userGuess != numberGuess)
                {
                    Console.WriteLine("chooes a number");
                    int input = int.Parse(Console.ReadLine());

                    if (input < numberGuess)
                        Console.WriteLine("your chooes is too low , please try again");

                    else if (input > numberGuess)
                        Console.WriteLine("your chooes is too high , please try again");
                    else
                        Console.WriteLine($"Congratulations! You guessed the correct number {numberGuess}");

                    Console.WriteLine("========================================");

                }

            }
        }
    }
}
