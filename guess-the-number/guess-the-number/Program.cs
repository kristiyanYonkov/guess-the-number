using System;

namespace guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome. Let's guess the number");

            Random random = new Random();

            int randomInt = random.Next(0, 100);            

            bool win = false;
            do
            {
                Console.WriteLine("Please enter a number between 0-100:");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < randomInt)
                {
                    Console.WriteLine($"---{inputNumber}--- is too low. Guess higher!");
                }
                else if (inputNumber > randomInt)
                {
                    Console.WriteLine($"---{inputNumber}--- is too high. Guess lower!");
                }
                else if (inputNumber == randomInt)
                {
                    Console.WriteLine("YOU HAVE GUESSED THE NUMBER. YOU WIN!");
                    win = true;
                }
            }
            while (win == false);

            Console.WriteLine("Please enter any key to exit the game!");
            Console.ReadLine();
            

        }
    }
}
