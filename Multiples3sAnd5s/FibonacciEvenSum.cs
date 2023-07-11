using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    internal class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Code Challenge #2!");
            Console.WriteLine("This is the Fibonacci Even Sum Lab.");
            

            int a = 1;
            int b = 1;
            int c = 1;

            int sum = 0;

            while (c < 4_000_000)
            {
                Console.WriteLine(c);
                if (c % 2 == 0)
                {
                    sum += c;
                }
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine($"The sum of the even numbers: {sum}");
        }
    }
}

