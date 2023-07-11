using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    internal class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Code Challenge #2!");
            Console.WriteLine("This is the Ten Digit Fibonacci challenge.");

            int a = 0;
            int b = 1;
            int c = 0;

            int index = 0;

            while (c.ToString().Length < 10)
            {
                index++;

                a = b;
                b = c;
                c = a + b;

                Console.WriteLine($"F{index} = {c}");
            }

            Console.WriteLine($"F{index} is the first index with 10 digits ({c}).");

        }
    }
}
