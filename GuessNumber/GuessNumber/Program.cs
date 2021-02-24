using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand;
            rand = new Random();
            int min, max, ranNum, guess=0, count=0;
            string answer, minAns, maxAns;

            Console.WriteLine("Welcome to the number guessing game!");
            
            Console.WriteLine("Please enter in a minimum number");
            minAns = Console.ReadLine();
            while (int.TryParse(minAns, out min) == false)
            {
                Console.WriteLine("Sory you enter an invalid number. Please enter a minimum number");
                minAns = Console.ReadLine();

            }
            
            Console.WriteLine("Please enter in a maximum number");
            maxAns = Console.ReadLine();
            while (int.TryParse(maxAns, out max)==false)
            {
                Console.WriteLine("Sory you enter an invalid number. Please enter a maximum number");
                maxAns = Console.ReadLine();
            }
            
            ranNum = rand.Next(min, max+1);
            Console.WriteLine($"This is the random Num {ranNum}");
            
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

            Console.WriteLine("You guess correctly!");
            Console.WriteLine($"It took you {count} times to guess correctly!");
        }
    }
}
