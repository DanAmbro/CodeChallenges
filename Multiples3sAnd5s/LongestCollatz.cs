using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    internal class LongestCollatz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Code Challenge #2!");
            Console.WriteLine("This is the Longest Collatx Lab.");


            int totalSteps;
            int longestSequence = 0;
            int stepNumber = 0;

            for (int i = 1; i < 1000; i++)
            {
                totalSteps = 0;
                int val = i;
                
                while (val > 1)
                {
                    totalSteps++;
                    if (val % 2 == 0)
                    {
                        val /= 2;
                    }
                    else
                    {
                        val = (val * 3) + 1;
                    }
                }

                if (totalSteps > longestSequence)
                {
                    longestSequence = totalSteps;
                    stepNumber = i;
                }
                Console.WriteLine($"{i}: {totalSteps} steps");
            }

            Console.WriteLine($"The longest chain is {longestSequence} at starting number {stepNumber}");
        }
    }
}
