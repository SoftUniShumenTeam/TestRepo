
namespace ShumenTeam
{
using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Get the sum of all odd numbers that are divided by 3 and all even numbers that are divisible by 3, 
            // in range [1...n]
            // then multiply the result by 3
            // If the final result is even, print "The result is even number."
            // else "The result is odd number."

            int n = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 1; i < n; i++)
            {
                // TODO:
                if(i % 3 == 0)
                {
                    totalSum += i;
                }
            }

            totalSum *= 3;

            if (totalSum % 2 == 0)
            {
                Console.WriteLine("The result is even number.");
            }
            else
            {
                Console.WriteLine("The result is odd number.");
            }
        }
    }
}
