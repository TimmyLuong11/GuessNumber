using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timmy Luong - 113401608
            //Declaring Variables
            Random rand;
            rand = new Random();
            int min, max, ranNum, guess=0, count=0;
            string answer, minAns, maxAns;

            //Welcoming the user to a guessing game
            Console.WriteLine("Welcome to the number guessing game!");
            
            //Asking the user to enter in a valid minimum number, if not it will loop until valid
            Console.WriteLine("Please enter in a minimum number");
            minAns = Console.ReadLine();
            while (int.TryParse(minAns, out min) == false)
            {
                Console.WriteLine("Sory you enter an invalid number. Please enter a minimum number");
                minAns = Console.ReadLine();

            }

            //Asking the user to enter in a valid maximum number, if not it will loop until valid
            Console.WriteLine("Please enter in a maximum number");
            maxAns = Console.ReadLine();
            while (int.TryParse(maxAns, out max)==false)
            {
                Console.WriteLine("Sory you enter an invalid number. Please enter a maximum number");
                maxAns = Console.ReadLine();
            }
            
            //Generating random number from the min and max value from the user with the +1 to include the max number
            ranNum = rand.Next(min, max+1);
            
            //Asking the user to start guessing and if the input is not valid it will ask the user to try agian
            Console.WriteLine("Please enter in your guess");
            do
            {
                answer = Console.ReadLine();
                ++count;
                while (int.TryParse(answer, out guess) == false)
                {
                    Console.WriteLine("Sory you enter an invalid number. Please try again");
                    answer = Console.ReadLine();
                    ++count;
                }

            } while (guess != ranNum);

            //Outputting to the user they have guess correctly, the correct number, and how many times it took
            Console.WriteLine("You guess correctly!");
            Console.WriteLine($"The correct number was: {ranNum}.");
            Console.WriteLine($"It took you {count} tries to guess correctly!");
        }
    }
}
