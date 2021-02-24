using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand;
            int min, max, ranNum, guess=0;
            string answer;

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Please enter in a minimum number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in a maximum number");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in your guess");
            answer = Console.ReadLine();

            rand = new Random();
            ranNum = rand.Next(min, max);

            while(int.TryParse(answer, out guess)==false)
            {
                Console.WriteLine("Sory you enter an invalid #. Please try again");
                guess = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(ranNum);
            while (guess != ranNum)
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You guess correctly!");
        }
    }
}
